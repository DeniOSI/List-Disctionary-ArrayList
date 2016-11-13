using ListAndCollection.StackBL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NUnit.Stack
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void TestMethod()
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("hello");
            st.Push(1);
            var result = StackS.PrintStack(st);

            Assert.Equals(8, result.Length);

        }
    }
}
