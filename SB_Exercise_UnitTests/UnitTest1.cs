using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SB_Exercise;

namespace SB_Exercise_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        MusicalLake a = new MusicalLake();

        [TestMethod]
        public void testSongOne()
        {                        
            List<String> list1 = new List<String>(new String[] { "fiu", "cric-cric", "brrah" });            
            Song result = a.searchSound("brr");            
            CollectionAssert.AreEqual(list1, result.getSong());
        }

        [TestMethod]
        public void testSongTwo()
        {            
            List<String> list1 = new List<String>(new String[] { "trri-trri", "croac" });
            Song result = a.searchSound("birip");
            CollectionAssert.AreEqual(list1, result.getSong());
        }

        [TestMethod]
        public void testSongThree()
        {
            List<String> list1 = new List<String>(new String[] { "cric-cric", "brrah" });
            Song result = a.searchSound("plop");
            CollectionAssert.AreEqual(list1, result.getSong());
        }

        [TestMethod]
        public void testCroac()
        {            
            Song result = a.searchSound("croac");
            Assert.IsNull(result);
        }

        [TestMethod]
        public void testBrrah()
        {
            Song result = a.searchSound("brrah");
            Assert.IsNull(result);
        }
    }
}
