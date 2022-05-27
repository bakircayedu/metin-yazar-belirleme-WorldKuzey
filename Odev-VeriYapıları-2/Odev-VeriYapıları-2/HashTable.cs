using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_VeriYapıları_2
{
    public class HashTable
    {


        int table_Size;
        public HashNode[] table;
        public HashTable()
        {
            table = new HashNode[table_Size];
            for (int i = 0; i < table_Size; i++)
            {
                table[i] = null;
            }

        }


        public void ekleChainle(int anahtar, string kelime)
        {
            int hash = (anahtar % table_Size);
            if (table[hash] == null) table[hash] = new HashNode(anahtar, kelime);
            else
            {
                HashNode hashNode = table[hash];
                while (hashNode.Next != null && hashNode.Anahtar != anahtar) hashNode = hashNode.Next;
                if (hashNode.Anahtar == anahtar)
                {
                    hashNode.Kelime = kelime;
                }
                else
                {
                    hashNode.Next = new HashNode(anahtar, kelime);
                }

            }

        }




        
    }
}
