using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto_game
{
    public class Game
    {   
        Random random = new Random();
        int[] winningNumbers = new int[6];
        int[] duplicatedNumbers = new int[6];
        int[] playersNumbers = new int[6];
        
        public int[] Winning()
        {
            return winningNumbers;
        }

        public int[] Players()
        {
            return playersNumbers;
        }

        public int[] DrawNumbers(int[] tab)
        {
            int i = 0;
            bool notDuplicated;
            int number;
            while (i < 6)
            {
                number = random.Next(49);
                notDuplicated = true;
                
                for(int j = 0; j < i; j++)
                {
                    if (number == duplicatedNumbers[j])
                    {
                        notDuplicated = false;
                        break;
                    }
                }
                if (notDuplicated)
                {
                    tab[i] = number;
                    duplicatedNumbers[i] = number;
                    i++;
                }
            }
            Array.Clear(duplicatedNumbers, 0, duplicatedNumbers.Length);
            return tab;
        }

        public string ShowNumbers(int[] tab)
        {
            string values = "";
            for (int i = 0; i < 6; i++)
            {
                values = values + tab[i].ToString() + " ";
            }
            return values;
        }
        public int CompareValues()
        {
            int sameNumbers = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (this.winningNumbers[i] == this.playersNumbers[j])
                    {
                        sameNumbers++;
                    }
                }
            }
            return sameNumbers;
        }
    }
}