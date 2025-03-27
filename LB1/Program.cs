namespace LB1
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаём 2 объекта user
                User user1  = new User { Name = "Том", Age = 33};
                User user2 = new User { Name = "Алиса", Age = 26 };

                // добавляем пользователей в бд
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}