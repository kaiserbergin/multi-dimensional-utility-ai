using System;

namespace MultiDimensionalUtilityAI.Blackboard.Entities {
    public abstract class AIDataElementBase<T>
    {
        public abstract Type GetDataType();
        public abstract bool GetAsBoolean();
        public abstract T GetDataValue();
        public abstract void SetDataValue(T value);
    }
}
