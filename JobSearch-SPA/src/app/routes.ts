import {Routes} from '@angular/router';

// Components
import {HomeComponent} from './home/home.component';
import {RegisterComponent} from './home/register/register.component';
import {QuestionComponent} from './question/question.component';
import {ContactComponent} from './contact/contact.component';
import { AuthGuard } from './_guards/auth.guard';
import { AboutComponent } from './about/about.component';
import { UserEditComponent } from './user-edit/user-edit.component';
import { ApplicationComponent } from './application/application.component';
import { AdminDashboardComponent } from './adminDashboard/adminDashboard.component';
import { CityComponent } from './city/city.component';
import { JobTypeComponent } from './jobType/jobType.component';
import { AddCompanyComponent } from './addCompany/addCompany.component';
import { AddAdvertismentComponent } from './addAdvertisment/addAdvertisment.component';
import { AddJobLevelComponent } from './addJobLevel/addJobLevel.component';


import { AdvertismentDetailComponent } from './advertisment/advertismentDetail/advertismentDetail.component';
import { AdminaplicationComponent } from './adminaplication/adminaplication.component';
import { AddskillComponent } from './addskill/addskill.component';
import { AddCategoryComponent } from './addCategory/addCategory.component';


export const appRoutes: Routes = [

    {path:'home',component:HomeComponent},
    {path:'advertisment/:id',component:AdvertismentDetailComponent},
    {path:'register',component:RegisterComponent},
    //{path:'register',component:RegisterComponent,canActivate:[AuthGuard]},
    {path:'question',component:QuestionComponent},
    {path:'contact',component:ContactComponent},
    {path:'about',component:AboutComponent},
    {path:'admin',component:AdminDashboardComponent},
    {path:'AddCity',component:CityComponent},
    {path:'AddJobType',component:JobTypeComponent},
    {path:'AddCompany',component:AddCompanyComponent},
    {path:'AddAdvertisment',component:AddAdvertismentComponent},
    {path:'AllAplications',component: AdminaplicationComponent},
    {path:'AllAplications',component: AdminaplicationComponent},
    {path:'AddSkill',component: AddskillComponent},
    {path:'AddCategory',component: AddCategoryComponent},
    {path:'AddJobLevel',component: AddJobLevelComponent},


    



    {path:'application/:id',component:ApplicationComponent},

    {path:'EditProfile',component:UserEditComponent,canActivate:[AuthGuard]},

    {path:'**', redirectTo:'home',pathMatch:'full'}

];

















