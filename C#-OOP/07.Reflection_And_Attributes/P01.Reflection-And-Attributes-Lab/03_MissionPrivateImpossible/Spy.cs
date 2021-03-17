using System;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string classToInvestigate)
    {
        Type classType = Type.GetType(classToInvestigate);

        MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance |
            BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"All Private Methods of Class: {classToInvestigate}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in classMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().TrimEnd();
    }
}