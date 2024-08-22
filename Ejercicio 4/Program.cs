namespace Ejercicio_4
{
    public class Ejercicio_4
    {
        static void Main(string[] args)
        {
            CheckNumberInRange();
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
        public static void CheckNumberInRange()
        {
            int userNumber1, userNumber2, userNumber3, aux;
            userNumber1 = InputNumber();
            userNumber2 = InputNumber();
            userNumber3 = InputNumber();
            if (userNumber1 > userNumber2)
            {
                aux = userNumber1;
                userNumber1 = userNumber2;
                userNumber2 = aux;
            }
            if (userNumber3 < userNumber2 && userNumber3 > userNumber1 )
            {
                Console.WriteLine($"El valor {userNumber3} esta comprendido entre {userNumber1} y {userNumber2}");
            }
        }
    }
}
