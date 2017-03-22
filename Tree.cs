using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BSTree
    {
        Node root;
        public void Insert(int value){
            if(root == null){
                root = new Node(value);
            } else {
                root.Insert(value);
            }
        }

       public BSTree()
       {
           
       }

       public bool Contains(int value)
       {
           var result = false;
           if(root != null){
               result = root.Contains(value);
           }
           return result;
       }
       
       public string ToStringLevelByLevel(){
            var nodes = new List<Node>();
            var lblString = new StringBuilder();
            nodes.Add(root);
           
            while(nodes.Count > 0){
                var current = nodes[0];
                lblString.Append(current.Value);

                if(current.Left != null) {
                    nodes.Add(current.Left);
                }
                if(current.Right != null) {
                    nodes.Add(current.Right);
                }
                nodes.RemoveAt(0);
            }

            return lblString.ToString();
       }

       public string ToStringLevel(int level){
           return root == null ? string.Empty : root.ToStringLevel(level);
       }

       public string ToStringInOrder(){
           return root == null ? string.Empty : root.ToStringInOrder();
       }
       public string ToStringDepthFirst(){
           return root == null ? string.Empty : root.ToStringDepthFirst();
       }

       public int GetSecondLargestValue(){
           return GetSecondLargestValue(root, null);
       }

       private int GetSecondLargestValue(Node node, Node parentNode){
           if(node == null) { 
               return -1;
            }
           else if (node.Left == null && node.Right == null) { 
               return parentNode == null ? -1 : parentNode.Value;
            }
           else if (node.Right == null) {
               return GetLargestElement(node.Left);
            }
           else {
               return GetSecondLargestValue(node.Right, node);
           }
       }

       private int GetLargestElement(Node node){
            var currentNode = node;

            while(currentNode.Right != null)
            {
                currentNode = currentNode.Right;
            }
            return currentNode == null ? -1 : currentNode.Value;
       }
    }

    internal class Node
    {
        public int Value { get; private set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value){
            Value = value;
        }
        public void Insert(int value){
            if(value < Value){
                if(Left == null){
                    Left = new Node(value);
                } else {
                    Left.Insert(value);
                }
            } else {
                if(Right == null){
                    Right = new Node(value);
                } else {
                    Right.Insert(value);
                }
            }
        }
        public bool Contains(int value){
            if(value == Value){
                return true;
            } else if(value < Value){
                if(Left == null)
                {
                    return false;
                } else {
                    return Left.Contains(value);
                }
            }  else if(value >= Value){
                if(Right == null)
                {
                    return false;
                } else {
                    return Right.Contains(value);
                }
            }

            return false;
        }
        public void PrintInOrder(){
            if(Left != null){
                Left.PrintInOrder();
            }
            Console.WriteLine(Value);
            if(Right != null){
                Right.PrintInOrder();
            }
        }


        public string ToStringDepthFirst(){
            StringBuilder strb = new StringBuilder();
            strb.Append(Value);
            if(Left != null){
                strb.Append(Left.ToStringDepthFirst());
            }
            
            if(Right != null){
                 strb.Append(Right.ToStringDepthFirst());
            }
            return strb.ToString();
        }



        public string ToStringInOrder(){
            StringBuilder strb = new StringBuilder();
            if(Left != null){
                strb.Append(Left.ToStringInOrder());
            }
            strb.Append(Value);
            if(Right != null){
                 strb.Append(Right.ToStringInOrder());
            }
            return strb.ToString();
        }

        public string ToStringLevel(int level)
        {
            return ToStringLevel(level, 0);
        }

        private string ToStringLevel(int level, int currentLevel){
            StringBuilder strb = new StringBuilder();
            if(level < currentLevel)
            {
                return string.Empty;
            }

            if(level == currentLevel)
            {
                strb.Append(Value);
            } else {

                if(Left != null) {
                    strb.Append(Left.ToStringLevel(level, currentLevel+1));
                }
                if(Right != null) {
                    strb.Append(Right.ToStringLevel(level, currentLevel+1));
                }
            }
            
            return strb.ToString();
        }
    }
}