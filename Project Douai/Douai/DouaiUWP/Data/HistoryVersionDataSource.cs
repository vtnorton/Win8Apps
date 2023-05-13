using System.Collections.Generic;

namespace DouaiUWP.Data
{
    public class HistoryVersionDataSource
    {
        private static List<HistoryVersion> _items = new List<HistoryVersion>()
        {
            new HistoryVersion()
            {
                Id = 0,
                UpdateRelease = "05/30/2017",
                Changelog = @"Hoje estou lançando uma atualização das grandes para o aplicativo Conjugar! Durante o último mês estive refazendo o código do aplicativo. Sim, ele pode até aparentar igual, mas ele está bem mais polido e terá bem menos erros, além de novidades animadoras que você pode conferir abaixo.

Verbos Irregulares
É com muito prazer que hoje anuncio o suporte para verbos irregulares no aplicativo! E isso me deu trabalho hein! Vale lembrar que a língua portuguesa é bem complexa e pode ser que nem todos os verbos irregulares estão disponíveis, mas são mais de 200 verbos irregulares cadastrados. Bem mais do que o sistema conseguia reconhecer na última versão.

Compras dentro do aplicativo
O aplicativo para Windows 10, tanto PC quanto Tablet e Mobile, terão opção de compras dentro do aplicativo. Você poderá comprar o removedor de anúncios que funciona de forma mágica e tira todos os anúncios do aplicativo e também poderá comprar o pacote de verbos irregulares. Há diversas opções de compras, incluindo opções de doações.

Windows Phone 8.1
Anteriormente eu havia dito que o suporte para Windows 8.1 e Windows Phone 8.1 para esse aplicativo tinha sido encerrado, mas o feedback e o número de usuários utilizando o aplicativo nestes sistemas foram maior do que a minha vontade. E mesmo com o suporte oficial para esses sistemas se encerrando ainda esse ano, o aplicativo Conjugar chega, inclusive com suporte para verbos Irregulares para os usuários do Windows Phone 8.1.
Ah, tem um detalhes, para usar o aplicativo sem anúncios e com os verbos irregulares, você precisará comprar a versão PRO. Vale ressaltar que essa versão não irá dar o direito de utilizar o aplicativo no Windows 10 e vice versa. Não será ofertado nenhuma compra dentro do aplicativo para você.

Envie feedback
Para o aplicativo do Windows 10 é possível enviar feedback dentro do aplicativo, então caso você encontrar algum problema ou tiver alguma sugestão é só mandar o feedback que provavelmente será respondido rapidamente, e caso sua ideia seja boa ela será implementada o mais rápido possível

Outras novidades menores que não são tão grandes para ter uma parte só para elas
Teve muitas outras melhorias claro e correções de bugs, e poderia listar aqui todos, mas vou terminar por aqui.",
                VersionName = "v5.1703.54",
            }
        };
        public static IList<HistoryVersion> GetAllHistoryVersion()
        {
            return _items;
        }
        public static HistoryVersion GetHistoryVersionById(int Id)
        {
            return _items.Find(item => item.Id == Id);
        }
    }
}
