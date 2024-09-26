namespace Hamster.DesignPattern
{
    public class BonusGameCenterJob : IReceiveJobSalary
    {
        private GameCenterJob gameCenterJob;
        private int bonusSalary = 2000;

        public BonusGameCenterJob()
        {
            gameCenterJob = new();
        }

        public int ReceiveJobSalary(int workHours)
        {
            return gameCenterJob.ReceiveJobSalary(workHours) + bonusSalary;
        }
    }
}
