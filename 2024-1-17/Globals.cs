using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_1_17
{
    class Globals
    {
        public static int GlobalUserId {  get; private set; }
        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}
