using Spring.Data;
using Spring.Data.Common;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Base
{
    abstract public class GenericDao<T> : AdoDaoSupport
    {

        abstract protected IRowMapper<T> GetRowMapper();

        public IList<T> ExecuteQueryWithRowMapper(string command)
        {
            return AdoTemplate.QueryWithRowMapper(
                CommandType.Text, command, GetRowMapper()).ToList<T>();
        }

        public IList<T> ExecuteQueryWithRowMapper(string command, IDbParameters parameters)
        {
            return AdoTemplate.QueryWithRowMapper(
                CommandType.Text, command, GetRowMapper(), parameters).ToList<T>();
        }

    }
}
