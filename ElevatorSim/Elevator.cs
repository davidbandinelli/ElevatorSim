namespace OOP {

    public class Elevator
    {

        public int CurrentFloor = 0;
        public int NumberOfFloors = 0;
        private const int MAX_CAPACITY = 1000;
        private int currentFloor;
        private int currentCapacity;
        private bool isUnderMaintenance;
        private int selectfloor;

       

        public Elevator()
        {
            
            currentFloor = 1;
            currentCapacity = 0;
            isUnderMaintenance = false;
        }



        public Elevator(int numFloors)
        {
            NumberOfFloors = numFloors;
            CurrentFloor = 1;
        }

        public int GetNumberOfFloorsMoved(int totalfloors, int selectfloor)
        {

            int totalFloorsMoved = 0;
            if (totalfloors < selectfloor || selectfloor < 1 || isUnderMaintenance||selectfloor==currentFloor)
            {
                return totalFloorsMoved;
            }
            else
            {
                totalFloorsMoved = selectfloor - currentFloor;
                return totalFloorsMoved;
            }

            
        }

        public void GoToFloor(int floor)
        {

            if (floor <= NumberOfFloors)
            {
                CurrentFloor = floor;
            }
        }


        public void StartMaintenance()
        {
            isUnderMaintenance = true;
        }

        public void EndMaintenance()
        {
            isUnderMaintenance = false;
        }

        public bool IsUnderMaintenance()
        {
            return isUnderMaintenance;
        }

        public bool CanAddPerson(int maxWeight, int currentPerson)
        {
            int maxPeopleLimit = 4;

            List<(string, int)> passengers = new List<(string, int)>()
        {
            ("Joe", 200),
            ("Mary", 300),
            ("John", 400)
        };

            if (isUnderMaintenance)
            {
                return false;
            }
            int totalWeight = 0;
            int totalPassengers = 0;
            foreach (var passenger in passengers)
            {
                totalWeight += passenger.Item2;
                totalPassengers++;
            }
            totalWeight += currentPerson;
            totalPassengers++;

            if (totalWeight > maxWeight || totalPassengers > maxPeopleLimit)
            {
                Console.WriteLine("massimo peso o numero di persone");
                return false;
            }

            return true;
        }


        public void AddPerson(int weight)
        {

            if (CanAddPerson(weight,900))
            {
                currentCapacity += weight;
            }
        }
    }
  }
        


    

