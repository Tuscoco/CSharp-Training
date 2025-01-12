using System;

namespace EX1{

    class Cotacao
    {
        
        private double atual;

        public Cotacao(){

            atual = 0;

        }

        public void SetAtual(double x){

            atual = x;

        }

        public double Calcular(double dolares){

            return dolares * atual;

        }

    }

}