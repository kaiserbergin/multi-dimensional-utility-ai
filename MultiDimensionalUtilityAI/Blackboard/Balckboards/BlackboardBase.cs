using MultiDimensionalUtilityAI.Blackboard.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MultiDimensionalUtilityAI.Blackboard.Balckboards
{
    public class BlackboardBase<T>
    {
        private Hashtable AIDataElements = new Hashtable();

        public void Add(string key, object item)
        {
            if (AIDataElements.ContainsKey(key))
                throw new ArgumentException("Data element already exists for key: " + key);
            AIDataElements.Add(key, item);
        }

        public object GetDataElement(string key)
        {
            if (!AIDataElements.ContainsKey(key))
            {
                throw new KeyNotFoundException("Blackboard does not contain a key for: " + key);
            }
            return AIDataElements[key];
        }

        public Type GetType(string key) 
        {
            ISimpleAIDataElement<T> simpleAIDataElement = (ISimpleAIDataElement<T>)GetDataElement(key);
            return simpleAIDataElement.GetDataType();
        }
    }
}
