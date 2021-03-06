import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';



import { AuthService } from './_services/auth.service';
import { AlertifyService } from './_services/alertify.service';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { AuthGuard } from './_guards/auth.guard';
import { GenderService } from './_services/gender.service';



import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './home/register/register.component';
import { ContactComponent } from './contact/contact.component';
import { QuestionComponent } from './question/question.component';
import { AdvertismentComponent } from './advertisment/advertisment.component';
import { AdvertismentDetailComponent } from './advertisment/advertismentDetail/advertismentDetail.component';
import { AboutComponent } from './about/about.component';
import { UserEditComponent } from './user-edit/user-edit.component';
import { ApplicationComponent } from './application/application.component';
import { AdminDashboardComponent } from './adminDashboard/adminDashboard.component';
import { CityComponent } from './city/city.component';
import { JobTypeComponent } from './jobType/jobType.component';
import { AddCompanyComponent } from './addCompany/addCompany.component';
import { AddAdvertismentComponent } from './addAdvertisment/addAdvertisment.component';
import { AdminaplicationComponent } from './adminaplication/adminaplication.component';
import { AddskillComponent } from './addskill/addskill.component';
import { AddCategoryComponent } from './addCategory/addCategory.component';
import { AddJobLevelComponent } from './addJobLevel/addJobLevel.component';
import { AdminapplicationdetailComponent } from './adminaplication/adminapplicationdetail/adminapplicationdetail.component';


@NgModule({
  declarations: [																									
    AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      ContactComponent,
      QuestionComponent,
      AdvertismentComponent,
      AdvertismentDetailComponent,
      AboutComponent,
      UserEditComponent,
      ApplicationComponent,
      AdminDashboardComponent,
      CityComponent,
      JobTypeComponent,
      AddCompanyComponent,
      AddAdvertismentComponent,
      AdminaplicationComponent,
      AddskillComponent,
      AddCategoryComponent,
      AddJobLevelComponent,
      AdminapplicationdetailComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BsDropdownModule.forRoot(),
    RouterModule.forRoot(appRoutes),
    ReactiveFormsModule,
  ],
  providers: [
    AuthService,
    AlertifyService,
    AuthGuard,
    GenderService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
