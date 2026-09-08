using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedlist = new LinkedList<string>(); //ประกาศตัวแปร
            linkedlist.AddLast("Node 1");
            linkedlist.AddLast("Node 2");
            linkedlist.AddFirst("Node 0"); //AddFirst จะทำให้ข้อมูลอยู่ตัวแรกของแถวเสมอ

            LinkedListNode<string> firstNode = linkedlist.First; //เรียกใช้ข้อมูล
            Debug.Log($"First: " + firstNode.Value);

            LinkedListNode<string> lastNode = linkedlist.Last;
            Debug.Log($"Last:" +  lastNode.Value);

            Debug.Log($"FirstNode.next: " + firstNode.Next.Value);
            Debug.Log($"FirstNode.next.next: " + firstNode.Next.Next.Value);

            Debug.Log($"lastNode.Previous: " + lastNode.Previous.Value);
            Debug.Log($"lastNode.Previous.Previous: " + lastNode.Previous.Previous.Value);
          

            if (firstNode.Previous == null) Debug.Log("FirstNode.Previous == null");
            if (lastNode.Next == null) Debug.Log("LastNode.Next == null");

            linkedlist.AddAfter(firstNode, "Node 0.5");
            linkedlist.AddBefore(lastNode, "Node 1.5");

            LinkedListNode<string> node1 = linkedlist.Find("Node 1");
            linkedlist.Remove("Node 1");
            linkedlist.Remove(node1);
            linkedlist.RemoveFirst();
            linkedlist.RemoveLast();

            linkedlist.Clear();
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<string, int> inv = new Dictionary<string, int>(); 
            var inv2 = new Dictionary<string, int>();

            inv.Add("Potion", 1);
            inv.Add("Apple", 10);

            inv["Banana"] = 5;
            inv["Potion"] = 10;

            var pickupItem = "Sword";
            inv[pickupItem] = 1;

            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} Value: {value}");
            }

            var appleExists = inv.ContainsKey("Apple");
            Debug.Log(appleExists);

            var keyExists = inv.ContainsKey("Key");
            Debug.Log(keyExists);

            inv.Remove("Apple");
            foreach (var pair in inv)
            {
                string key = pair.Key;
                int value = pair.Value;
                Debug.Log($"Key: {key} Value: {value}");
            }
        }

        #endregion
    }
}
