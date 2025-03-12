using System;

class Program {
    static bool fibonacci_detector(int num) {
        int a = 0;
        int b = 1;
        while (b < num) {
            int temp = b;
            b = a + b;
            a = temp;
        }
        return b == num || a == num;
    }

    static void Main(string[] args){
        Console.WriteLine("Digite o número a ser verificado:");
        int num_input = int.Parse(Console.ReadLine());

        if (fibonacci_detector(num_input)){
            Console.WriteLine($"O número {num_input} pertence à sequência de Fibonacci");
        }
        else {
            Console.WriteLine($"O número {num_input} não pertence à sequência de Fibonacci");
        }
    }
}
