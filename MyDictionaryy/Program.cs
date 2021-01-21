using System;

namespace MyDictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(124, "Muhammed ");
            ogrenci.Add(256, "Zeynep");
            ogrenci.Add(128, "Kenan");


            Console.WriteLine("Öğrenci Sayısı :" + ogrenci.Count);


        }
    }
    class MyDictionary<T, K>
    {
        T[] myKey;
        K[] myValue;
        public MyDictionary()
        {
            myKey = new T[0];
            myValue = new K[0];
        }
        public void Add(T t, K k)
        {

            T[] tempMyKey = myKey;
            K[] tempMyValue = myValue;
            myKey = new T[myKey.Length + 1];
            myValue = new K[myValue.Length + 1];
            for (int i = 0; i < tempMyKey.Length; i++)
            {
                myKey[i] = tempMyKey[i];
                myValue[i] = tempMyValue[i];
            }
            myKey[myKey.Length - 1] = t;
            myValue[myValue.Length - 1] = k;

        }



        public int Count
        {
            get { return myKey.Length; }


        }
    }
    }

