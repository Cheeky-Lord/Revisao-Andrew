using DDD.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinApplication.Configuration
{
    public class MSSQLConfiguration : IDBConfiguration
    {
        public string ConnectionString { get => @"Server=ANDREW-SURFACE\ANDREW;Database=LTP5;User Id=sa;Password=123;"; }
    }
}
