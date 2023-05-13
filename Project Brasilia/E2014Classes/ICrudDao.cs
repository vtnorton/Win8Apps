using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2014Classes
{
    public interface ICrudDao<T>
    {
        void Inserir(T Entidade);
        T RetornarPorID(string id);
        void StringSQL(String StringSQLASerExecutada);
        void DefinirDado(int id, String tabela, String coluna, int IntASerInserida);
        void DefinirDado(int id, String tabela, String coluna, DateTime DataASerInserida);
    }
}
