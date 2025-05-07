using System;

public class Program{
    public class NumeroComplexo{
        public int Real { get; set; }
        public int Imaginaria { get; set; }

        public NumeroComplexo(int real, int imaginaria)
        {
            Real = real;
            Imaginaria = imaginaria;
        }

        public void Soma(int real, int imaginaria){
            int parte_real = this.Real + real;
            int parte_imaginaria = this.Imaginaria + imaginaria;

            if(parte_imaginaria>=0){
                Console.WriteLine($"A soma é {parte_real}+{parte_imaginaria}i");
            }
            else{
                Console.WriteLine($"A soma é {parte_real}{parte_imaginaria}i");
            }
        }

        public void Subtracao(int real, int imaginaria){
            int parte_real = this.Real - real;
            int parte_imaginaria = this.Imaginaria - imaginaria;

            if(parte_imaginaria>=0){
                Console.WriteLine($"A soma é {parte_real}+{parte_imaginaria}i");
            }
            else{
                Console.WriteLine($"A soma é {parte_real}{parte_imaginaria}i");
            }
        }
    }
    public static void Main(){
        NumeroComplexo n_1 = new NumeroComplexo(4, 4);
        NumeroComplexo n_2 = new NumeroComplexo(1, 5);
        
        n_1.Soma(n_2.Real, n_2.Imaginaria);
        n_1.Subtracao(n_2.Real, n_2.Imaginaria);
    }
}