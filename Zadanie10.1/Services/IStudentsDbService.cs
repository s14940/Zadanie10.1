using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie10._1.Services
{
    interface IStudentsDbService
    {
        List<Object[]> ExecuteSelect(SqlCommand command);
        void ExecuteInsert(SqlCommand command);
        SqlConnection GetConnection();
    }
}
