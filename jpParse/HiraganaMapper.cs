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
            { JapaneseSyllable.N, "ん" },

            { JapaneseSyllable.Kya, "きゃ" },
            { JapaneseSyllable.Kyu, "きゅ" },
            { JapaneseSyllable.Kyo, "きょ" },

            { JapaneseSyllable.Gya, "ぎゃ" },
            { JapaneseSyllable.Gyu, "ぎゅ" },
            { JapaneseSyllable.Gyo, "ぎょ" },

            { JapaneseSyllable.Nya, "にゃ" },
            { JapaneseSyllable.Nyu, "にゅ" },
            { JapaneseSyllable.Nyo, "にょ" },

            { JapaneseSyllable.Hya, "ひゃ" },
            { JapaneseSyllable.Hyu, "ひゅ" },
            { JapaneseSyllable.Hyo, "ひょ" },

            { JapaneseSyllable.Bya, "びゃ" },
            { JapaneseSyllable.Byu, "びゅ" },
            { JapaneseSyllable.Byo, "びょ" },

            { JapaneseSyllable.Pya, "ぴゃ" },
            { JapaneseSyllable.Pyu, "ぴゅ" },
            { JapaneseSyllable.Pyo, "ぴょ" },

            { JapaneseSyllable.Mya, "みゃ" },
            { JapaneseSyllable.Myu, "みゅ" },
            { JapaneseSyllable.Myo, "みょ" },

            { JapaneseSyllable.Rya, "りゃ" },
            { JapaneseSyllable.Ryu, "りゅ" },
            { JapaneseSyllable.Ryo, "りょ" },

            { JapaneseSyllable.Ja, "じゃ" },
            { JapaneseSyllable.Ju, "じゅ" },
            { JapaneseSyllable.Jo, "じょ" },

            { JapaneseSyllable.Cha, "ちゃ" },
            { JapaneseSyllable.Chu, "ちゅ" },
            { JapaneseSyllable.Cho, "ちょ" },

            { JapaneseSyllable.Sha, "しゃ" },
            { JapaneseSyllable.Shu, "しゅ" },
            { JapaneseSyllable.Sho, "しょ" },

            { JapaneseSyllable.Kka, "っか" },
            { JapaneseSyllable.Kki, "っき" },
            { JapaneseSyllable.Kku, "っく" },
            { JapaneseSyllable.Kke, "っけ" },
            { JapaneseSyllable.Kko, "っこ" },

            { JapaneseSyllable.Ssa, "っさ" },
            { JapaneseSyllable.Sshi, "っし" },
            { JapaneseSyllable.Ssu, "っす" },
            { JapaneseSyllable.Sse, "っせ" },
            { JapaneseSyllable.Sso, "っそ" },

            { JapaneseSyllable.Tta, "った" },
            { JapaneseSyllable.Cchi, "っち" },
            { JapaneseSyllable.Ttsu, "っつ" },
            { JapaneseSyllable.Tte, "って" },
            { JapaneseSyllable.Tto, "っと" },

            { JapaneseSyllable.Bba, "っば" },
            { JapaneseSyllable.Bbi, "っび" },
            { JapaneseSyllable.Bbu, "っぶ" },
            { JapaneseSyllable.Bbe, "っべ" },
            { JapaneseSyllable.Bbo, "っぼ" },

            { JapaneseSyllable.Ppa, "っぱ" },
            { JapaneseSyllable.Ppi, "っぴ" },
            { JapaneseSyllable.Ppu, "っぷ" },
            { JapaneseSyllable.Ppe, "っぺ" },
            { JapaneseSyllable.Ppo, "っぽ" },
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

