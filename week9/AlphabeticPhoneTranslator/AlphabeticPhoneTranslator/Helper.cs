using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabeticPhoneTranslator
{
    public class Helper
    {
        public bool TextBoxLimit(KeyPressEventArgs e)
        {
            //char c = e.KeyChar;
            //if(!char.IsLetterOrDigit(c) && !char.IsLetter(c) && !char.IsDigit(c))
            //{
            //    e.Handled = true;
            //    return false;
            //}
            //else
            //{
                return true;
            //}
        }

        public string translatePhoneNumber(string character)
        {
            string newCharacter = string.Empty;

            if (character.Equals("A") || character.Equals("B") || character.Equals("C"))
            {
                newCharacter = "2";
            }
            else if (character.Equals("D") || character.Equals("E") || character.Equals("F"))
            {
                newCharacter = "3";
            }
            else if (character.Equals("G") || character.Equals("H") || character.Equals("I"))
            {
                newCharacter = "4";
            }
            else if (character.Equals("J") || character.Equals("K") || character.Equals("L"))
            {
                newCharacter = "5";
            }
            else if (character.Equals("M") || character.Equals("N") || character.Equals("O"))
            {
                newCharacter = "6";
            }
            else if (character.Equals("P") || character.Equals("Q") || character.Equals("R") || character.Equals("S"))
            {
                newCharacter = "7";
            }
            else if (character.Equals("T") || character.Equals("U") || character.Equals("V"))
            {
                newCharacter = "8";
            }
            else if (character.Equals("W") || character.Equals("X") || character.Equals("Y") || character.Equals("Z"))
            {
                newCharacter = "9";
            }
            else
            {
                newCharacter = character; 
            }
            return newCharacter;
        }
    }
}
