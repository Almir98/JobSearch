import { Component, OnInit } from '@angular/core';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { Gender } from 'src/app/_models/Gender';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { AuthService } from 'src/app/_services/auth.service';
import { GenderService } from 'src/app/_services/gender.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  genders:BsDropdownModule[];

  constructor(private genderService:GenderService,private alertify:AlertifyService,private authService:AuthService) { }

  ngOnInit()
  {
    this.loadGenders();
  }

  loadGenders()
  {
    this.genderService.getAll().subscribe(genders=>{
      
      genders.forEach(element=>{
        var el={id:element.genderId,name:element.genderType};
        this.genders.push(el);
      });
    },error=>{
      console.log(error);
      this.alertify.error(error);
    })
  }

  registerAccount()
  {
    // this.authService.register(this.)
    
  }


}
