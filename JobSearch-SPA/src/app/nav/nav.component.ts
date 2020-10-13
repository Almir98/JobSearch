import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from '../_models/User';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import { UserService } from '../_services/user.service';


@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model:any={};
  @ViewChild('loginForm') loginForm: NgForm;
  user: User;
  page:number;
  status:boolean= false;

  constructor(public authService:AuthService,private userService: UserService,private alert:AlertifyService,private router:Router) { }

  ngOnInit() {
  }

  login()
  {
    this.authService.login(this.model).subscribe(next=>{

      this.alert.success('Logged in successfully');
      this.loginForm.reset();

      this.userService.getUser(this.authService.decodedToken.nameid).subscribe((data:User)=>{
        this.user=data;
      if(this.user.userType.userTypeId == 1){
        this.router.navigate(['/admin']);
        this.status=true;
      }
      else{
        this.router.navigate(['/home']);
        this.status=false;
      }
      },error=>{
        this.alert.error("Error");
      });

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
