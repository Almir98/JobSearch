import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Skill } from '../_models/Skill';

@Injectable({
  providedIn: 'root'
})
export class SkillService {

  baseUrl=environment.apiUrl+'/Skill';

constructor(private http: HttpClient) { }

getAll(): Observable<Skill[]>
{
  return this.http.get<Skill[]>(this.baseUrl);
}

getById(id: number): Observable<Skill>
{
  return this.http.get<Skill>(this.baseUrl+'/id?id='+id);
}

insert(skill: Skill)
{
  return this.http.post(this.baseUrl,skill);
}













}
