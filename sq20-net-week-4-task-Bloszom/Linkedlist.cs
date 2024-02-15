namespace Sq20.Net_Week4_Task
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private int size;

        public LinkedList()
        {
            head = null;
            size = 0;
        }

        public int Add(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            size++;
            return size;
        }

        public bool Remove(T item)
        {
            if (head == null)
                return false;

            if (head.Data.Equals(item))
            {
                head = head.Next;
                size--;
                return true;
            }

            Node<T> startPoint = head;
            while (startPoint.Next != null)
            {
                if (startPoint.Next.Data.Equals(item))
                {
                    startPoint.Next = startPoint.Next.Next;
                    size--;
                    return true;
                }
                startPoint = startPoint.Next;
            }

            return false;
        }

        public bool Check(T item)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return true;
                }
                else
                {
                    current = current.Next;
                }
                
            }
            return false;
        }

        public int Index(T item)
        {
            Node<T> current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(item))
                    return index;
                current = current.Next;
                index++;
            }
            return -1;
        }

    }
}

