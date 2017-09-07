using System;
using System.Collections.Generic;
using System.Text;
using filehandling;
using System.Text.RegularExpressions;

namespace AnalogCompiler.NET.parser
{
    class ParseTree
    {
        File programfile;
        string class_name;
        ObjectDefinition[] class_definitions;

    
        public ParseTree(File file) {
            programfile = file;

        }
        public override string ToString() {

            return "";
        }
        
    }
}
