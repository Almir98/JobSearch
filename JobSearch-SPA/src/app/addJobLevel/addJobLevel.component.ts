import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { JobLevel } from '../_models/JobLevel';
import { AlertifyService } from '../_services/alertify.service';
import { JobLevelService } from '../_services/jobLevel.service';

@Component({
  selector: 'app-addJobLevel',
  templateUrl: './addJobLevel.component.html',
  styleUrls: ['./addJobLevel.component.scss']
})
export class AddJobLevelComponent implements OnInit {

  jobLevel: JobLevel = new JobLevel();
  jobRef: FormGroup;

  constructor(private alertify: AlertifyService,private router: Router, private joblevelService: JobLevelService) { }

  ngOnInit() {
  }

  addJobLevel()
  {
    this.joblevelService.insert(this.jobLevel).subscribe((data: JobLevel)=>{

      this.jobLevel=data;
      this.alertify.success("Successfully added");
      this.router.navigate(['admin']);
    },error =>{
      this.alertify.error("Something went wrong");
    })
  }
}
