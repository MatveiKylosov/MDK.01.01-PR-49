using Microsoft.EntityFrameworkCore;
using System;

namespace MDK._01._01_PR_49.Context
{
    public class Config
    {
        public static readonly string connection = "server=127.0.0.1; uid=root; pwd=; database=ISP_21_2_10";
        public static readonly MySqlServerVersion version = new MySqlServerVersion(new Version(8, 0, 11));
    }
}
