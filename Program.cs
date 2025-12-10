
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
            menupontok.Add("Pitagorasz tétel");
            menupontok.Add("Általános háromszög");
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
                case "Pitagorasz tétel":
                    Pitagorasz();
                    break;
                case "Általános háromszög":
                    AltalanosHaromszog();
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

        // todo Roli feladata
        private static void Pitagorasz()
        {
            Console.WriteLine("Add meg az első oldalt! ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a második oldalt! ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"A harmadik oldal hossza: {c}");
        }

        private static void Terulet()
        {
            Console.WriteLine("Add meg a háromszög alapjához tartozó magasságát! ");
            double magassag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a háromszög alapját! ");
            double alap = Convert.ToDouble(Console.ReadLine());
        }

        // todo Petra feladata
        private static void Kerulet()
        {
            Console.WriteLine("Add meg az első oldalt! ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a második oldalt! ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a harmadik oldalt! ");
            double c = Convert.ToDouble(Console.ReadLine());
            double kerulet = a + b + c;
            Console.WriteLine($"A háromszög kerülete: {kerulet}");
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
