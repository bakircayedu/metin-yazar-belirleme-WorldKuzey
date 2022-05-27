using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_VeriYapıları_2
{
    public  class HeapNode
    {
        public int Data { get; set; }
        public int Frekans { get; set; }

        public HeapNode(int data,int frekans)
        {
            this.Data = data;
            this.Frekans = frekans;
        }



    }
}
