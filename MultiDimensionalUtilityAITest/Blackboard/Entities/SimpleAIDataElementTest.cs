using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiDimensionalUtilityAI.Blackboard.Entities;

namespace MultiDimensionalUtilityAITest.Blackboard.Entities {
    [TestClass]
    public class SimpleAIDataElementTest {
        [TestMethod]
        public void SimpleAIDataElementTestForIntegerNotInitialized() {
            //Arrange
            var simpleInteger = new SimpleAIDataElement<int?>();

            //Assert
            Assert.IsFalse(simpleInteger.GetAsBoolean());
            Assert.IsNull(simpleInteger.GetDataValue());
            Assert.AreEqual(simpleInteger.GetDataType(), typeof(int?));
        }
    }
}
