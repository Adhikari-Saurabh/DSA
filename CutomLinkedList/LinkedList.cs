namespace CutomLinkedList
{
    public class LinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set;}
        public int Count { get; set; }

        public void AddFirst(Node<T> newNode)
        {
            if(First == null)
            {
                First = newNode;
                Last = newNode;

            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
            Count++;
            
        }

        public void AddLast(Node<T> newNode)
        {
            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = Last;
                Last = newNode;
            }
            Count++;
        }

        public void AddAfter(Node<T> newNode, Node<T> existingNode)
        {
            if(Last == existingNode)
            {
                Last = newNode;
            }
            newNode.Next = existingNode;
            existingNode.Next = newNode;  
            Count++;
        }

        public Node<T> Find(T target)
        {
            Node<T> currentNode = First;
            while(currentNode != null && !currentNode.Data.Equals(target)) 
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        public void RemoveFirst()
        {
            if(First == null || Count == 0)
            {
                return;
            }
            First = First.Next;
            Count--;
        }

        public void Remove(Node<T> removeNode)
        {
            if(First == null || Count == 0)
            {
                return;
            }
            if(First == removeNode)
            {
                RemoveFirst();
                return;
            }
            Node<T> previous = First;
            Node<T> current = previous.Next;

            while(current != null && current != removeNode)
            {
                previous = current;
                current = previous.Next;
            }
            if(current != null)
            {
                previous.Next = current.Next;
                Count--;
            }
        }

        public void Traverse()
        {

            Console.WriteLine($"First {First.Data}");
            Console.WriteLine($"Last {Last.Data}");
            Node<T> node = First;
            while(node.Next != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine(node.Data);
        }
       
    }
}
