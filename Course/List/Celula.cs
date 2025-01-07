class Celula
{
    
    public int valor;
    public Celula? prox;

    public Celula(){

        valor = -1;
        prox = null;

    }

    public Celula(int valor){

        this.valor = valor;
        prox = null;

    }

}