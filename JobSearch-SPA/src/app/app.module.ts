import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';



import { AuthService } from './_services/auth.service';
import { AlertifyService } from './_services/alertify.service';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { AuthGuard } from './_guards/auth.guard';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './home/register/register.component';
import { ContactComponent } from './contact/contact.component';
import { QuestionComponent } from './question/question.component';
import { AdvertismentComponent } from './advertisment/advertisment.component';
import { AdvertismentDetailComponent } from './advertisment/advertismentDetail/advertismentDetail.component';



@NgModule({
  declarations: [						
    AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      ContactComponent,
      QuestionComponent,
      AdvertismentComponent,
      AdvertismentDetailComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BsDropdownModule.forRoot(),
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    AuthService,
    AlertifyService,
    AuthGuard
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
