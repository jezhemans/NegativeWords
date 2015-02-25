using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class Words : INegativeWords
    {
        //Might be other properties to add to this class in the future
        private string word;
        public string Word { get { return word; } set { word = value.ToLower(); } }

        public Words(string word)
        {
            this.Word = word;
        }

        public Words()
        {
        }

        public List<Words> GetNegativeWords()
        {
            //Would get list from the database
            List<Words> negWords = new List<Words>();
            negWords.Add(new Words("bad"));
            negWords.Add(new Words("bugger"));
            negWords.Add(new Words("terrible"));

            return negWords;
        }
    }
}
