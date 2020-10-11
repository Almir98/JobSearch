import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Company } from '../_models/Company';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  baseUrl=environment.apiUrl+'/Company';

  constructor(private http: HttpClient) { }

  getAll(): Observable<Company[]>
  {
    return this.http.get<Company[]>(this.baseUrl);
  }

  getById(id: number): Observable<Company>
  {
    return this.http.get<Company>(this.baseUrl+'/id?id='+id);
  }

  insert(company: Company)
  {
    return this.http.post(this.baseUrl,company);
  }

}
