namespace Hamster.DesignPattern
{
    public class EngineerWork : IReceiveWorkSalary
    {
        // 1ƒ•ŒŽ‚Ì‹‹—¿
        private int monthlySalary = 200000;

        /// <summary>
        /// 1ƒ•ŒŽ‚Ì‹‹—¿‚ðŽó‚¯Žæ‚é
        /// </summary>
        public int ReceiveWorkSalary()
        {
            return monthlySalary;
        }
    }
}
