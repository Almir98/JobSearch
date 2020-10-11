import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
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
  city: any = {};

  constructor(private countryService: CountryService,private alertify: AlertifyService,private cityService: CityService,private router: Router) { }

  ngOnInit() {
    this.loadCountry();
  }

  loadCountry()
  {
    this.countryService.getAll().subscribe(data => {
      this.countries=data;
    })
  }

  addCity()
  {
    this.cityService.insert(this.city).subscribe(data =>{
      
      this.city=data;
      console.log(this.city);
      this.alertify.success("Successfully added");
      this.router.navigate(['/admin']);
      
    },error =>{
      this.alertify.error("Something went wrong");
    });
  }

}
