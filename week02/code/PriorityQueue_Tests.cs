using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding elements to the queue where the highest priority object is at the end of the list.
    // Expected Result: Should return the highest priority element ("Critical Patient").
    // Defect(s) Found: The original Dequeue function's 'for' loop terminated at '_queue.Count - 1', causing the last element in the queue to be completely ignored.
    public void TestPriorityQueue_1()
    {
       var priorityQueue = new PriorityQueue();
    
    // We add elements. The most important one is at the end.
    priorityQueue.Enqueue("Headache", 1);
    priorityQueue.Enqueue("Fracture", 3);
    priorityQueue.Enqueue("Critical Patient", 5);

    // When dequeuing, it should give us the one with priority 5
    var result = priorityQueue.Dequeue();
    
    Assert.AreEqual("Critical Patient", result);
    }

    [TestMethod]
    // Scenario: Add multiple items that share the same maximum priority.
    //  Expected Result: Should return the item that was queued first ("First Patient") according to the FIFO rule.
    // Defect(s) Found: Found: The condition used the '>=' operator instead of '>', causing a later item to incorrectly replace the first in case of a priority tie, breaking the FIFO rule.
    public void TestPriorityQueue_2()
    {
      var priorityQueue = new PriorityQueue();
    
    // Both have priority 5, but "First Patient" arrived first
    priorityQueue.Enqueue("First Patient", 5);
    priorityQueue.Enqueue("Second Patient", 5);
    priorityQueue.Enqueue("Mild Patient", 1);

    //  "First Patient" should be seen in order of arrival
    var result = priorityQueue.Dequeue();
    
    Assert.AreEqual("First Patient", result);
    }

    // Add more test cases as needed below.
}