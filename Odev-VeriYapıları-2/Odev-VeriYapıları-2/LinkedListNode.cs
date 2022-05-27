using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_VeriYapıları_2
{
    public class LinkedListNode
    {
        public string data;
        public LinkedListNode next;
        public int Cumledeki_Kelime { get; set; }
        public string isleme { get; set; }
        public int Frekans = 1;
        public LinkedListNode(string Data,int kelime)
        {   
            this.data = Data;
            this.next = null;
            this.Cumledeki_Kelime = kelime;
        }
        public LinkedListNode()
        {

        }
        public LinkedListNode(string Data, int kelime,string isleme)
        {
            this.isleme = isleme;
            this.data = Data;
            this.next = null;
            this.Cumledeki_Kelime = kelime;
        }



        //public LinkedListNode GetNode(string data)
        //{
        //    LinkedListNode node = new LinkedListNode(data);
        //    return node;
        //}
    }
}
