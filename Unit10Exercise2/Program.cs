using System;

public class Program
{
    public static void Main(string[] args)
    {
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();

        int[] array = new int[100000];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next();
        }
        Array.Sort(array);

        stopWatch.Stop();
        int elapsedTime = stopWatch.GetElapsedTime();
        Console.WriteLine("The running time of a selection sort of 100000 numbers is " + elapsedTime + " milliseconds.");
    }
}

public class StopWatch
{
    private DateTime startTime, endTime;
    public StopWatch() { 
        startTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public DateTime StartTime
    {
        get { return startTime; }
    }

    public DateTime EndTime
    {
        get { return endTime; }
    }

    public int GetElapsedTime()
    {
        return endTime.Millisecond - startTime.Millisecond;
    }
}