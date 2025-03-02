import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { response } from 'express';
import { EventoService } from '../services/evento.service';
import { Evento } from '../models/Evento';

@Component({
  selector: 'app-eventos',
  imports: [],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent implements OnInit {


  /* public eventos: any = [
    {
      Tema: 'Angular 18',
      Local: 'Belo Horizonte'
    },
    {
      Tema: 'Java 21',
      Local: 'Belo Horizonte'
    },
    {
      Tema: 'C# 9',
      Local: 'Belo Horizonte'
    }
  ] */

  public eventos: Evento[] = [];

  // foi criado um servico na pasta services e usado aqui. ele contem a url que é chamada
  constructor(private eventoService: EventoService) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.eventoService.getEventos().subscribe(
      response => this.eventos = response,
      error => console.log(error)
    )
  }


  

}
