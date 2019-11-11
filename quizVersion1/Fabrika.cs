using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizVersion1
{
    public class Fabrika
    {
        public string isim { get; set; }
        public string adres { get; set; }
        public List<Personel> Calisanlar = new List<Personel>();
        public Personel personel { get; set; }
        public void İsealma()
        {

        }
        public void İstenCikarma()
        {

        }
        public string CalisanListesi()
        {
            string liste="";
            foreach (Personel pers in Calisanlar)
            {
                liste +="Personel No: "+pers.PersonelNo+ "Ad: " + pers.kimlik.Ad+"Soyad: "+ pers.kimlik.Soyad+"Calistigi Birim: "+pers.CalistigiBirim+" \n ";
                
            }

            return liste;
        }
        public void ListeyeEkle(Personel p)
        {
            Calisanlar.Add(p);
        }
    }
}
