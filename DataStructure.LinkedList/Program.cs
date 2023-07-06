
using DataStructure.LinkedList;

CustomLinkedList<int> list = new();
list.AddFirst(1);
list.AddLast(2);
list.AddLast(new[] { 3, 4, 5 });
list.AddMiddle(0);
print();

void print()
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}