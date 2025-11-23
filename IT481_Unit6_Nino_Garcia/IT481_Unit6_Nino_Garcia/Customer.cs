using System;
using System.Threading;

public class Customer
{
    private Thread thread;
    private DressingRooms rooms;
    private Random rnd = new Random();
    private int numberOfItems;

    public TimeSpan WaitingTime { get; private set; }
    public TimeSpan UsageTime { get; private set; }
    public int ItemsTriedOn => numberOfItems;

    public Customer(DressingRooms r, int forcedItems)
    {
        rooms = r;
        numberOfItems = forcedItems == 0 ? rnd.Next(1, 7) : forcedItems;
        thread = new Thread(Run);
    }

    public void Start() => thread.Start();
    public void Join() => thread.Join();

    private void Run()
    {
        DateTime requestTime = rooms.RequestRoom();
        DateTime enterRoomTime = DateTime.Now;

        WaitingTime = enterRoomTime - requestTime;

        // Trying on items
        DateTime startUse = DateTime.Now;
        for (int i = 0; i < numberOfItems; i++)
        {
            int minutes = rnd.Next(1, 4);  // 1–3 minutes
            Thread.Sleep(minutes * 100);   // scaled down for testing
        }
        DateTime endUse = DateTime.Now;

        UsageTime = endUse - startUse;
        rooms.ReleaseRoom();
    }
}
