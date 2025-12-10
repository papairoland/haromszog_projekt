
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdvozloKep();
            Pitagorasz();
            Terulet();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Kilépés");
            ListazMenu(menupontok);
            Console.WriteLine("Vége!");
        }

        private static void ListazMenu(List<string> menupontok)
        {
            //Petra feladata
            Console.WriteLine("ide jött!");
            //throw new NotImplementedException("Még nincs kész, ezért ne használd!");
            Console.WriteLine("ide már jut el!");
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
            double magassag =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg a háromszög alapját! ");
            double alap=Convert.ToDouble(Console.ReadLine());
        }
    }
}
