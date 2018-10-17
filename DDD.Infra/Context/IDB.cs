using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.Context
{
    public interface IDB:IDisposable
    {
        IDbConnection GetCon();
    }
}
