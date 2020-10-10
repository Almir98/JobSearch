import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Country } from '../_models/Country';

@Injectable({
  providedIn: 'root'
})
export class CountryService {
  
  baseUrl=environment.apiUrl+'/Country';

constructor(private http: HttpClient) { }

getAll(): Observable<Country[]>
{
  return this.http.get<Country[]>(this.baseUrl);
}

getById(id: number): Observable<Country>
{
  return this.http.get<Country>(this.baseUrl+'/id?id='+id);
}

}
