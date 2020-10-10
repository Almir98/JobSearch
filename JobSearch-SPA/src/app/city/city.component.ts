import { Component, OnInit } from '@angular/core';
import { Country } from '../_models/Country';
import { AlertifyService } from '../_services/alertify.service';
import { CountryService } from '../_services/country.service';

@Component({
  selector: 'app-city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.css']
})
export class CityComponent implements OnInit {

  countries: Country[];
  city: any = {};

  constructor(private countryService: CountryService,private alertify: AlertifyService) { }

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
    console.log(this.city);    
  }

}
