using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class LockSingleton
    {
        private static LockSingleton _instance;
        private static readonly object _lock = new object();

        private LockSingleton() { }

        public static LockSingleton GetInstance()
        {
            lock (_lock)
            {
                if(_instance == null)
                {
                    _instance = new LockSingleton();
                }
            }

            return _instance;
        }
    }
}
