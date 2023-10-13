namespace StringExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "file";
            string text2 = "FILE";

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");

            bool areEqual1 = (text1 == text2);
            bool areEqual2 = text1.Equals(text1, StringComparison.InvariantCultureIgnoreCase);
            bool areEqual3 = string.Equals(text1, text2, StringComparison.InvariantCultureIgnoreCase);

            Console.WriteLine(areEqual1);
            Console.WriteLine(areEqual2);
            Console.WriteLine(areEqual3);

            string result = text1.Substring(1, 2);
            Console.WriteLine(result);


            bool contains = text1.Contains("le" , StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(contains);

        }
    }
}