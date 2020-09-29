import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Advertisment } from '../_models/Advertisment';
import { AdvertismentService } from '../_services/advertisment.service';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-advertisment',
  templateUrl: './advertisment.component.html',
  styleUrls: ['./advertisment.component.scss']
})
export class AdvertismentComponent implements OnInit {

  advertisments:Advertisment[];
  constructor(private adverstimentService: AdvertismentService, private alertify: AlertifyService, private authService : AuthService,
    private router: Router, private route:ActivatedRoute) { }

  ngOnInit()
  {
    this.loadAll();
  }

  loadAll()
  {
    this.adverstimentService.getAll().subscribe(data=>{

      this.advertisments=data;
      console.log(this.advertisments);
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }



}
