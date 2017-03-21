using System;
using DataStructures;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BSTree();

            Random rand = new Random();

            var val = rand.Next(10);
            Console.WriteLine(val);
            tree.Insert(val);
            
            val = rand.Next(10);
            Console.WriteLine(val);
            tree.Insert(val);
            
            val = rand.Next(10);
            Console.WriteLine(val);
            tree.Insert(val);

            
            val = rand.Next(10);
            Console.WriteLine(val);
            tree.Insert(val);
            
            val = rand.Next(10);
            Console.WriteLine(val);
            tree.Insert(val);
            
            val = rand.Next(10);
            Console.WriteLine(val);
            tree.Insert(val);
            
            val = rand.Next(10);
            Console.WriteLine(val);
            tree.Insert(val);
            
            val = rand.Next(10);
            Console.WriteLine(val);
            tree.Insert(val);
            
            Console.WriteLine(tree.ToStringInOrder());
            Console.WriteLine(tree.ToStringDepthFirst());
            Console.WriteLine(tree.ToStringLevelByLevel());

            Console.WriteLine(tree.ToStringLevel(0));
            Console.WriteLine(tree.ToStringLevel(1));
            Console.WriteLine(tree.ToStringLevel(2));
            
        }
    }

    
}
