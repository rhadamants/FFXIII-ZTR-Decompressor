﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFXIII_ZTR_Decompressor
{
    public class GameEncoding
    {
        private static Dictionary<string, byte[]> _Instance;
        private static readonly string[] _JapaneseSymbols = new string[]
        {
            " ", "、", "。", null, null, "・", "：", null, "？", "！",
            null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,
            "々", null, null, "ー", "ｰ", null, null /*Slash*/, null, "〜", null, null, null, "…", null, null, null, "“", "”", "（", "）",
            null, null, null, null, null, null, null, null, null, null,
            "「", "」", "『", "』", "【", "】", null /*Plus*/, null /*Minus*/, null, null /*Multiplication*/, null, null, "゠", null, null /*Less-than*/, null /*Greater-than*/,
            null, null, null, null, null, null, null, null, null, null, null, null, null, null,
            "％", null, "＆", null, null, null, "☆", "★", "⭘", null, "⭗", null, null, "⬜", "⬛", null, null,
            "※", null, "→", "←", "↑", "↓",

        };
        private static readonly string[] _LatinCharacters = new string[]
        {
            " ", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/",
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?", "@",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
            "[", "\\", "]", "^", "_", "`",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "{", "|", "}", "~", null, "€", null, "‚", null, "„", "…", "†", "‡", null, "‰", "Š", "‹", "Œ", null, "Ž", null, null, "‘", "’", "“", "”", "•",
            "–", "—", null, "™", "š", "›", "œ", null, "ž", "Ÿ", null, "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "¬", null, "®", "¯", "°", "±",
            "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í",
            "Î", "Ï", "Ð", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "Ý", "Þ", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é",
            "ê", "ë", "ì", "í", "î", "ï", "ð", "ñ", "ò", "ó", "ô", "õ", "ö", "÷", "ø", "ù", "ú", "û", "ü", "ý", "þ", "ÿ"
        };
        public static Dictionary<string, byte[]> _JapaneseCode = new Dictionary<string, byte[]>()
        {
            
        };
        public static Dictionary<string, byte[]> _GameCode = new Dictionary<string, byte[]>
        {
            #region Japanese Symobols
            {"、", new byte[] { 0x81, 0x41 } },
            {"。", new byte[] { 0x81, 0x42 } },
            {"･", new byte[] { 0x81, 0x45 }},
            {"：", new byte[] { 0x81, 0x46 }},
            {"？", new byte[] { 0x81, 0x48 }},
            {"！", new byte[] { 0x81, 0x49 }},
            {"々", new byte[] { 0x81, 0x58 }},
            {"ー", new byte[] { 0x81, 0x5B }},
            {"ｰ", new byte[] { 0x81, 0x5C }},
            /*{"/", new byte[] { 0x81, 0x5E }},*/
            {"〜", new byte[] { 0x81, 0x5F }},
            {"…", new byte[] { 0x81, 0x63 }},
            {"“", new byte[] { 0x81, 0x67 }},
            {"”", new byte[] { 0x81, 0x68 }},
            {"（", new byte[] { 0x81, 0x69 }},
            {"）", new byte[] { 0x81, 0x6A }},
            {"「", new byte[] { 0x81, 0x75 }},
            {"」", new byte[] { 0x81, 0x76 }},
            {"『", new byte[] { 0x81, 0x77 }},
            {"』", new byte[] { 0x81, 0x78 }},
            {"【", new byte[] { 0x81, 0x79 }},
            {"】", new byte[] { 0x81, 0x7A }},
            /*{"+", new byte[] { 0x81, 0x7B }},
            {"-", new byte[] { 0x81, 0x7C }},
            {"×", new byte[] { 0x81, 0x7E }},*/
            {"゠", new byte[] { 0x81, 0x81 }},
            /*{"<", new byte[] { 0x81, 0x83 }},
            {">", new byte[] { 0x81, 0x84 }},*/
            {"％", new byte[] { 0x81, 0x93 }},
            {"＆", new byte[] { 0x81, 0x95 }},
            {"☆", new byte[] { 0x81, 0x99 }},
            {"★", new byte[] { 0x81, 0x9A }},
            {"⭘", new byte[] { 0x81, 0x9B }},
            {"⭗", new byte[] { 0x81, 0x9D }},
            {"⬜", new byte[] { 0x81, 0xA0 }},
            {"⬛", new byte[] { 0x81, 0xA1 }},
            {"※", new byte[] { 0x81, 0xA4 }},
            {"→", new byte[] { 0x81, 0xA6 }},
            {"←", new byte[] { 0x81, 0xA7 }},
            {"↑", new byte[] { 0x81, 0xA8 }},
            {"↓", new byte[] { 0x81, 0xA9 }},
            #endregion
            #region Latin Characters (ASCII)
            {"€", new byte[] { 0x85, 0x40 }},
            {"‚", new byte[] { 0x85, 0x42 }},
            {"„", new byte[] { 0x85, 0x44 }},
            {"…", new byte[] { 0x85, 0x45 }},
            {"†", new byte[] { 0x85, 0x46 }},
            {"‡", new byte[] { 0x85, 0x47 }},
            {"‰", new byte[] { 0x85, 0x49 }},
            {"Š", new byte[] { 0x85, 0x4A }},
            {"‹", new byte[] { 0x85, 0x4B }},
            {"Œ", new byte[] { 0x85, 0x4C }},
            {"Ž", new byte[] { 0x85, 0x4E }},
            {"‘", new byte[] { 0x85, 0x51 }},
            {"’", new byte[] { 0x85, 0x52 }},
            {"“", new byte[] { 0x85, 0x53 }},
            {"”", new byte[] { 0x85, 0x54 }},
            {"•", new byte[] { 0x85, 0x55 }},
            {"-", new byte[] { 0x85, 0x56 }},
            {"—", new byte[] { 0x85, 0x57 }},
            {"™", new byte[] { 0x85, 0x59 }},
            {"š", new byte[] { 0x85, 0x5A }},
            {"›", new byte[] { 0x85, 0x5B }},
            {"œ", new byte[] { 0x85, 0x5C }},
            {"ž", new byte[] { 0x85, 0x5E }},
            {"Ÿ", new byte[] { 0x85, 0x5F }},
            {"¡", new byte[] { 0x85, 0x61 }},
            {"¢", new byte[] { 0x85, 0x62 }},
            {"£", new byte[] { 0x85, 0x63 }},
            {"¤", new byte[] { 0x85, 0x64 }},
            {"¥", new byte[] { 0x85, 0x65 }},
            {"¦", new byte[] { 0x85, 0x66 }},
            {"§", new byte[] { 0x85, 0x67 }},
            {"¨", new byte[] { 0x85, 0x68 }},
            {"©", new byte[] { 0x85, 0x69 }},
            {"ª", new byte[] { 0x85, 0x6A }},
            {"«", new byte[] { 0x85, 0x6B }},
            {"¬", new byte[] { 0x85, 0x6C }},
            {"®", new byte[] { 0x85, 0x6E }},
            {"¯", new byte[] { 0x85, 0x6F }},
            {"°", new byte[] { 0x85, 0x70 }},
            {"±", new byte[] { 0x85, 0x71 }},
            {"²", new byte[] { 0x85, 0x72 }},
            {"³", new byte[] { 0x85, 0x73 }},
            {"´", new byte[] { 0x85, 0x74 }},
            {"µ", new byte[] { 0x85, 0x75 }},
            {"¶", new byte[] { 0x85, 0x76 }},
            {"·", new byte[] { 0x85, 0x77 }},
            {"¸", new byte[] { 0x85, 0x78 }},
            {"¹", new byte[] { 0x85, 0x79 }},
            {"º", new byte[] { 0x85, 0x7A }},
            {"»", new byte[] { 0x85, 0x7B }},
            {"¼", new byte[] { 0x85, 0x7C }},
            {"½", new byte[] { 0x85, 0x7D }},
            {"¾", new byte[] { 0x85, 0x7E }},
            {"¿", new byte[] { 0x85, 0x7F }},
            {"À", new byte[] { 0x85, 0x9F }},
            {"Á", new byte[] { 0x85, 0x81 }},
            {"Â", new byte[] { 0x85, 0x82 }},
            {"Ã", new byte[] { 0x85, 0x83 }},
            {"Ä", new byte[] { 0x85, 0x84 }},
            {"Å", new byte[] { 0x85, 0x85 }},
            {"Æ", new byte[] { 0x85, 0x86 }},
            //{"Ç", new byte[] { 0x85, 0xA6 }},
            {"Ç", new byte[] { 0x85, 0x87 }},
            {"È", new byte[] { 0x85, 0x88 }},
            {"É", new byte[] { 0x85, 0x89 }},
            {"Ê", new byte[] { 0x85, 0x8A }},
            {"Ë", new byte[] { 0x85, 0x8B }},
            {"Ì", new byte[] { 0x85, 0x8C }},
            {"Í", new byte[] { 0x85, 0x8D }},
            {"Î", new byte[] { 0x85, 0x8E }},
            {"Ï", new byte[] { 0x85, 0x8F }},
            {"Ð", new byte[] { 0x85, 0x90 }},
            {"Ñ", new byte[] { 0x85, 0x91 }},
            {"Ò", new byte[] { 0x85, 0x92 }},
            {"Ó", new byte[] { 0x85, 0x93 }},
            {"Ô", new byte[] { 0x85, 0x94 }},
            {"Õ", new byte[] { 0x85, 0x95 }},
            {"Ö", new byte[] { 0x85, 0x96 }},
            {"×", new byte[] { 0x85, 0x97 }},
            {"Ø", new byte[] { 0x85, 0x98 }},
            {"Ù", new byte[] { 0x85, 0x99 }},
            {"Ú", new byte[] { 0x85, 0x9A }},
            {"Û", new byte[] { 0x85, 0x9B }},
            {"Ü", new byte[] { 0x85, 0x9C }},
            {"Ý", new byte[] { 0x85, 0x9D }},
            {"Þ", new byte[] { 0x85, 0xBD }},
            {"ß", new byte[] { 0x85, 0xBE }},
            {"à", new byte[] { 0x85, 0xBF }},
            {"á", new byte[] { 0x85, 0xC0 }},
            {"â", new byte[] { 0x85, 0xC1 }},
            {"ã", new byte[] { 0x85, 0xC2 }},
            {"ä", new byte[] { 0x85, 0xC3 }},
            {"å", new byte[] { 0x85, 0xC4 }},
            {"æ", new byte[] { 0x85, 0xC5 }},
            {"ç", new byte[] { 0x85, 0xC6 }},
            {"è", new byte[] { 0x85, 0xC7 }},
            {"é", new byte[] { 0x85, 0xC8 }},
            {"ê", new byte[] { 0x85, 0xC9 }},
            {"ë", new byte[] { 0x85, 0xCA }},
            {"ì", new byte[] { 0x85, 0xCB }},
            {"í", new byte[] { 0x85, 0xCC }},
            {"î", new byte[] { 0x85, 0xCD }},
            {"ï", new byte[] { 0x85, 0xCE }},
            {"ð", new byte[] { 0x85, 0xCF }},
            {"ñ", new byte[] { 0x85, 0xD0 }},
            {"ò", new byte[] { 0x85, 0xD1 }},
            {"ó", new byte[] { 0x85, 0xD2 }},
            {"ô", new byte[] { 0x85, 0xD3 }},
            {"õ", new byte[] { 0x85, 0xD4 }},
            {"ö", new byte[] { 0x85, 0xD5 }},
            {"÷", new byte[] { 0x85, 0xD6 }},
            {"ø", new byte[] { 0x85, 0xD7 }},
            {"ù", new byte[] { 0x85, 0xD8 }},
            {"ú", new byte[] { 0x85, 0xD9 }},
            {"û", new byte[] { 0x85, 0xDA }},
            {"ü", new byte[] { 0x85, 0xDB }},
            {"ý", new byte[] { 0x85, 0xDC }},
            {"þ", new byte[] { 0x85, 0xDD }},
            {"ÿ", new byte[] { 0x85, 0xDE }},
            #endregion
            #region Colors
            {"{Color SkyBlue}", new byte[] { 0xF9, 0x40 }},
            {"{Color BlizzardBlue}", new byte[] { 0xF9, 0x41 }},
            {"{Color Gold}", new byte[] { 0xF9, 0x42 }},
            {"{Color Red}", new byte[] { 0xF9, 0x43 }},
            {"{Color Yellow}", new byte[] { 0xF9, 0x44 }},
            {"{Color Green}", new byte[] { 0xF9, 0x45 }},
            {"{Color White}", new byte[] { 0xF9, 0x46 }},
            {"{Color Sand}", new byte[] { 0xF9, 0x47 }},
            {"{Color Rose}", new byte[] { 0xF9, 0x48 }},
            {"{Color Purple}", new byte[] { 0xF9, 0x49 }},
            {"{Color SandOrange}", new byte[] { 0xF9, 0x4A }},
            {"{Color WhiteGray}", new byte[] { 0xF9, 0x4B }},
            {"{Color WhitePurple}", new byte[] { 0xF9, 0x4C }},
            {"{Color WhiteGreen}", new byte[] { 0xF9, 0x4D }},
            {"{Color Transparent}", new byte[] { 0xF9, 0x4E }},
            {"{Color CyanDark}", new byte[] { 0xF9, 0x4F }},
            {"{Color OrangeViolet}", new byte[] { 0xF9, 0x50 }},
            {"{Color RoseWhite}", new byte[] { 0xF9, 0x51 }},
            //{"{Color RoseWite}", new byte[] { 0xF9, 0x51 }}, //typo?
            {"{Color OliveDark}", new byte[] { 0xF9, 0x52 }},
            {"{Color GreenDark}", new byte[] { 0xF9, 0x53 }},
            {"{Color GrayDark}", new byte[] { 0xF9, 0x54 }},
            {"{Color GoldDark}", new byte[] { 0xF9, 0x55 }},
            {"{Color RedDark}", new byte[] { 0xF9, 0x56 }},
            {"{Color PurpleDark}", new byte[] { 0xF9, 0x57 }},
            {"{Color RoseDark}", new byte[] { 0xF9, 0x58 }},
            {"{Color SmokeDark}", new byte[] { 0xF9, 0x59 }},
            #endregion

            {"{VarF4 64}", new byte[] { 0xF4, 0x40 }},
            {"{VarF4 65}", new byte[] { 0xF4, 0x41 }},
            {"{VarF4 66}", new byte[] { 0xF4, 0x42 }},
            {"{VarF4 67}", new byte[] { 0xF4, 0x43 }},
            {"{VarF2 90}", new byte[] { 0xF2, 0x5A }},
            {"{VarF2 114}", new byte[] { 0xF2, 0x72 }},
            {"{VarF2 116}", new byte[] { 0xF2, 0x74 }},
            {"{VarF2 91}", new byte[] { 0xF2, 0x5B }},
            {"{VarF2 92}", new byte[] { 0xF2, 0x5C }},
            {"{VarF2 95}", new byte[] { 0xF2, 0x5F }},
            {"{VarFF 208}", new byte[] { 0xFF, 0xD0 }},
            {"{VarFF 255}", new byte[] { 0xFF, 0xFF }},
            {"{VarFF 241}", new byte[] { 0xFF, 0xF1 }},
            {"{VarF7 64}", new byte[] { 0xF7, 0x40 }},
            {"{VarF7 65}", new byte[] { 0xF7, 0x41 }},
            {"{VarF6 64}", new byte[] { 0xF6, 0x40 }},
            {"{Var83 182}", new byte[] { 0x83, 0xB6 }},

            {"{Icon Eye01}", new byte[] { 0xF0, 0x61 }},
            {"{Icon Gunblade}", new byte[] { 0xF0, 0x49 }},
            {"{Icon Boomerang}", new byte[] { 0xF0, 0x4C }},
            {"{Icon Wrench}", new byte[] { 0xF0, 0x53 }},
            {"{Icon Ring}", new byte[] { 0xF0, 0x58 }},
            {"{Icon Bracert}", new byte[] { 0xF0, 0x57 }},
            {"{Icon Material01}", new byte[] { 0xF0, 0x56 }},
            {"{Icon Screw}", new byte[] { 0xF0, 0x55 }},
            {"{Icon Note}", new byte[] { 0xF0, 0x54 }},
            {"{Icon Attention}", new byte[] { 0xF0, 0x41 }},
            {"{Icon Doc}", new byte[] { 0xF0, 0x46 }},
            {"{Icon Earring}", new byte[] { 0xF0, 0x59 }},
            {"{Icon Brooch}", new byte[] { 0xF0, 0x5A }},
            {"{Icon Shotgun}", new byte[] { 0xF0, 0x4A }},
            {"{Icon Exclamation}", new byte[] { 0xF0, 0x42 }},
            {"{Icon Clock}", new byte[] { 0xF0, 0x40 }},
            {"{Icon EmptyCirlces}", new byte[] { 0xF0, 0x43 }},
            {"{Icon Greather}", new byte[] { 0xF0, 0x44 }},
            {"{Icon Less}", new byte[] { 0xF0, 0x45 }},
            {"{Icon Ok}", new byte[] { 0xF0, 0x47 }},
            {"{Icon FilledCirlces}", new byte[] { 0xF0, 0x48 }},

            {"{Key Cross}", new byte[] { 0xF1, 0x40 }},
            {"{Key Circle}", new byte[] { 0xF1, 0x41 }},
            {"{Key Square}", new byte[] { 0xF1, 0x42 }},
            {"{Key Triangle}", new byte[] { 0xF1, 0x43 }},
            {"{Key Start}", new byte[] { 0xF1, 0x44 }},
            {"{Key Select}", new byte[] { 0xF1, 0x45 }},
            {"{Key L1}", new byte[] { 0xF1, 0x46 }},
            {"{Key R1}", new byte[] { 0xF1, 0x47 }},
            {"{Key L2}", new byte[] { 0xF1, 0x48 }},
            {"{Key R2}", new byte[] { 0xF1, 0x49 }},
            {"{Key Left}", new byte[] { 0xF1, 0x4A }},
            {"{Key Down}", new byte[] { 0xF1, 0x4B }},
            {"{Key Right}", new byte[] { 0xF1, 0x4C }},
            {"{Key Up}", new byte[] { 0xF1, 0x4D }},
            {"{Key LSLeft}", new byte[] { 0xF1, 0x4E }},
            {"{Key LSDown}", new byte[] { 0xF1, 0x4F }},
            {"{Key LSRight}", new byte[] { 0xF1, 0x50 }},
            {"{Key LSUp}", new byte[] { 0xF1, 0x51 }},
            {"{Key LSLeftRight}", new byte[] { 0xF1, 0x52 }},
            {"{Key LSLSUpDow}", new byte[] { 0xF1, 0x53 }},
            {"{Key LSPress}", new byte[] { 0xF1, 0x54 }},
            {"{Key RSPress}", new byte[] { 0xF1, 0x55 }},
            {"{Key RSLeft}", new byte[] { 0xF1, 0x56 }},
            {"{Key RSDown}", new byte[] { 0xF1, 0x57 }},
            {"{Key RSRight}", new byte[] { 0xF1, 0x58 }},
            {"{Key RSUp}", new byte[] { 0xF1, 0x59 }},
            {"{Key DPad}", new byte[] { 0xF1, 0x5A }},
            {"{Key Analog}", new byte[] { 0xF1, 0x5B }},
            {"{Key LStick}", new byte[] { 0xF1, 0x5C }},
            {"{Key NPad}", new byte[] { 0xF1, 0x5D }},
            {"{Key LeftRightAnalogic}", new byte[] { 0xF1, 0x5E }},
            {"{Key LeftRightPad}", new byte[] { 0xF1, 0x5F }},
            {"{Key Arrows}", new byte[] { 0xF1, 0x60 }},
            {"{Key PadLeft}", new byte[] { 0xF1, 0x61 }},

            {"{End}", new byte[] { 0x0 }},
            {"{Escape}", new byte[] { 0x1 }},
            {"{Italic}", new byte[] { 0x2 }},
            {"{Many}", new byte[] { 0x3 }},
            {"{Article}", new byte[] { 0x4 }},
            {"{ArticleMany}", new byte[] { 0x5 }},
            {"{Text NewLine}", new byte[] { 0x40, 0x72 }},
            {"{Text NewPage}", new byte[] { 0x40, 0x70 }}
        };
    }
}
