using System; 

class URI {

    public static void Swap(int j, int jj, string[] array){

        string tmp = array[j];
        array[j] = array[jj];
        array[jj] = tmp;

    }

    public static string Ordenar(string[] array){

        bool swapped = true;

        for(int i = (array.Length - 1);i > 0 && swapped;i--){

            swapped = false;

            for(int j = 0;j < i;j++){

                if(array[j].Length < array[j + 1].Length){

                    Swap(j, j + 1, array);
                    swapped = true;

                }

            }

        }

        return string.Join(" ", array);

    }

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());

        for(int i = 0;i < n;i++){

            string frase = Console.ReadLine();

            Console.WriteLine(Ordenar(frase.Split(" ")));

        }

    }

}