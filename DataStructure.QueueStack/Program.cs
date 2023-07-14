using DataStructure.QueueStack;

//MyQueue<int> queue = new();
//queue.Enqueue(1);
//queue.Enqueue(2);

//var firstElement = queue.Dequeue();
//Console.WriteLine(firstElement);
//var secondElement = queue.Dequeue();
//Console.WriteLine(secondElement);

MyStack<string> myStack = new();
myStack.Push("A");
myStack.Push("B");
myStack.Push("C");

Console.WriteLine(myStack.Pop());
Console.WriteLine(myStack.Pop());
Console.WriteLine(myStack.Pop());
