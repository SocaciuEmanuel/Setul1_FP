internal class Program
{
    private static void Main(string[] args)
    {
        //P1();
        //P2();
        //P3();
        //P4();
        //P5();
        //P6();
        //P7();
        //P8();
        //P9();
        //P10();
        //P11();
        //P12();
        //P13();
        //P14();
        //P15();
        //P16(); 
        //P17();
        //P18();
        //P19();
        P20();
        //P21(); 
        Console.ReadKey();
    }

    private static void P21()
    {
        Console.WriteLine("Voi incerca sa ghicesc un numar intre 1 si 1024. Ganditi-va la un numar.");
        Console.WriteLine("Raspundeti cu da sau nu.");

        int stanga = 1;
        int dreapta = 1024;

        while (stanga <= dreapta)
        {
            int ghicire = (stanga + dreapta) / 2;
            Console.WriteLine($"Numarul este mai mare sau egal decat {ghicire}? (da/nu)");

            string input = Console.ReadLine().ToLower();

            if (input == "da")
            {
                stanga = ghicire + 1;
            }
            else if (input == "nu")
            {
                dreapta = ghicire - 1;
            }
            else
            {
                Console.WriteLine("Raspuns incorect. Te rog sa raspunzi cu 'da' sau 'nu'.");
                continue;
            }

            if (stanga > dreapta)
            {
                Console.WriteLine("S-ar putea sa fie o problema cu raspunsurile tale.");
                break;
            }
        }

        Console.WriteLine($"Numarul la care te-ai gandit este {(stanga + dreapta) / 2}.");
    }

    private static void P19()
    {
        int n, cifra1 = 0, cifra2 = 0;
        Console.Write("Dati un numar natural n: ");
        n = int.Parse(Console.ReadLine());

        int m = n;
        while (m != 0)
        {
            cifra1 = m % 10;
            m /= 10;
            if (cifra1 != m % 10) cifra2 = m % 10;
            break;
        }

        int p = n, contor = 0;
        while (p != 0)
        {
            if ((p % 10 != cifra1) && (p % 10 != cifra2))
            {
                contor++;
                break;
            }
            p /= 10;
        }

        if (contor > 0) Console.WriteLine("Numarul nu este format doar din 2 cifre care se repeta.");
        else Console.WriteLine("Numarul este format doar din 2 cifre care se repeta.");
    }

    private static void P18()
    {
        Console.Write("Dati un nr natural: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"{n} = ");
        DescompunereInFactoriPrimi(n);

        static void DescompunereInFactoriPrimi(int n)
        {
            int x = 0;

            while (n % 2 == 0)
            {
                x++;
                n /= 2;
            }
            if (x > 0) Console.Write($"2^{x} x ");

            for (int i = 3; i * i <= n; i += 2)
            {
                x = 0;
                while (n % i == 0)
                {
                    x++;
                    n /= i;
                }
                if (x > 0) Console.Write($"{i}^{x} x ");
            }

            if (n > 1)
            {
                Console.Write($"{n}");
                if (n != 1) Console.Write($"^1");
            }
        }
    }

    private static void P17()
    {
        int a, b;
        Console.WriteLine("Dati 2 nr: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Cel mai mare divizor comun este: {cmmdc(a, b)}");
        Console.WriteLine($"Cel mai mic multiplu comun este: {cmmmc(a, b)}");

        static int cmmdc(int a, int b)
        {
            if (a == b) return a;
            while (a != b)
            {
                if (a < b) b = b - a;
                else a = a - b;
            }
            return a;
        }

        static int cmmmc(int a, int b)
        {
            int n = a, m = b;

            if (a == b) return a;
            while (n != m)
            {
                if (n < m) n = n + a;
                else m = m + b;
            }
            return m;
        }   
    }

    private static void P16()
    {
        Console.WriteLine("Introduceti 5 numere:");
        int numar1 = int.Parse(Console.ReadLine());
        int numar2 = int.Parse(Console.ReadLine());
        int numar3 = int.Parse(Console.ReadLine());
        int numar4 = int.Parse(Console.ReadLine());
        int numar5 = int.Parse(Console.ReadLine());

        Sortare(ref numar1, ref numar2);
        Sortare(ref numar1, ref numar3);
        Sortare(ref numar1, ref numar4);
        Sortare(ref numar1, ref numar5);

        Sortare(ref numar2, ref numar3);
        Sortare(ref numar2, ref numar4);
        Sortare(ref numar2, ref numar5);

        Sortare(ref numar3, ref numar4);
        Sortare(ref numar3, ref numar5);

        Sortare(ref numar4, ref numar5);

        Console.WriteLine($"Numerele in ordine crescatoare sunt: {numar1}, {numar2}, {numar3}, {numar4}, {numar5}");

        static void Sortare(ref int a, ref int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }
    }

    private static void P15()
    {

        Console.WriteLine("Introduceti 3 numere:");
        int numar1 = int.Parse(Console.ReadLine());
        int numar2 = int.Parse(Console.ReadLine());
        int numar3 = int.Parse(Console.ReadLine());

        Sortare(ref numar1, ref numar2);
        Sortare(ref numar1, ref numar3);

        Sortare(ref numar2, ref numar3);

        Console.WriteLine($"Numerele in ordine crescatoare sunt: {numar1}, {numar2}, {numar3}.");

        static void Sortare(ref int a, ref int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }
    }

    private static void P14()
    {
        int n, inversul = 0;
        Console.Write("Dati un nr n: ");
        n = int.Parse(Console.ReadLine());

        int m = n;
        while (m != 0)
        {
            inversul = inversul * 10 + m % 10;
            m /= 10;
        }

        if (n == inversul) Console.WriteLine($"Numarul {n} este palindrom");
        else Console.WriteLine($"Numarul {n} nu este palindrom");
    }

    private static void P13()
    {
        int y1, y2, anBisect = 0; ;
        Console.WriteLine("Dati doua nr care sa reprezinte un interval de ani: ");
        y1 = int.Parse(Console.ReadLine());
        y2 = int.Parse(Console.ReadLine());

        for (int i = y1; i <= y2; i++)
        {
            if (i % 4 == 0 || i % 100 == 0 && i % 400 != 0) anBisect++;
        }
        Console.WriteLine($"Sunt {anBisect} ani bisecti in intervalul dat.");
    }

    private static void P12()
    {
        int n, a, b, nrIntregiDivizibile = 0;
        Console.WriteLine("Dati 2 nr care sa reprezinte un interval: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        Console.Write("Cu ce numar doriti ca numerele din interval sa fie divizibile? ");
        n = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            if (i % n == 0) nrIntregiDivizibile++;
        }

        Console.WriteLine($"Sunt {nrIntregiDivizibile} numere divizibile cu {n} in intervalul [{a}, {b}]");
    }

    private static void P11()
    {
        int n, m = 0;
        Console.Write("Dati un nr n: ");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            m = m * 10 + n % 10;
            n /= 10;
        }

        Console.WriteLine($"Nr n inversat este: {m}");
    }

    private static void P10()
    {
        int n, divizor = 0;
        Console.Write("Dati un nr n: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("Nr n nu este numar prim.");
                divizor++;
                break;
            }
        }

        if (divizor == 0) Console.WriteLine("Nr n este un numar prim.");
    }

    private static void P9()
    {
        int n, div = 0;
        Console.Write("Dati un numar n: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) div++;
        }

        Console.WriteLine($"Numar {n} are {div} divizori");
    }

    private static void P8()
    {
        int a, b;
        Console.WriteLine("Dati 2 nr:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"Numerele inversate sunt a = {a} si b = {b}");
    }

    private static void P7()
    {
        int a, b, c;
        Console.WriteLine("Dati doua numere a si b:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("Vom inversa valorile lui a si b");
        c = a;
        a = b;
        b = a;
        Console.WriteLine($"Valorile actualizate sunt: a = {a} si b = {b}");
    }

    private static void P6()
    {
        int a, b, c;
        Console.WriteLine("Dati 3 numere pozitive: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        if ((a + b > c) && (a + c > b) && (b + c > a))
        {
            Console.WriteLine($"Cu lungimile laturilor {a}, {b}, {c} se poate forma un triunghi.");
        }
        else Console.WriteLine($"Nu putem forma un triunghiu cu valorile {a}, {b} si {c}");
    }

    private static void P5()
    {
        int n, cifraK;
        Console.Write("Dati un numar: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("A cata cifra doriti sa fie afisata? ");
        int k = int.Parse(Console.ReadLine());
        int k2 = k;

        while (k != 1)
        {
            n /= 10;
            k--;
        }
        cifraK = n % 10;

        Console.WriteLine($"A {k2}-a cifra este {cifraK}");
    }

    private static void P4()
    {
        int y = int.Parse(Console.ReadLine());
        if (y % 4 == 0 || y % 100 == 0 && y % 400 != 0)
            Console.WriteLine($"Anul {y} e un an bisect");
        else Console.WriteLine($"Anul {y} nu e un an bisect");
    }

    private static void P3()
    {
        int n, k;
        Console.WriteLine("Dati 2 numere: ");
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());

        if (n % k == 0) Console.WriteLine("n se divide cu k");
        else Console.WriteLine("n nu se divide cu k");
    }

    private static void P2()
    {
        float a, b, c, delta;
        double x1, x2;

        Console.WriteLine("Dati 3 numere a, b si c: ");
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        c = float.Parse(Console.ReadLine());

        delta = b * b - 4 * a * c;
        x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
        x2 = ((-b - Math.Sqrt(delta)) / (2 * a));

        Console.WriteLine($"Solutia ecuatiei este {x1}, {x2}");
    }

    private static void P1()
    {
        float a, b, x;
        Console.Write("Dati un nr a: ");
        a = float.Parse(Console.ReadLine());
        Console.Write("Dati un nr b: ");
        b = float.Parse(Console.ReadLine());

        x = (-1) * b / a;

        Console.WriteLine(x);
    }
}