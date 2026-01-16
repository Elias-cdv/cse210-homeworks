using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities and dequeue them.
    // The item with the highest priority should be dequeued first.
    // Expected Result: Items are dequeued in order of priority (highest first): "High", "Medium", "Low"
    // Defect(s) Found: 
    public void TestPriorityQueue_HighestPriorityFirst()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("High", 5);
        
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority.
    // When priorities are equal, items should be dequeued in FIFO order.
    // Expected Result: Items with same priority are dequeued in the order they were added: "First", "Second", "Third"
    // Defect(s) Found: 
    public void TestPriorityQueue_SamePriorityFollowsFIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 3);
        priorityQueue.Enqueue("Second", 3);
        priorityQueue.Enqueue("Third", 3);
        
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Mix of different priorities with some items having the same priority.
    // Expected Result: Higher priority items come first, then FIFO for same priority: "Urgent1", "Urgent2", "Normal1", "Normal2", "Low"
    // Defect(s) Found: 
    public void TestPriorityQueue_MixedPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Normal1", 3);
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Urgent1", 5);
        priorityQueue.Enqueue("Normal2", 3);
        priorityQueue.Enqueue("Urgent2", 5);
        
        Assert.AreEqual("Urgent1", priorityQueue.Dequeue());
        Assert.AreEqual("Urgent2", priorityQueue.Dequeue());
        Assert.AreEqual("Normal1", priorityQueue.Dequeue());
        Assert.AreEqual("Normal2", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to dequeue from an empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: 
    public void TestPriorityQueue_EmptyQueueThrowsException()
    {
        var priorityQueue = new PriorityQueue();
        
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                string.Format("Unexpected exception of type {0} caught: {1}",
                    e.GetType(), e.Message)
            );
        }
    }

    [TestMethod]
    // Scenario: Enqueue items, dequeue some, then enqueue more items.
    // Verifies that the queue maintains correct priority order after mixed operations.
    // Expected Result: "High1", "High2", "Medium"
    // Defect(s) Found: 
    public void TestPriorityQueue_EnqueueAfterDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("High1", 5);
        
        Assert.AreEqual("High1", priorityQueue.Dequeue());
        
        priorityQueue.Enqueue("High2", 5);
        
        Assert.AreEqual("High2", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Single item in queue.
    // Expected Result: That single item is dequeued successfully.
    // Defect(s) Found: 
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("OnlyOne", 1);
        
        Assert.AreEqual("OnlyOne", priorityQueue.Dequeue());
    }
}