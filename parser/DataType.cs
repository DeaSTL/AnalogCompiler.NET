using System;
using System.Collections.Generic;
using System.Text;

namespace AnalogCompiler.NET.parser
{
    class DataType
    {
        public static string STRING = "TYPE_STRING";
        public static string INTEGER = "TYPE_INTEGER";
        public static string FLOAT = "TYPE_FLOAT";
        public static string DOUBLE = "TYPE_DOUBLE";
        
    }
    class TypeString {
        public string definition_name;
        public string type_id = DataType.STRING;
        public TypeString(string name) {
            definition_name = name;

        }
    }
    class TypeInteger {

    }
    class TypeFloat {

    }
    class TypeDouble {

    }
}
