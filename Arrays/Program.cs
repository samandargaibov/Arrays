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

            #region Task8
            ////Iki qat artirilmish tek elementleri tapin
            //Console.Write("Massivin uzunlugunu qeyd edin: ");

            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Reqemleri [{i}] daxil edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int count = 0;
            //int temp = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (Math.Sqrt(arr[i]) % 1 == 0 && temp % 2 == 0 && arr[i] % 2 == 1)
            //    {
            //        Console.WriteLine("Tek elementler: " + arr[i]);
            //        count++;
            //    }
            //    temp++;
            //}
            //Console.WriteLine("Ikiqat artirilmish tek ededlerin sayi: " + count);
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

            #region Task20
            ////Ededi silsile olub olmamagini yoxlamaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int tmp = arr[1] - arr[0];
            //bool edediSilsile = true;

            //for (int i = 1; i < arr.Length-1; i++)
            //{
            //    if (tmp != arr[i + 1] - arr[i])
            //    {
            //        Console.WriteLine("Ededi silsile deyil.");
            //        edediSilsile = false;
            //        break;
            //    }
            //    Console.WriteLine(arr[i]);
            //}
            //if (edediSilsile)
            //{
            //    Console.WriteLine("Ededi silsiledir.");
            //}
            #endregion

            #region Task21
            ////Hendesi silsile olub olmamasini yoxlamaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int tmp = arr[1] / arr[0];
            //bool hendesiSilsile = true;

            //for (int i = 1; i < arr.Length-1; i++)
            //{
            //    if (tmp != arr[i + 1] / arr[i])
            //    {
            //        Console.WriteLine("Hendesi silsile deyil!");
            //        hendesiSilsile = false;
            //        break;
            //    }
            //}
            //if (hendesiSilsile)
            //    Console.WriteLine("Hendesi silsiledir!");
            #endregion

            #region Task24
            ////x elementinin tekrarlanma sayini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Yoxlanilan ededi daxil edin: ");
            //int x = int.Parse(Console.ReadLine());
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (x == arr[i])
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Ededin tekrarlanma sayi: {count}");
            #endregion

            #region Task25
            ////Massivin maksimal ve minimal elementlerin yerlerinin deyishdirilmesini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int min = 0;
            //int max = 0;
            //int a = 0;
            //int b = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] <= arr[min])
            //    {
            //        min = i;
            //        a = arr[min];
            //    }
            //    if (arr[i] > arr[max])
            //    {
            //        max = i;
            //        b= arr[max];
            //    }
            //}

            //arr[max] = a;
            //arr[min] = b;

            //foreach (var item in arr)
            //{
            //    Console.WriteLine("Yerler deyishdikden sonra massiv: " + item);
            //}
            #endregion

            #region Task26
            ////Musbet,menfi, sifira beraber olan reqemlerin sayini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int count = 0;
            //int countMinus = 0;
            //int countZero = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        count++;
            //    }
            //    if (arr[i] < 0)
            //    {
            //        countMinus++;
            //    }
            //    if (arr[i] == 0)
            //    {
            //        countZero++;
            //    }
            //}
            //Console.WriteLine("Musbet olan reqemlerin sayi: " + count + "\nMenfi olan reqemlerin sayi: " + countMinus + "\nSifira beraber olan reqemlerin sayi: " + countZero);
            #endregion

            #region Task27
            /////Ededi ortasinin maximal ferqini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;
            //int count = 0;
            //int min = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < arr[min])
            //    {
            //        min = i;
            //    }
            //    sum += arr[i];
            //    count++;
            //}

            //int avg = sum / count;
            //int maxFerq = avg - arr[min];

            //Console.WriteLine("Ededi ortasi: " + avg + " Maksimal ferqi: " + maxFerq);
            #endregion

            #region Task29
            ////birinci elementi ile sonuncu minimal elementin yerinin deyishdirilmesini tapmaq.
            //Console.Write("Massivin uzunlugunu qeyd edin: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Elementleri [{i}] qeyd edin: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int min = 0;
            //int tmp1 = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] <= arr[min])
            //    {
            //        min = i;
            //        arr[0] = arr[min];
            //    }
            //}

            //arr[min]= tmp1;

            //foreach (var item in arr)
            //{
            //    Console.WriteLine("Yerler deyishdikden sonra massiv: " + item);
            //}
            #endregion


        }
    }
}