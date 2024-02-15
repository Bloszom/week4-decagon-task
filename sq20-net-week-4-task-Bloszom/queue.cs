namespace Sq20.Net_Week4_Task
{

    public class Queue<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public Queue()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T data = head.Data;
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            size--;
            return data;
        }

        public int Size()
        {
            return size;
        }
    }
}

