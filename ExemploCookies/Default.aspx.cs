using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploCookies
{
    public partial class _Default : Page
    {
        private void Gravar()
        {
            try
            {
                // Se meu brower requisitar cookies
                if (Request.Browser.Cookies)
                {
                    // Instancio a classe Cookie passando como parâmetro o txtNome
                    HttpCookie objCookie = new HttpCookie(this.txtNome.Text);

                    // O value do meu objeto instanciado recebe o txtValor
                    objCookie.Value = this.txtValor.Text;

                    // Defino quanto tempo meu cookie levará para expirar
                    objCookie.Expires = DateTime.Now.AddMinutes(5);

                    // Uso o Response para gravar meu Cookie
                    Response.Cookies.Add(objCookie);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void Recuperar()
        {
            try
            {
                //Crio o cookie passando o txtNome como valor, por meio do Request
                HttpCookie objCookie = Request.Cookies[txtNome.Text];

                //Verifico se meu cookie está diferente de nulo,
                //se estiver atribuo o valor do cookie ao txtValor
                if (objCookie != null)
                {
                    this.txtValor.Text = objCookie.Value;
                }
                else
                {
                    this.txtNome.Text = "Erro, o Cookie está vazio!";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Atualizar()
        {
            try
            {
                // Declara uma variável do tipo string, que irá armazenar os valores
                string totalCookies;

                // Limpa o ListBox
                this.lstCookies.Items.Clear();

                // Faz um laço para percorrer os valores (keys) dos cookies
                foreach (string objString in Request.Cookies.Keys)
                {
                    /* Minha variável recebe a contagem dos valores dos cookies, 
                     * por meio do método Count */
                    totalCookies = Request.Cookies[objString].Values.Keys.Count.ToString();

                    // Adiciona os valores no meu ListBox
                    lstCookies.Items.Add(new ListItem(objString + "(" + totalCookies + ")",
                        Request.Cookies[objString].Value));
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void GravarVariosItens()
        {
            try
            {
                // Instancia a classe Cookie passando como parâmetro o nome do cookie
                HttpCookie objCookie = new HttpCookie("nomeCookie");

                // Adiciona os valores ao meu cookie
                objCookie["Valor1"] = " Valor1";
                objCookie["Valor2"] = " Valor2";
                objCookie["Valor3"] = " Valor3";
                objCookie["Valor4"] = " Valor4";
                objCookie["Valor5"] = " Valor5";

                // Deine quanto tempo o cookie levará para expirar
                objCookie.Expires = DateTime.Now.AddDays(1);

                // Usa o Response para gravar o cookie
                Response.Cookies.Add(objCookie);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void lstCookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se o valor do ListBox for diferente de nulo, o passo para o lblValorCookie
            if (lstCookies.SelectedItem.Value != string.Empty)
            {
                lblValorCookie.Text = lstCookies.SelectedItem.Value;
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            Recuperar();
        }

        protected void lnkAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        protected void btnGravarItens_Click(object sender, EventArgs e)
        {
            GravarVariosItens();
        }
    }
}