import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Advertisment } from '../_models/Advertisment';
import { User } from '../_models/User';
import { Application } from '../_models/Application';
import { AdvertismentService } from '../_services/advertisment.service';
import { AlertifyService } from '../_services/alertify.service';
import {ApplicationService} from '../_services/application.service';
import { AuthService } from '../_services/auth.service';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.css']
})
export class ApplicationComponent implements OnInit {

  user: User;
  advertisment: Advertisment;
  application: any={};


  constructor(private applicationService: ApplicationService,private alertify: AlertifyService, private route: ActivatedRoute,
    private authService: AuthService, private userService: UserService, private router: Router, private advertismentService: AdvertismentService)
  {
  }

  ngOnInit() {
    this.loadUser();
    this.loadAdvertisment()
  }

  loadUser(){
    return this.userService.getUser(this.authService.decodedToken.nameid).subscribe(data=>{
      this.user=data;
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  loadAdvertisment()
  {
    return this.advertismentService.getById(+this.route.snapshot.params['id']).subscribe((data: Advertisment)=>{

      this.advertisment=data;
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  sendApplication()
  {

  }








}
