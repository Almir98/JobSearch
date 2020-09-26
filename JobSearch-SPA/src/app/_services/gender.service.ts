import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Gender } from '../_models/Gender';

@Injectable({
  providedIn: 'root'
})
export class GenderService {

  constructor(private http:HttpClient) { }

  baseUrl=environment.apiUrl+'Gender/';

  getAll(): Observable<Gender[]>
  {
    return this.http.get<Gender[]>(this.baseUrl+'Get');
  }

}
