namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseWord2(getWord());
        }
        public static string getWord()
        {
            string word;
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            do
            {
                try
                {
                    Console.WriteLine("Ingrese una palabra");
                    word = Console.ReadLine();
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (word.Contains(numbers[i]))
                        {
                            throw new Exception();
                        }
                    }
                    return word;
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor ingresado incorrecto, la palabra no puede contener numeros");
                }
            }
            while (true);
        }

        //Solucion 1
        public static void ReverseWord(string userWord)
        {
            string newWord = "";
            for (int i = userWord.Length - 1; i >= 0; i--)
            {
                newWord += userWord[i];
            }
            Console.WriteLine(newWord);
        }

        //Solucion 2
        public static void ReverseWord2(string userWord)
        {
            char[] charsWord = userWord.ToCharArray();
            Array.Reverse(charsWord);
            Console.WriteLine(new string(charsWord));
        }
    }
}
