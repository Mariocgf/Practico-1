namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(getWord());
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
        public static void IsPalindrome(string userWord)
        {
            bool isPalindrome;
            if (userWord.Length % 2 == 0)
            {
                Console.WriteLine("La palabra no es palindormo");
            }
            else 
            {
                isPalindrome = true;
                for (int i = 0; i < Math.Floor((decimal)userWord.Length/2); i++)
                {
                    if (!userWord[i].Equals(userWord[userWord.Length-1-i]))
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome)
                {
                    Console.WriteLine($"La palabra {userWord} es palíndromo");
                }
                else
                {
                    Console.WriteLine($"La palabra {userWord} no es palíndromo");
                }
            }
        }
    }

}
