using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_VeriYapıları_2
{
    public class HashNode
    {
        private int anahtar { get; set; }
        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }


        private string kelime { get; set; }
        public string Kelime
        {
            get { return kelime; }
            set { kelime = value; }
        }


        private HashNode next { get; set; }
        public HashNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public HashNode(int anahtar,string deger)
        {
            this.anahtar = anahtar;
            this.kelime = deger;
            this.next = null;

        }
    }
}
