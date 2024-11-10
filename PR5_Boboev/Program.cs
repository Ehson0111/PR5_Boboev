using HashPassword;
using pr5_Authorizatio_Boboev_E;
using PR5_Boboev.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_Boboev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    PasswordHasher hasher = new PasswordHasher();
                    
                    // Запрашиваем данные у пользователя
                    Console.Write("Введите имя: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Введите фамилию: ");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Ваша роль Сотруднк, Клиент");
                    string s = Console.ReadLine();
                    s = s.ToLower().Trim();
                    
                    if (s == "клиент")
                    {
                        Console.Write("Введите логин: ");
                    string login = Console.ReadLine();

                    Console.Write("Введите пароль: ");
                    string password = Console.ReadLine();

                    // Хешируем пароль
                    string hashedPassword = hasher.HashPassword1(password);
                    Console.Write($"Хешированный пароль {hashedPassword} \n ");
                        Клиент newClient = new Клиент
                        {
                            Фамилия = lastName,
                            Имя = firstName,

                        };


                        // Создаем экземпляр Helpel и добавляем клиента в базу данных
                        Helpel helpel = new Helpel();

                        Авторизация auth = new Авторизация
                        {
                            login = login,
                            password = hashedPassword,
                            id_role = 1 // Пример: роль клиента
                        };
                        helpel.CreateAuthorization(auth);
                        var authId = helpel.GetLastAuthorizationId();
                        newClient.id_Авторизация = authId;
                        helpel.CreateUser(newClient);
                        Console.WriteLine("Регистрация успешно");


                        Console.ReadKey();
                    }
                    else if (s == "сотрудник")
                    {
                        Console.Write("Введите логин: ");
                        string login = Console.ReadLine();

                        Console.Write("Введите пароль: ");
                        string password = Console.ReadLine();

                        // Хешируем пароль
                        string hashedPassword = hasher.HashPassword1(password);
                        Console.Write($"Хешированный пароль {hashedPassword} \n ");
                        Сотрудник newSotrudnik = new Сотрудник
                        {
                            Фамилия = lastName,
                            Имя = firstName,

                        };


                        // Создаем экземпляр Helpel и добавляем клиента в базу данных
                        Helpel helpel = new Helpel();

                        Авторизация auth = new Авторизация
                        {
                            login = login,
                            password = hashedPassword,
                            id_role = 1 // Пример: роль клиента
                        };
                        helpel.CreateAuthorization(auth);
                        var authId = helpel.GetLastAuthorizationId();
                        newSotrudnik.id_Авторизация = authId;
                        helpel.CreateSotrudnik(newSotrudnik);
                        Console.WriteLine("Регистрация успешно");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Введите коректный роль ");
                        Console.ReadKey();
                    }
                    // Создаем объект Клиент
                    Console.WriteLine("Введите . для завершение ");
                    string d = Console.ReadLine();
                    if (d == ".")
                    {
                        break;

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Ошибка {ex}");
                Console.ReadKey();

            }
        }
    }
}
