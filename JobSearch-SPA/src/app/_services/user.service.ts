import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import {User } from '../_models/User';
import {UserUpsertModel } from '../_shared/UserUpsertModel';


@Injectable({
  providedIn: 'root'
})
export class UserService {

  baseUrl=environment.apiUrl+'/User';

constructor(private http:HttpClient) { }


getAll()
{
  return this.http.get<User[]>(this.baseUrl);
}

GetUser(id:number)
{
  return this.http.get<User>(this.baseUrl+"/id?id="+1);
}

Insert(client:UserUpsertModel)
{
  return this.http.post(this.baseUrl,client);
}

Update(id:number,client:UserUpsertModel)
{
  return this.http.put(this.baseUrl+"/"+id,client);
}

}
