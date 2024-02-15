namespace Sq20.Net_Week4_Task
{   
    public class Stack<T> 
    {
        private Node<T> top;
        private int size;

        public Stack()
        {
            top = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            size++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T data = top.Data;
            top = top.Next;
            size--;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Data;
        }



        public int Size()
        {
            return size;
        }
    }


    /* public class Stack<T>
     {
         private T[] items;
         private int top;
         private const int defaultCapacity = 10;

         public Stack()
         {
             items = new T[defaultCapacity];
             top = -1;
         }

         public bool IsEmpty()
         {
             return top == -1;
         }

         public void Push(T item)
         {
             if (top == items.Length - 1)
                 ResizeArray();

             items[++top] = item;
         }

         public T Pop()
         {
             if (IsEmpty())
                 throw new InvalidOperationException("Stack is empty");

             T poppedItem = items[top];
             items[top--] = default(T);
             return poppedItem;
         }

         public T Peek()
         {
             if (IsEmpty())
                 throw new InvalidOperationException("Stack is empty");

             return items[top];
         }

         public int Size()
         {
             return top + 1;
         }

         private void ResizeArray()
         {
             T[] newArray = new T[items.Length * 2];
             Array.Copy(items, newArray, items.Length);
             items = newArray;
            
         }
     }*/
}
