import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Category } from '../_models/Category';
import { AlertifyService } from '../_services/alertify.service';
import { CategoryService } from '../_services/category.service';

@Component({
  selector: 'app-addCategory',
  templateUrl: './addCategory.component.html',
  styleUrls: ['./addCategory.component.scss']
})
export class AddCategoryComponent implements OnInit {

  public category: Category = new Category();
  categoryRef: FormGroup;

  constructor(private categoryService: CategoryService,private alertify: AlertifyService, private router:Router) { }

  ngOnInit() {
  }

  addCategory()
  {
    this.categoryService.insert(this.category).subscribe((data:Category)=>{
      this.category=data;
      this.alertify.success("Successfully added");
      this.router.navigate(['admin']);
    },error=>{
      this.alertify.error("Something went wrong");
    })
  }
}
