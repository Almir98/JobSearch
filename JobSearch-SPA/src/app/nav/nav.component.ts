import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';


@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model:any={};
  field=false;

  constructor(private authService:AuthService) { }

  ngOnInit() {}

  login()
  {
    this.authService.login(this.model).subscribe(next=>{

      console.log(this.model);
      console.log("Logged in successfully");

    },error=>{
      
      console.log(this.model);
      console.log("Logged wrong");

    });
  }

  loggedIn()
  {
    const token=localStorage.getItem('token');
    return !!token;
  }

  logout()
  {
    localStorage.removeItem('token');
  }

  register()
  {
    this.field=!this.field;
  }



}