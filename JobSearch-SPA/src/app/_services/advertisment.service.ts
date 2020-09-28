import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AdvertismentService {

  baseUrl=environment.apiUrl+'/Advertisment';

  constructor(private http:HttpClient)
 {}










}
