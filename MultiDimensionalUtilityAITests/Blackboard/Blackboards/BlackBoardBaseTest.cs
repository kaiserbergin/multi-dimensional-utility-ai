using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiDimensionalUtilityAI.Blackboard.Balckboards;
using MultiDimensionalUtilityAI.Blackboard.Entities;

namespace MultiDimensionalUtilityAITests.Blackboard.Blackboards
{
    [TestClass]
    public class BlackBoardBaseTest
    {
        [TestMethod]
        public void BlackBoardBaseAddObject()
        {
            //Arrange
            string key = "INTERGER";
            object value = 1;

            //Act
            BlackBoard.Instance.Objects.Add(key, value);
            object result = BlackBoard.Instance.Objects[key];

            //Assert
            Assert.AreEqual(value.GetType(), result.GetType());
            Assert.AreEqual(value, result);
            Assert.AreEqual((int)value, (int)result);
        }

        [TestMethod]
        public void BlackBoardBaseAddSimpleAIDataElementToObjects()
        {
            //Arrange
            string key = "SIMPLE_AI_DATA_ELEMENT";
            int value = 1;
            SimpleAIDataElement<int> simpleAIDataElement = new SimpleAIDataElement<int>();
            simpleAIDataElement.SetDataValue(value);

            //Act
            BlackBoard.Instance.Objects.Add(key, simpleAIDataElement);
            SimpleAIDataElement<int> result = (SimpleAIDataElement<int>)BlackBoard.Instance.Objects[key];

            //Assert
            Assert.AreEqual(value.GetType(), result.GetDataType());
            Assert.AreEqual(value, result.GetDataValue());
        }

        [TestMethod]
        public void BlackBoardBaseAddToInts()
        {
            //Arrange
            string key = "NULLABLE_INT";
            int value = 1;
            SimpleAIDataElement<int> simpleDataElement = new SimpleAIDataElement<int>(value);

            //Act
            BlackBoard.Instance.Objects.Add(key, simpleDataElement);
            SimpleAIDataElement<int> result = (SimpleAIDataElement<int>)BlackBoard.Instance.Objects[key];

            //Assert
            Assert.AreEqual(value.GetType(), result.GetDataType());
            Assert.AreEqual(value, result.GetDataValue());
        }
    }
}
