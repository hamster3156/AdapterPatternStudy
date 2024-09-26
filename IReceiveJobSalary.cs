namespace Hamster.DesignPattern
{
    public interface IReceiveJobSalary
    {
        /// <summary>
        /// 仕事で働いた時間の給料を受け取るメソッド
        /// </summary>
        public int ReceiveJobSalary(int jobHours);
    }
}
