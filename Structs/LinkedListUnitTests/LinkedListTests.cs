using LinkedLists;

namespace LinkedListUnitTests;

public class LinkedListTests
{
    [Fact]
    public void AddNode_ShouldAddSingleNodeToEmptyList()
    {
        // Arrange
        var linkedList = new LinkedList();

        // Act
        linkedList.AddNode(10);

        // Assert
        Assert.NotNull(linkedList.Head);
        Assert.Equal(10, linkedList.Head.Value);
        Assert.Null(linkedList.Head.Next);
    }

    [Fact]
    public void AddNode_ShouldAddMultipleNodesToList()
    {
        // Arrange
        var linkedList = new LinkedList();

        // Act
        linkedList.AddNode(10);
        linkedList.AddNode(20);
        linkedList.AddNode(30);

        // Assert
        Assert.NotNull(linkedList.Head);
        Assert.Equal(10, linkedList.Head.Value);
        Assert.NotNull(linkedList.Head.Next);
        Assert.Equal(20, linkedList.Head.Next.Value);
        Assert.NotNull(linkedList.Head.Next.Next);
        Assert.Equal(30, linkedList.Head.Next.Next.Value);
        Assert.Null(linkedList.Head.Next.Next.Next);
    }

    [Fact]
    public void RemoveLastNode_ShouldRemoveLastNodeFromList()
    {
        // Arrange
        var linkedList = new LinkedList();
        linkedList.AddNode(10);
        linkedList.AddNode(20);
        linkedList.AddNode(30);

        // Act
        var removedNode = linkedList.RemoveLastNode();

        // Assert
        Assert.NotNull(removedNode);
        Assert.Equal(20, removedNode.Value);
        Assert.NotNull(linkedList.Head);
        Assert.Equal(10, linkedList.Head.Value);
        Assert.NotNull(linkedList.Head.Next);
        Assert.Equal(20, linkedList.Head.Next.Value);
        Assert.Null(linkedList.Head.Next.Next);
    }

    [Fact]
    public void RemoveLastNode_ShouldHandleSingleNodeList()
    {
        // Arrange
        var linkedList = new LinkedList();
        linkedList.AddNode(10);

        // Act
        var removedNode = linkedList.RemoveLastNode();

        // Assert
        Assert.Null(linkedList.Head);
        Assert.Null(removedNode);
    }

    [Fact]
    public void RemoveLastNode_ShouldHandleEmptyList()
    {
        // Arrange
        var linkedList = new LinkedList();

        // Act
        var removedNode = linkedList.RemoveLastNode();

        // Assert
        Assert.Null(removedNode);
        Assert.Null(linkedList.Head);
    }

     [Fact]
        public void MergeTwoLists_BothListsEmpty_ReturnsNull()
        {
            // Arrange
            var linkedList = new LinkedList();
            Node list1 = null;
            Node list2 = null;

            // Act
            var result = linkedList.MergeTwoLists(list1, list2);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void MergeTwoLists_OneListEmpty_ReturnsOtherList()
        {
            // Arrange
            var linkedList = new LinkedList();
            var list1 = new Node(1);
            list1.Next = new Node(3);
            list1.Next.Next = new Node(5);
            Node list2 = null;

            // Act
            var result = linkedList.MergeTwoLists(list1, list2);

            // Assert
            Assert.Equal(1, result.Value);
            Assert.Equal(3, result.Next.Value);
            Assert.Equal(5, result.Next.Next.Value);
            Assert.Null(result.Next.Next.Next);
        }

        [Fact]
        public void MergeTwoLists_BothListsNonEmpty_ReturnsMergedSortedList()
        {
            // Arrange
            var linkedList = new LinkedList();
            var list1 = new Node(1);
            list1.Next = new Node(3);
            list1.Next.Next = new Node(5);

            var list2 = new Node(2);
            list2.Next = new Node(4);
            list2.Next.Next = new Node(6);

            // Act
            var result = linkedList.MergeTwoLists(list1, list2);

            // Assert
            Assert.Equal(1, result.Value);
            Assert.Equal(2, result.Next.Value);
            Assert.Equal(3, result.Next.Next.Value);
            Assert.Equal(4, result.Next.Next.Next.Value);
            Assert.Equal(5, result.Next.Next.Next.Next.Value);
            Assert.Equal(6, result.Next.Next.Next.Next.Next.Value);
            Assert.Null(result.Next.Next.Next.Next.Next.Next);
        }
}