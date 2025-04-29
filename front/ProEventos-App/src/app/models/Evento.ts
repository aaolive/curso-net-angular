import { Lote } from "./Lote";
import { Palestrante } from "./Palestrante";
import { RedeSocial } from "./RedeSocial";

export interface Evento {

     id: number;
     nome:string;
     descricao:string;
     dataevento?: Date;
     lotes: Lote[];
     redesocials: RedeSocial[];
     palestranteseventos: Palestrante[];
}
