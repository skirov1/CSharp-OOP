using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attrubites
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;
        private int maxValue;
        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            var inputInteger = (int)obj;
            if (inputInteger >= minValue && inputInteger <= maxValue)
            {
                return true;
            }
            return false;
        }
    }
}
