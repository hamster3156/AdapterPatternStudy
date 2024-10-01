namespace Hamster.DesignPattern
{
    // �Q�[���Z���^�[�̃A���o�C�g�N���X
    public class GameCenterPartTimeWork
    {
        // 1���ԕӂ�̎���
        private int hourlyWage = 1200;

        /// <summary>
        /// 1���ԓ�����̋�����Ԃ�
        /// </summary>
        /// <param name="workHours">����������</param>
        /// <returns>���ԍ��v�̋���</returns>
        public int PerHourSalary(int workHours)
        {
            return workHours * hourlyWage;
        }
    }
}
