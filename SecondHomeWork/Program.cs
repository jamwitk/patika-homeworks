using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomeWork
{
    /*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
     * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan
     * m'e eşit yada tam bölünenleri console'a yazdırın.
     *
     */
    public class SecondQuestion
    {
        public static void Main(string[] arg)
        {
            var girilenSayilar = new List<int>();
            start:
            Console.WriteLine("İki pozitif sayı giriniz.");
            var arr = Console.ReadLine().Split(' ').ToArray();
            var N = Convert.ToInt16(arr[0]);
            var M = Convert.ToInt16(arr[1]);
            if (CheckIfPositiveNumber(N) || CheckIfPositiveNumber(M))
            {
                Console.Clear();
                goto start;
            }
            Console.Clear();
            for (var i = 0; i < N; i++)
            {
                checkpoint:
                Console.WriteLine((i + 1) + ". sayı giriniz.");
                var input = Convert.ToInt16(Console.ReadLine());
                if (CheckIfPositiveNumber(input))
                {
                    goto checkpoint;
                    i--;
                }
                girilenSayilar.Add(input);
            }
            Console.Clear();
            Console.WriteLine("Sonuç:");
            foreach (var t in girilenSayilar.Where(t => t == M || t % 2 == 0))
            {
                Console.WriteLine(t);
            }
        }
        public static bool CheckIfPositiveNumber(int input)
        {
            return input <= 0;
        }
    }

}