using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursul9
{
    public class Stack
    {
        ///In stiva noastra adaugam si stergem elemente de la inceputul sirului,
        ///adica cea mai mare pozitia are elementul pus prima data in stiva
        int[] values;
        public Stack()
        {
            values = new int[0];
        }

        public void Push(int ValueToAdd)
        {
            int[] temp = new int[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                temp[i + 1] = values[i];
            }
            temp[0] = ValueToAdd;
            values = temp;
        }

        public int Pop()
        {
            int toReturn = values[0];
            int[] temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length - 1; i++)
                temp[i] = values[i + 1];
            values = temp;
            return toReturn;
        }

        public int Peek()
        {
            return values[0];
        }

        public bool isEmpty()
        {
            if (values.Length == 0)
                return true;
            return false;
        }

        public void view()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
        }
    }
}
