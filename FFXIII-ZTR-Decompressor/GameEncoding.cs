﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIII_ZTR_Decompressor
{
    public class GameEncoding
    {
        private static Dictionary<string, byte[]> _Instance;
        private static Dictionary<string, byte[]> Instance()
        {
            Dictionary<string, byte[]> gameCode = new Dictionary<string, byte[]>
            {
                {"—", new byte[] {0x85, 0x57}},
                {"®", new byte[] {0x85, 0x6E}},
                {"á", new byte[] { 0x85, 0xC0 }},
                {"à", new byte[] { 0x85, 0xBF }},
                {"â", new byte[] { 0x85, 0xC1 }},
                {"ã", new byte[] { 0x85, 0xC2 }},
                {"è", new byte[] { 0x85, 0xC7 }},
                {"é", new byte[] { 0x85, 0xC8 }},
                {"ê", new byte[] { 0x85, 0xC9 }},
                {"í", new byte[] { 0x85, 0xCC }},
                {"î", new byte[] { 0x85, 0xCD }},
                {"ï", new byte[] { 0x85, 0xCE }},
                {"ó", new byte[] { 0x85, 0xD2 }},
                {"ô", new byte[] { 0x85, 0xD3 }},
                {"õ", new byte[] { 0x85, 0xD4 }},
                {"ú", new byte[] { 0x85, 0xD9 }},
                {"û", new byte[] { 0x85, 0xDA }},
                {"ç", new byte[] { 0x85, 0xC6 }},
                {"À", new byte[] { 0x85, 0x9F }},
                {"Á", new byte[] { 0x85, 0xA0 }},
                {"Â", new byte[] { 0x85, 0xA1 }},
                {"Ã", new byte[] { 0x85, 0xA2 }},
                {"É", new byte[] { 0x85, 0xA8 }},
                {"Ê", new byte[] { 0x85, 0xA9 }},
                {"Í", new byte[] { 0x85, 0xAC }},
                {"Ó", new byte[] { 0x85, 0xB2 }},
                {"Ô", new byte[] { 0x85, 0xB3 }},
                {"Õ", new byte[] { 0x85, 0xB4 }},
                {"Ú", new byte[] { 0x85, 0xB9 }},
                {"Ç", new byte[] { 0x85, 0xA6 }},
                {"œ", new byte[] { 0x85, 0x5C }},
                {"«", new byte[] { 0x85, 0x6B }},
                {"»", new byte[] { 0x85, 0x7B }},
                {"「", new byte[] { 0x81, 0x75 }},
                {"」", new byte[] { 0x81, 0x76 }},
                {"･", new byte[] { 0x81, 0x45 }},
                {"★", new byte[] { 0x81, 0x9A }},
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
                {"{Color CyanDark}", new byte[] { 0xF9, 0x4f }},
                {"{Color OrangeViolet}", new byte[] { 0xF9, 0x50 }},
                {"{Color RoseWite}", new byte[] { 0xF9, 0x51 }},
                {"{Color OliveDark}", new byte[] { 0xF9, 0x52 }},
                {"{Color GreenDark}", new byte[] { 0xF9, 0x53 }},
                {"{Color GrayDark}", new byte[] { 0xF9, 0x54 }},
                {"{Color GoldDark}", new byte[] { 0xF9, 0x55 }},
                {"{Color RedDark}", new byte[] { 0xF9, 0x56 }},
                {"{Color PurpleDark}", new byte[] { 0xF9, 0x57 }},
                {"{Color RoseDark}", new byte[] { 0xF9, 0x58 }},
                {"{Color SmokeDark}", new byte[] { 0xF9, 0x59 }},
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

            return gameCode;

        }
        public static Dictionary<string, byte[]> GetGameCode()
        {
            if (_Instance == null)
            {
                _Instance = Instance();
            }
            return _Instance;
        }
    }
}
