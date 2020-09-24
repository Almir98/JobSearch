import {Routes} from '@angular/router';

// Components
import {HomeComponent} from './home/home.component';
import {RegisterComponent} from './home/register/register.component';
import {QuestionComponent} from './question/question.component';
import {ContactComponent} from './contact/contact.component';
import { AuthGuard } from './_guards/auth.guard';
import { AboutComponent } from './about/about.component';


export const appRoutes: Routes = [

    {path:'home',component:HomeComponent},
    {path:'register',component:RegisterComponent},
    //{path:'register',component:RegisterComponent,canActivate:[AuthGuard]},
    {path:'question',component:QuestionComponent},
    {path:'contact',component:ContactComponent},
    {path:'about',component:AboutComponent},
    {path:'**', redirectTo:'home',pathMatch:'full'}

];

















