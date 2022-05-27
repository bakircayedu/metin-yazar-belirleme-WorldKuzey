using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_VeriYapıları_2
{
    public class Heap
    {

        private int currentSize;
        private int maxSize;
        private HeapNode[] heapArray;



        public Heap(int Max_Size)
        {
            currentSize = 0;
            this.maxSize = Max_Size;
            heapArray = new HeapNode[Max_Size];
           

        }
        public bool Insert(int data, int frekans)
        {
            if (currentSize == maxSize) return false;

            HeapNode newNode = new HeapNode(data, frekans);
            heapArray[currentSize] = newNode;
            MoveToUp(currentSize++);
            return true;

        }



        private void MoveToUp(int index)
        {
            //int parent = GetParent(index);
            int parent = (index - 1) / 2;

            HeapNode bottom = heapArray[index];
            while (index>0 && heapArray[parent].Data<bottom.Data)
            {heapArray[index]=heapArray[parent];
                index = parent;
                parent = (index - 1) /2;

            }
            heapArray[index] = bottom;
        }
          
        


        //private int GetParent(int index)
        //{
        //    int parent=(index - 1) / 2;
        //    return parent;

        //}

    }
}
