using FluentNHibernate.Mapping;
using SunCore;
using SunCore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Mapping
{
    public class DocumentMap:ClassMap<Document>
    {
        public DocumentMap(){
            Id(c => c.Id);
            Map(c => c.BrazilCPF);
            Map(c => c.BrazilRG);
            Map(c => c.Passport);
            Map(c => c.BrazilCDTNumero);
            Map(c => c.BrazilCNPJ);
            Map(c => c.BrazilCDTCadastro);
            Map(c => c.BrazilCDTDataDeEmissao);
            Map(c => c.BrazilCDTPIS);
            Map(c => c.BrazilCDTSerie);
            Map(c => c.BrazilCDTSigla);
            Map(c => c.BrazilCNH);
            Table(TableNames.Document);
        }
    }
}
