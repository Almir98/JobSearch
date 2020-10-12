import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { JobType } from '../_models/JobType';
import { AlertifyService } from '../_services/alertify.service';
import { JobTypeService} from '../_services/jobType.service';

@Component({
  selector: 'app-jobType',
  templateUrl: './jobType.component.html',
  styleUrls: ['./jobType.component.css']
})
export class JobTypeComponent implements OnInit {

  jobType: JobType = new JobType();

  constructor(private alertify: AlertifyService, private router:Router,private jobTypeService: JobTypeService)
  {
  }

  ngOnInit() {
  }

  addJobType()
  {
     this.jobTypeService.insert(this.jobType).subscribe((data:JobType) => {
      
       this.jobType=data;
       console.log(this.jobType);

       this.alertify.success("Successfully added");
       this.router.navigate(['/admin']);
     },erorr=>{
       this.alertify.error("Something went wrong");
     })
  }
}
