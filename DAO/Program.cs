﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = "insert into [Table](Name) Values('Pedro')";
            Db.Execute(sql);
            Console.ReadLine();
        }
    }
}
