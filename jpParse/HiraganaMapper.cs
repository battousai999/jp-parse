using System;
using System.Collections.Generic;
using System.Text;

namespace battousai.jpParse
{
    public static class HiraganaMapper
    {
        private static Dictionary<JapaneseSyllable, string> syllableMap = new Dictionary<JapaneseSyllable, string>
        {
            { JapaneseSyllable.A, "あ" },
            { JapaneseSyllable.I, "い" },
            { JapaneseSyllable.U, "う" },
            { JapaneseSyllable.E, "え" },
            { JapaneseSyllable.O, "お" },

            { JapaneseSyllable.Ka, "か" },
            { JapaneseSyllable.Ki, "き" },
            { JapaneseSyllable.Ku, "く" },
            { JapaneseSyllable.Ke, "け" },
            { JapaneseSyllable.Ko, "こ" },
            { JapaneseSyllable.Kou, "こう" }
        };

        public static string Map(JapaneseSyllable syllable)
        {
            string value;

            if (!syllableMap.TryGetValue(syllable, out value))
                throw new InvalidOperationException("Unexpected syllable: " + syllable.ToString());

            return value;
        }
    }
}

