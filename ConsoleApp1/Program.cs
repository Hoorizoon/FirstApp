namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int a;
            //    int b;
            //    try
            //    {
            //        Console.WriteLine("Podaj 1 liczbe: ");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Podaj 2 liczbe: ");
            //        b = Convert.ToInt32(Console.ReadLine());


            //        //Console.WriteLine(a + b);
            //    if (a == b) {
            //        Console.WriteLine("Liczby są równe");
            //    }

            //    else if (b > a) {
            //        Console.WriteLine("b jest wieksze od a");
            //    }

            //    else { 
            //        Console.WriteLine("a jest wieksze od b"); 
            //    }
            //}
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }


            //string a;
            //List<string> lista = new List<string>(); 
            //a = Console.ReadLine();
            //lista.Add(a);
            //lista.Add("slowo1");
            //lista.Add("slowo2");
            //lista.Add("slowo3");

            ////string d = lista.Where(x => x.StartsWith("s")).FirstOrDefault();
            ////Console.WriteLine(d);

            //List<string> lista2 = new List<string>();
            //lista2 = lista.Where(x => x.StartsWith("s")).ToList();
            //foreach (string s in lista2)
            //{
            //    Console.WriteLine(s);
            //}

            //foreach (var x in a) { Console.WriteLine(x); }

            while (true)
            {
                Console.WriteLine("----Kalkulator----");
                Console.WriteLine("1.dodawanie");
                Console.WriteLine("2.odejmowanie");
                Console.WriteLine("3.mnozenie");
                Console.WriteLine("4.dzielenie");
                Console.WriteLine("5.pierwiastek");
                Console.WriteLine("6.potega");
                Console.WriteLine("7.odwrocenie");

                long x, y;

                int wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 1:
                        Console.WriteLine("Podaj liczbe 1");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(dodawanie(x, y));
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Podaj liczbe 1");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(odejmowanie(x, y));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Podaj liczbe 1");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(mnozenie(x, y));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Podaj liczbe 1");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(dzielenie(x, y));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Podaj liczbe 1");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(pierwiastek(x, y));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Podaj liczbe 1");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Podaj liczbe 2");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(potega(x, y));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Podaj liczbe 1");
                        string a = Console.ReadLine();
                        Console.WriteLine(o(a));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            static long dodawanie(long x, long y)
            {
                return x + y;
            }
            static long odejmowanie(long x, long y)
            {
                return x - y;
            }
            static long mnozenie(long x, long y)
            {
                return x * y;
            }
            static float dzielenie(float x, float y)
            {
                if (y == 0)
                {
                    Console.WriteLine("Liczba 2 musi byc wieksza od zera!");
                    return 0;
                }
                return x / y;
            }
            static double pierwiastek(double x, double y)
            {
                return Math.Pow(x, (1 / y));
            }
            static double potega(double x, double y)
            {
                return Math.Pow(x, y);
            }
            static string o(string x)
            {
                char[] chars = x.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }

        }
    }
}