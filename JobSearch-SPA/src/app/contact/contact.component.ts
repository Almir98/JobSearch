import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { timeInterval } from 'rxjs/operators';
import { Question } from '../_models/Question';
import { User } from '../_models/User';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import { QuestionService } from '../_services/question.service';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {

  question: any={};

  user: User;
  @ViewChild('submitQuestion') submitQuestion : NgForm;

  constructor(private questionService : QuestionService,private authService:AuthService,private alertify:AlertifyService,
  private route:ActivatedRoute,private router:Router,private userService : UserService)
    {
    }

  ngOnInit() {
    this.getUser();
  }

  getUser()
  {
    return this.userService.getUser(this.authService.decodedToken.nameid).subscribe(data=>{
      this.user=data;
    },error=>{
      this.alertify.error(error);
    })
  }

  sendQuestion()
  {
    this.questionService.insert(this.question).subscribe(next=>{

      this.router.navigate(['/home']);
      this.alertify.success("Message sent successfully! Thank you.");
      this.submitQuestion.reset(this.question);

    },error => {
      this.alertify.error("Something went wrong!");
    })
    
  }

}
