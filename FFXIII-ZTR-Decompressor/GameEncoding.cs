﻿using System.Collections.Generic;

namespace FFXIII_ZTR_Decompressor
{
    public static class GameEncoding
    {
        public static Dictionary<string, int> EncodingCode = new Dictionary<string, int>
        {
            { "_jp", 932 }, //Japanese (Shift-JIS)
            { "_kr", 51949 }, //Korean (EUC)
            { "_ch", 950 }, //Chinese Traditional (Big5)	
        };

        public static string[] LatinCharacters { get; } = new string[]
        {
            " ", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/",
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?", "@",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z",
            "[", "\\", "]", "^", "_", "`",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
            "v", "w", "x", "y", "z",
            "{", "|", "}", "~", null, "€", null, "‚", null, "„", "…", "†", "‡", null, "‰", "Š", "‹", "Œ", null, "Ž",
            null, null, "‘", "’", "“", "”", "•",
            "–", "—", null, "™", "š", "›", "œ", null, "ž", "Ÿ", null, "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª",
            "«", "¬", null, "®", "¯", "°", "±",
            "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "»", "¼", "½", "¾", "¿", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ",
            "Ç", "È", "É", "Ê", "Ë", "Ì", "Í",
            "Î", "Ï", "Ð", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "×", "Ø", "Ù", "Ú", "Û", "Ü", "Ý", "Þ", "ß", "à", "á", "â",
            "ã", "ä", "å", "æ", "ç", "è", "é",
            "ê", "ë", "ì", "í", "î", "ï", "ð", "ñ", "ò", "ó", "ô", "õ", "ö", "÷", "ø", "ù", "ú", "û", "ü", "ý", "þ", "ÿ"
        };

