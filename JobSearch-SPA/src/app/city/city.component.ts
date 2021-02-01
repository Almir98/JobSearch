import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { City } from '../_models/City';
import { Country } from '../_models/Country';
import { AlertifyService } from '../_services/alertify.service';
import { CityService } from '../_services/city.service';
import { CountryService } from '../_services/country.service';

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.css']
})
export class CityComponent implements OnInit {

  countries: Country[];
  city: City = new City();
  cityForm: FormGroup;

  constructor(private countryService: CountryService,private alertify: AlertifyService,private cityService: CityService,private router: Router,
    private fb: FormBuilder) { 

    }

  ngOnInit() {
    this.loadCountry();

    this.cityForm = this.fb.group({

      spancityName: ['',Validators.required],
      spanzipCode: ['',Validators.required],
      spancountryId:['',Validators.required]
    });
  }

  public get getFormControl() {
    return this.cityForm.controls;
  }

  loadCountry()
  {
    this.countryService.getAll().subscribe(data => {
      this.countries=data;
    })
  }

  addCity()
  {
    if(this.cityForm.valid)
    {
      this.city.cityName = this.getFormControl.spancityName.value;
      this.city.zipCode = this.getFormControl.spanzipCode.value;
      this.city.countryId = this.getFormControl.spancountryId.value;
      console.log(this.city);

      this.cityService.insert(this.city).subscribe(data =>{
  
        this.alertify.success("Successfully added");
        this.router.navigate(['/admin']);
      });
    }
    else{
      this.alertify.error("Something went wrong");
      this.cityForm.markAllAsTouched();
    }
  }
}
