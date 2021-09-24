using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class PropertySingleton
    {
        private static volatile PropertySingleton _instance;
        private static readonly object _lock = new object();

        private PropertySingleton() { }

        public static PropertySingleton Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PropertySingleton();
                    }
                }

                return _instance;
            }
        }
    }
}
