using System;
using System.Collections.Generic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NegativeWords;

namespace NegativeWordsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetNegativeWordsTestMethod()
        {
           string sentence = "Bad  code  is not necessarily a sign of a     terrible programmer. Always look at the bigger picture.";
           DataAccess.Fakes.StubINegativeWords da = new DataAccess.Fakes.StubINegativeWords();
           List<Words> words = new List<Words>();
           da.GetNegativeWords = () =>
               {
                   Words word = new Words()
                   {
                       Word = "BAD"
                   };
                   words.Add(word);
                   word = null;
                   Words word1 = new Words()
                   {
                       Word = "terrible"
                   };
                   words.Add(word1);
                   return words;
               };
           Display display = new Display(da);
           int n = display.displayNegatives(sentence);
           Assert.AreEqual(2, n);
        }
    }
}
