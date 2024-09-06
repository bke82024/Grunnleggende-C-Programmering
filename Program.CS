namespace Oppgave_uke_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int randomNumber = 10;
            Console.WriteLine(randomNumber);
            string randomText = ("Send help");
            Console.WriteLine(randomText);
            double randomDecimal = 12.5;
            Console.WriteLine(randomDecimal);
            char randomChar = 'A';
            Console.WriteLine(randomChar);
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < intArray.Count(); i++)
            {
                Console.WriteLine(intArray[i]);
            }
            string[] stringArray = { "Hello", "From", "A", "C#", "Array!" };
            foreach (string myStrings in stringArray)
            {
                Console.WriteLine(myStrings);
            }
            List<string> myList = new List<string>();

            myList.Add("Hello");
            myList.Add("From");
            myList.Add("A");
            myList.Add("C#");
            myList.Add("List");
            foreach (string strings in myList)
            {
                Console.WriteLine(strings);
            }


        }
    }
}

