namespace Playground
{
    public class LongestCommonPrefix
    {
        public string GetPrefixWordByWord(string[] strs)
        {
            if (strs.Length == 0) return string.Empty;

            int minLen;
            string pref = strs[0];
            int charIdx;
            int wordIdx = 1;

            while (pref != string.Empty && wordIdx < strs.Length)
            {
                minLen = strs[wordIdx].Length < pref.Length ? strs[wordIdx].Length : pref.Length;

                charIdx = 0;

                while (charIdx < minLen && strs[wordIdx][charIdx] == pref[charIdx])
                {
                    charIdx++;
                }

                pref = pref.Substring(0, charIdx);

                wordIdx++;
            }

            return pref;
        }

        /// <summary>
        /// Looks by checking the first char of all the words, then the seccond, and so forth
        /// if the difference is locatted torwards the end it may be faster in finding it.
        /// </summary>
        /// <remarks>
        /// This method should be faster for a case like this one. 
        /// 
        /// { "this is a long frase a", 
        ///   "this is a long frase b", 
        ///   "this is a long frase c", 
        ///   "this is a long frase d", 
        ///   "dif" }
        ///   
        /// In theory this is true but I didn't get to verify it. It seems that the optimization comes for more extreme cases
        /// </remarks>
        public string GetPrefixCharByChar(string[] strs)
        {
            if (strs.Length == 0 || strs[0].Length == 0) return string.Empty;

            int charIdx = 0;
            int wordIdx = 1;
            bool keepLooking = true;
            char chr = strs[0][0];

            while (keepLooking)
            {
                // search the nth char in all words
                while (keepLooking && wordIdx < strs.Length)
                {
                    keepLooking = charIdx < strs[wordIdx].Length && // the word is long enough
                                  chr == strs[wordIdx][charIdx]; // still didn't find a difference

                    wordIdx++;
                }

                charIdx++;

                if (charIdx < strs[0].Length) // contemplate the case of the fist word being the shortest one
                    chr = strs[0][charIdx];
                else
                {
                    keepLooking = false;

                    // this is wrong
                    if (wordIdx > strs.Length) // first word special case. This hack is incredibly aweful 
                        charIdx++; 
                }
                wordIdx = 1;
            }

            return charIdx > 0 
                    ? strs[0].Substring(0, charIdx - 1) 
                    : string.Empty;
        }
    }
}