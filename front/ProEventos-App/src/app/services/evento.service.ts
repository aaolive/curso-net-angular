import { Injectable } from '@angular/core';
import { Evento } from '../models/Evento';

@Injectable({
  providedIn: 'root'
})
export class EventoService {

  baseurl = "url da api"

  constructor(private http: HttpClient) { }

  getEventos(): Observable<Evento[]> {
    return this.http.get<Evento[]>(this.baseurl);
  }


  getEventosByTema(tema: string): Observable<Evento[]> {
    return this.http.get<Evento[]>(`${this.baseurl}/${tema}/tema`);
  }

  getEventosNyId(id: number): Observable<Evento> {
    return this.http.get<Evento>(`${this.baseurl}/${id}`);
  }

}
