using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Stotage<T>
    {
        private T _item;

        public void StoreItem(T item)
        {
            _item = item;
            Console.WriteLine($"item has been stored");
        }
        public T RetrieveItem()
        {  
            Console.WriteLine($"item retrieved:{_item}");
            return _item;
        }
    }

}
