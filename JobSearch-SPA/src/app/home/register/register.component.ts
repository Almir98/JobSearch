import { Component, OnInit } from '@angular/core';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { Gender } from 'src/app/_models/Gender';
import { User } from 'src/app/_models/User';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { AuthService } from 'src/app/_services/auth.service';
import { GenderService } from 'src/app/_services/gender.service';
import { CityService } from 'src/app/_services/city.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  genders:BsDropdownModule[];
  cities:BsDropdownModule[];
  user:any={};

  constructor(private genderService:GenderService,private alertify:AlertifyService,private authService:AuthService,
    private cityService: CityService) { }

  ngOnInit()
  {
    this.loadGenders();
    this.loadCities();
  }

  loadGenders()
  {
    this.genderService.getAll().subscribe(genders=>{
      
      genders.forEach(element=>{
        var el={genderId:element.genderId,genderType:element.genderType};
        //console.log(el);
        //this.genders.push(el);
      });
    },error=>{
      console.log(error);
      this.alertify.error(error);
    })
  }

  loadCities()
  {
    this.cityService.getAll().subscribe(data=>{

      this.cities=data;
      console.log(this.cities);
    },error=>{
      this.alertify.error(error);
    })
  }

  registerAccount()
  {
    console.log(this.user);
  }


}
