using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    // This class represents a node in
    // the link list
    public class Node
    {
        public object data=null;
        public Node next=null;
    }
    public class Node<AnyType>
    {
        public AnyType data ;
        public Node<AnyType> next;
    }
}
