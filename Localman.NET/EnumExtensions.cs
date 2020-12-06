using System;
using System.ComponentModel;
using System.Reflection;

namespace Localman.NET
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetRuntimeField(value.ToString());
            var displayAttribute = field.GetCustomAttribute<DescriptionAttribute>();
            return displayAttribute?.Description ?? value.ToString();
        }
    }
}
