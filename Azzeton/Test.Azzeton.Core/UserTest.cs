using Azzeton.Core.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Azzeton.Shared;
using System.Collections.ObjectModel;

namespace Test.Azzeton.Core
{
    
    
    /// <summary>
    ///This is a test class for UserTest and is intended
    ///to contain all UserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserTest
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
        ///A test for Username
        ///</summary>
        [TestMethod()]
        public void UsernameTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Username = expected;
            actual = target.Username;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Rights
        ///</summary>
        [TestMethod()]
        public void RightsTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            Collection<IUserRight> actual;
            actual = target.Rights;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResetQuestion
        ///</summary>
        [TestMethod()]
        public void ResetQuestionTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ResetQuestion = expected;
            actual = target.ResetQuestion;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResetAnswer
        ///</summary>
        [TestMethod()]
        public void ResetAnswerTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.ResetAnswer = expected;
            actual = target.ResetAnswer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Password
        ///</summary>
        [TestMethod()]
        public void PasswordTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Password = expected;
            actual = target.Password;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NonGroups
        ///</summary>
        [TestMethod()]
        public void NonGroupsTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            Collection<IGroup> actual;
            actual = target.NonGroups;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsLocked
        ///</summary>
        [TestMethod()]
        public void IsLockedTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsLocked = expected;
            actual = target.IsLocked;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsActive
        ///</summary>
        [TestMethod()]
        public void IsActiveTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsActive = expected;
            actual = target.IsActive;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Id
        ///</summary>
        [TestMethod()]
        public void IdTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Id = expected;
            actual = target.Id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Groups
        ///</summary>
        [TestMethod()]
        public void GroupsTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            Collection<IGroup> actual;
            actual = target.Groups;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            User target = new User(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for User Constructor
        ///</summary>
        [TestMethod()]
        public void UserConstructorTest1()
        {
            User target = new User();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for User Constructor
        ///</summary>
        [TestMethod()]
        public void UserConstructorTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            string username = string.Empty; // TODO: Initialize to an appropriate value
            string password = string.Empty; // TODO: Initialize to an appropriate value
            bool islocked = false; // TODO: Initialize to an appropriate value
            bool isactive = false; // TODO: Initialize to an appropriate value
            string resetquestion = string.Empty; // TODO: Initialize to an appropriate value
            string resetanswer = string.Empty; // TODO: Initialize to an appropriate value
            User target = new User(id, username, password, islocked, isactive, resetquestion, resetanswer);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
