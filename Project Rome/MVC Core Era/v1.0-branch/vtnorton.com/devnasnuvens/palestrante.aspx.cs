using System;

namespace VTNORTON.devnasnuvens
{
    public partial class palestrante : System.Web.UI.Page
    {
        DateTime Today = DateTime.Now;
        string[] MenssagensPreEvento = { "XXX, tá curioso para saber o que tem nesse QR Code né? Ainda não.", "XXX, Easter Eggs escondidos fazem um evento melhor. Volte depois.", "XXX, depois do evento você pode voltar aqui... ah, não esqueça de usar o filtro do Snapchat no evento hein?" };
        string[] MenssagensPosEvento = { "XXX, obrigado pela sua participação!", "XXX, este evento não teria acontecido se não fosse por você", "XXX, may the cloud be with you" };
        protected void Page_Load(object sender, EventArgs e)
        {
            string Palestrante;
            if (Request.QueryString["id"] != null)
                Palestrante = Request.QueryString["id"];
            else
                Palestrante = "000";

            if (IsAfterEvent()){
                Page.Title = "#DevNasNuvens - Obrigado pela participação!";
                txtH1.Text = "Obrigado pela participação!";
            }
            else{
                Page.Title = "#DevNasNuvens - Bem vindo ao evento!"; //Verificar se Bem vindo é junto ou separado
                txtH1.Text = "Bem vindo ao evento!";
            }
            
            switch (Palestrante)
            {
                case "yanaga":
                case "1224":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Yanaga");
                    break;
                case "duarte":
                case "8953":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Renan");
                    break;
                case "mauro":
                case "9875":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Guilherme");
                    break;
                case "ribeiro":
                case "2345":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Tiago");
                    break;
                case "lacerda":
                case "9472":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Thommy");
                    break;
                case "bassi":
                case "2234":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Giovanni");
                    break;
                case "hugo":
                case "17624":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Victor");
                    break;
                case "hadler":
                case "5224":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Mikael");
                    break;
                case "lamim":
                case "4534":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Jonathan");
                    break;
                case "leonardo":
                case "5534":
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Leonardo");
                    break;
                default:
                    Mensagem.Text = MenssagemSelecionada().Replace("XXX", "Hey");
                    break;
            }

        }
        private string MenssagemSelecionada()
        {
            int Sorteado = new Random().Next(0, 3);
            if (IsAfterEvent())
                return MenssagensPosEvento[Sorteado];
            else
                return MenssagensPreEvento[Sorteado];
        }
        private bool IsAfterEvent()
        {
            return Today > new DateTime(2016, 8, 20, 18, 0, 0);
        }
    }
}