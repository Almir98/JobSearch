import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ObserveOnMessage } from 'rxjs/internal/operators/observeOn';
import { environment } from 'src/environments/environment';
import { Advertisment } from '../_models/Advertisment';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class AdvertismentService {

  baseUrl=environment.apiUrl+'/Advertisment';

  constructor(private http:HttpClient,private authService : AuthService)
 {}

 getAll() : Observable<Advertisment[]>
 {
   return this.http.get<Advertisment[]>(this.baseUrl);
 }

 getById(id): Observable<Advertisment> 
 {
    console.log(id);
   return this.http.get<Advertisment>(this.baseUrl+'/id?id='+ id);
 }

 insert(request: Advertisment)
 {
   return this.http.post(this.baseUrl,request);
 }

 update(id: number,request: Advertisment)
 {
   return this.http.put(this.baseUrl+"/"+id,request);
 }
 

}
