using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiDimensionalUtilityAI.Blackboard.Balckboards;
using MultiDimensionalUtilityAI.Blackboard.Entities;

namespace MultiDimensionalUtilityAITest.Blackboard.Blackboards
{
    [TestClass]
    public class UnitTest1<T>
    {
        [TestMethod]
        public void BlackBoardBaseAddTest()
        {
            string key = "INTERGER";
            int value = 1;
            BlackboardBase<T> blackboardBase = new BlackboardBase<T>();
            NullableIntDataElement nullableIntDataElement = new NullableIntDataElement(value);
            blackboardBase.Add(key, nullableIntDataElement);

            Assert.AreEqual(value.GetType(), blackboardBase.GetType(key));
        }
    }
}
