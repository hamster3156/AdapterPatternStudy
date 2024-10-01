using UnityEngine;

namespace Hamster.DesignPattern
{
    public class Human : MonoBehaviour
    {
        [SerializeField, Header("エンジニア判定フラグ")]
        private bool isEngineer = false;

        private void Start()
        {
            Work();
        }

        /// <summary>
        /// 働くメソッド
        /// </summary>
        private void Work()
        {
            IReceiveWorkSalary receiveWorkSalary;

            if (isEngineer)
            {
                receiveWorkSalary = new EngineerWork();
                Debug.Log($"エンジニアの月給は{receiveWorkSalary.ReceiveWorkSalary()}円です。");
            }
            else
            {
                // ゲームセンターアルバイトをラップしているアダプタークラスを使う
                receiveWorkSalary = new GameCenterWorkAdapter();
                Debug.Log($"ゲームセンターのアルバイトの日給は{receiveWorkSalary.ReceiveWorkSalary()}円です。");
            }
        }
    }
}
