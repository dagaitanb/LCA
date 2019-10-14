
namespace LCA.WebApi.Model
{
    /// <summary>
    /// BinaryTree
    /// </summary>
    public class BinaryTree
    {
        /// <summary>
        /// Root node
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Constructor principal
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }

        /// <summary>
        /// Method to add nodes
        /// </summary>
        /// <param name="value"></param>
        public void Add(long value)
        {
            Root = AddRecursively(Root, new Node(value));
        }

        /// <summary>
        /// Method to add nodes recursively from the root node
        /// </summary>
        /// <param name="current">Root Node</param>
        /// <param name="newNode">New Node to add</param>
        public Node AddRecursively(Node current, Node newNode)
        {
            if (current == null)
                return newNode;

            if (newNode.Value < current.Value)
            {
                current.Left = AddRecursively(current.Left, newNode);
            }
            else if (newNode.Value > current.Value)
            {
                current.Right = AddRecursively(current.Right, newNode);
            }
            else
            {
                return current;
            }

            return current;
        }

    }
}
