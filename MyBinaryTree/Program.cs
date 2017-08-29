using MyBinaryTree;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinaryTree
{
    public class Program
    {
        
        static void Main(string[] args)
        {



           
                BinarySearchTree binarySearchTree = new BinarySearchTree();

                binarySearchTree.Insert(14);
                binarySearchTree.Insert(25);
                binarySearchTree.Insert(15);
                binarySearchTree.Insert(46);
                binarySearchTree.Insert(11);
                binarySearchTree.Insert(20);
                binarySearchTree.Insert(18);
                binarySearchTree.Insert(17);
                binarySearchTree.Insert(50);
                binarySearchTree.Insert(12);
                
                Console.ReadLine();
            }
        }
    }