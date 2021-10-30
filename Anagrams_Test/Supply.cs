using System;
using System.IO;
using System.Linq;

namespace Anagrams_Test {
    public class Supply {
        public static void CallWithReassignedIO(Action<string[]> mainMethod, 
            StringReader reader, 
            out string[] output) {
            using (StringWriter sw = new StringWriter()) {
                using (StringReader sr = reader) {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    mainMethod(new string[]{});
                    Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
                    Console.SetIn(new StreamReader(Console.OpenStandardInput()));
                    output = sw.ToString()
                        .Split("\r\n")
                        .SkipLast(1)
                        .ToArray();
                }
            }
        }
    }
}