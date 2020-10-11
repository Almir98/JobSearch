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

  addJob: FormGroup;
  jobType: any={};

  constructor(private alertify: AlertifyService, private fb: FormBuilder, private router:Router,private jobTypeService: JobTypeService)
  {
  }

  ngOnInit() {
    this.validateFields();
  }

  validateFields()
  {
    this.addJob = this.fb.group({
      jobTypeName:['',Validators.required]
    })
  }

  addJobType()
  {
    
    console.log(this.addJob.value);
    
     this.jobTypeService.insert(this.jobType).subscribe(data => {
      
       this.jobType=this.addJob.value;
      
       console.log(data);
     })
  }

}
