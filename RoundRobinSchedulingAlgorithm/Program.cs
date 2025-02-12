using System;
using System.Collections.Generic;

public class Process
{
    public int ProcessID { get; set; }
    public int BurstTime { get; set; }
    public int Priority { get; set; }
    public Process Next { get; set; }
}

public class RoundRobinScheduler
{
    private Process head;
    private int timeQuantum;

    public RoundRobinScheduler(int timeQuantum)
    {
        this.timeQuantum = timeQuantum;
    }

    public void AddProcess(int processId, int burstTime, int priority)
    {
        Process newProcess = new Process
        {
            ProcessID = processId,
            BurstTime = burstTime,
            Priority = priority
        };

        if (head == null)
        {
            head = newProcess;
            newProcess.Next = head;
        }
        else
        {
            Process temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newProcess;
            newProcess.Next = head;
        }
    }

    public void RemoveProcessById(int processId)
    {
        if (head == null) return;

        Process current = head;
        Process previous = null;

        do
        {
            if (current.ProcessID == processId)
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                }
                else
                {
                    Process temp = head;
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

    public void SimulateRoundRobin()
    {
        if (head == null) return;

        Queue<Process> processQueue = new Queue<Process>();
        Process current = head;
        do
        {
            processQueue.Enqueue(current);
            current = current.Next;
        } while (current != head);

        int time = 0;
        Dictionary<int, int> waitingTime = new Dictionary<int, int>();
        Dictionary<int, int> turnaroundTime = new Dictionary<int, int>();

        while (processQueue.Count > 0)
        {
            Process process = processQueue.Dequeue();
            int executionTime = Math.Min(process.BurstTime, timeQuantum);
            process.BurstTime -= executionTime;
            time += executionTime;

            if (!waitingTime.ContainsKey(process.ProcessID))
            {
                waitingTime[process.ProcessID] = time - executionTime;
            }

            if (process.BurstTime > 0)
            {
                processQueue.Enqueue(process);
            }
            else
            {
                turnaroundTime[process.ProcessID] = time;
            }

            DisplayProcesses(processQueue);
        }

        CalculateAverageTimes(waitingTime, turnaroundTime);
    }

    private void DisplayProcesses(Queue<Process> processQueue)
    {
        Console.WriteLine("Processes in Queue:");
        foreach (var process in processQueue)
        {
            Console.WriteLine($"Process ID: {process.ProcessID}, Remaining Burst Time: {process.BurstTime}");
        }
        Console.WriteLine();
    }

    private void CalculateAverageTimes(Dictionary<int, int> waitingTime, Dictionary<int, int> turnaroundTime)
    {
        double totalWaitingTime = 0;
        double totalTurnaroundTime = 0;
        int count = waitingTime.Count;

        foreach (var processId in waitingTime.Keys)
        {
            totalWaitingTime += waitingTime[processId];
            totalTurnaroundTime += turnaroundTime[processId];
        }

        Console.WriteLine($"Average Waiting Time: {totalWaitingTime / count}");
        Console.WriteLine($"Average Turnaround Time: {totalTurnaroundTime / count}");
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(4);
        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 3);

        Console.WriteLine("Simulating Round Robin Scheduling:");
        scheduler.SimulateRoundRobin();
    }
}
