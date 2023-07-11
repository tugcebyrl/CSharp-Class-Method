using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        Musteri[] musteriler = new Musteri[] { };
        List<Musteri> musteriList = new List<Musteri>();
        public void MusteriEkle(Musteri musteri)
        {
            musteriList.Add(musteri);   
            Console.WriteLine(musteri.Name + " Added");

        }
        public void MusteriSilme(Musteri musteri)
        {
            musteriList.Remove(musteri);
            Console.WriteLine(musteri.Id+" Deleted");
        }

        public void MusteriList()
        {
            foreach (Musteri musteri in musteriList)
            {
                Console.WriteLine(musteri.Id+" "+musteri.Name+" "+musteri.Surname+" "+musteri.Age);
            }
        }

    }
}
