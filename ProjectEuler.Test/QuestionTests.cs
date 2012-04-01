using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Test
{
    [TestClass]
    public class QuestionTests
    {
        [TestMethod]
        public void Question1Test()
        {
            Assert.AreEqual(Questions.question1(), 233168);
        }

        [TestMethod]
        public void Question2Test()
        {
            Assert.AreEqual(Questions.question2(), 4613732);
        }

        [TestMethod]
        public void Question3Test()
        {
            Assert.AreEqual(Questions.question3(), 6857);
        }
    }
}