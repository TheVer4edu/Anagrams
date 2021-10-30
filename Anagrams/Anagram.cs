using System.Collections.Generic;
using System.Linq;

namespace Anagrams {
    class Anagram {
        private readonly SortedDictionary<char, int> _dictionary = new SortedDictionary<char, int>();
        private readonly string _word;
        public int Length => _word.Length;

        public Anagram(string word) {
            _word = word;
            foreach (char symbol in word) {
                if (_dictionary.ContainsKey(symbol))
                    _dictionary[symbol]++;
                else
                    _dictionary.Add(symbol, 1);
            }
        }

        private bool Equals(Anagram other) {
            return this.Length == other.Length && this.GetHashCode() == other.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Anagram) obj);
        }

        public override int GetHashCode() {
            return _dictionary.Aggregate(1, 
                (current, pair) => current * (pair.Key * 1039 + pair.Value));
        }

        public override string ToString() {
            return _word;
        }
    }
}