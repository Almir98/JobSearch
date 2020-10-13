import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Category } from '../_models/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  baseUrl=environment.apiUrl+'/Category';

constructor(private http: HttpClient) { }

getAll(): Observable<Category[]>
{
  return this.http.get<Category[]>(this.baseUrl);
}

getById(id: number): Observable<Category>
{
  return this.http.get<Category>(this.baseUrl+'/id?id='+id);
}

insert(category: Category)
{
  return this.http.post(this.baseUrl,category);
}


}
