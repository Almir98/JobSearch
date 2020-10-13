import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { JobLevel } from '../_models/JobLevel';

@Injectable({
  providedIn: 'root'
})
export class JobLevelService {

  baseUrl=environment.apiUrl+'/JobLevel';

constructor(private http:HttpClient) { }

getAll(): Observable<JobLevel[]>
{
  return this.http.get<JobLevel[]>(this.baseUrl);
}

insert(level: JobLevel)
{
  return this.http.post(this.baseUrl,level);
}

}
