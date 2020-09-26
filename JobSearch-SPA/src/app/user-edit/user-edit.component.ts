import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import {User} from '../_models/User';
import { AlertifyService } from '../_services/alertify.service';
import {UserService} from '../_services/user.service';


@Component({
  selector: 'app-user-edit',
  templateUrl: './user-edit.component.html',
  styleUrls: ['./user-edit.component.css']
})
export class UserEditComponent implements OnInit {

  user:User;

  constructor(private userService:UserService,private route:ActivatedRoute,private alertify:AlertifyService) { }

  ngOnInit() {
    this.loadUser();
  }

  loadUser()
  {
    this.userService.GetUser(+this.route.snapshot.params['id']).subscribe((user:User)=>{
      this.user=user;
    },error=>{
      this.alertify.error(error);
    });
  }

}


