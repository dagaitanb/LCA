using System;
using System.Collections.Generic;
using System.Text;

namespace LCA.WebApi.Model
{
    public class Node
    {
        /// <summary>
        /// Node value
        /// </summary>
        public long Value { get; set; }

        /// <summary>
        /// Left Node
        /// </summary>
        public Node Left { get; set; }

        /// <summary>
        /// Right Node
        /// </summary>
        public Node Right { get; set; }

        /// <summary>
        /// Constructor principal
        /// </summary>
        /// <param name="value">Node value</param>
        public Node (long value)
        {
            Value = value;
            Right = null;
            Left = null;
        }
    }
}
