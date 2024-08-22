namespace Ejercicio_3
{
    public class Ejercicio_3
    {
        static void Main(string[] args)
        {
            ShowPairs();
        }
        public static int InputNumber()
        {
            int number;

            do
            {
                try
                {
                    Console.WriteLine("Ingrese un numero, ó 0 para salir.");
                    number = int.Parse(Console.ReadLine());
                    return number;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor incorrecto, debe ingresar un numero");
                }
            }
            while (true);
        }
        public static void ShowPairs()
        {
            int userNumber1, userNumber2; //No se si esta permitido usar esto en C#
            bool aux1 = false, aux2 = false;
            do
            {
                Console.WriteLine("Ingrese el primer numero");
                userNumber1 = int.Parse(Console.ReadLine());
                if (userNumber1 == 0)
                {
                    aux1 = true;
                }
                else
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("Ingrese el segundo numero");
                            userNumber2 = int.Parse(Console.ReadLine());
                            if (userNumber1 > userNumber2)
                            {
                                throw new Exception();
                            }
                            else
                            {
                                for (int i = userNumber1 + 1, j = userNumber2; i < j; i++)
                                {
                                    if (i%2 == 0)
                                    {
                                        Console.WriteLine(i);
                                    }
                                }
                                aux2 = true;

                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("El segundo numero no puede ser mayor al primero");
                        }
                    } while (!aux2);
                }
            }
            while (!aux1);
        }
    }
}
