using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19xBedAndBreakfast
{
    public class BBController
    {

        DataBaseManager dbm = new DataBaseManager();

        public List<Guest> gæster = new List<Guest>();
        public Guest g;
        public void InsertGuest(string pasnr, int tlfnr, string fnavn, string enavn, char gender, string adr)
        {
            g = new Guest(pasnr, tlfnr, fnavn, enavn, gender, adr);
            gæster.Add(g);
            dbm.InsertGuest(g);
        }
        public void UpdateGuest(string pasnr, int tlfnr, string fnavn, string enavn, char gender, string adr)
        {
            g = new Guest(pasnr, tlfnr, fnavn, enavn, gender, adr);
            dbm.UpdateGuest(g);
        }

        public void DeleteGuest(string pasnr)
        {
            dbm.DeleteGuest(pasnr);
        }
        public bool GetGuestByPassPortNo(string pasnr)
        {
            g = dbm.GetGuestByPassPortNo(pasnr);
            if (g != null)
            {
                ShowGuest(g);
                return true;
            }
            else
                return false;
        }
        public List<Guest> GetAllGuests()
        {
            gæster=dbm.GetAllGuests();
            return gæster;
        }
        public void ShowAllGuests()
        {
            foreach (Guest g in gæster)
            {
                ShowGuest(g);
            }
        }
        public void ShowGuest(Guest g)
        {
            Console.Write(g.PassPortNo + " ");
            Console.Write(g.FName + " ");
            Console.Write(g.LName + " ");
            Console.Write(g.Address + " ");
            Console.Write(g.Gender + " ");
            Console.WriteLine(g.PhoneNo);

        }
    }
}
