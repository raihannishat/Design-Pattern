using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class EagerlySingleton
    {
        private static readonly EagerlySingleton _instance = new EagerlySingleton();

        private EagerlySingleton() { }

        public static EagerlySingleton GetInstance()
        {
            return _instance;
        }
    }
}
