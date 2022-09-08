using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Class4
    {
        private string word;
        public string answer2 = "You need more practice(";

        public string WordCheck
        { 
            get
            {
                return word;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    word = "Error";
                }
                else
                {
                    word = value;
                }
            }
        }
        public string Answer { get; set; }

        public void Knowledge(string answer, string answer2, int number)
        {
            if (number >= 10)
            {
                Answer = answer;
                Console.WriteLine(Answer);
            }
            else
            {
                Console.WriteLine(answer2);
            }
        }
    }
}
