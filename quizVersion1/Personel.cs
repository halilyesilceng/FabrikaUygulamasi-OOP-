using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizVersion1
{
    public class Personel
    {
        public Kimlik kimlik { get; set; } = new Kimlik();
        public int PersonelNo { get;private set; }
        public string CalistigiBirim { get; set; }

        public Personel(int b)
        {
            this.PersonelNo = b;

        }
    }
}
