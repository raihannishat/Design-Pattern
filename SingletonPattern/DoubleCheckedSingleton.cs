using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class DoubleCheckedSingleton
    {
        private volatile static DoubleCheckedSingleton _instance;
        private static readonly object _lock = new object();

        private DoubleCheckedSingleton() { }

        public static DoubleCheckedSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DoubleCheckedSingleton();
                    }
                }
            }

            return _instance;
        }
    }
}
