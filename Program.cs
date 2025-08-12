namespace Assignment6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of ArrayStack with default capacity
            ArrayStack stack = new ArrayStack();
            //push a few numbers onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            //Peek to confirm the top is what you expect
            Console.WriteLine("Top item after pushes: " + stack.Peek());
            //pop a few numbers off the stack
            Console.WriteLine("Popped item: " + stack.Pop());
            //try popping until empty to test underflow handling
            try
            {
                Console.WriteLine("Popped item: " + stack.Pop()); //20
                Console.WriteLine("Popped item: " + stack.Pop()); // 10
                Console.WriteLine("Popped item: " + stack.Pop()); //throws exception
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
            //try pushing until full to test overflow handling
            try
            {
                for (int i = 0; i < 12; i++) // Attempt to push more than the default capacity
                {
                    stack.Push(i);
                    Console.WriteLine("Pushed item: " + i);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
            //edge case: check if stack is empty
            Console.WriteLine("Is stack empty? " + stack.IsEmpty());
            //edge case: check if stack is full
            Console.WriteLine("Is stack full? " + stack.IsFull());
            Console.WriteLine("Final top item: " + stack.Peek());
            Console.ReadKey();
        }
    }
}
