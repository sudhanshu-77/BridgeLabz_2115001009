using System;

public class Task
{
    public int TaskID { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public DateTime DueDate { get; set; }
    public Task Next { get; set; }
}

public class TaskScheduler
{
    private Task head;
    private Task current;

    public void AddTaskAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task
        {
            TaskID = taskId,
            TaskName = taskName,
            Priority = priority,
            DueDate = dueDate
        };

        if (head == null)
        {
            head = newTask;
            newTask.Next = head;
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            newTask.Next = head;
            temp.Next = newTask;
            head = newTask;
        }
    }

    public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
    {
        Task newTask = new Task
        {
            TaskID = taskId,
            TaskName = taskName,
            Priority = priority,
            DueDate = dueDate
        };

        if (head == null)
        {
            head = newTask;
            newTask.Next = head;
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
        }
    }

    public void RemoveTaskById(int taskId)
    {
        if (head == null) return;

        Task current = head;
        Task previous = null;

        do
        {
            if (current.TaskID == taskId)
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                }
                else
                {
                    Task temp = head;
                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }
                    head = current.Next;
                    temp.Next = head;
                }
                return;
            }
            previous = current;
            current = current.Next;
        } while (current != head);
    }

    public Task ViewCurrentTask()
    {
        if (current == null)
        {
            current = head;
        }
        return current;
    }

    public void MoveToNextTask()
    {
        if (current != null)
        {
            current = current.Next;
        }
    }

    public void DisplayAllTasks()
    {
        if (head == null) return;

        Task temp = head;
        do
        {
            Console.WriteLine($"Task ID: {temp.TaskID}, Task Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
            temp = temp.Next;
        } while (temp != head);
    }

    public Task SearchTaskByPriority(int priority)
    {
        if (head == null) return null;

        Task temp = head;
        do
        {
            if (temp.Priority == priority)
            {
                return temp;
            }
            temp = temp.Next;
        } while (temp != head);

        return null;
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();
        scheduler.AddTaskAtBeginning(1, "Task 1", 1, DateTime.Now.AddDays(1));
        scheduler.AddTaskAtEnd(2, "Task 2", 2, DateTime.Now.AddDays(2));
        scheduler.AddTaskAtEnd(3, "Task 3", 3, DateTime.Now.AddDays(3));

        Console.WriteLine("All Tasks:");
        scheduler.DisplayAllTasks();

        Console.WriteLine("\nCurrent Task:");
        Task currentTask = scheduler.ViewCurrentTask();
        Console.WriteLine($"Task ID: {currentTask.TaskID}, Task Name: {currentTask.TaskName}");

        Console.WriteLine("\nMoving to Next Task...");
        scheduler.MoveToNextTask();
        currentTask = scheduler.ViewCurrentTask();
        Console.WriteLine($"Task ID: {currentTask.TaskID}, Task Name: {currentTask.TaskName}");

        Console.WriteLine("\nSearching for Task with Priority 2:");
        Task foundTask = scheduler.SearchTaskByPriority(2);
        if (foundTask != null)
        {
            Console.WriteLine($"Found Task ID: {foundTask.TaskID}, Task Name: {foundTask.TaskName}");
        }

        Console.WriteLine("\nRemoving Task with ID 1");
        scheduler.RemoveTaskById(1);

        Console.WriteLine("\nAll Tasks after removal:");
        scheduler.DisplayAllTasks();
    }
}
