namespace Hamster.DesignPattern
{
    public class GameCenterJob : IReceiveJobSalary
    {
        // 1���ԕӂ�̎���
        private int hourlyWage = 1200;

        public int ReceiveJobSalary(int workHours)
        {
            return workHours * hourlyWage;
        }
    }
}
