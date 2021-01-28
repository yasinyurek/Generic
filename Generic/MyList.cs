using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    // list tarzı yazmak için constructor ve bazı özellikleri içeren bir class lazım.
    class MyList<T>
    {
        // itemleri tutacağımız bir array abi lazım. 
        T[] items;


        public MyList()
        {
            //constructor reisde 0 elemanlı bir item arrayi yapıyoruz.

            items = new T[0];
        }

        public void Add(T item)
        {
            //tempArray abimize eski referans numarasını tutturuyoruz.
            T[] tempArray = items;

            //Yeni bir tane boşluk açıyoruz ki eleman alalım.
            items = new T[items.Length + 1];

            // emanetcimiz olan tempArrayden emanetleri geri alıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            // itemsdeki boşluğa add ile eleman yerleştiriyoruz.
            items[items.Length - 1] = item;

            // burada da programdan neler ekledik ona bakalım.
            Console.WriteLine(item);
        }

        
    }
}
