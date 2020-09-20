import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class AuthService {

constructor(private http:HttpClient) { }

// base URL

baseURL="https://localhost:44399/api/User/";

  login(model:any)
  {
    return this.http.post(this.baseURL+'login',model)
    .pipe(
      map((response:any)=>{

        const user=response;
        if(user)
        {
          localStorage.setItem('token',user.token);
        }
      })
    )  
  }

  register(model:any)
  {
    return this.http.post(this.baseURL+'Register',model);
  }
}
