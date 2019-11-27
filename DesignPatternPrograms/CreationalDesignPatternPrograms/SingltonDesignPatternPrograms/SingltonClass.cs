using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.CreationalDesignPatternPrograms.SingltonDesignPatternPrograms
{
    class SingltonClass
    {
        public void DisplaySingltonClass()
        {
            UserLogin userid = UserLogin.getInstance();
            userid.PrintDetails("First User");
            UserLogin useridsecond = UserLogin.getInstance();
            useridsecond.PrintDetails("Second User");
        }
    }
}
