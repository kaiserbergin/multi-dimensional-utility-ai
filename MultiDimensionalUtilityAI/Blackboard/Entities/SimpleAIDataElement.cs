using System;

namespace MultiDimensionalUtilityAI.Blackboard.Entities
{
    public class SimpleAIDataElement<T> : AIDataElementBase<T>
    {
        private T value;

        public SimpleAIDataElement() { }

        public SimpleAIDataElement(T value)
        {
            this.value = value;
        }

        public override Type GetDataType() => typeof(T);
        public override bool GetAsBoolean() => value != null;
        public override T GetDataValue() => value;
        public override void SetDataValue(T value)
        {
            this.value = value;
        }
    }
}
