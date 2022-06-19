using System;

namespace DepotConsole
{
    class Program
    {
        static void Main()
        {
            int Pagina = 0;
            while (Pagina != -1)
            {
                switch (Pagina)
                {
                    case 0:
                        Pagina = StartMenuDepot();
                        break;
                    case 1:
                        Pagina = BezoekerMenu();
                        break;
                    case 2:
                        Pagina = GidsMenu();
                        break;
                }
            }
        }
        private static int StartMenuDepot()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Het Depot Boijmans Van Beuningen\n\n[1] Bezoeker\n[2] Gids");

                int invoergebruiker = Convert.ToInt32(Console.ReadLine());
                switch (invoergebruiker)
                {
                    case 1:
                        return 1;
                    case 2:
                        return 2;
                    case 6:
                        Console.WriteLine("Closing the application. See you next time!");
                        return -1;
                    default:
                        Console.WriteLine("Invalid option. Please only enter the number of the option you would like to pick.\nPress 'Enter' to continue.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static int BezoekerMenu()
        {
            while (true)
            {
                LeegPagina();
                Console.WriteLine("Bezoeker");
                Console.WriteLine("[0] om terug te gaan naar het start menu ");

                int invoerbezoeker = Convert.ToInt32(Console.ReadLine());
                switch (invoerbezoeker)
                {
                    case 1:
                        break;
                    case 0:
                        return 0;

                    default:
                        Console.WriteLine("Invalid option. Please only enter the number of the option you would like to pick.\nPress 'Enter' to continue.");
                        Console.ReadLine();
                        break;
                }
            }

        }

        private static int GidsMenu()
        {
            while (true)
            {
                LeegPagina();
                Console.WriteLine("gids menu\n[0] keer terug te keren naar het start menu");
                int invoergids = Convert.ToInt32(Console.ReadLine());

                switch (invoergids)
                {
                    case 1: break;
                    case 0: return 0;

                    default:
                        Console.WriteLine("Invalid option. Please only enter the number of the option you would like to pick.\nPress 'Enter' to continue.");
                        Console.ReadLine();
                        break;
                }

            }
        }
        
        static void LeegPagina()
        {
            Console.Clear();
        }
        
        static int DelenDoor17(int code)
        {
            int answer = code % 17;

            if (answer == 0)
            {
                return 0;
            }
            else
                return answer;
        }
        
        static string GetTijdvak(int tijdOptie)
        {
            string Tijdvak;

            switch (tijdOptie)
            {
                case 1:
                    Tijdvak = "11:00-11:20";
                    break;
                case 2:
                    Tijdvak = "12:00-12:20";
                    break;
                case 3:
                    Tijdvak = "13:00-13:20";
                    break;
                case 4:
                    Tijdvak = "14:00-14:20";
                    break;
                case 5:
                    Tijdvak = "15:00-15:20";
                    break;
                case 6:
                    Tijdvak = "16:00-16:20";
                    break;
                case 7:
                    Tijdvak = "17:00-17:20";
                    break;
                default:
                    Tijdvak = "onjuiste keuze";
                    break;
            }
            return Tijdvak;
        }
    }
}

