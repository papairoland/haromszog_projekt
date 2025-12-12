
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdvozloKep();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Pitagorasz tétel (derékszögű háromszög)");
            menupontok.Add("Általános háromszög");
            menupontok.Add("Háromszög típus meghatározás");
            menupontok.Add("Háromszögbe írható kör sugara (r)");
            menupontok.Add("Kilépés");
            ListazMenu(menupontok);
            Console.WriteLine("Vége!");
        }



        // todo Petra feladata
        private static void ListazMenu(List<string> menupontok)
        {
            Console.WriteLine("Válassz a menüpontok közül!");
            for (int i = 0; i < menupontok.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menupontok[i]}");
            }

            int MegadottValasz = 0;
            bool Szam = false;


            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.D1)
                {
                    MegadottValasz = 0;
                    Szam = true;
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    MegadottValasz = 1;
                    Szam = true;
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    MegadottValasz = 2;
                    Szam = true;
                }
                else if (key.Key == ConsoleKey.D4)
                {
                    MegadottValasz = 3;
                    Szam = true;
                }
                else if (key.Key == ConsoleKey.D5)
                {
                    MegadottValasz = 4;
                    Szam = true;
                }
                else if (key.Key == ConsoleKey.D6)
                {
                    MegadottValasz = 5;
                    Szam = true;
                }
                else if (key.Key == ConsoleKey.D7)
                {
                    MegadottValasz = 6;
                    Szam = true;
                }
            }
            while (!Szam);


            switch (menupontok[MegadottValasz])
            {
                case "Kerület számítása":
                    Kerulet();
                    break;
                case "Terület számítása":
                    Terulet();
                    break;
                case "Pitagorasz tétel (derékszögű háromszög)":
                    Pitagorasz();
                    break;
                case "Általános háromszög":
                    AltalanosHaromszog();
                    break;
                case "Háromszög típus meghatározás":
                    TipusMeghatarozas();
                    break;
                case "Háromszögbe írható kör sugara (r)":
                    BeleIrtSugar();
                    break;
                case "Kilépés":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }



        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");
        }

        //todo Roli feladata
        private static void BeleIrtSugar()
        {
            Console.WriteLine("Írd be a háromszög első oldalát! ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Írd be a háromszög második oldalát! ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Írd be a háromszög harmadik oldalát! ");
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) / 2;
            double terulet = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            double r = terulet / s;
            Console.WriteLine($"Beírt kör sugara: {Math.Round(r,2)}");
        }

        // todo Roli feladata
        private static void Pitagorasz()
        {
            Console.WriteLine("Add meg az első oldalt! ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a második oldalt! ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"A harmadik oldal hossza: {Math.Round(c,2)}");
        }

        //todo Roli feladata
        private static void Terulet()
        {
            Console.WriteLine("Add meg a háromszög alapjához tartozó magasságát! ");
            double magassag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a háromszög alapját! ");
            double alap = Convert.ToDouble(Console.ReadLine());
            double terulet = (alap * magassag) / 2;
            Console.WriteLine($"A háromszög területe: {Math.Round(terulet,2)}");
        }

        //todo Roli feladata
        private static void TipusMeghatarozas()
        {
            Console.WriteLine("Írd be a háromszög első oldalát! ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Írd be a háromszög második oldalát! ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Írd be a háromszög harmadik oldalát! ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Egyenlő oldalú háromszög");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Egyenlő szárú háromszög");
                }
                else
                {
                    Console.WriteLine("Általános háromszög");
                }
            }
            else
            {
                Console.WriteLine("A háromszög nem létezik (háromszög-egyenlőtlensége)");
            }
        }

        // todo Petra feladata
        private static void Kerulet()
        {
            Console.WriteLine("Add meg az első oldalt! ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a második oldalt! ");
            double b = Convert.ToDouble(Console.ReadLine());,
            Console.WriteLine("Add meg a harmadik oldalt! ");
            double c = Convert.ToDouble(Console.ReadLine());
            double kerulet = a + b + c;
            Console.WriteLine($"A háromszög kerülete: {Math.Round(kerulet,2)}");
        }

        // todo Petra feladata
        private static void AltalanosHaromszog()
        {
            Console.WriteLine("Add meg az első oldalt! ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a második oldalt! ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a harmadik oldalt! ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a != b || a != c || b != c)
            {
                Console.WriteLine("A háromszög általános háromszög");
            }
            else
            {
                Console.WriteLine("A háromszög nem általános háromszög");
            }

        }
    }
}
