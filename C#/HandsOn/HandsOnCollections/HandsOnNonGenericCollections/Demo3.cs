using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Demo3
    {
        static void Main()
        {
            try
            {
                //Keys are uniqe and not null
                Hashtable hashtable = new Hashtable();
                //  SortedList hashtable = new SortedList();
                hashtable.Add(1056, "Priyanka");
                hashtable.Add(1090, "Sohil");
                hashtable.Add(1000, "ROhan");
                hashtable.Add(1023, "Anusha");
                hashtable.Add(1078, "Laxmitha");
                hashtable.Remove(1056); //remove the key-value pair
                string ename = hashtable[1000].ToString();
                //access all key-value pairs
                foreach (DictionaryEntry d in hashtable)
                {
                    Console.WriteLine("ID:{0} Name:{1}", d.Key, d.Value);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
