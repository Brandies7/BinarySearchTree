namespace MyBinaryTree
{
    public class BinarySearchTree
    {
        private Node root;

        public Node node;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new Node(i);
            newNode.data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.data)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public bool Search(Node node, int number)
        {
            
            if (number > node.data)
            {
                if (node.rightChild == null)
                {
                    return false;
                }
                else if (node.rightChild.data != number)
                {
                    return false;
                }
                else if (node.rightChild.data == number)
                {
                    return true;
                }
            }
            else if (number < node.data)
            {
                if (node.leftChild == null)
                {
                    return false;
                }
                else if (node.leftChild.data != number)
                {
                    return false;
                }
                else if (node.leftChild.data == number)
                {
                    return true;
                }
            }

            return true;
        }
    }
}