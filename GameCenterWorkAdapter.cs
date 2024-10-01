namespace Hamster.DesignPattern
{
    public class GameCenterWorkAdapter : IReceiveWorkSalary
    {
        // 特定のインタフェースに対応したいクラス
        private GameCenterPartTimeWork gameCenterJob;

        // 固定で8時間働く
        private int workHours = 8;

        public GameCenterWorkAdapter()
        {
            gameCenterJob = new();
        }

        /// <summary>
        /// ゲームセンタークラスの給料取得処理を返す
        /// </summary>
        public int ReceiveWorkSalary()
        {
            return gameCenterJob.PerHourSalary(workHours);
        }
    }
}
