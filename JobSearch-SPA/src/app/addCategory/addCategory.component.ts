import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
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
  categoryForm: FormGroup;

  constructor(private categoryService: CategoryService,private alertify: AlertifyService, private router:Router,private fb:FormBuilder) { }

  ngOnInit() {

    this.categoryForm = this.fb.group({
      spanCategoryName:['',Validators.required]
    })
  }

  public get getFormControl() {
    return this.categoryForm.controls;
  }

  addCategory()
  {
    if(this.categoryForm.valid)
    {
      this.category.categoryName = this.getFormControl.spanCategoryName.value;

      this.categoryService.insert(this.category).subscribe((data:Category)=>{
        this.category=data;
        this.alertify.success("Successfully added");
        this.router.navigate(['admin']);
      });
    }
    else{
      this.alertify.error("Something went wrong");
      this.categoryForm.markAllAsTouched();
    }
  }
}
