import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';


@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model:any={};

  constructor(public authService:AuthService,private alert:AlertifyService,private router:Router) { }

  ngOnInit() {}

  login()
  {
    this.authService.login(this.model).subscribe(next=>{

      this.alert.success('Logged in successfully');
      this.router.navigate['/home'];

    },error=>{
       
      this.alert.error('Something went wrong');
    });
  }

  loggedIn()
  {
    return this.authService.loggedIn();
  }

  logout()
  {
    localStorage.removeItem('token');
    this.alert.message('Logged out!');
    this.router.navigate['/home'];

  }

}
