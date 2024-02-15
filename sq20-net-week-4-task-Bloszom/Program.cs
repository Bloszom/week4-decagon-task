namespace Sq20.Net_Week4_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            //LinkedList mylist = new LinkedList();



            LinkedList<int> linkedList = new LinkedList<int>();
            Console.WriteLine(linkedList.Add(1));
            Console.WriteLine(linkedList.Add(2));
            Console.WriteLine(linkedList.Add(3)); 
            Console.WriteLine(linkedList.Remove(2)); // Output: true
            Console.WriteLine(linkedList.Check(3));  // Output: true
            Console.WriteLine(linkedList.Index(3));  // Output: 1



           /* Stack<int> stack = new Stack<int>();
            Console.WriteLine(stack.IsEmpty());  // Output:  True just kin time
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.IsEmpty());  // Output: False
            Console.WriteLine(stack.Peek());      // Output: 3
            Console.WriteLine(stack.Pop());       // Output: 3
            Console.WriteLine(stack.Size());      // Output: 2*/



            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
           // queue.Enqueue(3);
           // Console.WriteLine(queue.IsEmpty()); // Output: False
            //Console.WriteLine(queue.Dequeue()); // Output: 1
            // Console.WriteLine(queue.Size());    // Output: 2


        }
    }
}
