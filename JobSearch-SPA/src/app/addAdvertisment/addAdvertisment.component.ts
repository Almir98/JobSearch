import { Component, OnInit } from '@angular/core';
import { City } from '../_models/City';
import { Company } from '../_models/Company';
import { JobLevel } from '../_models/JobLevel';
import { Category } from '../_models/Category';
import { AlertifyService } from '../_services/alertify.service';
import { CityService } from '../_services/city.service';
import { CompanyService } from '../_services/company.service';
import { JobLevelService } from '../_services/jobLevel.service';
import { CategoryService } from '../_services/category.service';
import { JobTypeService } from '../_services/jobType.service';
import { JobType } from '../_models/JobType';
import { AdvertismentDetailComponent } from '../advertisment/advertismentDetail/advertismentDetail.component';
import { Advertisment } from '../_models/Advertisment';


@Component({
  selector: 'app-addAdvertisment',
  templateUrl: './addAdvertisment.component.html',
  styleUrls: ['./addAdvertisment.component.css']
})
export class AddAdvertismentComponent implements OnInit {

  advertisment: any={};
    
  jobLevel: JobLevel[];
  cities: City[];
  companies: Company[];
  categories: Category[];
  jobTypes: JobType[];

  constructor(private companyService: CompanyService, private cityService: CityService, private jobLevelService: JobLevelService,
    private alertify:AlertifyService, private categoryService: CategoryService, private jobTypeService: JobTypeService) { }

  ngOnInit() {
    this.loadJobLevels();
    this.loadCities();
    this.loadCompanies();
    this.loadCategories();
    this.loadJobType();
  }

  addAdvertisment()
  {
    console.log(this.advertisment);
  }

  loadJobLevels()
  {
    this.jobLevelService.getAll().subscribe(data =>{
      this.jobLevel=data;

      console.log(this.jobLevel);
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  loadCities(){
    this.cityService.getAll().subscribe(data=>{

      this.cities=data;
      console.log(this.cities);
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  loadCompanies(){
    this.companyService.getAll().subscribe(data=>{

      this.companies=data;
      console.log(this.companies);
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  loadCategories(){
    this.categoryService.getAll().subscribe(data=>{

      this.categories=data;
      console.log(this.categories);
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }
  
  loadJobType()
  {
    this.jobTypeService.getAll().subscribe(data =>{
      this.jobTypes=data;
      console.log(this.jobTypes);
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

}
