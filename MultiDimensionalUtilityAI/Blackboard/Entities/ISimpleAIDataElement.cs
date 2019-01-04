using System;

namespace MultiDimensionalUtilityAI.Blackboard.Entities
{
    public interface ISimpleAIDataElement<T>
    {
        bool GetAsBoolean();
        Type GetDataType();
        T GetDataValue();
        void SetDataValue(T value);
    }
}