using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _19xBedAndBreakfast;

namespace BBConsoleUI
{
    class BBConsoleUI
    {
        BBController bbc = new BBController();
        public bool Menu()
        {
            bool retur = true;
            Console.WriteLine("Menu");
            Console.WriteLine("1 - insert");
            Console.WriteLine("2 - update");
            Console.WriteLine("3 - delete");
            Console.WriteLine("4 - get single");
            Console.WriteLine("5 - Get all");
            Console.WriteLine("x - slut");
            string valg = Console.ReadLine();
            Console.Clear();
            switch (valg)
            {
                case "1":
                    InsertGuest();
                    break;
                case "2":
                    UpdateGuest();
                    break;
                case "3":
                    DeleteGuest();
                    break;
                case "4":
                    GetGuestByPassPortno();
                    break;
                case "5":
                    GetAllGuests();
                    break;
                case "x":
                    retur = false;
                    break;
                default:
                    break;
            }
            return retur;
        }
        public void InsertGuest()
        {
            BBController bbc = new BBController();
            Console.WriteLine("Indlæs og udfør InsertGuest-metode");
            Console.WriteLine("Indtast pasnummer:");
            string pasnr = Console.ReadLine();
            Console.WriteLine("Indtast fornavn: ");
            string fnavn = Console.ReadLine();
            Console.WriteLine("Indtast efternavn: ");
            string lnavn = Console.ReadLine();
            Console.WriteLine("Indtast adresse: ");
            string adresse = Console.ReadLine();
            Console.WriteLine("Indtast køn: ");
            char køn = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Indtast telefonnr: ");
            int tlf = Convert.ToInt32(Console.ReadLine());
            bbc.InsertGuest(pasnr, tlf, fnavn, lnavn, køn, adresse);
        }
        public void UpdateGuest()
        {
            Console.WriteLine("Indlæs og udfør UpdateGuest-metode");
            bbc.UpdateGuest("P78", 7914, "Ole78", "Mikk", 'M', "adr");
        }
        public void DeleteGuest()
        {
            Console.WriteLine("Indlæs og udfør DeleteGuest-metode");
            bbc.DeleteGuest("P78"); 
        }
        public void GetGuestByPassPortno()
        {
            Console.WriteLine("Indlæs og udfør GetGuestByPassPortNo-metode");
            bbc.GetGuestByPassPortNo("P78"); 
        }
        public void GetAllGuests()
        {
            Console.WriteLine("udfør GetALlguests-metode");
            bbc.GetAllGuests();
            bbc.ShowAllGuests();
        }
    }
}
