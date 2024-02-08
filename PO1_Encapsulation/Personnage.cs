using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        private string nom;
        private int pv;
        private int strength;

        public string Nom { get => nom; set => nom = value; }
        public int Pv 
        { 
            get => pv;
            set 
            {
                if (value > 0)
                {
                    pv = value;
                }
                else
                {
                    pv = 0;
                }
            } 
        }
        public int Strength { get => strength; set => strength = value; }

        public bool EstEnVie
        {
            get
            {
                if(pv > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
