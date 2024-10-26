using HashPassword;
using PR5_Boboev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_Boboev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordHasher hasher = new PasswordHasher();

            // Запрашиваем данные у пользователя
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();

            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();

            // Хешируем пароль
            string hashedPassword = hasher.HashPassword1(password);
            Console.Write($"Хешированный пароль поьзователя {hashedPassword} \n ");
            
            // Создаем объект Клиент
            Клиент newClient = new Клиент
            {

                
                Фамилия = lastName,
                Имя = firstName,
                login = login,
                parol = hashedPassword,


            };

            // Создаем экземпляр Helpel и добавляем клиента в базу данных
            Helpel helpel = new Helpel();
            helpel.CreateUser(newClient);

            Console.WriteLine("Клиент успешно добавлен в базу данных.");
            Console.ReadKey();


        }
    }
}
