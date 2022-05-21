import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { FilmsListResponse} from 'src/app/models/films.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class FilmsService {

  constructor(private http:HttpClient) {}

  public getFilmList(query: string): Observable<FilmsListResponse> {
    const url = `${environment.URL}/?s=${query}&apikey=${environment.APIKEY}`;
    return this.http.get<any>(url);

  }
}
