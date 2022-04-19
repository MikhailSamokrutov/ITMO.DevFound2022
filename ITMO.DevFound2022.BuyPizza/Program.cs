using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DevFound2022.BuyPizza
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Numberphome = "89123456";
            do
            {

                
                Console.WriteLine("Введите номер телефона, на который был оформлен заказ");
                Numberphome = Console.ReadLine();
                string numberpizza = "89123456";

                if (Numberphome == numberpizza)

                {
                    Console.WriteLine("Номер заказа введен верно!");
                }

                else
                {
                    Console.WriteLine("Номер заказа введен неверно! Повтор попытки.");

                }

            }
            while (Numberphome != "89123456");
            Console.WriteLine("Оплатить картой?");
            string answer = Console.ReadLine();
            string Yes = "да";
            string No = "нет";

            if (answer == Yes)

            {
                for (int i = 4; i > 0; i--)
                {
                    if  (i==1)
                    {
                        Console.WriteLine("Ошибка. количество попыток ввода закончилось");
                        break;
                        

                    }
                    Console.WriteLine("Приложите карту к терминалу");
                    string pinkod = "1234";
                    Console.WriteLine("введите пинкод");
                    string pindokin = Console.ReadLine();
                    if (pinkod == pindokin)
                    {
                        Console.WriteLine("Оплата прошла успешно!Пицца будет готова в течении 15 минут.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Оплата не выполнена. Пинкод неверный. Повторить попытку.");

                    }
                }
                        
                        
            }





            else if (answer == No)
            {
                Console.WriteLine("В данный момент оплата возможна только картой");
            }
            
            else 
            {

                Console.WriteLine("некорректный ответ");
                    
            }


        }


    }
}
