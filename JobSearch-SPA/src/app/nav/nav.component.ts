import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';


@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model:any={};

  constructor(private authService:AuthService,private alert:AlertifyService) { }

  ngOnInit() {}

  login()
  {
    this.authService.login(this.model).subscribe(next=>{

      this.alert.success('Logged in successfully');

    },error=>{
      
      console.log(this.model);
      this.alert.error('Something went wrong');
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
    this.alert.message('Logged out!');
  }

}
