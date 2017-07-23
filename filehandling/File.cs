using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace filehandling
{
    class File
    {
        private List<String> file_lines;
        public File(String filename_)
        {
            file_lines = getLines(filename_);
        }
        private List<String> getLines(String filename) {
            List<String> file_lines = new List<string>();
            FileStream filest = new FileStream(filename,FileMode.Open);
            StreamReader stread = new StreamReader(filest);
            String current_line = "";
            while ((current_line = stread.ReadLine()) != null) {
                file_lines.Add(current_line);

            }
            return file_lines;
        }
        public String getRawFileContents() {
            String output = "";
            foreach (String line in file_lines)
            {
                output += line;
            }
            return output;
        }
        public String getFileContents() {
            String output = "";
            foreach (String line in file_lines)
            {
                output += line + "\n";
            }
            return output;
        }


    }
}
