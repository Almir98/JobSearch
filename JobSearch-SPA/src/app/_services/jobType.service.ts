import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { JobType } from '../_models/JobType';

@Injectable({
  providedIn: 'root'
})
export class JobTypeService {

baseUrl=environment.apiUrl+'/JobType';

constructor(private http: HttpClient) { }

getAll(): Observable <JobType[]>
{
  return this.http.get<JobType[]>(this.baseUrl);
}

getById(id: number): Observable<JobType>
{
  return this.http.get<JobType>(this.baseUrl+'/id?id='+id);
}

insert(jobtype: JobType)
{
  return this.http.post(this.baseUrl,jobtype);
}


}
