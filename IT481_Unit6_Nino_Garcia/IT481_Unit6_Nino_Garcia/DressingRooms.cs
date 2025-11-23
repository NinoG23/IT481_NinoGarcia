using System;
using System.Threading;

public class DressingRooms
{
    private Semaphore semaphore;

    public DressingRooms() : this(3) { }

    public DressingRooms(int rooms)
    {
        semaphore = new Semaphore(rooms, rooms);
    }

    public DateTime RequestRoom()
    {
        DateTime startWait = DateTime.Now;
        semaphore.WaitOne();
        return startWait;
    }

    public void ReleaseRoom()
    {
        semaphore.Release();
    }
}
