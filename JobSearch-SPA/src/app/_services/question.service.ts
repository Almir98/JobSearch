import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import {Question} from '../_models/Question';
import { AuthService } from './auth.service';
@Injectable({
  providedIn: 'root'
})
export class QuestionService {

constructor(private http:HttpClient,private authService:AuthService) { }

baseUrl= environment.apiUrl+'/Question';


getAll():Observable<Question[]>
{
  return null;
}

getById(id:number):Observable<Question>
{
  return null;
}

insert(question:Question)
{
  question.userid=this.authService.decodedToken.nameid;   // to get logged userId number and to store in database which userId sent a message 
  return this.http.post(this.baseUrl,question);
}









}
