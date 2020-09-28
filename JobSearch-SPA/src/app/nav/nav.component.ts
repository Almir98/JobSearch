import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
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
  @ViewChild('loginForm') loginForm: NgForm;

  constructor(public authService:AuthService,private alert:AlertifyService,private router:Router) { }

  ngOnInit() {}

  login()
  {
    this.authService.login(this.model).subscribe(next=>{

      this.router.navigate(['/home']);
      this.alert.success('Logged in successfully');
      this.loginForm.reset();
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
    this.router.navigate(['/home']);
    this.alert.message('Logged out!');

  }

}
