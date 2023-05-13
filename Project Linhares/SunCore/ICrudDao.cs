using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore
{
    public interface ICrudDao<T>
    {
        void Create(T Entidade);
        void Update(T Entidade);
        void Delete(T Entidade);
        T RetornarID(int id);
    }
}
