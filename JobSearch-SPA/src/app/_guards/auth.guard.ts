import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(private authservice:AuthService,private router:Router,private alert:AlertifyService)
  {

  }

  canActivate(): boolean {

    if(this.authservice.loggedIn())   // if the user logged in
    {
      return true;
    }
    else{
      this.alert.error("You must logged in");
      this.router.navigate['/home'];
      return false;
    }

  }
  
}
