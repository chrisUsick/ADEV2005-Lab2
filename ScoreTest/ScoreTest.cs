using ADEV2005Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ScoreTest
{
    
    
    /// <summary>
    ///This is a test class for ScoreTest and is intended
    ///to contain all ScoreTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ScoreTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for getItemScore 0 errors
        ///</summary>
        [TestMethod()]
        public void getItemScoreMeets()
        {
            Score.ItemScore comments = Score_Accessor.ItemScore.BelowStandard;
            Score.ItemScore namingConventions = Score_Accessor.ItemScore.BelowStandard;
            Score.ItemScore unitTests = Score_Accessor.ItemScore.BelowStandard;
            bool crash = false;
            int functionalErrors = 0;
            int interfaceErrors = 0;
            Score_Accessor target = new Score_Accessor(comments, namingConventions, unitTests, crash, functionalErrors, interfaceErrors);
            int numberOfErrors = 0;
            Score.ItemScore expected = Score.ItemScore.MeetsStandard;
            Score.ItemScore actual;
            actual = target.getItemScore(numberOfErrors);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getItemScore 1 errors
        ///</summary>
        [TestMethod()]
        public void getItemScoreMinimum()
        {
            Score.ItemScore comments = Score_Accessor.ItemScore.BelowStandard;
            Score.ItemScore namingConventions = Score_Accessor.ItemScore.BelowStandard;
            Score.ItemScore unitTests = Score_Accessor.ItemScore.BelowStandard;
            bool crash = false;
            int functionalErrors = 0;
            int interfaceErrors = 0;
            Score_Accessor target = new Score_Accessor(comments, namingConventions, unitTests, crash, functionalErrors, interfaceErrors);
            int numberOfErrors = 1;
            Score.ItemScore expected = Score.ItemScore.MeetsMinimumStandard;
            Score.ItemScore actual;
            actual = target.getItemScore(numberOfErrors);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getItemScore 2 or more errors
        ///</summary>
        [TestMethod()]
        public void getItemScoreBelow()
        {
            Score.ItemScore comments = Score_Accessor.ItemScore.BelowStandard;
            Score.ItemScore namingConventions = Score_Accessor.ItemScore.BelowStandard;
            Score.ItemScore unitTests = Score_Accessor.ItemScore.BelowStandard;
            bool crash = false;
            int functionalErrors = 0;
            int interfaceErrors = 0;
            Score_Accessor target = new Score_Accessor(comments, namingConventions, unitTests, crash, functionalErrors, interfaceErrors);
            int numberOfErrors = 2;
            Score.ItemScore expected = Score_Accessor.ItemScore.BelowStandard;
            Score.ItemScore actual;
            actual = target.getItemScore(numberOfErrors);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Score Constructor
        ///</summary>
        [TestMethod()]
        public void ScoreConstructorTest()
        {
            Score.ItemScore comments = new Score.ItemScore(); // TODO: Initialize to an appropriate value
            Score.ItemScore namingConventions = new Score.ItemScore(); // TODO: Initialize to an appropriate value
            Score.ItemScore unitTests = new Score.ItemScore(); // TODO: Initialize to an appropriate value
            bool crash = false; // TODO: Initialize to an appropriate value
            int functionalErrors = 0; // TODO: Initialize to an appropriate value
            int interfaceErrors = 0; // TODO: Initialize to an appropriate value
            Score target = new Score(comments, namingConventions, unitTests, crash, functionalErrors, interfaceErrors);
            Assert.AreEqual(comments, target.Comments);
            Assert.AreEqual(namingConventions, target.NamingConventions);
            Assert.AreEqual(unitTests, target.UnitTests);
            Assert.AreEqual(crash, target.Crash);
            Assert.AreEqual(functionalErrors, target.FunctionalErrors);
            Assert.AreEqual(interfaceErrors, target.InterfaceErrors);
        }
    }
}
