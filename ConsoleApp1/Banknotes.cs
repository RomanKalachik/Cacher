using System;
using System.ComponentModel;
using System.Linq;

namespace Cacher {
    public enum Banknotes : int {
        OnePenny = 1,
        TwoPence = 2,
        FivePence = 5,
        TenPence = 10,
        TwentyPence = 20,
        HalfPound = 50,
        [Description("£1")]
        Pound = 100,
        [Description("£2")]
        TwoPound = 200,
        [Description("£5")]
        FivePound = 500,
        [Description("£10")]
        TenPound = 1000,
        [Description("£20")]
        TwentyPound = 2000,
        [Description("£50")]
        FiftyPound = 5000,
    }
}
