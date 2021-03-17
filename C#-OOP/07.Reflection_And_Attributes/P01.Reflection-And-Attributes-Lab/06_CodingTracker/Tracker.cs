using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        Type type = typeof(StartUp);

        MethodInfo[] methods = type.GetMethods(BindingFlags.Instance |
            BindingFlags.Static |
            BindingFlags.Public);

        foreach (var method in methods)
        {
            if (method.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute)))
            {
                object[] attributes = method.GetCustomAttributes(false);

                //inherit
                //Boolean
                //true to search this member's inheritance chain to find the attributes; otherwise, 
                //false.This parameter is ignored for properties and events.

                //Returns
                //Object[]
                //An array that contains all the custom attributes applied to this member, 
                //or an array with zero elements if no attributes are defined.

                foreach (AuthorAttribute attribute in attributes)
                {
                    Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                }
            }
        }
    }
}