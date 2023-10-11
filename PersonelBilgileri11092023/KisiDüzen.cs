using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgileri11092023
{
    public class KisiDüzen : Personel
    {
        private readonly Personel _personel;
        public KisiDüzen(Personel personel)
        {

            _personel = personel;
            

        }

    }
}
