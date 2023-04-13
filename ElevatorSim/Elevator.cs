namespace OOP {

    public class Elevator {

        public int CurrentFloor = 0;
        public int NumberOfFloors = 0;

        public Elevator(int numFloors) {
            NumberOfFloors = numFloors;
            CurrentFloor = 1;
        }

        public void GoToFloor(int floor) {
            if (floor <= NumberOfFloors) {
                CurrentFloor = floor;
            }
        }

    }
}