        public static Dictionary<string, byte[]> JapaneseSymbol = new Dictionary<string, byte[]>
        {
            #region SHIFT JIS Symbols
            {"{Unknown}", new byte[] { 0x81, 0x40 } }, //resident/system $pause_05a
            {"、", new byte[] { 0x81, 0x41 } },
            {"。", new byte[] { 0x81, 0x42 } },
            {"･", new byte[] { 0x81, 0x45 }},
            {"：", new byte[] { 0x81, 0x46 }},
            {"？", new byte[] { 0x81, 0x48 }},
            {"！", new byte[] { 0x81, 0x49 }},
            {"々", new byte[] { 0x81, 0x58 }},
            {"ー", new byte[] { 0x81, 0x5B }},
            {"ｰ", new byte[] { 0x81, 0x5C }},
            {"／", new byte[] { 0x81, 0x5E }},
            {"〜", new byte[] { 0x81, 0x5F }},
            //{"…", new byte[] { 0x81, 0x63 }},
            /*{"“", new byte[] { 0x81, 0x67 }},
            {"”", new byte[] { 0x81, 0x68 }},*/
            {"（", new byte[] { 0x81, 0x69 }},
            {"）", new byte[] { 0x81, 0x6A }},
            {"「", new byte[] { 0x81, 0x75 }},
            {"」", new byte[] { 0x81, 0x76 }},
            {"『", new byte[] { 0x81, 0x77 }},
            {"』", new byte[] { 0x81, 0x78 }},
            {"【", new byte[] { 0x81, 0x79 }},
            {"】", new byte[] { 0x81, 0x7A }},
            {"＋", new byte[] { 0x81, 0x7B }},
            {"－", new byte[] { 0x81, 0x7C }},
            {"{Var81 ×}", new byte[] { 0x81, 0x7E }},
            {"゠", new byte[] { 0x81, 0x81 }},
            {"＜", new byte[] { 0x81, 0x83 }},
            {"＞", new byte[] { 0x81, 0x84 }},
            {"％", new byte[] { 0x81, 0x93 }},
            {"＆", new byte[] { 0x81, 0x95 }},
            {"☆", new byte[] { 0x81, 0x99 }},
            {"★", new byte[] { 0x81, 0x9A }},
            {"○", new byte[] { 0x81, 0x9B }},
            {"◎", new byte[] { 0x81, 0x9D }},
            {"□", new byte[] { 0x81, 0xA0 }},
            {"■", new byte[] { 0x81, 0xA1 }},
            {"※", new byte[] { 0x81, 0xA6 }},
            {"→", new byte[] { 0x81, 0xA8 }},
            {"←", new byte[] { 0x81, 0xA9 }},
            {"↑", new byte[] { 0x81, 0xAA }},
            {"↓", new byte[] { 0x81, 0xAB }},

            {"①", new byte[] { 0x87, 0x40 }},
            {"②", new byte[] { 0x87, 0x41 }},
            {"③", new byte[] { 0x87, 0x42 }},
            {"④", new byte[] { 0x87, 0x43 }},
            {"⑤", new byte[] { 0x87, 0x44 }},
            {"⑥", new byte[] { 0x87, 0x45 }},
            {"⑦", new byte[] { 0x87, 0x46 }},
            {"⑧", new byte[] { 0x87, 0x47 }},
            {"⑨", new byte[] { 0x87, 0x48 }},

            {"Ⅰ", new byte[] { 0x87, 0x54 }},
            {"Ⅱ", new byte[] { 0x87, 0x55 }},
            {"Ⅲ", new byte[] { 0x87, 0x56 }},
            {"Ⅳ", new byte[] { 0x87, 0x57 }},
            {"Ⅴ", new byte[] { 0x87, 0x58 }},
            {"Ⅵ", new byte[] { 0x87, 0x59 }},
            {"Ⅶ", new byte[] { 0x87, 0x5A }},
            {"Ⅷ", new byte[] { 0x87, 0x5B }},
            {"Ⅸ", new byte[] { 0x87, 0x5C }},
            #endregion
        };
        public static Dictionary<string, byte[]> GameCode = new Dictionary<string, byte[]>
        {
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
            //{"¿", new byte[] { 0x85, 0x7F }},
            {"¿", new byte[] { 0x85, 0x80 }},
            {"À", new byte[] { 0x85, 0x9F }},
            {"Á", new byte[] { 0x85, 0x81 }},
            {"{A Acute}", new byte[] { 0x85, 0xA0 }},
            {"Â", new byte[] { 0x85, 0x82 }},
            {"{A Circumflex}", new byte[] { 0x85, 0xA1 }},
            {"Ã", new byte[] { 0x85, 0x83 }},
            {"{A Tilde}", new byte[] { 0x85, 0xA2 }},
            {"Å", new byte[] { 0x85, 0x85 }},
            {"Æ", new byte[] { 0x85, 0x86 }},
            {"{Ç}", new byte[] { 0x85, 0xA6 }},
            {"Ç", new byte[] { 0x85, 0x87 }},
            {"È", new byte[] { 0x85, 0x88 }},
            {"É", new byte[] { 0x85, 0x89 }},
            {"{E Acute}", new byte[] { 0x85, 0xA8 }},
            {"Ê", new byte[] { 0x85, 0x8A }},
            {"{E Circumflex}", new byte[] { 0x85, 0xA9 }},
            {"Ì", new byte[] { 0x85, 0x8C }},
            {"Í", new byte[] { 0x85, 0x8D }},
            {"{I Acute}", new byte[] { 0x85, 0xAC }},
            {"Î", new byte[] { 0x85, 0x8E }},
            {"Ð", new byte[] { 0x85, 0x90 }},
            {"Ñ", new byte[] { 0x85, 0x91 }},
            {"Ò", new byte[] { 0x85, 0x92 }},
            {"Ó", new byte[] { 0x85, 0x93 }},
            {"{O Acute}", new byte[] { 0x85, 0xB2 }},
            {"Ô", new byte[] { 0x85, 0x94 }},
            {"{O Circumflex}", new byte[] { 0x85, 0xB3 }},
            {"Õ", new byte[] { 0x85, 0x95 }},
            {"{O Tilde}", new byte[] { 0x85, 0xB4 }},
            {"×", new byte[] { 0x85, 0x97 }},
            {"{Multiplication Sign}", new byte[] { 0x85, 0xB6 }}, //avoid confuse
            {"Ø", new byte[] { 0x85, 0x98 }},
            {"Ù", new byte[] { 0x85, 0x99 }},
            {"Ú", new byte[] { 0x85, 0x9A }},
            {"{U Acute}", new byte[] { 0x85, 0xB9 }},
            {"Û", new byte[] { 0x85, 0x9B }},                        
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
            #region Latim Diaresis
            {"Ä", new byte[] { 0x85, 0xA3 }},
            {"Ë", new byte[] { 0x85, 0x8B }},
            {"Ï", new byte[] { 0x85, 0x8F }},
            {"Ö", new byte[] { 0x85, 0xB5 }},
            {"Ü", new byte[] { 0x85, 0xBB }},
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
            {"{VarF4 68}", new byte[] { 0xF4, 0x44 }},
            {"{VarF4 70}", new byte[] { 0xF4, 0x46 }},
            {"{VarF4 72}", new byte[] { 0xF4, 0x48 }},
            {"{VarF4 96}", new byte[] { 0xF4, 0x60 }},
            {"{VarF2 79}", new byte[] { 0xF2, 0x4F }},
            {"{VarF2 82}", new byte[] { 0xF2, 0x52 }},
            {"{VarF2 87}", new byte[] { 0xF2, 0x57 }},
            {"{VarF2 90}", new byte[] { 0xF2, 0x5A }},
            {"{VarF2 97}", new byte[] { 0xF2, 0x61 }},
            {"{VarF2 100}", new byte[] { 0xF2, 0x64 }},
            {"{VarF2 101}", new byte[] { 0xF2, 0x65 }},
            {"{VarF2 105}", new byte[] { 0xF2, 0x69 }},
            {"{VarF2 114}", new byte[] { 0xF2, 0x72 }},
            {"{VarF2 115}", new byte[] { 0xF2, 0x73 }},
            {"{VarF2 116}", new byte[] { 0xF2, 0x74 }},
            {"{VarF2 119}", new byte[] { 0xF2, 0x77 }},
            {"{VarF2 91}", new byte[] { 0xF2, 0x5B }},
            {"{VarF2 92}", new byte[] { 0xF2, 0x5C }},
            {"{VarF2 95}", new byte[] { 0xF2, 0x5F }},
            {"{VarFF 134}", new byte[] { 0xFF, 0x86 }},
            {"{VarFF 144}", new byte[] { 0xFF, 0x90 }},
            {"{VarFF 148}", new byte[] { 0xFF, 0x94 }},
            {"{VarFF 153}", new byte[] { 0xFF, 0x99 }},
            {"{VarFF 154}", new byte[] { 0xFF, 0x9A }},
            {"{VarFF 157}", new byte[] { 0xFF, 0x9D }},
            {"{VarFF 158}", new byte[] { 0xFF, 0x9E }},
            {"{VarFF 208}", new byte[] { 0xFF, 0xD0 }},
            {"{VarFF 224}", new byte[] { 0xFF, 0xE0 }},
            {"{VarFF 228}", new byte[] { 0xFF, 0xE4 }},
            {"{VarFF 255}", new byte[] { 0xFF, 0xFF }},
            {"{VarFF 241}", new byte[] { 0xFF, 0xF1 }},
            {"{VarF6 64}", new byte[] { 0xF6, 0x40 }},
            {"{VarF7 64}", new byte[] { 0xF7, 0x40 }},
            {"{VarF7 65}", new byte[] { 0xF7, 0x41 }},
            {"{VarF7 66}", new byte[] { 0xF7, 0x42 }},
            {"{Var82 80}", new byte[] { 0x82, 0x50 }},
            {"{Var82 152}", new byte[] { 0x82, 0x98 }},
            {"{Var83 182}", new byte[] { 0x83, 0xB6 }},

            #region Icons
            {"{Icon Clock}", new byte[] { 0xF0, 0x40 }},
            {"{Icon Attention}", new byte[] { 0xF0, 0x41 }},
            {"{Icon Exclamation}", new byte[] { 0xF0, 0x42 }},
            {"{Icon EmptyCirlces}", new byte[] { 0xF0, 0x43 }},
            {"{Icon Greather}", new byte[] { 0xF0, 0x44 }},
            {"{Icon Less}", new byte[] { 0xF0, 0x45 }},
            {"{Icon Doc}", new byte[] { 0xF0, 0x46 }},
            {"{Icon Ok}", new byte[] { 0xF0, 0x47 }},
            {"{Icon FilledCirlces}", new byte[] { 0xF0, 0x48 }},
            {"{Icon Gunblade}", new byte[] { 0xF0, 0x49 }},
            {"{Icon Shotgun}", new byte[] { 0xF0, 0x4A }},
            {"{Icon Weapon03}", new byte[] { 0xF0, 0x4B }},
            {"{Icon Boomerang}", new byte[] { 0xF0, 0x4C }},
            {"{Icon Rod}", new byte[] { 0xF0, 0x4D }},
            {"{Icon Glaive}", new byte[] { 0xF0, 0x4E }},
            {"{Icon AxisBlade}", new byte[] { 0xF0, 0x4F }},
            {"{Icon Katar}", new byte[] { 0xF0, 0x50 }},
            {"{Icon Weapon09}", new byte[] { 0xF0, 0x51 }},
            {"{Icon Shield01}", new byte[] { 0xF0, 0x52 }},
            {"{Icon Wrench}", new byte[] { 0xF0, 0x53 }},
            {"{Icon Note}", new byte[] { 0xF0, 0x54 }},
            {"{Icon Screw}", new byte[] { 0xF0, 0x55 }},
            {"{Icon Material01}", new byte[] { 0xF0, 0x56 }},
            {"{Icon Bracert}", new byte[] { 0xF0, 0x57 }},
            {"{Icon Ring}", new byte[] { 0xF0, 0x58 }},
            {"{Icon Earring}", new byte[] { 0xF0, 0x59 }},
            {"{Icon Brooch}", new byte[] { 0xF0, 0x5A }},
            {"{Icon Potion01}", new byte[] { 0xF0, 0x5B }},
            {"{Icon Potion02}", new byte[] { 0xF0, 0x5C }},
            {"{Icon Potion03}", new byte[] { 0xF0, 0x5D }},
            {"{Icon Feather}", new byte[] { 0xF0, 0x5E }},
            {"{Icon Cloth}", new byte[] { 0xF0, 0x5F }},
            {"{Icon Item}", new byte[] { 0xF0, 0x60 }},
            {"{Icon Eye01}", new byte[] { 0xF0, 0x61 }},
            {"{Icon Sword01}", new byte[] { 0xF0, 0x62 }},
            {"{Icon Staff01}", new byte[] { 0xF0, 0x63 }},
            {"{Icon Shield02}", new byte[] { 0xF0, 0x64 }},
            {"{Icon HealthUp}", new byte[] { 0xF0, 0x65 }},
            {"{Icon Imperial}", new byte[] { 0xF0, 0x66 }},
            {"{Icon Ugly}", new byte[] { 0xF0, 0x67 }},
            {"{Icon Rage}", new byte[] { 0xF0, 0x68 }},
            {"{Icon Provoke}", new byte[] { 0xF0, 0x69 }},
            {"{Icon Sword02}", new byte[] { 0xF0, 0x6A }},
            {"{Icon Shield03}", new byte[] { 0xF0, 0x6B }},
            {"{Icon Staff}", new byte[] { 0xF0, 0x6C }},
            {"{Icon Up}", new byte[] { 0xF0, 0x6D }},
            {"{Icon Kn}", new byte[] { 0xF0, 0x6E }},
            {"{Icon Yu}", new byte[] { 0xF0, 0x6F }},
            {"{Icon Rudder}", new byte[] { 0xF0, 0x70 }},
            {"{Icon Eye02}", new byte[] { 0xF0, 0x71 }},
            {"{Icon Ribbon}", new byte[] { 0xF0, 0x72 }},
            {"{Icon Sphere}", new byte[] { 0xF0, 0x73 }},
            {"{Icon Neck}", new byte[] { 0xF0, 0x74 }},
            #endregion
            #region Keys
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
#endregion

            {"{End}", new byte[] { 0x0 }},
            {"{Escape}", new byte[] { 0x1 }},
            {"{Italic}", new byte[] { 0x2 }},
            {"{Many}", new byte[] { 0x3 }},
            {"{Article}", new byte[] { 0x4 }},
            {"{ArticleMany}", new byte[] { 0x5 }},
            {"{Text Tab}", new byte[] { 0x85, 0x60 }}, //Unicode Character 'NO-BREAK SPACE' (U+00A0) Used on resident/system.
            {"{Text NewLine}", new byte[] { 0x40, 0x72 }},
            {"{Text NewPage}", new byte[] { 0x40, 0x70 }}
        };
    }
}
