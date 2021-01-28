using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // tertemiz bir generic yaptık h.o.
            MyList<string> itemler = new MyList<string>();


            // Add ile artık dizinize istediğimiz kadar zamazingo ekleyebiliriz.
            itemler.Add("+9 dolunay kılıcı");
            itemler.Add("+3 hilal kılıcı");
            itemler.Add("+2 Sos nuker kılıcı");


        }
    }
}
