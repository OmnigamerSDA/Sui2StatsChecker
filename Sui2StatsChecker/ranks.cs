using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sui2StatsChecker
{
    static class ranks
    {
        public static double[,] probs = new double[13, 3] { { 242,172,98 }, { 80, 224, 124 }, { 175, 32, 144 }, { 13, 108, 144 }, { 134, 179, 144 }, { 229, 243, 157 }, { 67, 51, 177 }, { 202, 102, 216 }, { 94, 160, 249 }, { 146, 56, 164 }, { 146, 164, 196 }, { 26, 224, 203 }, { 202, 96, 236 } };
        public static int[,] growths = new int[13, 3] { { 0, 0, 0 }, { 1, 0, 0 }, { 1, 1, 0 }, { 2, 1, 0 }, { 2, 1, 0 }, { 2, 1, 0 }, { 3, 2, 0 }, { 3, 2, 0 }, { 4, 2, 0 }, { 5, 1, 0 }, { 6, 1, 0 }, { 2, 1, 1 }, { 2, 2, 1 } };
        public static int[] bases = new int[13] { 10, 11, 11, 12, 12, 13, 13, 14, 14, 14, 14, 13, 13 };

        public static double[,] HPprobs = new double[12, 3] { { 67, 192, 216 }, { 121, 96, 216 }, { 161, 64, 91 }, { 13, 256, 157 }, { 229, 256, 91 }, { 188, 64, 91 }, { 53, 256, 91 }, { 175, 192, 157 }, { 40, 256, 223 }, { 107, 256, 85 }, { 13, 192, 236 }, { 161, 192, 144 } };
        public static int[,] HPgrowths = new int[12, 3] { { 3, 5, 3 }, { 4, 6, 3 }, { 5, 7, 4 }, { 7, 7, 4 }, { 7, 8, 4 }, { 8, 10, 4 }, { 10, 10, 4 }, { 11, 11, 4 }, { 13, 12, 4 }, { 18, 7, 3 }, { 7, 3, 16 }, { 22, 8, 2 }};
        public static int[] HPbases = new int[12] { 10, 13, 13, 16, 20, 24, 26, 28, 30, 50, 6, 70 };
    }
}
