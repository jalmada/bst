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

            // for(var i = 0; i < 10; i++){
            //     var val = rand.Next(10);
            //     Console.WriteLine(val);
            //     tree.Insert(val);           
            // }

            tree.Insert(8);
            tree.Insert(0);
            tree.Insert(1);
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(0);
            tree.Insert(0);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(5);

            Console.WriteLine(tree.ToStringInOrder());
            Console.WriteLine(tree.ToStringDepthFirst());
            Console.WriteLine(tree.ToStringLevelByLevel());

            Console.WriteLine(tree.ToStringLevel(0));
            Console.WriteLine(tree.ToStringLevel(1));
            Console.WriteLine(tree.ToStringLevel(2));

            Console.WriteLine(tree.GetSecondLargestValue());
            
        }
    }

    
}
