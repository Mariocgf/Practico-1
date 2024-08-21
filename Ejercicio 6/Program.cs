namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VocalCount(getWord());
        }
        public static string getWord()
        {
            string word;
            Console.WriteLine("Ingrese una palabra");
            word = Console.ReadLine();
            return word;
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
