import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { response } from 'express';

@Component({
  selector: 'app-eventos',
  imports: [],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent implements OnInit {


  // public eventos: any = [
  //   {
  //     Tema: 'Angular 18',
  //     Local: 'Belo Horizonte'
  //   },
  //   {
  //     Tema: 'Java 21',
  //     Local: 'Belo Horizonte'
  //   },
  //   {
  //     Tema: 'C# 9',
  //     Local: 'Belo Horizonte'
  //   }
  // ]

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('endereco api').subscribe(
      response => this.eventos = response,
      error => console.log(error)
    )
  }
}
