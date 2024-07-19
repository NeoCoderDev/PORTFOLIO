using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci_Konobar_Enkapsulacija
{
    public class Osobe
    {
        private String returnSrba;
        private String returnMarko;
        private int brojosoba;

        public String Marko
        {

            get
            {
                return returnMarko;
            }

            set
            {
                returnMarko = value;
            }

        }
        public String Srba
        {

            get
            {
                return returnSrba;
            }

            set
            {
                returnSrba = value;
            }

        }
        public int broj
        {

            get
            {
                return brojosoba;
            }

            set
            {
                brojosoba = value;
            }

        }


    } 
}
