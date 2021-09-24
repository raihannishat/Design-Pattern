using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        private SimpleSingleton() { }

        public static SimpleSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SimpleSingleton();
            }

            return _instance;
        }
    }
}
