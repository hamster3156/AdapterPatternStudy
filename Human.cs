using UnityEngine;

namespace Hamster.DesignPattern
{
    public class Human : MonoBehaviour
    {
        private void Start()
        {
            Job(false, 8);
            Job(true, 8);
        }

        /// <summary>
        /// �A���o�C�g�����郁�\�b�h
        /// </summary>
        private void Job(bool isBonusJob, int jobHours)
        {
            IReceiveJobSalary receiveJobSalary;

            if (isBonusJob)
            {
                receiveJobSalary = new BonusGameCenterJob();
            }
            else
            {
                receiveJobSalary = new GameCenterJob();
            }

            Debug.Log($"{receiveJobSalary.ReceiveJobSalary(jobHours)}�~������I");
        }
    }
}
