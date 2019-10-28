<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> eaf00ea8a1791b5c33474a132a531aa28624a7af
using System.Collections.Generic;

namespace LuhnModN
{
<<<<<<< HEAD
    public class LuhnModN : LuhnModN<char>
=======
   public class LuhnModN : LuhnModN<char>
>>>>>>> eaf00ea8a1791b5c33474a132a531aa28624a7af
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
<<<<<<< HEAD
            return GenerateCheckDigit(checkString);
=======
            return GenerateCheckDigit(checkString.ToCharArray());
>>>>>>> eaf00ea8a1791b5c33474a132a531aa28624a7af
        }

        public bool CheckValue(string checkString)
        {
<<<<<<< HEAD
            return CheckValue(checkString);
        }
    }
}
=======
            return CheckValue(checkString.ToCharArray());
        }
    }
}
>>>>>>> eaf00ea8a1791b5c33474a132a531aa28624a7af
