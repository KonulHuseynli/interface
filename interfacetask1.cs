using System;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.FullName = "Huseynli Konul";
            user1.Email = "konulH03@gmail.com";
            user1.Password = "kh";
            Console.WriteLine(user1.PasswordChecker(user1.Password));
            user1.ShowInfo();
        } 
    }
        public interface IAccount
        {
            public abstract bool PasswordChecker(string password);
            public abstract void ShowInfo();
        }

        class User : IAccount
        {
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public void ShowInfo()
            {
                Console.WriteLine($"{Email}   {FullName}");
            }
            public  bool PasswordChecker(string password)
            {
                int LowerCount = 0;
                int UpperCount = 0;
                int DigitCount = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if(password.Length>7)
                    {
                        if(Char.IsLower(password[i]))
                        {
                            LowerCount++;
                        }
                        else if(Char.IsUpper(password[i]))
                        {
                            UpperCount++;
                        }
                        else if(Char.IsDigit(password[i]))
                        {
                            DigitCount++;
                        }
                        if(LowerCount>0 && UpperCount>0 && DigitCount>0)
                        {
                            return true;
                        }
                    }

                }
                return false;

            }
           
        }
    }
