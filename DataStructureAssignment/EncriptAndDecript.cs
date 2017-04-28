using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAssignment
{
    public class EncriptAndDecript
    {
        public static string Encript(string Text)
        {
            string EncriptText="";
            string TextEncripted;
            for (int i = 0; i < Text.Length; i++)
            {
                #region switch
                switch (Text[i])
                {
                    case '!' : TextEncripted = "MpBp";
                        break;
                    case '@':
                        TextEncripted = "BoMH";
                        break;
                    case '#':
                        TextEncripted = "TCnM";
                        break;
                    case '$':
                        TextEncripted = "VHeu";
                        break;
                    case '%':
                        TextEncripted = "CHVM";
                        break;
                    case '^':
                        TextEncripted = "MTVp";
                        break;
                    case '&':
                        TextEncripted = "IjIp";
                        break;
                    case '*':
                        TextEncripted = "HjCM";
                        break;
                    case '(':
                        TextEncripted = "jBVo";
                        break;
                    case ')':
                        TextEncripted = "nVak";
                        break;
                    case '+':
                        TextEncripted = "MAII";
                        break;
                    case '=':
                        TextEncripted = "Bsdj";
                        break;
                    case '_':
                        TextEncripted = "SEIH";
                        break;
                    case '-':
                        TextEncripted = "YAqo";
                        break;
                    case '0':
                        TextEncripted = "TYBj";
                        break;
                    case '9':
                        TextEncripted = "gATk";
                        break;
                    case '8':
                        TextEncripted = "eHko";
                        break;
                    case '7':
                        TextEncripted = "Xkno ";
                        break;
                    case '6':
                        TextEncripted = "zCXM";
                        break;
                    case '5':
                        TextEncripted = "SEdM";
                        break;
                    case '4':
                        TextEncripted = "eQkM";
                        break;
                    case '3':
                        TextEncripted = "qIBH";
                        break;
                    case '2':
                        TextEncripted = "aIXI";
                        break;
                    case '1':
                        TextEncripted = "dCTk";
                        break;
                    case '`':
                        TextEncripted = "eogj";
                        break;
                    case '~':
                        TextEncripted = "fZIj";
                        break;
                    case 'q':
                        TextEncripted = "BBXp";
                        break;
                    case 'w':
                        TextEncripted = "nHqp";
                        break;
                    case 'e':
                        TextEncripted = "jQTp";
                        break;
                    case 'r':
                        TextEncripted = "BnVI";
                        break;
                    case 't':
                        TextEncripted = "CnIH";
                        break;
                    case 'y':
                        TextEncripted = "fnnu";
                        break;
                    case 'u':
                        TextEncripted = "YjVj";
                        break;
                    case 'i':
                        TextEncripted = "RoRI";
                        break;
                    case 'o':
                        TextEncripted = "akfj";
                        break;
                    case 'p':
                        TextEncripted = "WCCo";
                        break;
                    case '[':
                        TextEncripted = "SIIj";
                        break;
                    case ']':
                        TextEncripted = "eVfp";
                        break;
                    case '\\':
                        TextEncripted = "gkXo";
                        break;
                    case '\'':
                        TextEncripted = "VsCI";
                        break;
                    case ';':
                        TextEncripted = "gVfp";
                        break;
                    case 'l':
                        TextEncripted = "zffI";
                        break;
                    case 'k':
                        TextEncripted = "Xufp";
                        break;
                    case 'j':
                        TextEncripted = "VQno";
                        break;
                    case 'h':
                        TextEncripted = "Tnfk";
                        break;
                    case 'g':
                        TextEncripted = "nTdH";
                        break;
                    case 'f':
                        TextEncripted = "jVku";
                        break;
                    case 'd':
                        TextEncripted = "uZfM";
                        break;
                    case 's':
                        TextEncripted = "gQdu";
                        break;
                    case 'a':
                        TextEncripted = "fsfH";
                        break;
                    case 'z':
                        TextEncripted = "kVgH";
                        break;
                    case 'x':
                        TextEncripted = "BkkM";
                        break;
                    case 'c':
                        TextEncripted = "Xsnp";
                        break;
                    case 'v':
                        TextEncripted = "YfVu";
                        break;
                    case 'b':
                        TextEncripted = "BMCH";
                        break;
                    case 'n':
                        TextEncripted = "HMek";
                        break;
                    case 'm':
                        TextEncripted = "zjfu";
                        break;
                    case ',':
                        TextEncripted = "SsCI";
                        break;
                    case '.':
                        TextEncripted = "ewCH";
                        break;
                    case '/':
                        TextEncripted = "qpfI";
                        break;
                    case 'Z':
                        TextEncripted = "eARH";
                        break;
                    case 'X':
                        TextEncripted = "nEfk";
                        break;
                    case 'C':
                        TextEncripted = "nZBH";
                        break;
                    case 'V':
                        TextEncripted = "HHRo";
                        break;
                    case 'B':
                        TextEncripted = "VjnH";
                        break;
                    case 'N':
                        TextEncripted = "zVRu";
                        break;
                    case 'M':
                        TextEncripted = "WHCp";
                        break;
                    case '<':
                        TextEncripted = "dfeo";
                        break;
                    case '>':
                        TextEncripted = "YsRk";
                        break;
                    case '?':
                        TextEncripted = "MVRu";
                        break;
                    case 'A':
                        TextEncripted = "IsXp";
                        break;
                    case 'S':
                        TextEncripted = "Xpdk";
                        break;
                    case 'D':
                        TextEncripted = "fgfu";
                        break;
                    case 'F':
                        TextEncripted = "TEBo";
                        break;
                    case 'G':
                        TextEncripted = "SYRo";
                        break;
                    case 'H':
                        TextEncripted = "euCj";
                        break;
                    case 'J':
                        TextEncripted = "fQCk";
                        break;
                    case 'K':
                        TextEncripted = "IoBM";
                        break;
                    case 'L':
                        TextEncripted = "jggk";
                        break;
                    case ':':
                        TextEncripted = "dwBI";
                        break;
                    case '"':
                        TextEncripted = "Yuak";
                        break;
                    case '|':
                        TextEncripted = "fCRH";
                        break;
                    case '}':
                        TextEncripted = "IneH";
                        break;
                    case '{':
                        TextEncripted = "TkgI";
                        break;
                    case 'P':
                        TextEncripted = "eInI";
                        break;
                    case 'O':
                        TextEncripted = "zCkH";
                        break;
                    case 'I':
                        TextEncripted = "HBYM";
                        break;
                    case 'U':
                        TextEncripted = "eTVp";
                        break;
                    case 'Y':
                        TextEncripted = "eCkH";
                        break;
                    case 'T':
                        TextEncripted = "doaM";
                        break;
                    case 'R':
                        TextEncripted = "qQTp";
                        break;
                    case 'E':
                        TextEncripted = "zTVp";
                        break;
                    case 'W':
                        TextEncripted = "epBp";
                        break;
                    case 'Q':
                        TextEncripted = "Hpnj";
                        break;
                    default: TextEncripted = Text[i].ToString();
                        break;
                }
                #endregion
                EncriptText = EncriptText + TextEncripted;
            }

            return EncriptText;
        }

        public static string Decript(string Text)
        {
            string DecriptText = "";
            string TextDecripted;
            int QuantityText= Text.Length/4;
            int j = 0;
            for (int i = 0; i < QuantityText; i++)
            {
                string TextCut = Text.Substring(j,4);
                #region switch
                switch (TextCut)
                {
                    case "MpBp":
                        TextDecripted = "!";
                        break;
                    case "BoMH":
                        TextDecripted = "@";
                        break;
                    case "TCnM":
                        TextDecripted = "#";
                        break;
                    case "VHeu":
                        TextDecripted = "$";
                        break;
                    case "CHVM":
                        TextDecripted = "%";
                        break;
                    case "MTVp":
                        TextDecripted = "^";
                        break;
                    case "IjIp":
                        TextDecripted = "&";
                        break;
                    case "HjCM":
                        TextDecripted = "*";
                        break;
                    case "jBVo":
                        TextDecripted = "(";
                        break;
                    case "nVak":
                        TextDecripted = ")";
                        break;
                    case "MAII":
                        TextDecripted = "+";
                        break;
                    case "SEIH":
                        TextDecripted = "_";
                        break;
                    case "Bsdj":
                        TextDecripted = "=";
                        break;
                    case "YAqo":
                        TextDecripted = "-";
                        break;
                    case "TYBj":
                        TextDecripted = "0";
                        break;
                    case "gATk":
                        TextDecripted = "9";
                        break;
                    case "eHko":
                        TextDecripted = "8";
                        break;
                    case "Xkno":
                        TextDecripted = "7";
                        break;
                    case "zCXM":
                        TextDecripted = "6";
                        break;
                    case "SEdM":
                        TextDecripted = "5";
                        break;
                    case "eQkM":
                        TextDecripted = "4";
                        break;
                    case "qIBH":
                        TextDecripted = "3";
                        break;
                    case "aIXI":
                        TextDecripted = "2";
                        break;
                    case "dCTk":
                        TextDecripted = "1";
                        break;
                    case "eogj":
                        TextDecripted = "`";
                        break;
                    case "fZIj":
                        TextDecripted = "~";
                        break;
                    case "BBXp":
                        TextDecripted = "q";
                        break;
                    case "nHqp":
                        TextDecripted = "w";
                        break;
                    case "jQTp":
                        TextDecripted = "e";
                        break;
                    case "BnVI":
                        TextDecripted = "r";
                        break;
                    case "CnIH":
                        TextDecripted = "t";
                        break;
                    case "fnnu":
                        TextDecripted = "y";
                        break;
                    case "YjVj":
                        TextDecripted = "u";
                        break;
                    case "RoRI":
                        TextDecripted = "i";
                        break;
                    case "akfj":
                        TextDecripted = "o";
                        break;
                    case "WCCo":
                        TextDecripted = "p";
                        break;
                    case "SIIj":
                        TextDecripted = "[";
                        break;
                    case "eVfp":
                        TextDecripted = "]";
                        break;
                    case "gkXo":
                        TextDecripted = "\\";
                        break;
                    case "VsCI":
                        TextDecripted = "'";
                        break;
                    case "gVfp":
                        TextDecripted = ";";
                        break;
                    case "zffI":
                        TextDecripted = "l";
                        break;
                    case "Xufp":
                        TextDecripted = "k";
                        break;
                    case "VQno":
                        TextDecripted = "j";
                        break;
                    case "Tnfk":
                        TextDecripted = "h";
                        break;
                    case "nTdH":
                        TextDecripted = "g";
                        break;
                    case "jVku":
                        TextDecripted = "f";
                        break;
                    case "uZfM":
                        TextDecripted = "d";
                        break;
                    case "gQdu":
                        TextDecripted = "s";
                        break;
                    case "fsfH":
                        TextDecripted = "a";
                        break;
                    case "kVgH":
                        TextDecripted = "z";
                        break;
                    case "BkkM":
                        TextDecripted = "x";
                        break;
                    case "Xsnp":
                        TextDecripted = "c";
                        break;
                    case "YfVu":
                        TextDecripted = "v";
                        break;
                    case "BMCH":
                        TextDecripted = "b";
                        break;
                    case "HMek":
                        TextDecripted = "n";
                        break;
                    case "zjfu":
                        TextDecripted = "m";
                        break;
                    case "SsCI":
                        TextDecripted = ",";
                        break;
                    case "ewCH":
                        TextDecripted = ".";
                        break;
                    case "qpfI":
                        TextDecripted = "/";
                        break;
                    case "eARH":
                        TextDecripted = "Z";
                        break;
                    case "nEfk":
                        TextDecripted = "X";
                        break;
                    case "nZBH":
                        TextDecripted = "C";
                        break;
                    case "HHRo":
                        TextDecripted = "V";
                        break;
                    case "VjnH":
                        TextDecripted = "B";
                        break;
                    case "zVRu":
                        TextDecripted = "N";
                        break;
                    case "WHCp":
                        TextDecripted = "M";
                        break;
                    case "dfeo":
                        TextDecripted = "<";
                        break;
                    case "YsRk":
                        TextDecripted = ">";
                        break;
                    case "MVRu":
                        TextDecripted = "?";
                        break;
                    case "IsXp":
                        TextDecripted = "A";
                        break;
                    case "Xpdk":
                        TextDecripted = "S";
                        break;
                    case "fgfu":
                        TextDecripted = "D";
                        break;
                    case "TEBo":
                        TextDecripted = "F";
                        break;
                    case "SYRo":
                        TextDecripted = "G";
                        break;
                    case "euCj":
                        TextDecripted = "H";
                        break;
                    case "fQCk":
                        TextDecripted = "J";
                        break;
                    case "IoBM":
                        TextDecripted = "K";
                        break;
                    case "jggk":
                        TextDecripted = "L";
                        break;
                    case "dwBI":
                        TextDecripted = ":";
                        break;
                    case "Yuak":
                        TextDecripted = "\"";
                        break;
                    case "fCRH":
                        TextDecripted = "|";
                        break;
                    case "IneH":
                        TextDecripted = "}";
                        break;
                    case "TkgI":
                        TextDecripted = "{";
                        break;
                    case "eInI":
                        TextDecripted = "P";
                        break;
                    case "zCkH":
                        TextDecripted = "O";
                        break;
                    case "HBYM":
                        TextDecripted = "I";
                        break;
                    case "eTVp":
                        TextDecripted = "U";
                        break;
                    case "eCkH":
                        TextDecripted = "Y";
                        break;
                    case "doaM":
                        TextDecripted = "T";
                        break;
                    case "qQTp":
                        TextDecripted = "R";
                        break;
                    case "zTVp":
                        TextDecripted = "E";
                        break;
                    case "epBp":
                        TextDecripted = "W";
                        break;
                    case "Hpnj":
                        TextDecripted = "Q";
                        break;
                    default:
                        TextDecripted = Text[i].ToString();
                        break;
                }
#endregion
                j = j + 4;
                DecriptText = DecriptText + TextDecripted;
            }

            return DecriptText;
        }
    }
}
