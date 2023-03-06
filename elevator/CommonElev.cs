public class CommonElev : Elevator 
{
    public override void MoveFloor(int desiredFloor)
    {
        Console.WriteLine(_floor);

        if (desiredFloor == _floor)
        {
            OpenDoor();
        }
        else
        {
            while (desiredFloor != _floor)
            {
                if (desiredFloor > _floor && desiredFloor <= 30)
                {
                    _floor++;
                    Console.WriteLine(_floor);
                }
                else if (desiredFloor < _floor && desiredFloor >= 1)
                {
                    _floor--;
                    Console.WriteLine(_floor);
                }
            }

            OpenDoor();


        }
    }
  
}