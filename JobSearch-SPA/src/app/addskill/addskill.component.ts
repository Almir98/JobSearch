import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AlertifyService } from '../_services/alertify.service';
import { SkillService } from '../_services/skill.service';
import { Skill } from '../_models/Skill';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Router } from '@angular/router';

@Component({
  selector: 'app-addskill',
  templateUrl: './addskill.component.html',
  styleUrls: ['./addskill.component.scss']
})
export class AddskillComponent implements OnInit {

  addSkill: FormGroup;
  skill=new Skill();

  constructor(private alertify:AlertifyService,private fb:FormBuilder, private skillService: SkillService,private router:Router) { }

  ngOnInit() {
  }

  submitSkill()
  {
    this.skillService.insert(this.skill).subscribe((data: Skill)=>{

      this.skill=data;
      console.log(this.skill);
      this.alertify.success("Successfully added");
      this.router.navigate(['/admin']);
    },error =>{
      this.alertify.error("Something went wrong");
    })
  }
}
