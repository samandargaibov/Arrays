namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            ////elementlerin cemi ve sayini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");

            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Reqemi daxil edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int count = 0;
            //int sum = 0;

            //foreach (var item in arr)
            //{
            //    if (item < 0)
            //    {
            //        count++;
            //        Console.WriteLine(item);
            //        sum += item;
            //    }
            //}
            //Console.WriteLine("Menfi reqemlerin sayi: " + count + "\nMenfi elementlerin cemi: " + sum);
            #endregion

            #region Task2
            ////5e bolunen ve 7-e bolunmeyenlerin cemi ve sayi.
            //Console.Write("Massivin uzunlugunu daxil edin: ");

            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Reqemleri daxil edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //int count = 0;

            //foreach (var item in arr)
            //{
            //    if (item % 5 == 0 && item % 7 != 0)
            //    {
            //        count++;
            //        sum += item;
            //        Console.WriteLine($"5-e bolunenler: {item}");
            //    }
            //}
            //Console.WriteLine("5-e bolunen ve 7-ye bolunmeyen elementlerin cemi: " + sum + "\nSayi: " + count);
            #endregion

            #region Task3
            ////musbet ve tek olan elementlerin cemi ve sayi
            //Console.Write("Massivin uzunlugunu daxil edin: ");

            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Reqemleri daxil edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int count = 0;
            //int sum = 0;

            //foreach (var item in arr)
            //{
            //    if (item > 0 && item % 2 != 0)
            //    {
            //        count++;
            //        sum += item;
            //        Console.WriteLine("Musbet ve tek olan elementler: " + item);
            //    }
            //}
            //Console.WriteLine("Musbet ve tek olan reqemlerin cemi: " + sum + "\nSayi: " + count);
            #endregion

            #region Task4
            ////cut yerde duran elementlerin cemi ve sayi
            //Console.Write("Massivin uzunlugunu daxil edin: ");

            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Reqemleri daxil edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int count = 0;
            //int sum = 0;
            //int temp = 0;

            //foreach (var item in arr)
            //{
            //    if (temp % 2 == 1 && item % 2 == 0)
            //    {
            //        count++;
            //        sum += item;
            //        Console.WriteLine("Sherti odeyen reqemler: " + item);
            //    }
            //    temp++;
            //}
            //Console.WriteLine("Cemi: " + sum + "\nSayi: " + count);
            #endregion

            #region Task5
            ////tek yerde olan cut elementlerin cemi ve sayi.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Reqemleri qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //int count = 0;
            //int temp = 0;

            //foreach (var item in arr)
            //{
            //    if (item % 2 == 0 && temp % 2 == 0)
            //    {
            //        count++;
            //        sum += item;
            //        Console.WriteLine("Sherti odeyen reqemler: " + item);
            //    }
            //    temp++;
            //}
            //Console.WriteLine($"Tek yerde duran reqemlerin cemi: {sum}\nSayi: {count}");
            #endregion

            #region Task6
            ////Cut yerlerde olan tek elementlerin cemi ve sayi.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Reqemleri daxil edin: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //int count = 0;
            //int temp = 0;

            //foreach (var item in arr)
            //{
            //    if (item % 2 != 0 && temp % 2 == 1)
            //    {
            //        count++;
            //        sum += item;
            //        Console.WriteLine($"Sherti odeyen reqemler: {item}");
            //    }
            //    temp++;
            //}
            //Console.WriteLine($"Reqemlerin cemi: {sum}\nReqemlerin sayi: {count}");
            #endregion

            #region Task7
            ////7-ye bolende qaligi  1,2,5 olan reqemlerin sayi.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");

            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Reqemleri daxil edin: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //////static array
            ///////int[] arr = { 10, 12, 15, 19, 21, 30, 37, 40 };

            //int count = 0;

            //foreach (var item in arr)
            //{
            //    if (item % 7 == 1 || item % 7 == 2 || item % 7 == 5)
            //    {
            //        count++;
            //        Console.WriteLine("Qaliqla bolunen reqemler: " + item);
            //    }
            //}

            //Console.WriteLine($"\nElementlerin toplam sayi: {count}");
            #endregion

            #region Task9
            ////birinci maximal elementin nomresini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");

            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Reqemleri daxil edin: ");
            //    arr[i]=int.Parse(Console.ReadLine());
            //}

            //int maxIndex = 0;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > arr[maxIndex])
            //    {
            //        maxIndex = i;
            //    }
            //}

            //Console.WriteLine("\nEn boyuk element: " + arr[maxIndex] + "\nElementin indexi: " + maxIndex);
            #endregion

            #region Task10
            ////Axirinci minimal elementi tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Reqemleri [{i}] daxil edin: ");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int minIndex = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] <= arr[minIndex])
            //    {
            //        minIndex = i;
            //    }
            //}
            //Console.WriteLine("Minimal element: " + arr[minIndex] + "\nIndex sayi: " + minIndex);
            #endregion

            #region Task15
            ////birinci menfi elementi tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i]=int.Parse(Console.ReadLine());
            //}

            //int minus = 0;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < arr[minus])
            //    {
            //        minus = i;
            //    }
            //}
            //Console.WriteLine("Menfi elementin nomresi: " + minus);
            #endregion

            #region Task16
            ////Axirinci musbet elementin nomresini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int musbet = 0;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] >= arr[musbet])
            //    {
            //        musbet = i;
            //    }
            //}
            //Console.WriteLine("Axirinci musbet elementin nomresi: " + musbet);
            #endregion

            #region Task17
            ////Axirinci menfi elementin nomresini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int minus = 0;

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] <= arr[minus])
            //    {
            //        minus = i;
            //    }
            //}
            //Console.WriteLine("Axirinci Menfi elementin nomresi: " + minus);
            #endregion

            #region Task19
            ////ededlerin ortalamasini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int avg = 0;
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    avg = avg + arr[i];
            //    count++;
            //}
            //avg = avg / count;
            //Console.WriteLine("\nEdedlerin ortalamasi: " + avg);
            #endregion
        }
    }
}