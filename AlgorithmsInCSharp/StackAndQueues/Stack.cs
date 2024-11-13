namespace AlgorithmsInCSharp.StackAndQueues
{
    internal class StackProgram
    {
        public static void StackExample()
        {
            //Creating a Generic Stack to Store Intger Elements
            Stack<int> genericStack = new Stack<int>();

            //Pushing Elements to the Stack using Push Method
            genericStack.Push(10);
            genericStack.Push(20);
            genericStack.Push(30);
            genericStack.Push(50);
            genericStack.Push(25);

            //Printing the Stack Elements using Foreach loop
            Console.WriteLine($"All Generic Stack Elements, Count: {genericStack.Count}");
            foreach (var element in genericStack)
            {
                Console.WriteLine(element);
            }
            //25,50,30,20,10

            // Removing and Returning an Element from the Generic Stack using Pop method
            Console.WriteLine($"\nPop Element: {genericStack.Pop()}");
            //Pop Element 25

            //Printing Elements After Removing the Last Added Element
            Console.WriteLine($"All Stack Elements After Pop: Count {genericStack.Count}");
            foreach (var element in genericStack)
            {
                Console.WriteLine($"{element} ");
            }
            //50,30,20,10

            // Returning an Element from the Generic Stack using Peek method without Removing
            Console.WriteLine($"\nPeek Element: {genericStack.Peek()}");
            //Peek element: 50

            //Printing Elements After Peek the Last Added Element
            Console.WriteLine($"All Stack Elements After Peek: Count {genericStack.Count}");
            foreach (var element in genericStack)
            {
                Console.WriteLine($"{element} ");
            }
            //50,30,20,10
            Console.ReadKey();
        }
    }
}
