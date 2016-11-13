using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using ListAndCollection.StackBL;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void PritStack()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

           var result = StackS.PrintStack(st);


            Assert.AreEqual(6, result.Length);
            Assert.AreEqual("3 2 1 ", result);
     


        }
    }
}
