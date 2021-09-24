using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleSingleton = SimpleSingleton.GetInstance();
            var lockSingleton = LockSingleton.GetInstance();
            var eagerlySingleton = EagerlySingleton.GetInstance();
            var doubleCheckedSingleton = DoubleCheckedSingleton.GetInstance();
            var propertySingleton = PropertySingleton.Instance;
            var sealedSingleton = SealedSingleton.Instance;
            var holderSingleton = HolderSingleton.Instance;
        }
    }
}
