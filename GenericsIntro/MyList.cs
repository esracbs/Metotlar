using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        
        T[] items;
        //constructor bir class newlendiğinde çalışan bloktur
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];//listenin eleman sayısını öncelikle arttırdık
            //burada yeni eleman ekledik sonra eleman sayısını 1 arttırınca 2 eleman olucak ama new dediğimiz için ddeğerler uçuyordu
            //aslında uçan ise benim referans numaram o yüzden o referansı birine tutturmam lazım bunun içinT[] tempArray = items; bunu  ekledik

        }
    }
}
