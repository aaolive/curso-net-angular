import { Evento } from "./Evento";
import { RedeSocial } from "./RedeSocial";

export interface Palestrante {
    id:number;
    nome:string;
    email:string;
    telefone:string;
    redesocials: RedeSocial[];
    palestranteseventos:Evento[];
}
