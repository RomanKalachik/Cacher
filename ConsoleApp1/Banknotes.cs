using System.ComponentModel;
namespace Cacher {
    public enum Banknotes : int {
        [Description("1c")]
        OnePenny = 1,
        [Description("2c")]
        TwoPence = 2,
        [Description("5c")]
        FivePence = 5,
        [Description("10c")]
        TenPence = 10,
        [Description("20c")]
        TwentyPence = 20,
        [Description("50c")]
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
