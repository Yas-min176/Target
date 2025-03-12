using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir os valores de faturamento e os estados
        double[] valores = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };
        string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };

        // Inicializar a variável para o total
        double total = 0;

        // Calcular o total de faturamento
        foreach (double valor in valores)
        {
            total += valor;
        }

        // Calcular o percentual de cada estado e imprimir
        for (int i = 0; i < valores.Length; i++)
        {
            double percentual = (valores[i] / total) * 100;
            Console.WriteLine($"Estado: {estados[i]} - Percentual: {percentual:F2}%");
        }
    }
}