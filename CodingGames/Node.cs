using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodingGames
{
    internal class Node
    {
        public Node left, right;
        public int value;

        public Node? Find(int v)
        {
            var node = this;
            while (node != null)
            {
                if (node.value == v)
                    return node;
                if (node.left == null && node.right == null)
                    return null;
                if (v < node.value)
                {
                    if (node.left != null)
                    {
                        node = node.left;
                    }
                    else
                        return null;
                }
                else
                {
                    if (node.right != null)
                    {
                        node = node.right;
                    }
                    else
                        return null;

                }

            }

            return null;
        }

    }
    //internal class Test
    //{
    //    private Node _node;
    //    public Test(Node nd)
    //    {
    //        _node = nd;

    //    }
    //    public Node? Find(int v)
    //    {
    //        var node = _node;
    //        while (node != null)
    //        {
    //            if (node.value == v)
    //                return node;
    //            if (node.left == null && node.right == null)
    //                return null;
    //            if (v < node.value)
    //            {
    //                if (node.left != null)
    //                {
    //                    node = node.left;
    //                }
    //                else
    //                    return null;
    //            }
    //            else
    //            {
    //                if (node.right != null)
    //                {
    //                    node = node.right;
    //                }
    //                else
    //                    return null;

    //            }

    //        }

    //        return null;
    //    }

    //    // To print the value of the node found
    //    public void PrintNode(Node? node)
    //    {
    //        if (node != null)
    //            Console.WriteLine("Node found with value: " + node.value);
    //        else
    //            Console.WriteLine("Node not found.");
    //    }
    //}

}
