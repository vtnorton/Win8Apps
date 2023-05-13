using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonCore
{
    public interface ICrudDao<T>
    {
        void Create(T Entidade);
        void Update(T Entidade);
        void Delete(T Entidade);
        T RetornarID(int id);
    }
}
