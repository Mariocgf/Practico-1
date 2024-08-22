namespace Ejercicio_2
{
    public class Ejercicio_2
    {
        static void Main(string[] args)
        {
            GenerateTable();
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
        public static void GenerateTable()
        {
            int userNumber;
            bool aux = false;
            do
            {
                userNumber = InputNumber();
                if (userNumber == 0)
                {
                    aux = true;
                }
                else
                {
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");
                    }

                }
            }
            while (!aux);
        }
    }
}
