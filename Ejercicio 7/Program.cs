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
            Console.WriteLine("Ingrese una palabra");
            word = Console.ReadLine();
            return word;
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
        public static void ReverseWord2 (string userWord)
        {
            char[] charsWord = userWord.ToCharArray();
            Array.Reverse(charsWord);
            Console.WriteLine(new string(charsWord));
        }
    }
}
