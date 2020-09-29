import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import {User } from '../_models/User';
import { AuthService } from './auth.service';


@Injectable({
  providedIn: 'root'
})
export class UserService {

  baseUrl=environment.apiUrl+'/User';

constructor(private http:HttpClient,private authService:AuthService) { }

getAll()
{
  return this.http.get<User[]>(this.baseUrl);
}

getUser(id:number)
{
  return this.http.get<User>(this.baseUrl+"/id?id="+this.authService.decodedToken.nameid);
}

insert(client:User)
{
  return this.http.post(this.baseUrl,client);
}

update(id:number, user:User)
{
  return this.http.put(this.baseUrl+"/"+id,user);
}

}
