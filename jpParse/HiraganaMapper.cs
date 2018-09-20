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

            { JapaneseSyllable.Ka,  "か" },
            { JapaneseSyllable.Ki,  "き" },
            { JapaneseSyllable.Ku,  "く" },
            { JapaneseSyllable.Ke,  "け" },
            { JapaneseSyllable.Ko,  "こ" },
            { JapaneseSyllable.Kou, "こう" },

            { JapaneseSyllable.Ga,  "が" },
            { JapaneseSyllable.Gi,  "ぎ" },
            { JapaneseSyllable.Gu,  "ぐ" },
            { JapaneseSyllable.Ge,  "げ" },
            { JapaneseSyllable.Go,  "ご" },
            { JapaneseSyllable.Gou, "ごう" },

            { JapaneseSyllable.Ta,  "た" },
            { JapaneseSyllable.Chi, "ち" },
            { JapaneseSyllable.Tsu, "つ" },
            { JapaneseSyllable.Te,  "て" },
            { JapaneseSyllable.To,  "と" },
            { JapaneseSyllable.Tou, "とう" },

            { JapaneseSyllable.Da,  "だ" },
            { JapaneseSyllable.Di,  "ぢ" },
            { JapaneseSyllable.Du,  "づ" },
            { JapaneseSyllable.De,  "で" },
            { JapaneseSyllable.Do,  "ど" },
            { JapaneseSyllable.Dou, "どう" },

            { JapaneseSyllable.Sa,  "さ" },
            { JapaneseSyllable.Shi, "し" },
            { JapaneseSyllable.Su,  "す" },
            { JapaneseSyllable.Se,  "せ" },
            { JapaneseSyllable.So,  "そ" },
            { JapaneseSyllable.Sou, "そう" },

            { JapaneseSyllable.Za,  "ざ" },
            { JapaneseSyllable.Ji,  "じ" },
            { JapaneseSyllable.Zu,  "ず" },
            { JapaneseSyllable.Ze,  "ぜ" },
            { JapaneseSyllable.Zo,  "ぞ" },
            { JapaneseSyllable.Zou, "ぞう" },

            { JapaneseSyllable.Na, "な" },
            { JapaneseSyllable.Ni, "に" },
            { JapaneseSyllable.Nu, "ぬ" },
            { JapaneseSyllable.Ne, "ね" },
            { JapaneseSyllable.No, "の" },
            { JapaneseSyllable.Nou, "のう" },

            { JapaneseSyllable.Ha, "は" },
            { JapaneseSyllable.Hi, "ひ" },
            { JapaneseSyllable.Fu, "ふ" },
            { JapaneseSyllable.He, "へ" },
            { JapaneseSyllable.Ho, "ほ" },
            { JapaneseSyllable.Hou, "ほう" },

            { JapaneseSyllable.Ba, "ば" },
            { JapaneseSyllable.Bi, "び" },
            { JapaneseSyllable.Bu, "ぶ" },
            { JapaneseSyllable.Be, "べ" },
            { JapaneseSyllable.Bo, "ぼ" },
            { JapaneseSyllable.Bou, "ぼう" },

            { JapaneseSyllable.Pa, "ぱ" },
            { JapaneseSyllable.Pi, "ぴ" },
            { JapaneseSyllable.Pu, "ぷ" },
            { JapaneseSyllable.Pe, "ぺ" },
            { JapaneseSyllable.Po, "ぽ" },
            { JapaneseSyllable.Pou, "ぽう" },

            { JapaneseSyllable.Ma, "ま" },
            { JapaneseSyllable.Mi, "み" },
            { JapaneseSyllable.Mu, "む" },
            { JapaneseSyllable.Me, "め" },
            { JapaneseSyllable.Mo, "も" },
            { JapaneseSyllable.Mou, "もう" },

            { JapaneseSyllable.Ra, "ら" },
            { JapaneseSyllable.Ri, "り" },
            { JapaneseSyllable.Ru, "る" },
            { JapaneseSyllable.Re, "れ" },
            { JapaneseSyllable.Ro, "ろ" },
            { JapaneseSyllable.Rou, "ろう" },

            { JapaneseSyllable.Ya, "や" },
            { JapaneseSyllable.Yu, "ゆ" },
            { JapaneseSyllable.Yo, "よ" },
            { JapaneseSyllable.You, "よう" },

            { JapaneseSyllable.Wa, "わ" },
            { JapaneseSyllable.Wo, "を" },
            { JapaneseSyllable.N, "ん" }
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

