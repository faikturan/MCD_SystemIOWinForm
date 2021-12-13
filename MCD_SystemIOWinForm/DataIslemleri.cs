using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SystemIOWinForm
{
    public class DataIslemleri
    {
        public DataIslemleri()
        {

        }

        public List<Personel> PersonelGetir(int adet)
        {
            List<Personel> personelListe = new List<Personel>();

            int id = 0;
            for (int i = 0; i <= adet; i++)
            {
                Personel personel = new Personel();
                personel.id = id++;
                personel.isim = FakeData.NameData.GetFirstName();
                personel.soyisim = FakeData.NameData.GetSurname();
                personel.firmaAdi = FakeData.NetworkData.GetDomain();
                personel.emailAdres = personel.isim + "." + personel.soyisim + "@" + personel.firmaAdi;
                personel.ulke = FakeData.PlaceData.GetCountry();
                personelListe.Add(personel);
            }

            return personelListe;
        }

    }
}
