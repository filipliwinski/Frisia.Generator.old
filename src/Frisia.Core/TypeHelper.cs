﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace Frisia.Core
{ 
    public static class TypeHelper
    {
        public static object GetDefaultValue(TypeSyntax type)
        {
            return GetDefaultValue(type.ToString());
        }

        public static object GetDefaultValue(string typeName)
        {
            switch (typeName)
            {
                case "bool":
                    return default(bool);
                case "int":
                    return default(int);
                case "decimal":
                    return default(decimal);
                case "double":
                    return default(double);
                case "string":
                    return default(string);
                case "string[]":
                    return default(string[]);
                default:
                    throw new NotSupportedException($"{typeName} is not supported.");
            }
        }

        public static string GetFullTypeName(TypeSyntax type)
        {
            return GetFullTypeName(type.ToString());
        }

        public static string GetFullTypeName(string type)
        {
            switch (type)
            {
                case "void":
                    return null;
                case "bool":
                    return typeof(bool).FullName;
                case "int":
                    return typeof(int).FullName;
                case "decimal":
                    return typeof(decimal).FullName;
                case "double":
                    return typeof(double).FullName;
                default:
                    throw new NotSupportedException($"{type} is not supported.");
            }
        }
    }
}
