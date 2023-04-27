using System;
using System.Threading;
using OOP;

namespace ElevatorTest
{
    [TestClass]

    public class ElevatorTest
    {

        [TestMethod]
        public void TestElevatorAscend()
        {
            // 1. Setup
            var el = new Elevator(5);

            // 2. Act
            el.GoToFloor(3);

            // 3. Assert
            Assert.AreEqual(el.CurrentFloor, 3);
        }

        [TestMethod]
        public void TestMaxCapacity()
        {
            Elevator elevator = new Elevator(1000);
            elevator.AddPerson(50);
            Assert.AreEqual(true, elevator.CanAddPerson(1000, 50));


        }
        
        

            [TestMethod]
        public void TestElevatorInvalidFloor()
        {
            // TODO
            Elevator elevator = new Elevator(5);
            elevator.GoToFloor(7);
            Assert.AreEqual(0,elevator.GetNumberOfFloorsMoved(5,7));
        }

        // Scrivere un test che verifichi che se all'ascensore viene chiesto di andare ad un piano non esistente, questo rimanga fermo al piano attuale
        

        public class Ascensore
        {


            private int posizione;

            public Ascensore()
            {


                posizione = 0; // l'ascensore parte dal piano terra
            }



            int currentFloor = 0;
            private int maxFloor;

            // logica per far muovere l'ascensore in su
            public void MoveUp()
            {
                if (currentFloor < maxFloor)
                {
                    currentFloor++;
                    Console.WriteLine("L'ascensore si sta muovendo verso il piano " + currentFloor);
                }
                else
                {
                    Console.WriteLine("Sei già all'ultimo piano.");
                }
            }

            // logica per far muovere l'ascensore in giù
            public void MoveDown()
            {
                if (currentFloor > 0)
                {
                    currentFloor--;
                    Console.WriteLine("L'ascensore si sta muovendo verso il piano " + currentFloor);
                }
                else
                {
                    Console.WriteLine("Sei già al piano terra.");
                }
            }
            public class Elevator
            {
                private const int MAX_CAPACITY = 1000;
                private int currentFloor;
                private int currentCapacity;
                private bool isUnderMaintenance;
                

                public Elevator()
                {
                    ;
                    currentFloor = 1;
                    currentCapacity = 0;
                    isUnderMaintenance = false;
                }

                public void GoToFloor(int n)
                {
                    Ascensore ascensore = new Ascensore();
                    ascensore.MoveUp(); // stampa "L'ascensore è salito al piano 1"
                    ascensore.MoveUp(); // stampa "L'ascensore è salito al piano 2"
                    ascensore.MoveDown(); // stampa "L'ascensore è sceso al piano 1"
                }
                
            }
        }
    }
}









