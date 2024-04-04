using System;

namespace PsevdotextGenNameSpace
{
    public class PsevdotextGen
    {
        public string GenPsevdotext(string golosni, string prygolosni, int maxLength)
        {
            Random random = new Random();
            string psevdoText = "";

            for (int i = 0; i < 400; i++)
            {
                int wordLength = random.Next(1, maxLength + 1);
                string word = "";

                for (int j = 0; j < wordLength; j++)
                {
                    if (j == 0)
                    {
                        word += Char.ToUpper(GetRandomChar(golosni + prygolosni, random));
                    }
                    else
                    {
                        word += GetRandomChar(golosni + prygolosni, random);
                    }
                }

                psevdoText += word + " ";
            }

            psevdoText = psevdoText.Trim() + ".";
            return psevdoText;
        }

        private char GetRandomChar(string str, Random random)
        {
            int index = random.Next(0, str.Length);
            return str[index];
        }
    }
}
