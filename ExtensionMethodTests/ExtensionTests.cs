using ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace ExtensionMethodTests
{
    [TestClass]
    public class ExtensionTests
    {

        #region String IsTrue Tests

        
        [TestMethod]
        public void TestIsTrueAllFalse()
        {
            string candidate = "monkey";

            Assert.IsFalse(candidate.IsTrue());

            candidate = "N";

            Assert.IsFalse(candidate.IsTrue());

            candidate = "maybe";

            Assert.IsFalse(candidate.IsTrue());

            #region Super Special Trick

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            candidate = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS8604 // Possible null reference argument.
            Assert.IsFalse(candidate.IsTrue());
#pragma warning restore CS8604 // Possible null reference argument.

            #endregion

        }

        [TestMethod]
        public void TestIsTrueAllTrue()
        {
            string candidate = "yEs";

            Assert.IsTrue(candidate.IsTrue());


            candidate = "Y";

            Assert.IsTrue(candidate.IsTrue());


            candidate = "       t    ";

            Assert.IsTrue(candidate.IsTrue());


            candidate = "tRuE";

            Assert.IsTrue(candidate.IsTrue());


            candidate = "  1";

            Assert.IsTrue(candidate.IsTrue());

        }

        #endregion

        #region Collection Tests

        [TestMethod]
        public void TestCollectionHasEntriesAllTrue()
        {

            Dictionary<string, string> pairs = new Dictionary<string, string>();

            pairs.Add("cheeky", "monkey");

            Assert.IsTrue(pairs.HasEntries());


            ArrayList arrayList = new ArrayList();

            arrayList.Add("Quacky Ducks");

            // note: this is why we hate arraylists.  What is this, javascript??
            arrayList.Add(4);

            Assert.IsTrue(arrayList.HasEntries());



            ICollection collection = new List<string>() { "foo" };

            Assert.IsTrue(collection.HasEntries());

        }


        [TestMethod]
        public void TestCollectionHasEntriesAllFalse()
        {

            Dictionary<string, string> pairs = new Dictionary<string, string>();

            Assert.IsFalse(pairs.HasEntries());


            ArrayList arrayList = new ArrayList();

            Assert.IsFalse(arrayList.HasEntries());

            #region Bonus Special Go Go Gadget test

            ICollection? collection = null;

#pragma warning disable CS8604 // Possible null reference argument.
            Assert.IsFalse(collection.HasEntries());
#pragma warning restore CS8604 // Possible null reference argument.

            #endregion

        }

        #endregion
    }
}