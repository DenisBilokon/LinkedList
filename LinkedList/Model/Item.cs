using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace LinkedList.Model
{
    
    public class Item<T> 
    {
        private T data = default(T);
        private Item<T> next = null;


        public T Data
        {
            get { return data; }
            set
            {
                if (value != null)
                    data = value;

            }
        }

        public Item<T> Next { get; set; }
        
        public Item(T data)
        {
            Data = data;
        }

    }
}

