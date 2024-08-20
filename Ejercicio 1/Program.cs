namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckNumber(GenerateRandom());
        }
        public static int InputNumber()
        {
            int numero;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese un numero entre 1 y 10, ó 0 para salir");
                    numero = int.Parse(Console.ReadLine());
                    if (numero > 10 || numero < 0)
                    {
                        throw new Exception();
                    }
                    return numero;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor incorrecto, el valor tiene que ser un numero entre 0 y 10");
                }
            }
            while (true);
        }
        public static int GenerateRandom()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10);
        }

        public static void CheckNumber(int randomNumber)
        {
            int userNumber;
            bool isTheSame = false;
            do
            {
                userNumber = InputNumber();
                if (userNumber == 0)
                {
                    isTheSame = true;
                }
                else if (userNumber == randomNumber)
                {
                    Console.WriteLine("El numero ingresado es igual al generado aleatoriamente");
                }
            }
            while (!isTheSame);
        }
    }
}
