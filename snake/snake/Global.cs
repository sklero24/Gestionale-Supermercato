using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ciao mondo

namespace snake
{
    public static class Global
    {

        public static bool volume = true;
        public static short livello = 1;
        public static int difficoltaMinimaTic = 30;
        public static int punti = 0;
        public static int eventBigFoodInc = 0; //ogni 5 punti presi arriva 1 big point
        public static int eventBigFoodIsWritten = 0;

    }
}
