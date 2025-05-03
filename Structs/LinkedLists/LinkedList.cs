namespace LinkedLists;

public class LinkedList
{
    public Node? Head { get; set; }

    public LinkedList()
    {
        Head = null;
    }

    public void AddNode(int Valueue)
    {
        var node = new Node(Valueue);
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
    public Node MergeTwoLists(Node list1, Node list2) {
        Node newList = new Node();
        Node point = newList;
       
        while(list1 != null && list2 != null){
            if(list1.Value <= list2.Value){
                newList.Next = list1;
                list1 = list1.Next;
            }else{
                newList.Next = list2;
                list2 = list2.Next;
            }
            newList = newList.Next;
        }
        newList.Next = list1 is {} ? list1 : list2;
        return point.Next;
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
