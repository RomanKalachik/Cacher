using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cacher {
    [TestFixture]
    public class CacherTests {
        Cashier cacher;

        [SetUp]
        public void Setup() {
            var state = new List<Tuple<Banknotes, int>>(){
            new Tuple<Banknotes, int>(Banknotes.FiftyPound, 10),
            new Tuple<Banknotes, int>(Banknotes.TwentyPound, 10),

        };

            cacher = new Cashier(state);

        }
        [Test]
        public void TestAlgorithm1() {
            var resut = cacher.Withdraw(120, false);
            Assert.AreEqual(2, resut.Count);
            Assert.AreEqual(2, resut[0].Item2);
            Assert.AreEqual(1, resut[1].Item2);
            Assert.AreEqual(Banknotes.FiftyPound, resut[0].Item1);
            Assert.AreEqual(Banknotes.TwentyPound, resut[1].Item1);
        }
        [Test]
        public void TestAlgorithm2() {
            var resut = cacher.Withdraw(120, true);
            Assert.AreEqual(1, resut.Count);
            Assert.AreEqual(6, resut[0].Item2);
            Assert.AreEqual(Banknotes.TwentyPound, resut[0].Item1);
        }
    }
}
