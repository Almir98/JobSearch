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
import { AdvertismentService } from '../_services/advertisment.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-addAdvertisment',
  templateUrl: './addAdvertisment.component.html',
  styleUrls: ['./addAdvertisment.component.css']
})
export class AddAdvertismentComponent implements OnInit {

  advertisment: Advertisment = new Advertisment();
    
  jobLevel: JobLevel[];
  cities: City[];
  companies: Company[];
  categories: Category[];
  jobTypes: JobType[];

  constructor(private companyService: CompanyService, private cityService: CityService, private jobLevelService: JobLevelService,
    private alertify:AlertifyService, private categoryService: CategoryService, private jobTypeService: JobTypeService,
    private advertismentService: AdvertismentService,private router: Router) { }

  ngOnInit() {
    this.loadJobLevels();
    this.loadCities();
    this.loadCompanies();
    this.loadCategories();
    this.loadJobType();
  }

  addAdvertisment()
  {
    this.advertismentService.insert(this.advertisment).subscribe((data:Advertisment)=>{
      this.advertisment=data;
      this.alertify.success("Successfully added");
      this.router.navigate(['/admin']);
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  loadJobLevels()
  {
    this.jobLevelService.getAll().subscribe(data =>{
      this.jobLevel=data;
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  loadCities(){
    this.cityService.getAll().subscribe(data=>{
      this.cities=data;
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  loadCompanies(){
    this.companyService.getAll().subscribe(data=>{
      this.companies=data;
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }

  loadCategories(){
    this.categoryService.getAll().subscribe(data=>{
      this.categories=data;
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }
  
  loadJobType()
  {
    this.jobTypeService.getAll().subscribe(data =>{
      this.jobTypes=data;
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }
}
