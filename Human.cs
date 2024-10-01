using UnityEngine;

namespace Hamster.DesignPattern
{
    public class Human : MonoBehaviour
    {
        [SerializeField, Header("�G���W�j�A����t���O")]
        private bool isEngineer = false;

        private void Start()
        {
            Work();
        }

        /// <summary>
        /// �������\�b�h
        /// </summary>
        private void Work()
        {
            IReceiveWorkSalary receiveWorkSalary;

            if (isEngineer)
            {
                receiveWorkSalary = new EngineerWork();
                Debug.Log($"�G���W�j�A�̌�����{receiveWorkSalary.ReceiveWorkSalary()}�~�ł��B");
            }
            else
            {
                // �Q�[���Z���^�[�A���o�C�g�����b�v���Ă���A�_�v�^�[�N���X���g��
                receiveWorkSalary = new GameCenterWorkAdapter();
                Debug.Log($"�Q�[���Z���^�[�̃A���o�C�g�̓�����{receiveWorkSalary.ReceiveWorkSalary()}�~�ł��B");
            }
        }
    }
}
