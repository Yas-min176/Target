using System;

class Program
{
    // Função para inverter a string
    static string Inverter_string(string texto)
    {
        string invertida = "";
        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertida += texto[i];
        }
        return invertida;
    }

    static void Main(string[] args)
    {
        // Definir o texto a ser invertido
        Console.WriteLine("Digite o texto a ser invertido:");
        string texto = Console.ReadLine();

        // Chamar a função para inverter o texto
        string texto_invertido = Inverter_string(texto);
        // Exibir o resultado
        Console.WriteLine($"Texto invertido: {texto_invertido}");
    }
}
