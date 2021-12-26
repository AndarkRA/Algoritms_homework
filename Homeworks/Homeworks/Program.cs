/*using System;
using HW6_1;
using System.Collections;

namespace HW6_1
{

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode myTree = new TreeNode();


            myTree.add(55);
            myTree.add(19);
            myTree.add(36);
            myTree.add(48);
            myTree.add(51);
            myTree.add(15);
            myTree.add(98);
            myTree.add(42);
            myTree.add(16);
            myTree.add(44);
            myTree.add(30);
            myTree.add(9);





            myTree.printTreeBFS();
            Console.WriteLine();

            myTree.printTreeDFS();
            Console.WriteLine();
        }
    }
} */


using System;

namespace HW6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graf myGraf = new Graf();
            myGraf.AddVertex(15);
            myGraf.AddVertex(25);
            myGraf.AddVertex(35);
            myGraf.AddVertex(45);
            myGraf.AddVertex(55);

            myGraf.AddEdge(15, 25, 10);
            myGraf.AddEdge(15, 35, 8);

            myGraf.AddEdge(45, 25, 7);
            myGraf.AddEdge(55, 35, 6);
            myGraf.AddEdge(45, 55, 5);

            myGraf.printGrafBFS();
            myGraf.printGrafDFS();

            Console.ReadLine();
        }
    }
}
