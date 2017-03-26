using System;

namespace NhanSu.BusinessLogicLayer
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class VadidationAttribute : Attribute
    {
        public string Required;

        public override bool Match(object obj)
        {
            return base.Match(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}