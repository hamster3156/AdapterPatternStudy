namespace Hamster.DesignPattern
{
    // ゲームセンターのアルバイトクラス
    public class GameCenterPartTimeWork
    {
        // 1時間辺りの時給
        private int hourlyWage = 1200;

        /// <summary>
        /// 1時間当たりの給料を返す
        /// </summary>
        /// <param name="workHours">働いた時間</param>
        /// <returns>時間合計の給料</returns>
        public int PerHourSalary(int workHours)
        {
            return workHours * hourlyWage;
        }
    }
}
