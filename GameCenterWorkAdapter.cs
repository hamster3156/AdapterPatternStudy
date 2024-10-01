namespace Hamster.DesignPattern
{
    public class GameCenterWorkAdapter : IReceiveWorkSalary
    {
        // ����̃C���^�t�F�[�X�ɂ������N���X
        private GameCenterPartTimeWork gameCenterJob;

        // �Œ��8���ԓ���
        private int workHours = 8;

        public GameCenterWorkAdapter()
        {
            gameCenterJob = new();
        }

        /// <summary>
        /// �Q�[���Z���^�[�N���X�̋����擾������Ԃ�
        /// </summary>
        /// <returns></returns>
        public int ReceiveWorkSalary()
        {
            return gameCenterJob.PerHourSalary(workHours);
        }
    }
}
