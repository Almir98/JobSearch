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
  jobForm: FormGroup;

  constructor(private alertify: AlertifyService, private router:Router,private jobTypeService: JobTypeService, private fb: FormBuilder)
  {
  }

  ngOnInit() {

    this.jobForm = this.fb.group ({

      spanJobName:['',Validators.required]
    });

  }

  public get getFormControl() {
    return this.jobForm.controls;
  }

  addJobType()
  {
    if(this.jobForm.valid)
    {
      this.jobType.jobTypeName = this.getFormControl.spanJobName.value;

      this.jobTypeService.insert(this.jobType).subscribe((data:JobType) => {
        
        this.jobType=data;
        this.alertify.success("Successfully added");
        this.router.navigate(['/admin']);
      });
    }
    else{
      this.alertify.error("Something went wrong");
      this.jobForm.markAllAsTouched();
    }
  }
}
