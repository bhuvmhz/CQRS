using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Extensions
{
    public static class Extensions
    {
        public static string TrimAndLower(this string text)
        {
            return text?.Trim().ToLower();
        }

        public static string TrimAndUpper(this string text)
        {
            return text?.Trim().ToUpper();
        }
    }
}
