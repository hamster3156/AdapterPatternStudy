namespace Hamster.DesignPattern
{
    public class EngineerWork : IReceiveWorkSalary
    {
        // 1�����̋���
        private int monthlySalary = 200000;

        /// <summary>
        /// 1�����̋������󂯎��
        /// </summary>
        public int ReceiveWorkSalary()
        {
            return monthlySalary;
        }
    }
}
