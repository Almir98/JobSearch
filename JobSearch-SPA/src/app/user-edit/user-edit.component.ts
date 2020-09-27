import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {User} from '../_models/User';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import {UserService} from '../_services/user.service';


@Component({
  selector: 'app-user-edit',
  templateUrl: './user-edit.component.html',
  styleUrls: ['./user-edit.component.css']
})
export class UserEditComponent implements OnInit {

  user:User;

  constructor(private userService:UserService,private route:ActivatedRoute,private alertify:AlertifyService,private authService:AuthService) { }

  ngOnInit() {
    this.loadUser();
  }

  loadUser()
  {
    this.userService.getUser(this.authService.decodedToken.nameid).subscribe((user:User)=>{
      this.user=user;
      console.log(user);
    },error=>{
      this.alertify.error(error);
    });
  }

  updateUser()
  {
    this.userService.update(this.authService.decodedToken.nameid,this.user).subscribe(next=>{

      console.log(this.authService.decodedToken.nameid);
      this.alertify.success("Profile updated successfully");

    },error=>{
      this.alertify.error(error);
    })
  }

}


