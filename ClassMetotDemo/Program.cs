namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Musteri musteri1 = new Musteri();
            musteri1.Id= 1; 
            musteri1.Name = "ASD";
            musteri1.Surname = "FGH";
            musteri1.Age = 30;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "ZXC";
            musteri2.Surname = "VBN";
            musteri2.Age = 42;


            
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            musteriManager.MusteriList();
            //musteriManager.MusteriList(musteri2);

            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);
        }
    }
}