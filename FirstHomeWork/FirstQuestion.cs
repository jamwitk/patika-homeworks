namespace FirstHomeWork;

public class FirstQuestion
{
    /*
     * Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
     * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
     * Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
     */
    public static void Main(string[] arg)
    {
        var girilenSayilar = new List<int>();
        start:
        Console.WriteLine("Pozitif sayı giriniz : ");
        var input = Convert.ToInt16(Console.ReadLine());
        if (CheckIfPositiveNumber(input))
        {
            Console.Clear();
            goto start;
        }

        for (var i = 0; i < input; i++)
        {
            Console.Clear();
            checkpoint:
            Console.WriteLine((i + 1)+". pozitif sayıyı giriniz: ");
            var _input = Convert.ToInt16(Console.ReadLine());
            if(CheckIfPositiveNumber(_input))
            {
                goto checkpoint;
                i--;
            }
            girilenSayilar.Add(_input);
        }
        Console.WriteLine("Çift sayılar");
        foreach (var t in girilenSayilar.Where(t => t%2==0))
        {
            Console.WriteLine(t);
        }
    }

    public static bool CheckIfPositiveNumber(int input)
    {
        return input <= 0;
    }
}