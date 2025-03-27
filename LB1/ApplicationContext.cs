using Microsoft.EntityFrameworkCore;

namespace LB1
{
    // Для работы с базой данных и таблицами в ней 
    internal class ApplicationContext: DbContext
    {
        //связь с таблицей Users
        public DbSet<User> Users { get; set; } = null!;


    //если базы нет, то она будет создана.
    // Если бд есть, но нет таблиц, то они будут созданы.
    // Если бд есть и таблицы есть, то ничего не изменится
    //public ApplicationContext()
    //{
    //    Database.EnsureCreated();
    //}

        // Задаёт параметры подключения к БД 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=1111");
        }


    }
}
