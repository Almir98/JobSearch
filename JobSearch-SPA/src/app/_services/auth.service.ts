import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { JwtHelperService } from '@auth0/angular-jwt';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class AuthService {

constructor(private http:HttpClient) { }

// base URL
baseURL=environment.apiUrl+'/User/';

helper=new JwtHelperService();
decodedToken:any;

login(model:any)
{
  return this.http.post(this.baseURL+'login',model)
  .pipe(
    map((response:any)=>{

      const user=response;
      if(user)
      {
        localStorage.setItem('token',user.token);
        this.decodedToken=this.helper.decodeToken(user.token);
      }
    })
  )  
}

  register(model:any)
  {
    return this.http.post(this.baseURL+'register',model);
  }

  loggedIn()
  {
    const token=localStorage.getItem('token');
    return !this.helper.isTokenExpired(token);
  }
}
