export interface Evento {
    eventoId: number;
    local: string;
    dataEvento: string;
    tema: string;
    qtdPessoas: number;
    imagemURL: string;
    telefone: string;
    email: string;
    lotes: [
        {
            id: number;
            nome: string;
            preco: number;
            dataInicio?: string;
            dataFim?: string;
            quantidade: number;
            eventoId: number;
        }
    ];
    redesSociais: [
        {
            nome: string;
            url: string;
        }
    ];
    palestranteEventos: [
        {
            palestranteId: number;
            palestrante: {
                palestranteId: number;
                nome: string;
                miniCurriculo: string;
                imagemURL: string;
                telefone: string;
                email: string;
            }
        }
    ];
}
