using System;
using System.Collections.Generic;
using System.Linq;
namespace Cacher {
    public class Cacher {
        public Cacher(List<Tuple<Banknotes, int>> state) {
            State = state;
        }
        List<Tuple<Banknotes, int>> State { get; set; }
        public static void Display(List<Tuple<Banknotes, int>> displayValue) {
            foreach (Tuple<Banknotes, int> displayValueItem in displayValue)
                Console.WriteLine(string.Format("{0}x{1}", displayValueItem.Item1.GetDescription(), displayValueItem.Item2));
        }
        public List<Tuple<Banknotes, int>> Withdraw(int amount, bool prefer20) {
            State.Sort(new BanknotesComparer());
            if (prefer20) {
                Tuple<Banknotes, int> f20 = State.Where(i => i.Item1 == Banknotes.TwentyPound).FirstOrDefault();
                if (f20 != null) {
                    State.Remove(f20);
                    State.Insert(0, f20);
                }
            }
            int normalizedAmount = amount * 100;
            int amountLeft = normalizedAmount;
            List<Tuple<Banknotes, int>> result = new List<Tuple<Banknotes, int>>();
            for (int i = 0; i < State.Count; i++) {
                Tuple<Banknotes, int> note = State[i];
                if (note.Item1 <= 0) continue;
                int amountNeeded = amountLeft / (int)note.Item1;
                int currentNoteAmount = Math.Min(amountNeeded * (int)note.Item1, note.Item2 * (int)note.Item1);
                amountLeft -= currentNoteAmount;
                result.Add(new Tuple<Banknotes, int>(note.Item1, amountNeeded));
                State[i] = new Tuple<Banknotes, int>(note.Item1, note.Item2 - amountNeeded);
                if (amountLeft == 0) break;
            }
            return result;
        }
    }
}
