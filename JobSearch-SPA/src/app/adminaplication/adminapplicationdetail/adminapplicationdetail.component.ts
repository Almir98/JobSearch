import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Application } from 'src/app/_models/Application';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { ApplicationService } from 'src/app/_services/application.service';

@Component({
  selector: 'app-adminapplicationdetail',
  templateUrl: './adminapplicationdetail.component.html',
  styleUrls: ['./adminapplicationdetail.component.scss']
})
export class AdminapplicationdetailComponent implements OnInit {

  application: Application;

  constructor(private applicationService: ApplicationService,private route: ActivatedRoute,private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadApplicationDetails();
  }

  loadApplicationDetails()
  {
    this.applicationService.getById(+this.route.snapshot.params['id']).subscribe((data:Application)=>{
      this.application=data;
    },error => {
      this.alertify.error("Something went wrong");
    })
  }
}
