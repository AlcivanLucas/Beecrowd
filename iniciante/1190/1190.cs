using System;

class URI {
    static void Main(string[] args) {
        string O = Console.ReadLine().Trim();

        int contador = 0;
        double soma = 0.0;
        for(int i = 0; i < 12; ++i){
            for(int j = 0; j < 12; ++j){
                double numero = double.Parse(Console.ReadLine().Trim());

                if((i < 6 && j > 11 - i) || (i > 5 && j > i)){
                    soma += numero;
                    ++contador;
                }
            }
        }

        Console.WriteLine($"{(O == "S" ? soma : soma/contador):0.0}");
    }
}