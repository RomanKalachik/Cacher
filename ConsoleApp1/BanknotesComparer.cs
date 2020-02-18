using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Cacher {
    public class BanknotesComparer : IComparer<Tuple<Banknotes, int>> {
        public int Compare( Tuple<Banknotes, int> x, Tuple<Banknotes, int> y) {
            return ((int)x.Item1).CompareTo((int)y.Item1) * -1;
        }
    }
}
