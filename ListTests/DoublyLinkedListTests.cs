using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace List.Tests
{
    [TestClass()]
    public class DoublyLinkedListTests
    {
        [TestMethod()]
        public void BackEnumeratorTest()
        {
            DoublyLinkedList<int> actual = new DoublyLinkedList<int>();
            actual.Add(1);
            actual.Add(2);
            actual.Add(3);
            actual.Add(99);
            actual.Add(455);
            actual.Add(1999);

            DoublyLinkedList<int> expected = new DoublyLinkedList<int>();
            expected.Add(1999);
            expected.Add(455);
            expected.Add(99);
            expected.Add(3);
            expected.Add(2);
            expected.Add(1);
            
            List<int> listactual = new List<int>(actual.BackEnumerator());
            List<int> listexpected = new List<int>(expected);
            
            CollectionAssert.AreEqual(listexpected, listactual);
        }
    }
}