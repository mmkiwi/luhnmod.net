using System;
using System.Collections.Generic;

namespace LuhnModN
{
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
            return GenerateCheckDigit(checkString);
        }

        public bool CheckValue(string checkString)
        {
            return CheckValue(checkString);
        }
    }
}