namespace LB1
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // ������ 2 ������� user
                User user1  = new User { Name = "���", Age = 33};
                User user2 = new User { Name = "�����", Age = 26 };

                // ��������� ������������� � ��
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}