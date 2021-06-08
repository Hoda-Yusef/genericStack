using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericStack
{
    class specialStack
    {
        private T[] arr;
        private int count;

        public specialStack(int size)
        {
            arr = new T[size];
            count = 0;
        }

        public void push(Task elment)
        {
            if (count < arr.Length)
            {
                arr[count] = elment;
                count++;
            }

        }

        public T pop()
        {
            if (count > 0)
            {
                return arr[--count];
            }
            else
                return default(T);
        }

        public T Top()
        {
            if (count > 0)
            {
                return arr[count-1];
            }
            else
                return default(T);
        }

        public bool isEmpty()
        {
            return (count == 0);
        }

        public override string ToString()
        {
            string str = string.Empty;
            for(int i=0;i<count;i++)
            {
                str += Environment.NewLine + arr[i];
            }
            return str;
        }
    }
}
