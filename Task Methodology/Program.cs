namespace Task_Methodology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, -4, 9, -8 };

            string arrayString = FileName.ArrayToString(array);
            int sum = FileName.Sum(array);
            bool hasNegative = FileName.ContainsNegative(array);

            Console.WriteLine(arrayString);
            Console.WriteLine(sum);
            Console.WriteLine(hasNegative);
            

        }
    }
}
