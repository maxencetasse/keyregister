using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace KeyRegister.Global
{
    public static class Method
    {
        public static string _MD5(string MDP)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(MDP)).Select(s => s.ToString("x2")));
        }
    }
}