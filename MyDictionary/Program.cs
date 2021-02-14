using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int,string> ogrenci = new MyDictonary<int,string>();
            ogrenci.Add(152, "Ahmet Hacı");
            ogrenci.Yazdir();
        }
    }
    class MyDictonary<T,A>
    {
        T[] array;
        T[] array2;
        A[] _array;
        A[] _array2;
        public MyDictonary()
        {
            _array = new A[0];
            array = new T[0];
        }

        public void Add(T key, A item)
        {
            array2 = array;
            _array2 = _array;
            array = new T[array.Length + 1];
            _array = new A[_array.Length + 1];
            for (int i = 0; i < array2.Length; i++)
            {
                array[i] = array2[i];
                _array[i] = _array2[i];
            }
            array[array.Length - 1] = key;
            _array[_array.Length - 1] = item;
        }

        public void Yazdir()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]+" numaralı "+_array[i]);
            }
            
        }
    }
}
