namespace Ejercicio_6
{
    public class Ejercicio_6
    {
        static void Main(string[] args)
        {
            VocalCount(getWord());
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

        public static void VocalCount (string userWord)
        {
            char[] vocals = new char[] {'a', 'e', 'i', 'o', 'u'};
            userWord = userWord.ToLower();
            int count = 0;
            for (int i = 0; i < vocals.Length; i++)
            {
                for (int j = 0; j < userWord.Length; j++)
                {
                    if (vocals[i].Equals(userWord[j]) )
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"La palabra {userWord} tiene un total de {count} vocales");
        }
    }
}
