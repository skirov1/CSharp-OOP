using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attrubites
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj) 
            => obj != null;     
    }
}
