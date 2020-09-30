import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { City } from '../_models/City';

@Injectable({
  providedIn: 'root'
})
export class CityService {

baseUrl=environment.apiUrl+'/City';

constructor(private http: HttpClient) { }

getAll(): Observable<City[]>
{
  return this.http.get<City[]>(this.baseUrl);
}

getById(id:number): Observable<City>
{
  return this.http.get<City>(this.baseUrl+'/id?id='+id);
}

insert(city:City)
{
  return this.http.post(this.baseUrl,city);
}

update(id:number,city:City)
{
  return this.http.put(this.baseUrl+'/'+id,city);
}

}
