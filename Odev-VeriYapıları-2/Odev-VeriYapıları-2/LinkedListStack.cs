using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_VeriYapıları_2
{
    public class LinkedListStack
    {
        LinkedListNode top;//top(en üst)düğüm yarattık
        public int count = 0;
        public int Count()
        {

            return count - 1;
        }
        public LinkedListStack()
        {
            this.top = null;//düğüme boş değer atadık
        }



        public void Push(string value, int cumle_kelime)
        {
            LinkedListNode newNode = new LinkedListNode(value, cumle_kelime);
            if (top == null) //düğümümüz boş ise
            {
                newNode.next = null;//düğümün nextine null atadık
            }
            else//düğümümüz dolu ise 
            {
                newNode.next = top;//düğümün nextine top u atadık
            }
            top = newNode;
            count++;


        }

        public void Push(string value, int cumle_kelime, bool essiz)
        {
            string isleme = string.Empty;
            foreach (var harf in value)
            {
                if (Char.IsPunctuation(harf))//imlasını kontrol eder
                {
                    break;
                }

                isleme += harf;

            }



            LinkedListNode node = new LinkedListNode(value, cumle_kelime, isleme);
            if (top == null)
            {
                top = node;
                count++;
                return;
            }


            //processiz kelimeleri eşleme
            LinkedListNode node_control = AyniKelimeler(node);
            if (node_control == null)
            {
                node.next = top;
                top = node;
                count++;

            }
            else
            {
                FrekansArttir(node);
            }

        }
        private LinkedListNode AyniKelimeler(LinkedListNode control)
        {
            LinkedListNode temp = new LinkedListNode();
            temp = top;
            while (temp.next != null)
            {
                if (String.Equals(temp.isleme, control.isleme))
                {

                    return temp;

                }

                temp = temp.next;

            }
            if (String.Equals(temp.isleme, control.isleme))
            {

                return temp;

            }
            return null;
        }


        private void FrekansArttir(LinkedListNode node)
        {
            LinkedListNode onceki = new LinkedListNode();
            onceki = top;
            while (onceki.next != null)
            {
                if (String.Equals(onceki.next.isleme, node.isleme))//iki stringi karşılaştırıyor
                {
                    int yenifrekans = onceki.next.Frekans;
                    onceki.next.Frekans = ++yenifrekans;
                }
                onceki = onceki.next;
            }


        }







        public string peek()//son indexi döndürür
        {

            if (top != null)
            {
                return top.data;
            }
            return "";


        }

        public string cumleYazdir()
        {
            LinkedListNode temp = new LinkedListNode(null, 0);
            temp = top;
            string cumle = "";
            while (temp.next != null)//bütün paragraf sonuna kadar git
            {
                cumle += temp.data + temp.Cumledeki_Kelime + Environment.NewLine;//cumleyi ayırıyor

                temp = temp.next;
            }
            cumle += temp.data + temp.Cumledeki_Kelime + Environment.NewLine;
            return cumle;

        }



        public int[] MetinCumleAyirici()
        {
            int[] bilgi = new int[Count()];
            int i = 0;
            LinkedListNode temp = new LinkedListNode(null, 0);
            temp = top;
            while (temp.next != null)
            {
                bilgi[i] = temp.data.Split(' ').Count();

                temp = temp.next;
                i++;
            }
            return bilgi;
        }






        public string cumleSayisiYazdir()
        {
            LinkedListNode temp = new LinkedListNode(null, 0);
            temp = top;
            int cumlesayisi = 0;
            string cumle = "";
            while (temp.next != null)//bütün paragraf sonuna kadar git
            {
                cumle += temp.data + Environment.NewLine;//cumleyi ayırıyor
                temp = temp.next;
                cumlesayisi += 1;
            }
            cumle += temp.data + Environment.NewLine;
            return cumlesayisi.ToString();

        }





        public string kelimeyaz()
        {
            LinkedListNode temp = new LinkedListNode(null, 0);
            temp = top;
            string kelime = "";
            while (temp.next != null)
            {
               
                kelime += temp.data +Environment.NewLine;

                temp = temp.next;


            }
            return kelime;

        }


        public string toplamcumlesay()
        {

            //int cumlesayisi=0;
            //string kelime = "";
            //LinkedListNode temp = new LinkedListNode(null);
            //temp = top;
            ////string kelime = "";
            //while (temp.next != null)
            //{
            //}

            return count.ToString();

        }





    }
}
