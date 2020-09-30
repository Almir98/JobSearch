import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Advertisment } from 'src/app/_models/Advertisment';
import { AdvertismentService } from 'src/app/_services/advertisment.service';
import { AlertifyService } from 'src/app/_services/alertify.service';

@Component({
  selector: 'app-advertismentDetail',
  templateUrl: './advertismentDetail.component.html',
  styleUrls: ['./advertismentDetail.component.scss']
})
export class AdvertismentDetailComponent implements OnInit {

  advertisment: Advertisment;

  constructor(private advertismentService: AdvertismentService, private alertify: AlertifyService, private route: ActivatedRoute )
  {
  }

  ngOnInit() {
    this.loadAdvertisment();
  }

  loadAdvertisment()
  {
    this.advertismentService.getById(+this.route.snapshot.params['id']).subscribe((data: Advertisment) =>{
       this.advertisment=data;
     },error =>{
       this.alertify.error("Something went wrong");
     });
  }


}
