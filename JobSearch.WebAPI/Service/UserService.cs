using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.Helpers;
using JobSearch.WebAPI.Interface;
using JobSearch.WebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class UserService : IUserRepository
    {
        protected readonly SearchJobContext _context;
        protected readonly IMapper _mapper;
        public UserService(SearchJobContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public Model.Users Login(string email,string password)
        {
            var customer = _context.Users.FirstOrDefault(x => x.Email == email);
            if (customer != null)
            {
                var newHash = HashGenerator.GenerateHash(customer.PasswordSalt, password);

                if (customer.PasswordHash == newHash)
                {
                    return _mapper.Map<Model.Users>(customer);
                }
            }
            return null;
        }

        public Model.Users Register(UserVM request,string password)
        {
            //byte[] passwordHash, passwordSalt;
            //var user = _mapper.Map<Database.Users>(req);

            //CreatePasswordHash(password, out passwordHash, out passwordSalt);

            //user.PasswordHash = passwordHash;
            //user.PasswordSalt = passwordSalt;

            // _context.Users.Add(user);
            // _context.SaveChanges();


            var entity = _mapper.Map<Users>(request);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Password and password confirm not matched !");
            }
            entity.PasswordSalt = HashGenerator.GenerateSalt();
            entity.PasswordHash = HashGenerator.GenerateHash(entity.PasswordSalt, request.Password);

            _context.Add(entity);
            _context.SaveChanges();
            
            return _mapper.Map<Model.Users>(entity);
        }

        public bool UserExist(string email)
        {
            if (_context.Users.Any(x => x.Email == email))
                return true;
            else
                return false;
        }

        public Model.Users GetUser(int id)
        {
            var entity = _context.Users.Include(e=>e.UserType).FirstOrDefault(x => x.UserId == id);
            if (entity!=null)
            {
                return _mapper.Map<Model.Users>(entity);
            }
            else { return null; }
        }

        public Model.Users Update(int id, UserUpsertVM user)
        {
            var entity = _context.Users.FirstOrDefault(e => e.UserId == id);
            if (entity == null){
                throw new Exception($"Updating user {id} failed on save");
            }
            else
            {
                _context.Users.Attach(entity);
                _context.Users.Update(entity);

                _mapper.Map(user, entity);
                _context.SaveChanges();
                return _mapper.Map<Model.Users>(entity);
            }
        }
    }
}
