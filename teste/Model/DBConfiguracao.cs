using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model
{
    public class DBConfiguracao : DbConfiguration
    {
        public DBConfiguracao()
        {
            //SetDatabaseInitializer<Contexto>(new my)
           // SetDefaultConnectionFactory(IdbCoj)
        }
    }
}
