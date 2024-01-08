import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Evento } from '../models/Evento';

@Injectable()
export class EventoService {
  baseURL = 'https://localhost:7221/api/Eventos';

  constructor(private http: HttpClient) { }

  public getEvento(): Observable<Evento[]> {
    return this.http.get<Evento[]>(this.baseURL)
  };

  public getEventoByTema(tema: string): Observable<Evento[]> {
    return this.http.get<Evento[]>(`${this.baseURL}/${tema}/tema`)
  };

  public getEventoById(id: number): Observable<Evento> {
    return this.http.get<Evento>(`${this.baseURL}/${id}`)
  };
}
