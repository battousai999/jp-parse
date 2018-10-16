using System;
using System.Collections.Generic;
using System.Text;

namespace battousai.jpParse
{
    public class KatakanaMapper
    {
        private static Dictionary<JapaneseSyllable, string> syllableMap = new Dictionary<JapaneseSyllable, string>
        {
            { JapaneseSyllable.A, "ア" },
            { JapaneseSyllable.I, "イ" },
            { JapaneseSyllable.U, "ウ" },
            { JapaneseSyllable.E, "エ" },
            { JapaneseSyllable.O, "オ" },

            { JapaneseSyllable.Ka,  "カ" },
            { JapaneseSyllable.Ki,  "キ" },
            { JapaneseSyllable.Ku,  "ク" },
            { JapaneseSyllable.Ke,  "ケ" },
            { JapaneseSyllable.Ko,  "コ" },
            { JapaneseSyllable.Kou, "コウ" },

            { JapaneseSyllable.Ga,  "ガ" },
            { JapaneseSyllable.Gi,  "ギ" },
            { JapaneseSyllable.Gu,  "グ" },
            { JapaneseSyllable.Ge,  "ゲ" },
            { JapaneseSyllable.Go,  "ゴ" },
            { JapaneseSyllable.Gou, "ゴウ" },

            { JapaneseSyllable.Ta,  "タ" },
            { JapaneseSyllable.Chi, "チ" },
            { JapaneseSyllable.Tsu, "ツ" },
            { JapaneseSyllable.Te,  "テ" },
            { JapaneseSyllable.To,  "ト" },
            { JapaneseSyllable.Tou, "トウ" },

            { JapaneseSyllable.Da,  "ダ" },
            { JapaneseSyllable.Di,  "ヂ" },
            { JapaneseSyllable.Du,  "ヅ" },
            { JapaneseSyllable.De,  "デ" },
            { JapaneseSyllable.Do,  "ド" },
            { JapaneseSyllable.Dou, "ドウ" },

            { JapaneseSyllable.Sa,  "サ" },
            { JapaneseSyllable.Shi, "シ" },
            { JapaneseSyllable.Su,  "ス" },
            { JapaneseSyllable.Se,  "セ" },
            { JapaneseSyllable.So,  "ソ" },
            { JapaneseSyllable.Sou, "ソウ" },

            { JapaneseSyllable.Za,  "ザ" },
            { JapaneseSyllable.Ji,  "ジ" },
            { JapaneseSyllable.Zu,  "ズ" },
            { JapaneseSyllable.Ze,  "ゼ" },
            { JapaneseSyllable.Zo,  "ゾ" },
            { JapaneseSyllable.Zou, "ゾウ" },

            { JapaneseSyllable.Na, "ナ" },
            { JapaneseSyllable.Ni, "ニ" },
            { JapaneseSyllable.Nu, "ヌ" },
            { JapaneseSyllable.Ne, "ネ" },
            { JapaneseSyllable.No, "ノ" },
            { JapaneseSyllable.Nou, "ノウ" },

            { JapaneseSyllable.Ha, "ハ" },
            { JapaneseSyllable.Hi, "ヒ" },
            { JapaneseSyllable.Fu, "フ" },
            { JapaneseSyllable.He, "ヘ" },
            { JapaneseSyllable.Ho, "ホ" },
            { JapaneseSyllable.Hou, "ホウ" },

            { JapaneseSyllable.Ba, "バ" },
            { JapaneseSyllable.Bi, "ビ" },
            { JapaneseSyllable.Bu, "ブ" },
            { JapaneseSyllable.Be, "ベ" },
            { JapaneseSyllable.Bo, "ボ" },
            { JapaneseSyllable.Bou, "ボウ" },

            { JapaneseSyllable.Pa, "パ" },
            { JapaneseSyllable.Pi, "ピ" },
            { JapaneseSyllable.Pu, "プ" },
            { JapaneseSyllable.Pe, "ペ" },
            { JapaneseSyllable.Po, "ポ" },
            { JapaneseSyllable.Pou, "ポウ" },

            { JapaneseSyllable.Ma, "マ" },
            { JapaneseSyllable.Mi, "ミ" },
            { JapaneseSyllable.Mu, "ム" },
            { JapaneseSyllable.Me, "メ" },
            { JapaneseSyllable.Mo, "モ" },
            { JapaneseSyllable.Mou, "モウ" },

            { JapaneseSyllable.Ra, "ラ" },
            { JapaneseSyllable.Ri, "リ" },
            { JapaneseSyllable.Ru, "ル" },
            { JapaneseSyllable.Re, "レ" },
            { JapaneseSyllable.Ro, "ロ" },
            { JapaneseSyllable.Rou, "ロウ" },

            { JapaneseSyllable.Ya, "ヤ" },
            { JapaneseSyllable.Yu, "ユ" },
            { JapaneseSyllable.Yo, "ヨ" },
            { JapaneseSyllable.You, "ヨウ" },

            { JapaneseSyllable.Wa, "ワ" },
            { JapaneseSyllable.Wo, "ヲ" },
            { JapaneseSyllable.N, "ン" },

            { JapaneseSyllable.Kya, "キャ" },
            { JapaneseSyllable.Kyu, "キュ" },
            { JapaneseSyllable.Kyo, "キョ" },

            { JapaneseSyllable.Gya, "ギャ" },
            { JapaneseSyllable.Gyu, "ギュ" },
            { JapaneseSyllable.Gyo, "ギョ" },

            { JapaneseSyllable.Nya, "ニャ" },
            { JapaneseSyllable.Nyu, "ニュ" },
            { JapaneseSyllable.Nyo, "ニョ" },

            { JapaneseSyllable.Hya, "ヒャ" },
            { JapaneseSyllable.Hyu, "ヒュ" },
            { JapaneseSyllable.Hyo, "ヒョ" },

            { JapaneseSyllable.Bya, "ビャ" },
            { JapaneseSyllable.Byu, "ビュ" },
            { JapaneseSyllable.Byo, "ビョ" },

            { JapaneseSyllable.Pya, "ピャ" },
            { JapaneseSyllable.Pyu, "ピュ" },
            { JapaneseSyllable.Pyo, "ピョ" },

            { JapaneseSyllable.Mya, "ミャ" },
            { JapaneseSyllable.Myu, "ミュ" },
            { JapaneseSyllable.Myo, "ミョ" },

            { JapaneseSyllable.Rya, "リャ" },
            { JapaneseSyllable.Ryu, "リュ" },
            { JapaneseSyllable.Ryo, "リョ" },

            { JapaneseSyllable.Ja, "ジャ" },
            { JapaneseSyllable.Ju, "ジュ" },
            { JapaneseSyllable.Jo, "ジョ" },

            { JapaneseSyllable.Cha, "チャ" },
            { JapaneseSyllable.Chu, "チュ" },
            { JapaneseSyllable.Cho, "チョ" },

            { JapaneseSyllable.Sha, "シャ" },
            { JapaneseSyllable.Shu, "シュ" },
            { JapaneseSyllable.Sho, "ショ" },

            { JapaneseSyllable.Kka, "ッカ" },
            { JapaneseSyllable.Kki, "ッキ" },
            { JapaneseSyllable.Kku, "ック" },
            { JapaneseSyllable.Kke, "ッケ" },
            { JapaneseSyllable.Kko, "ッコ" },

            { JapaneseSyllable.Ssa, "ッサ" },
            { JapaneseSyllable.Sshi, "ッシ" },
            { JapaneseSyllable.Ssu, "ッス" },
            { JapaneseSyllable.Sse, "ッセ" },
            { JapaneseSyllable.Sso, "ッソ" },

            { JapaneseSyllable.Tta, "ッタ" },
            { JapaneseSyllable.Cchi, "ッチ" },
            { JapaneseSyllable.Ttsu, "ッツ" },
            { JapaneseSyllable.Tte, "ッテ" },
            { JapaneseSyllable.Tto, "ット" },

            { JapaneseSyllable.Bba, "ッバ" },
            { JapaneseSyllable.Bbi, "ッビ" },
            { JapaneseSyllable.Bbu, "ッブ" },
            { JapaneseSyllable.Bbe, "ッベ" },
            { JapaneseSyllable.Bbo, "ッボ" },

            { JapaneseSyllable.Ppa, "ッパ" },
            { JapaneseSyllable.Ppi, "ッピ" },
            { JapaneseSyllable.Ppu, "ップ" },
            { JapaneseSyllable.Ppe, "ッペ" },
            { JapaneseSyllable.Ppo, "ッポ" },
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
