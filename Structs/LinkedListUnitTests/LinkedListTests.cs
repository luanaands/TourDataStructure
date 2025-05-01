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
}