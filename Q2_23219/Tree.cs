using System;
using System.Collections.Generic;
using System.Text;

namespace DS_Practical_Test_2_b
{
    public class Tree<T>
    {
        public BinaryNode<T> Root { get; set; }

        public Tree()
        {
            this.Root = null;
        }


    }

    public class BinaryNode<T>
    {
        public Person Data { get; set; }

        public BinaryNode<T> Parent { get; set; }

        public BinaryNode<T>[] Children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            BinaryNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
        public static bool NodeExists(BinaryNode<T> _node, string _name, out BinaryNode<T> _NodeFound)
        {
            _NodeFound = null;
            if (_node == null) return false;
            else if (_node.Data.Name == _name)
            {
                _NodeFound = _node;
                return true;
                
            }
            else if (_node.Children == null) return false;
            else
            {
                if (NodeExists(_node.Children[0], _name, out _NodeFound))
                {
                    
                    return true;
                }

                else return NodeExists(_node.Children[1], _name, out _NodeFound);
            }
           

        }

        public static int IndirectSum(BinaryNode<T> _node, int sum)
        {

            if (_node.Children!= null)
            {
                sum += IndirectSum(_node.Children[0],sum);
                sum += IndirectSum(_node.Children[1],sum);
            }
            return sum;
        }
    }
}
