namespace Ejercicio_5
{
    public class Ejercicio_5
    {
        static void Main(string[] args)
        {
            SumNumbers();
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
        public static void SumNumbers()
        {
            int userNumber, sum = 0;
            bool aux = false;
            do
            {
                userNumber = InputNumber();
                if (userNumber != 0)
                {
                    sum += userNumber;
                    Console.WriteLine($"La suma va: {sum}");
                }
                else
                {
                    aux = true;
                }
            }
            while (!aux);
            Console.WriteLine($"La suma total fue de: {sum}");
        }
    }
}
