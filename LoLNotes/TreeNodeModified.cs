using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoLNotes
{
    class TreeNodeModified : TreeNode
    {
        public TreeNodeModified() : base() { }
        public TreeNodeModified(String name) : base(name) { }
        public TreeNodeModified(String name, TreeNode[] children) : base(name, children) { }
        public enum NodeType
        {
            ASObject,
            Array,
            Dictionary,
            ArrayCollection,
            Double,
            Integer,
            Boolean,
            String,
            Object
        }

        public NodeType Type { get; set; }
        public string ObjName { get; set; }
        public string ChildName { get; set; }
    }
}
