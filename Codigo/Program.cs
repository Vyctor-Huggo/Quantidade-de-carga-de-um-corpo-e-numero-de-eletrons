using System;

namespace Codigo
{
    class Program
    {
        public static Char[] delimitadores = { '.', 'x', 'e', '^' };
        static void Main()
        {
            Console.WriteLine("[1] Para calcular a [Quantidade de carga do matérial] (Q = n.e)");
            Console.WriteLine("[2] Para calcular o [Número de Elétrons transferidos] (n = Q/e)");
            Console.Write("O que você deseja: "); 
            int X = Convert.ToInt32(Console.ReadLine());
            switch (X)
            {
                case 1:
                    try
                    {
                        Console.Write("Qual é o valor de N: ");
                        var CompN = Console.ReadLine().Split(delimitadores);
                        Double N = double.Parse(CompN[0]);
                        int baseN = int.Parse(CompN[1]);
                        int ExpoN = int.Parse(CompN[2]);  
                        
                        while(N >= 10)
                        {
                            N = N/10;
                            ExpoN++;
                        }      

                        double x = N*1.6;
                        int y = ExpoN + (-19);
                        soluction(x, y, baseN, N, ExpoN, "case1");
                    } 
                    catch
                    {
                        Console.Write("Error:Valor não aceito analise o número e tente novamente");
                        Main();
                    }
                    break;

                case 2:
                    try
                    {
                        Console.Write("Qual é o valor de Q: ");
                        var CompQ = Console.ReadLine().Split(delimitadores);
                        Double Q = double.Parse(CompQ[0]);
                        int baseQ = int.Parse(CompQ[1]);
                        int ExpoQ = int.Parse(CompQ[2]);

                        while(Q >= 10)
                        {
                            Q = Q/10;
                            ExpoQ++;
                        }

                        double x1 = Q/1.6;
                        int y1 = ExpoQ -(-19);
                        soluction(x1, y1, baseQ, Q, ExpoQ, "case2");
                    } 
                    catch
                    {
                        Console.Write("Error:Valor não aceito analise o número e tente novamente.");
                        Main();
                    }
                    break;

                default:
                    Console.WriteLine("|----------------|\n" + "|Número inválido!|\n" + "|----------------|");
                    Main();
                    break;
            }
        }
        static void soluction(double a, int b, int c, double d, int e, string name)
        {
            if(name == "case1")
            {
                Console.WriteLine("O corpo ganha(-) ou perde(+) elétrons?");
                string G = Console.ReadLine();
                G = G.ToUpper();

                switch(G)
                {
                    case "GANHA":
                        Console.WriteLine("\n");
                        Console.WriteLine($"Q = {d}.{c}^{e}.1,6.10^-19");
                        Console.WriteLine($"Q = {d}.1,6.{c}^{e}.10^-19");
                        Console.WriteLine($"Q =  {-a:f2}.{c}^{b} C");
                        break;

                    case "G":
                        Console.WriteLine("\n");
                        Console.WriteLine($"Q = {d}.{c}^{e}.1,6.10^-19");
                        Console.WriteLine($"Q = {d}.1,6.{c}^{e}.10^-19");
                        Console.WriteLine($"Q =  {-a:f2}.{c}^{b} C");
                        break;

                    case "PERDE":
                        Console.WriteLine("\n");
                        Console.WriteLine($"Q = {d}.{c}^{e}.1,6.10^-19");
                        Console.WriteLine($"Q = {d}.1,6.{c}^{e}.10^-19");
                        Console.WriteLine($"Q =  {a:f2}.{c}^{b} C");
                        break;

                    case "P":
                        Console.WriteLine("\n");
                        Console.WriteLine($"Q = {d}.{c}^{e}.1,6.10^-19");
                        Console.WriteLine($"Q = {d}.1,6.{c}^{e}.10^-19");
                        Console.WriteLine($"Q =  {a:f2}.{c}^{b} C");
                        break;
                }
            }
            if(name == "case2")
            {
                Console.WriteLine("\n");
                Console.WriteLine($"N = {d}.{c}^{e}/1,6.10^-19");
                Console.WriteLine($"N = {d}/1,6.{c}^{e}/10^-19");

                if(a < 0)
                {
                    Console.WriteLine($"N = {-1*a:f2}.{c}^{b} C" + "Ganha");
                }
                else
                {
                    Console.Write($"N = {a:f2}.{c}^{b} C" + " (Perde)");
                }
            }
        }
    }
}
