using System.IO;
using NUnit.Framework;
using static Anagrams_Test.Supply;

namespace Anagrams_Test {
    public class Tests {

        [Test]
        public void TestWithOneAnagram() {
            string data = @"4
poke
pkoe
okpe
ekop";
            CallWithReassignedIO(Anagrams.Program.Main, 
                new StringReader(data), 
                out string[] output);
            Assert.AreEqual(new []{
                "poke"
            }, output);
        }
        
        [Test]
        public void TestWithTwoAnagrams() {
            string data = @"4
code
aaagrmns
anagrams
doce";
            CallWithReassignedIO(Anagrams.Program.Main, 
                new StringReader(data), 
                out string[] output);
            Assert.AreEqual(new []{
                "aaagrmns",
                "code"
            }, output);
        }
        
        [Test]
        public void TestWithThreeDifferentWorks() {
            string data = @"3
code
frame
framer";
            CallWithReassignedIO(Anagrams.Program.Main, 
                new StringReader(data), 
                out string[] output);
            Assert.AreEqual(new []{
                "code",
                "frame",
                "framer"
            }, output);
        }


    }
}