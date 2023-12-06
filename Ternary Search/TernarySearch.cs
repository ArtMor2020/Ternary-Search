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
 
        // Lista
        int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
 
        // Começo da lista
        esquerda = 0;
 
        // Fim da Lista
        direita = 9;
 
 
        // Chave a ser buscada
        chave = 5;
 
        // Busca da chave
        posicao = TernarySearch(esquerda, direita, chave, lista);
 
        // Exibir resultado da busca no terminal
        Console.WriteLine("A posição de " + chave + " é " + posicao);
 

        // Chave fora da lista a ser buscada
        chave = 50;
 
        // Busca da chave
        posicao = TernarySearch(esquerda, direita, chave, lista);
 
        // Exibir resultado da busca no terminal
        Console.WriteLine("A posição de " + chave + " é " + posicao);
    }
}
