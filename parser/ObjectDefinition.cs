using System;
using System.Collections.Generic;
using System.Text;

namespace AnalogCompiler.NET.parser
{
    class ObjectDefinition
    {
        public string name;
        public FunctionDefinition[] function_definitions;
        public VariableDefinition[] variable_definition;
    }
}
