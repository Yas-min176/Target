using System;
using System.IO;
using Newtonsoft.Json; // Biblioteca Newtonsoft.Json para trabalhar com JSON

class Program {
    public class Faturamento {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main(string[] args) {
        // Puxar e deserializar o arquivo JSON
        string json_file_path = "../Dados/dados.json";
        string json_string = File.ReadAllText(json_file_path);
        if (!string.IsNullOrEmpty(json_string)) {
            Faturamento[] faturamento_diario = JsonConvert.DeserializeObject<Faturamento[]>(json_string);
            double menor_valor = double.MaxValue;
            double maior_valor = double.MinValue;
            double soma = 0;
            int dias_com_faturamento = 0;

            // Iterar pelos valores e calcular menor, maior e soma (ignorando os zeros)
            foreach (var dia in faturamento_diario) {
                if (dia.valor > 0) {
                    if (dia.valor < menor_valor) menor_valor = dia.valor;
                    if (dia.valor > maior_valor) maior_valor = dia.valor;
                    soma += dia.valor;
                    dias_com_faturamento++;
                }
            }

            // Calcular a média
            double media_mensal = soma / dias_com_faturamento;

            // Contar os dias com faturamento acima da média
            int dias_acima_media = 0;
            foreach (var dia in faturamento_diario) {
                if (dia.valor > media_mensal) {
                    dias_acima_media++;
                }
            }

            Console.WriteLine($"Menor valor de faturamento: R${menor_valor}");
            Console.WriteLine($"Maior valor de faturamento: R${maior_valor}");
            Console.WriteLine($"Número de dias com faturamento acima da média mensal: {dias_acima_media}");
        } 
        else {
            Console.WriteLine("Erro ao ler o arquivo JSON.");
        }
    }
}
