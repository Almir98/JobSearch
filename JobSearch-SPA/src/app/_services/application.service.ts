import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Application } from '../_models/Application';

@Injectable({
  providedIn: 'root'
})
export class ApplicationService {

baseUrl=environment.apiUrl+'/Application';

constructor(private http: HttpClient) { }

getAll() : Observable<Application[]>
{
  return this.http.get<Application[]>(this.baseUrl);
}

getById(id:number) :Observable<Application>
{
  return this.http.get<Application>(this.baseUrl+'/id?id='+id);
}

insert(application: Application)
{
  return this.http.post(this.baseUrl,application);
}

update(id:number, application: Application)
{
  return this.http.put(this.baseUrl+"/"+id,application);
}

}
