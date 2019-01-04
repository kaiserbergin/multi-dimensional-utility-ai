using System;
using System.Collections.Generic;
using System.Text;

namespace MultiDimensionalUtilityAI.Blackboard.Entities
{
    public class NullableIntDataElement : SimpleAIDataElement<int?>
    {
        public NullableIntDataElement(int value)
        {
            SetDataValue(value);
        }
        public NullableIntDataElement() { }
    }
}
