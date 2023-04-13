using OOP;

namespace ElevatorTest {
    [TestClass]

    public class ElevatorTest {

        [TestMethod]
        public void TestElevatorAscend() {
            // 1. Setup
            var el = new Elevator(5);

            // 2. Act
            el.GoToFloor(3);

            // 3. Assert
            Assert.AreEqual(el.CurrentFloor, 3);
        }

        // Scrivere un test che verifichi che se all'ascensore viene chiesto di andare ad un piano non esistente, questo rimanga fermo al piano attuale
        [TestMethod]
        public void TestElevatorInvalidFloor() {
            // TODO
        }

    }
}