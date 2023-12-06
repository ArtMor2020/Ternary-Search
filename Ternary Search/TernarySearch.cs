//Codigo de https://www.geeksforgeeks.org/ternary-search/

using System;

public class Program
{
    //Função para realizar a busca
    public static int TernarySearch(int esquerda, int direita, int chave, int[] lista)
    {
        if (direita >= esquerda)
        {
            //Para encontrar meio1 e meio2
            int meio1 = esquerda + (direita - esquerda) / 3;
            int meio2 = direita - (direita - esquerda) / 3;

            //Checar se a chave esta em algum dos meios
            if (lista[meio1] == chave)
            {
                return meio1;
            }

            if (lista[meio2] == chave)
            {
                return meio2;
            }

            //Checar em qual região a chave está, e então repitir a busca.
            if (chave < lista[meio1])
            {
                return TernarySearch(esquerda, meio1 - 1, chave, lista);
            }
            else if (chave > lista[meio2])
            {
                return TernarySearch(meio2 + 1, direita, chave, lista);
            }
            else
            {
                return TernarySearch(meio1 + 1, meio2 - 1, chave, lista);
            }
        }
        //Retorna -1 caso a chave não seja encontrada
        return -1;
    }

    // Codigo principal
    public static void Main()
    {
        int esquerda, direita, posicao, chave;
 
        // Get the array
        // Sort the array if not sorted
        int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
 
        // Starting index
        esquerda = 0;
 
        // end element index
        direita = 9;
 
        // Checking for 5
 
        // Key to be searched in the array
        chave = 5;
 
        // Search the key using ternarySearch
        posicao = TernarySearch(esquerda, direita, chave, lista);
 
        // Print the result
        Console.WriteLine("A posição de " + chave + " é " + posicao);
 
        // Checking for 50
 
        // Key to be searched in the array
        chave = 50;
 
        // Search the key using ternarySearch
        posicao = TernarySearch(esquerda, direita, chave, lista);
 
        // Print the result
        Console.WriteLine("A posição de " + chave + " é " + posicao);
    }
}
