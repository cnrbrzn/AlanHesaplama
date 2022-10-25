using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class GeometricShapes
    {
        public void Circle()
        {
            int r = 0, Csecim = 0;
            double PI = Math.PI, Calan = 0, Ccevre = 0;
            Console.Write("Dairenin Yarıçapı: ");
            r = Convert.ToInt16(Console.ReadLine());
            Console.Write("1-Alan Hesabı\n2-Çevre Hesabı\n");
            Csecim = int.Parse(Console.ReadLine());
            switch (Csecim)
            {
                case 1:
                    Calan = PI * r * r;
                    Console.Write($"Dairenin Alanı: {Calan}\n\n");
                    break;
                case 2:
                    Ccevre = 2 * PI * r;
                    Console.Write($"Dairenin Çevresi: {Ccevre}\n\n");
                    break;
                default:
                    break;
            }
        }
        public void Triangle()
        {
            int h = 0, a = 0, Tsecim = 0, Talan = 0, Tcevre = 0;
            Console.Write("Üçgenin Taban Kenarı: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Üçgenin Yükseliği: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("1-Alan Hesabı\n2-Çevre Hesabı\n");
            Tsecim = int.Parse(Console.ReadLine());
            switch (Tsecim)
            {
                case 1:
                    Talan = (h * a) / 2;
                    Console.Write($"Üçgenin Alanı: {Talan}\n");
                    break;
                case 2:
                    Tcevre = 3 * a;
                    Console.Write($"Üçgenin Çevresi: {Tcevre}\n");
                    break;
                default:
                    break;
            }
        }
        public void Square()
        {
            int Skenar = 0, S_alan = 0, S_cevre = 0, Ssecim = 0;
            Console.Write("Karenin Kenarı: ");
            Skenar = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("1-Alan Hesabı\n2-Çevre Hesabı\n");
            Ssecim = int.Parse(Console.ReadLine());
            switch (Ssecim)
            {
                case 1:
                    S_alan = Skenar * Skenar;
                    Console.Write($"Karenin Alanı: {S_alan}\n");
                    break;
                case 2:
                    S_cevre = 4 * Skenar;
                    Console.Write($"Karenin Çevresi: {S_cevre}\n");
                    break;
                default:
                    break;
            }
        }
        public void Rectangle()
        {
            int uzunKenar = 0, kısaKenar, R_alan = 0, R_cevre = 0, Rsecim = 0;
            Console.Write("Dikdörtgenin Uzun Kenarı: ");
            uzunKenar = int.Parse(Console.ReadLine());

            Console.Write("Dikdörtgenin Kısa Kenarı: ");
            kısaKenar = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("1-Alan Hesabı\n2-Çevre Hesabı\n");
            Rsecim = int.Parse(Console.ReadLine());
            switch (Rsecim)
            {
                case 1:
                    R_alan = uzunKenar * kısaKenar;
                    Console.Write($"Dikdörtgenin Alanı: {R_alan}\n");
                    break;
                case 2:
                    R_cevre = (2 * uzunKenar) + (2 * kısaKenar);
                    Console.Write($"Dikdörtgenin Çevresi: {R_cevre}\n");
                    break;
                default:
                    break;
            }
        }
    }
}
