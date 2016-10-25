using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sui2StatsChecker
{
    static class characters
    {
        public static string[] names = { "Riou", "Abizboah", "Amada", "Anita", "Ayda", "Badeaux", "Bob", "Bolgan", "Camus", "Chaco", "Chuchara", "Clive", "Eilie", "Feather", "Flik", "Freed Y", "Futch", "Gabocha", "Gadget", "Gantetsu", "Gengen", "Genshu", "Georg", "Gijimu", "Hai Yo", "Hanna", "Hauser", "Hix", "Hoi", "Humphrey", "Jowy", "Jowy", "Kahn", "Karen", "Kasumi", "Killey", "Kinnison", "Koyu", "L.C.Chan", "Lo Wen", "Lorelai", "Luc", "Makumaku", "Mazus", "McDohl", "Meg", "Mekumeku", "Miklotov", "Mikumiku", "Millie", "Millie", "Mokumoku", "Mondo", "Mukumuku", "Nanami", "Nina", "Oulan", "Pesmerga", "Rikimaru", "Rina", "Rulodia", "Sasuke", "Sheena", "Shilo", "Shin", "Shiro", "Sid", "Sierra", "Sigfried", "Simone", "Stallion", "Tai Ho", "Tengaar", "Tomo", "Tsai", "Tuta", "Valeria", "Viki", "Viktor", "Vincent", "Wakaba", "Yoshino", "Zamza" };
        public static int[] magic = { 5, 1, 2, 4, 3, 3, 3, 1, 4, 3, 2, 2, 4, 3, 6, 3, 3, 3, 0, 4, 3, 3, 0, 2, 3, 2, 3, 3, 2, 1, 7, 7, 5, 4, 3, 3, 3, 3, 3, 3, 4, 8, 4, 7, 7, 3, 2, 3, 2, 4, 4, 1, 3, 2, 3, 5, 1, 3, 2, 6, 3, 3, 4, 3, 3, 3, 3, 6, 5, 4, 3, 3, 6, 3, 3, 2, 3, 6, 1, 3, 3, 4, 5 };
        public static int[] strength = { 6, 7, 5, 5, 4, 4, 4, 7, 5, 4, 12, 4, 4, 5, 6, 4, 4, 3, 4, 4, 4, 5, 8, 6, 3, 5, 7, 4, 3, 7, 5, 5, 4, 4, 4, 4, 4, 3, 5, 5, 4, 0, 1, 3, 6, 3, 3, 6, 2, 2, 2, 4, 5, 3, 4, 4, 5, 8, 6, 3, 5, 4, 5, 4, 5, 4, 4, 4, 6, 4, 4, 5, 3, 5, 4, 2, 6, 2, 10, 4, 5, 3, 5 };
        public static int[] mdef = { 5, 1, 3, 5, 4, 4, 6, 3, 4, 6, 2, 4, 5, 3, 4, 4, 3, 3, 4, 5, 2, 3, 0, 3, 3, 3, 3, 4, 2, 3, 6, 6, 5, 4, 5, 5, 5, 5, 4, 4, 6, 7, 4, 8, 6, 5, 2, 4, 2, 6, 6, 3, 4, 3, 5, 6, 7, 6, 2, 6, 3, 3, 5, 3, 2, 5, 5, 5, 6, 6, 5, 5, 5, 4, 4, 3, 4, 4, 4, 6, 4, 4, 5 };
        public static int[] prot =  { 4, 6, 5, 4, 4, 4, 5, 5, 5, 4, 5, 3, 4, 4, 5, 4, 3, 3, 7, 5, 4, 4, 6, 5, 4, 6, 6, 4, 3, 8, 5, 5, 4, 3, 3, 5, 4, 3, 4, 4, 4, 0, 2, 2, 6, 3, 2, 6, 2, 3, 3, 4, 5, 2, 4, 4, 7, 5, 5, 3, 5, 4, 4, 3, 3, 3, 5, 3, 4, 3, 3, 4, 3, 4, 5, 1, 4, 2, 7, 3, 4, 3, 5 };
        public static int[] speed = { 6, 0, 3, 5, 6, 4, 5, 1, 5, 5, 3, 6, 5, 5, 5, 4, 6, 5, 4, 3, 4, 5, 6, 4, 4, 3, 3, 5, 6, 2, 6, 6, 4, 4, 8, 5, 5, 5, 6, 4, 5, 6, 5, 4, 5, 4, 4, 4, 7, 4, 4, 3, 5, 5, 7, 4, 3, 3, 3, 4, 2, 7, 4, 4, 4, 7, 5, 5, 3, 4, 8, 4, 4, 5, 4, 5, 6, 2, 4, 4, 6, 4, 3 };
        public static int[] tech = { 7, 2, 3, 6, 5, 4, 4, 2, 5, 4, 5, 8, 5, 5, 6, 4, 5, 6, 5, 3, 5, 5, 7, 3, 3, 5, 4, 5, 5, 4, 7, 7, 5, 4, 6, 4, 6, 4, 7, 4, 6, 5, 3, 4, 7, 5, 3, 4, 3, 3, 3, 1, 5, 3, 6, 3, 4, 5, 4, 4, 3, 6, 5, 8, 7, 5, 4, 4, 4, 5, 5, 6, 4, 6, 7, 3, 6, 5, 4, 6, 6, 4, 4 };
        public static int[] hp = { 5, 11, 7, 5, 4, 5, 6, 6, 4, 3, 10, 4, 4, 9, 5, 4, 4, 3, 4, 4, 4, 4, 6, 6, 4, 5, 6, 4, 3, 7, 4, 4, 5, 4, 4, 4, 4, 4, 5, 5, 4, 3, 1, 4, 5, 3, 2, 5, 2, 3, 3, 4, 5, 2, 3, 4, 7, 5, 8, 3, 11, 4, 4, 4, 4, 4, 4, 4, 9, 4, 4, 4, 4, 4, 4, 0, 5, 3, 6, 4, 4, 4, 5 };
        public static int[] luck = { 7, 5, 4, 4, 6, 3, 2, 6, 4, 6, 6, 2, 5, 4, 2, 7, 6, 6, 3, 4, 6, 5, 5, 4, 4, 4, 3, 6, 7, 2, 6, 6, 3, 5, 5, 4, 5, 4, 6, 5, 4, 0, 3, 1, 6, 7, 5, 4, 3, 7, 7, 3, 4, 3, 5, 4, 1, 1, 3, 4, 4, 4, 4, 6, 7, 5, 5, 2, 2, 3, 3, 4, 5, 4, 6, 5, 5, 8, 5, 3, 6, 5, 2 };
    }
}
