namespace ValidationAttributes.Utilities
{
    using System.Linq;
    using System.Reflection;

    using ValidationAttributes.Attributes;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] propertiesInfo = obj
                .GetType()
                .GetProperties();

            foreach (PropertyInfo property in propertiesInfo)
            {
                MyValidationAttribute[] attributes = property
                    .GetCustomAttributes()
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (MyValidationAttribute attribute in attributes)
                {
                    if (!attribute.IsValid(property.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}