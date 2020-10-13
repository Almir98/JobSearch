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
  application: Application = new Application();
  
  constructor(private applicationService: ApplicationService,private alertify: AlertifyService, private route: ActivatedRoute,
    private authService: AuthService, private userService: UserService, private router: Router, private advertismentService: AdvertismentService)
  {
  }

  ngOnInit() {
    this.loadUser();
    this.loadAdvertisment()
    this.application.applicationDate=new Date();
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
    this.application.userId = this.authService.decodedToken.nameid;
    this.application.advertismentId = +this.route.snapshot.params['id'];

    this.applicationService.insert(this.application).subscribe((data:Application) => {
      this.application=data;
      console.log(this.application);
      this.alertify.success("Successfully");
      this.router.navigate(['/home']);
    },error =>{
      this.alertify.error("Something went wrong");
    })
  }
}
