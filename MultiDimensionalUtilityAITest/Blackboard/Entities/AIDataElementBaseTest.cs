using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiDimensionalUtilityAI.Blackboard.Entities;
using Moq;

namespace MultiDimensionalUtilityAITest.Blackboard.Entities {
    [TestClass]
    public class AIDataElementBaseTest {
        [TestMethod]
        public void TestAIDataElementBase() {
            //Arrange
            var mockAIDataElementBase = new Mock<AIDataElementBase<int>>();
            int INT_VALUE = 1;

            mockAIDataElementBase.Setup(x => x.GetAsBoolean())
                .Returns(true);
            mockAIDataElementBase.Setup(x => x.GetDataType())
                .Returns(typeof(int));
            mockAIDataElementBase.Setup(x => x.GetDataValue())
                .Returns(INT_VALUE);

            //Act
            mockAIDataElementBase.Object.SetDataValue(INT_VALUE);


            //Assert
            Assert.IsTrue(mockAIDataElementBase.Object.GetAsBoolean());
            Assert.AreEqual(mockAIDataElementBase.Object.GetDataType(), typeof(int));
            Assert.AreEqual(mockAIDataElementBase.Object.GetDataValue(), INT_VALUE);
            mockAIDataElementBase.Verify(x => x.SetDataValue(INT_VALUE), Times.Once);
        }
    }
}
