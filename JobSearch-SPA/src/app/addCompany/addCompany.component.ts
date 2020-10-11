import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../_services/company.service';

@Component({
  selector: 'app-addCompany',
  templateUrl: './addCompany.component.html',
  styleUrls: ['./addCompany.component.css']
})
export class AddCompanyComponent implements OnInit {

  company: any={};

  constructor(private companyService: CompanyService) { }

  ngOnInit() {
  }

  addCompany()
  {
    console.log(this.company);
  }


}
