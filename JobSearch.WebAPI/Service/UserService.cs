using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.Interface;
using JobSearch.WebAPI.ViewModels;
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

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
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
            var request = _context.Users.FirstOrDefault(x => x.Email == email);
            if (request == null)
                return null;
            else
            {
                if (!VerifyPasswordHash(password, request.PasswordHash, request.PasswordSalt))
                {
                    return null;
                }
                return _mapper.Map<Model.Users>(request);
            }
        }

        public Model.Users Register(UserVM req,string password)
        {
            byte[] passwordHash, passwordSalt;
            var user = _mapper.Map<Database.Users>(req);

            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

             _context.Users.Add(user);
             _context.SaveChanges();

            return _mapper.Map<Model.Users>(user);
        }

        public bool UserExist(string email)
        {
            if (_context.Users.Any(x => x.Email == email))
                return true;
            else
                return false;
        }
    }
}
