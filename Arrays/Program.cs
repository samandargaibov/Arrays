namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            ////elementlerin cemi ve sayini tapmaq.
            Console.Write("Massivin uzunlugunu qeyd edin: ");

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Reqemi daxil edin: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            int sum = 0;

            foreach (var item in arr)
            {
                if (item < 0)
                {
                    count++;
                    Console.WriteLine(item);
                    sum += item;
                }
            }
            Console.WriteLine("Menfi reqemlerin sayi: " + count + "\nMenfi elementlerin cemi: " + sum);
            #endregion


        }
    }
}