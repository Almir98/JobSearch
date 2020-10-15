import { Component, OnInit } from '@angular/core';
import { Company } from '../_models/Company';
import { AlertifyService } from '../_services/alertify.service';
import { CompanyService } from '../_services/company.service';

@Component({
  selector: 'app-addCompany',
  templateUrl: './addCompany.component.html',
  styleUrls: ['./addCompany.component.css']
})
export class AddCompanyComponent implements OnInit {

  company: Company=new Company();

  constructor(private companyService: CompanyService,private alertify: AlertifyService) { }

  ngOnInit() {
  }

  addCompany()
  {
    this.companyService.insert(this.company).subscribe((data: Company)=>{

      this.company=data;
      console.log(this.company);
      this.alertify.success("Successfully added");
    },error =>{
      this.alertify.error("Something went wrong");
    })
  }
  
  
}
