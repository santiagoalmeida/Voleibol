import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EquipoService {


  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };
  addPointUrl: string = 'Puntos/AddPoint';
  checkSetUrl: string = 'Puntos/CheckSet';

  saveEquipos(equipos: IMatch) {
    sessionStorage.clear();
    sessionStorage.setItem('Equipos', JSON.stringify(equipos));
  }

  getEquipos(): IMatch {
    let equipo = sessionStorage.getItem('Equipos')
    return JSON.parse(equipo) as IMatch;
  }

  borrar(): void {
    sessionStorage.clear();
  }

  addPoint(match: IMatch): Observable<any> {
    return this.http.post(this.addPointUrl, match, this.httpOptions);
  }

  checkSet(match: IMatch): Observable<any> {
    return this.http.post(this.checkSetUrl, match, this.httpOptions);
  }
}
