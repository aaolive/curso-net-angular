import { ChangeDetectionStrategy, Component } from '@angular/core';

@Component({
  selector: 'app-titulo',
  imports: [],
  template: `<p>Titulo works!</p>`,
  styleUrl: './Titulo.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class TituloComponent { }
