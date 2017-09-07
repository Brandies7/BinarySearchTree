namespace MyBinaryTree
{
    public class Node
    {
        public Node leftChild;
        public int data;
        public Node rightChild;

        public Node(int data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }
    }
}