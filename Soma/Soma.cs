using System;

class Soma {
    static void Main(string[] args)
    {
        int indice = 13;
        int soma = 0;
        int k = 0;

        while (k < indice) {
            k++;
            soma = soma + k;
        }
        Console.WriteLine("Valor final da soma: " + soma);
    }
}