import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Question } from '../_models/Question';
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

  user: any={};
  @ViewChild('editProfile') editProfile:NgForm;

  constructor(private userService:UserService,private route:ActivatedRoute,private alertify:AlertifyService,
    private authService:AuthService,private router:Router) { }

  ngOnInit() {
    this.loadUser();
  }

  loadUser()
  {
    this.userService.getUser(this.authService.decodedToken.nameid).subscribe((user:User)=>{
      this.user=user;
      console.log(this.user);
    },error=>{
      this.alertify.error(error);
    });
  }

  updateUser()
  {
    this.userService.update(this.authService.decodedToken.nameid,this.user).subscribe(next=>{

      this.router.navigate(['/home']);
      this.alertify.success("Profile updated successfully");
      this.editProfile.reset(this.user);

    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

}


