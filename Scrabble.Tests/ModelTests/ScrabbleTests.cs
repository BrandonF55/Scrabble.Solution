using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System.Collections.Generic;
using System;

namespace Scrabble.Tests
{
    [TestClass]

    public class ScrabbleScoresTests
    {
        [TestMethod]
        public void ScrabbleConstructor_CreatesInstanceOfScrabble_Scrabble()
        {
            ScrabbleScores newScrabble = new ScrabbleScores();
            Assert.AreEqual(typeof(ScrabbleScores), newScrabble.GetType());


        }


    }
}
