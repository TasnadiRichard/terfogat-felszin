using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terfogat_felszin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Testek> testek = new List<Testek>();
            testek.Add(new Teglatest(1, 2, 3));
            testek.Add(new Kocka(4));
            testek.Add(new Henger(4, 6));
            foreach (var item in testek)
            {
                if (item.GetType().Equals(typeof(Teglatest)))
                {
                    Teglatest kor = (Teglatest)item;   
                    Console.WriteLine($"A Téglatest Felszíne: {kor.Felszin()} - Térfogata: {kor.Terfogat()}");  
                }
                else if (item.GetType().Equals(typeof(Kocka)))
                { 
                    Kocka negyzet = (Kocka)item;
                    Console.WriteLine($"\nA Kocka Felszíne: {negyzet.Felszin()} - Térfogata: {negyzet.Terfogat()}");   
                }
                else if (item.GetType().Equals(typeof(Henger)))
                {

                    Henger teglalap = (Henger)item;
                    Console.WriteLine($"\nA Henger Felszíne: {teglalap.Felszin()} - Térfogata: {teglalap.Terfogat()}");
                }

                
            }
            Console.ReadLine();
        }
    }
}

