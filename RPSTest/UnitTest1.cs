using RPS;

namespace RPSTest
{
    [TestClass]
    public class UnitTest1
    {
        string result = "";

        [TestMethod]
        public void UserInputLessThanOne()
        {
            try
            {
                result = RPS.RPS.RPSChecker(0, 1);
            }

            catch(Exception ex)
            {
                StringAssert.Contains(ex.Message, "Please enter a number 1, 2 or 3.");
            }
        }

        [TestMethod]
        public void UserInputMoreThanThree()
        {
            try
            {
                result = RPS.RPS.RPSChecker(4, 1);
            }

            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Please enter a number 1, 2 or 3.");
            }
        }

        [TestMethod]
        public void ItsATie()
        {
            result = RPS.RPS.RPSChecker(1, 1); 
            Assert.AreEqual("It's a tie", result);
            result = RPS.RPS.RPSChecker(2, 2);
            Assert.AreEqual("It's a tie", result);
            result = RPS.RPS.RPSChecker(3, 3);
            Assert.AreEqual("It's a tie", result);
        }

        [TestMethod]
        public void ItsATie1()
        {
            result = RPS.RPS.RPSChecker(1, 1);
            Assert.AreNotEqual("User wins", result);
            result = RPS.RPS.RPSChecker(2, 2);
            Assert.AreNotEqual("User wins", result);
            result = RPS.RPS.RPSChecker(3, 3);
            Assert.AreNotEqual("User wins", result);
        }

        [TestMethod]
        public void ItsATie2()
        {
            result = RPS.RPS.RPSChecker(1, 1);
            Assert.AreNotEqual("Computer Wins", result);
            result = RPS.RPS.RPSChecker(2, 2);
            Assert.AreNotEqual("Computer Wins", result);
            result = RPS.RPS.RPSChecker(3, 3);
            Assert.AreNotEqual("Computer Wins", result);
        }

        [TestMethod]
        public void UserWins()
        {
            result = RPS.RPS.RPSChecker(2, 1);
            Assert.AreEqual("User wins", result);
            result = RPS.RPS.RPSChecker(3, 2);
            Assert.AreEqual("User wins", result);
            result = RPS.RPS.RPSChecker(1, 3);
            Assert.AreEqual("User wins", result);
        }

        [TestMethod]
        public void UserWins1()
        {
            result = RPS.RPS.RPSChecker(1, 2);
            Assert.AreNotEqual("It's a tie", result);
            result = RPS.RPS.RPSChecker(2, 3);
            Assert.AreNotEqual("It's a tie", result);
            result = RPS.RPS.RPSChecker(3, 1);
            Assert.AreNotEqual("It's a tie", result);
        }

        [TestMethod]
        public void UserWins2()
        {
            result = RPS.RPS.RPSChecker(2, 1);
            Assert.AreNotEqual("Computer Wins", result);
            result = RPS.RPS.RPSChecker(3, 2);
            Assert.AreNotEqual("Computer Wins", result);
            result = RPS.RPS.RPSChecker(1, 3);
            Assert.AreNotEqual("Computer Wins", result);
        }

        [TestMethod]
        public void CompWins()
        {
            result = RPS.RPS.RPSChecker(3, 1);
            Assert.AreEqual("Computer Wins", result);
            result = RPS.RPS.RPSChecker(1, 2);
            Assert.AreEqual("Computer Wins", result);
            result = RPS.RPS.RPSChecker(2, 3);
            Assert.AreEqual("Computer Wins", result);
        }

        [TestMethod]
        public void CompWins1()
        {
            result = RPS.RPS.RPSChecker(3, 1);
            Assert.AreNotEqual("User wins", result);
            result = RPS.RPS.RPSChecker(1, 2);
            Assert.AreNotEqual("User wins", result);
            result = RPS.RPS.RPSChecker(2, 3);
            Assert.AreNotEqual("User wins", result);
        }

        [TestMethod]
        public void CompWins2()
        {
            result = RPS.RPS.RPSChecker(1, 3);
            Assert.AreNotEqual("It's a tie", result);
            result = RPS.RPS.RPSChecker(2, 1);
            Assert.AreNotEqual("It's a tie", result);
            result = RPS.RPS.RPSChecker(3, 2);
            Assert.AreNotEqual("It's a tie", result);
        }
    }
}