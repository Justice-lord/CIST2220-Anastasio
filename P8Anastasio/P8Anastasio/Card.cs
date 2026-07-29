using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P8Anastasio
{
    public class Card
    {
        public int numRight;
        public int numWrong;

        public string Answer { get; set; }
        public int CardID { get; set; }
        public int NumRight { get; set;}
        public int NumWrong { get; set; }
        public string Question { get; set; }
        public float RightWrongRatio {  get; set; }
        public string Title { get; set; }

        public Card() : this(0, "TBD", "TBD", "TBD", 0, 0)
        {
            Calc();
        }

        public Card (int cardID, string title, string question, string answer, int numRight, int numWrong)
        {
            CardID = cardID;
            Title = title;
            Question = question;
            Answer = answer;
            NumRight = numRight;
            NumWrong = numWrong;
            Calc();
        }

        private void Calc()
        {
            if (NumWrong == 0)
            {
                RightWrongRatio = 0;
            }
            else
            {
                RightWrongRatio = (float)NumRight / NumWrong;
            }
        }

        public override string ToString()
        {
            return $"Title: {Title}, Number Right {NumRight}, Number Wrong {NumWrong}, Raito {RightWrongRatio}";
        }
    }
}
