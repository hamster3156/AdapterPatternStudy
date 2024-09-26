namespace Hamster.DesignPattern
{
    public class GameCenterJob : IReceiveJobSalary
    {
        // 時給
        private int hourlyWage = 1200;

        public int ReceiveJobSalary(int workHours)
        {
            return workHours * hourlyWage;
        }
    }
}
