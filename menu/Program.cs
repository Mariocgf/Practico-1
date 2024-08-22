namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.WriteLine("1) Ejercicio 1");
                Console.WriteLine("2) Ejercicio 2");
                Console.WriteLine("3) Ejercicio 3");
                Console.WriteLine("4) Ejercicio 4");
                Console.WriteLine("5) Ejercicio 5");
                Console.WriteLine("6) Ejercicio 6");
                Console.WriteLine("7) Ejercicio 7");
                Console.WriteLine("8) Ejercicio 8");
                switch (Ejercicio_1.Ejercicio_1.InputNumber())
                {
                    case 1:
                        Ejercicio_1.Ejercicio_1.CheckNumber(Ejercicio_1.Ejercicio_1.GenerateRandom());
                        break;
                    case 2:
                        Ejercicio_2.Ejercicio_2.GenerateTable();
                        break;
                    case 3:
                        Ejercicio_3.Ejercicio_3.ShowPairs();
                        break;
                    case 4:
                        Ejercicio_4.Ejercicio_4.CheckNumberInRange();
                        break;
                    case 5:
                        Ejercicio_5.Ejercicio_5.SumNumbers();
                        break;
                    case 6:
                        Ejercicio_6.Ejercicio_6.VocalCount(Ejercicio_6.Ejercicio_6.getWord());
                        break;
                    case 7:
                        Ejercicio_7.Ejercicio_7.ReverseWord2(Ejercicio_7.Ejercicio_7.getWord());
                        break;
                    case 8:
                        Ejercicio_8.Ejercicio_8.IsPalindrome(Ejercicio_8.Ejercicio_8.getWord());
                        break;
                    default:
                        exit = true;
                        break;
                }
            }
            while (!exit);
        }
    }
}
