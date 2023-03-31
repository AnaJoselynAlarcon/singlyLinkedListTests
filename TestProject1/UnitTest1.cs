using SinglyLinkedList;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        //field to hold our LL
        private SLL sll;

        [SetUp]
        public void Setup()
        {
            sll = new SLL();
        }

        [Test]
        public void TestPrepending()
        {
            string name = "Joe Blow";

            sll.AddFirst(name);

            //1-Assert it was added or SLL is bigger
            Assert.IsNotNull(sll.Head);

            //2- Assert first node value is "Joe Blow"
            //first go the head
            Node firstNode = sll.Head;

            //get the value of the head
            string value = firstNode.Value;

            Assert.AreEqual(name, value);


            //3- Assert there's no next of first node
            Assert.IsNull(firstNode.Next);

            Assert.AreEqual(1, sll.Count);
        }

        /// <summary>
        /// 2.	Test Adding nodes to the end of the list
        /// </summary>
        [Test]
        public void TestAppending()
        {
            string nameZero = "Joe Schmoe";
            sll.AddLast(nameZero);


            //string nameOne = "John Smith";
            //sll.AddLast(nameOne);

            //string nameTwo = "Jane Doe";
            //sll.AddLast(nameTwo);

            //string nameThree = "Bob Bobberson";
            //sll.AddLast(nameThree);

            //string nameFour = "Sam Sammerson";
            //sll.AddLast(nameFour);

            //string nameFive = "Dave Daverson";
            //sll.AddLast(nameFive);



            //1-Assert it was added or SLL is bigger
            Assert.IsNotNull(sll.Head);

            //2- Assert last node value is "Joe Schmoe"
            //go to the last node
            Node currentNode = sll.Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            Node lastNode = currentNode;


            Assert.AreEqual(lastNode.Value, nameZero);


            //Assert count is 1 or greater
            Assert.IsTrue(sll.Count != 0);

        }


        [Test]
        /// <summary>
        /// 3.	Removing the first node in the list
        /// </summary>
        public void TestRemoveFirst()
        {
            string name = "Joe Blow";

            sll.AddFirst(name);

            string nameOne = "Joss";
            sll.AddLast(nameOne);



            sll.RemoveFirst(name);



            //Assert 
            // Get the current node at the head
            Node currentNodeAtHead = sll.Head;
            //Assert Head is not name
            Assert.AreNotEqual(name, currentNodeAtHead.Value);


        }

        [Test]
        public void TestRemoveLast()
        {
            string name = "Joe Blow";

            sll.AddFirst(name);

            string nameOne = "Joss";
            sll.AddLast(nameOne);

            sll.RemoveLast(nameOne);


            Node currentNode = sll.Head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            Node lastNode = currentNode;

            Assert.AreEqual(lastNode.Value, name);
        }


        ///5.	Retrieving the value of a node at a given index
        [Test]
        public void TestGetValue()
        {
            string nameOne = "john smith";
            sll.AddLast(nameOne);

            string nameTwo = "jane doe";
            sll.AddLast(nameTwo);

            string nameThree = "bob bobberson";
            sll.AddLast(nameThree);

            string valueThree = sll.GetValue(3);



            //assert nameThree is bob bobberson
            Assert.AreEqual(valueThree, nameThree);


        }

        //1.	Determining the size of the list
        [Test]
        public void TestGetSize()
        {
            string nameOne = "john smith";
            sll.AddLast(nameOne);

            string nameTwo = "jane doe";
            sll.AddLast(nameTwo);

            string nameThree = "bob bobberson";
            sll.AddLast(nameThree);

            string valueThree = sll.GetValue(3);
            ulong size = sll.Count;




            //Assert the last value is at last node
            Assert.AreEqual(size, 3);
        }
    }
}