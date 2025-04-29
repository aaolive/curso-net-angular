import { Routes } from '@angular/router';

// importe dos componentes
import { EventosComponent } from './eventos/eventos.component';
import { ContatosComponent } from './contatos/contatos.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';


// apos colocar aqui para apontar a rota (path:) para o componente
export const routes: Routes = [
  {path: 'eventos', component: EventosComponent},
  {path: 'contatos', component: ContatosComponent},
  {path: 'palestrantes', component: PalestrantesComponent},
  {path: '', redirectTo: 'eventos', pathMatch:'full'},

];
