import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Application } from '../_models/Application';
import { User } from '../_models/User';
import { AlertifyService } from '../_services/alertify.service';
import { ApplicationService } from '../_services/application.service';
import { AuthService } from '../_services/auth.service';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-adminaplication',
  templateUrl: './adminaplication.component.html',
  styleUrls: ['./adminaplication.component.scss']
})
export class AdminaplicationComponent implements OnInit {

  applications: Application[];
  user: User;
  constructor(private alertify:AlertifyService,private router: Router, private applicationService: ApplicationService,
    private userService: UserService, private authService: AuthService) { }

  ngOnInit() {
    this.loadApplications();
  }

  loadApplications()
  {
    return this.applicationService.getAll().subscribe((data:Application[])=>{
      this.applications=data;
      console.log(this.applications);
    },error => {
      this.alertify.error("Something went wrong");
    })
  }

}
