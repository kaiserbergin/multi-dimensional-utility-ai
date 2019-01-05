using MultiDimensionalUtilityAI.Blackboard.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MultiDimensionalUtilityAI.Blackboard.Balckboards
{
    public class BlackBoard
    {
        private static BlackBoard instance = null;

        private BlackBoard() { }

        public static BlackBoard Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BlackBoard();
                }
                return instance;
            }
        }

        public Dictionary<string, object> Objects = new Dictionary<string, object>();

        public Dictionary<string, SimpleAIDataElement<int>> ints = new Dictionary<string, SimpleAIDataElement<int>>();                
    }
}
