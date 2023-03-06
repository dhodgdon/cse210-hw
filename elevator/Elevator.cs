public abstract class Elevator
{
    protected int _elevatorNumber;
    protected int _floor;
    protected bool _isOpen = false;
    // protected List<int> _floorsAvailable;

    public Elevator()
    {
        _elevatorNumber = 1;
        _floor = 1;
        // _floorsAvailable = new List<int>(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30);
    }

    public void CloseDoor()
    {
        if (_isOpen == true)
        {
            _isOpen = false;
            Console.WriteLine("Door is closed.");
        }
    }

    public void OpenDoor()
    {
        if (_isOpen == false)
        {
            _isOpen = true;
            Console.WriteLine("Door is open.");
            Thread.Sleep(5000);
            CloseDoor();
        }
    }

    public abstract void MoveFloor(int desiredFloor);
    // {
    //     if (desiredFloor == _floor)
    //     {
    //         OpenDoor();
    //     }
    //     else
    //     {
    //         while (desiredFloor != _floor)
    //         {
    //             if (desiredFloor > _floor)
    //             {
    //                 _floor++;
    //                 Console.WriteLine(_floor);
    //             }
    //             else if (desiredFloor < _floor)
    //             {
    //                 _floor--;
    //                 Console.WriteLine(_floor);
    //             }
    //         }

    //         OpenDoor();
    //     }
    // }
}