namespace LinkedLists;

public class LinkedList
{
    public Node? Head { get; set; }

    public LinkedList()
    {
        Head = null;
    }

    public void AddNode(int value)
    {
        var node = new Node(value);
        if(Head == null){
            Head = node;
            return;
        }
        var current = Head;
        while(current.Next != null){
            current = current.Next;
        }
        current.Next = node;
    }

    public Node RemoveLastNode()
    {
        if(Head == null){
            Console.WriteLine("List is empty");
            return null;
        }

         if(Head.Next == null){
            Console.WriteLine("Single node removed");
            Head = null;	
            return Head;
        }
        
        var secondLast = Head;
        while(secondLast.Next.Next != null){
            secondLast = secondLast.Next;
        }
        secondLast.Next = null;
        return secondLast;
    }

    public static void PrintList(Node head)
    {
        while (head != null) {
            Console.Write(head.Value + " -> ");
            head = head.Next;
        }
        Console.WriteLine("null");
    }
}
