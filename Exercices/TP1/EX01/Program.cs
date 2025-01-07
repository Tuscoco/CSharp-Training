using System;

class Program
{

    public static bool Fim(string str){

        bool isFim = false;

        if(str.Equals("FIM")){

            isFim = true;

        }

        return isFim;

    }

    public static bool EhPalindromo(string str){

        bool resultado = true;

        int i = 0;
        int j = 0;

        for(i = 0,j = str.Length - 1; i < str.Length / 2;i++,j--){

            if(str[i] != str[j]){

                resultado = false;
                break;

            }

        }

        return resultado;

    }
    
    static void Main(string[] args){

        string str = "";

        do{

            str = Console.ReadLine();

            if(!Fim(str)){

                if(EhPalindromo(str)){

                    Console.WriteLine("SIM");

                }else{

                    Console.WriteLine("NAO");

                }

            }

        }while(!Fim(str));

    }
    
}