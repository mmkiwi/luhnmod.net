using System;
using System.Collections.Generic;

namespace LuhnModN
{
    public abstract class LuhnModN<T>
    {
        public abstract int GetCodePoint(T item);
        public abstract T GetItem(int codePoint);
        public abstract int NumberOfCodePoints { get; }

        int GetSum(IEnumerable<T> items)
        {
            int factor = 1;
            int sum = 0;
            int n = NumberOfCodePoints;

            foreach (T i in items)
            {
                int codePoint = GetCodePoint(i);
                int addend = factor * codePoint;

                // Alternate the "factor" that each "codePoint" is multiplied by
                factor = (factor == 2) ? 1 : 2;

                addend = addend / n + (addend % n);
                sum += addend;
            }
            return sum;
        }

        public T GenerateCheckDigit(IEnumerable<T> items)
        {

            int n = NumberOfCodePoints;

            int sum = GetSum(items);

            int remainder = sum % n;
            int checkCodePoint = (n - remainder) % n;

            return GetItem(checkCodePoint);
        }

        public bool CheckValue(IEnumerable<T> items)
        {
            return GetSum(items) % NumberOfCodePoints == 0;
        }
    }

    public class LuhnModN : LuhnModN<char>
    {
        public string ValidChars { get; private set; }

        public override int GetCodePoint(char item)
        {
            return ValidChars.IndexOf(item);
        }

        public override int NumberOfCodePoints { get { return ValidChars.Length; } }

        public override char GetItem(int codePoint)
        {
            return ValidChars[codePoint];
        }

        public LuhnModN(string validChars)
        {
            //TODO: Test no duplicates
            ValidChars = validChars;
        }

        public char GenerateCheckDigit(string checkString)
        {
            return GenerateCheckDigit(checkString.ToCharArray());
        }

        public bool CheckValue(string checkString)
        {
            return CheckValue(checkString.ToCharArray());
        }
    }
}
