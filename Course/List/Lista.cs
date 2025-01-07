class Lista
{
    
    public Celula inicio, fim;

    public Lista(){

        inicio = new Celula();
        fim = inicio;

    }

    public void InserirFim(int x){

        Celula? tmp = new Celula(x);
        fim.prox = tmp;
        fim = fim.prox;

        tmp = null;

    }

    public void Imprimir(){

        Celula i = inicio.prox;

        while(i != null){

            Console.WriteLine(i.valor);
            i = i.prox;

        }

    }

}