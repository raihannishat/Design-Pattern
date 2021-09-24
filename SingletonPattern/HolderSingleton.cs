using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class HolderSingleton
    {
        private class Holder
        {
            public static readonly HolderSingleton instance = new HolderSingleton(); 
        }   

        private HolderSingleton() { }

        public static HolderSingleton Instance => Holder.instance;
    }
}
