using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalizadorDocumentosTeste
{
    public partial class Totalizador : Form
    {
        private string pathRaiz = string.Empty;
        private List<Documento> listaDocumentos = new List<Documento>();

        private List<string> ListaAnos = new List<string>();
        private List<string> ListaMeses = new List<string>();

        private string CategoriaSelecionada = string.Empty;
        private string MesTextoSelecionado = string.Empty;
        private int MesNumeroSelecionado = 0;
        private int AnoSelecionado = 0;

        public Totalizador()
        {
            InitializeComponent();
            //pathRaiz = @"C:\Users\Public\Documents\Documentos Regina";
            //CarregarDocumentos();
        }

        private void btnBuscarPastaRaiz_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPastaRaiz.Text = pathRaiz = folderBrowserDialog1.SelectedPath;
                btnTotalizador.Enabled = true;
            }
            else
            {
                btnTotalizador.Enabled = false;
            }
        }

        private void btnTotalizador_Click(object sender, EventArgs e)
        {
            CarregarDocumentos();
          
        }

        public void CarregarDocumentos()
        {
            string[] files = Directory.GetFiles(pathRaiz, "*", SearchOption.AllDirectories);
            foreach (var dados in files)
            {
                var arrays = dados.Split('\\');
                if (!(arrays.Last() == "desktop.ini" || arrays[6].Contains("Modelo") || arrays[6].Contains("Comprovantes")))
                {


                    var doc = new Documento();
                    doc.Ano = int.Parse(arrays[5]);
                    doc.Mes = arrays[6];
                    doc.Categoria = arrays[7];
                    doc.NomeArquivo = arrays[8];
                    var ArrayValor = doc.NomeArquivo.Replace(".png", "").Split('-');
                    doc.Valor = double.Parse(ArrayValor[3] + "," + ArrayValor[4]);

                    listaDocumentos.Add(doc);
                }
            }

            VerificarAnos();
            //VerificarMeses();
            //var anos = ListaAnos;
        }

        private void VerificarAnos()
        {
            ListaAnos = new List<string>();
            var subpastaAno = Directory.GetDirectories(pathRaiz);

            foreach (var anos in subpastaAno)
            {
                var ano = anos.Split('\\').Last().ToString();
                try
                {
                    var anoConvertido = int.Parse(ano);
                    ListaAnos.Add(anoConvertido.ToString());
                }
                catch
                {

                }
            }

            lstAnos.DataSource = ListaAnos;
        }

        private void VerificarMeses()
        {
            foreach (var ano in ListaAnos)
            {
                var subpastaAno = Directory.GetDirectories(pathRaiz + "\\" + ano);

                foreach (var meses in subpastaAno)
                {
                    var mes = meses.Split('\\').Last().ToString();
                    ListaMeses.Add(mes);
                }

                lstAnos.DataSource = ListaAnos;
            }
        }

        public void LimparGrids(string gridSelecionada)
        {
            if(gridSelecionada == "ano")
            {
                ListMeses.DataSource = null;
                LstCategoria.DataSource = null;
                lstArquivosEscaneados.DataSource = null;
            }
            if(gridSelecionada == "mes")
            {
                LstCategoria.DataSource = null;
                lstArquivosEscaneados.DataSource = null;
            }
            if(gridSelecionada == "categoria")
            {
                lstArquivosEscaneados.DataSource = null;
            }
        }

        private void lstAnos_MouseClick(object sender, MouseEventArgs e)
        {
            LimparGrids("ano");
            //VerificarAnos();
            AnoSelecionado = int.Parse(lstAnos.GetItemText(lstAnos.SelectedValue));

            var mes = from lista in listaDocumentos where lista.Ano == AnoSelecionado group lista by lista.Mes into meses orderby meses.Key select meses;

            ListMeses.DataSource = mes.ToList();
            ListMeses.DisplayMember = "Key";
        }

        private void ListMeses_MouseClick(object sender, MouseEventArgs e)
        {
            LimparGrids("mes");

            MesTextoSelecionado = ListMeses.GetItemText(ListMeses.SelectedValue);



            Mes foo = (Mes)Enum.Parse(typeof(Mes), MesTextoSelecionado);
            MesNumeroSelecionado = (int)foo;

            var pasta = from lista in listaDocumentos where lista.Mes == MesTextoSelecionado group lista by lista.Categoria into categorias orderby categorias.Key select categorias;

            LstCategoria.DataSource = pasta.ToList();
            LstCategoria.DisplayMember = "Key";
        }

        private void LstCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            var aqruivos = new List<Arquivo>();
            LimparGrids("categoria");

            CategoriaSelecionada = LstCategoria.GetItemText(LstCategoria.SelectedValue);

            var lista = listaDocumentos.Where(x => x.Categoria == CategoriaSelecionada && x.Ano == AnoSelecionado && x.Mes == MesTextoSelecionado).ToList();

            //var arquivos = from lista in listaDocumentos 
            //               where lista.Categoria == CategoriaSelecionada && lista.Ano == AnoSelecionado && lista.Mes == MesTextoSelecionado
            //               group lista by lista.NomeArquivo 
            //               into arquivo
            //               orderby arquivo.Key 
            //               select arquivo;

            lstArquivosEscaneados.DataSource = lista;
            
            lstArquivosEscaneados.DisplayMember = "NomeArquivo";

            TotalizadorValores();


        }

        public void TotalizadorValores()
        {
            double totalAno = listaDocumentos.Where(x => x.Ano == AnoSelecionado).Sum(item => item.Valor);
            double totalMes = listaDocumentos.Where(x => x.Ano == AnoSelecionado && x.Mes == MesTextoSelecionado).Sum(item => item.Valor);
            double totalCategoria = listaDocumentos.Where(x => x.Categoria == CategoriaSelecionada && x.Ano == AnoSelecionado && x.Mes == MesTextoSelecionado).Sum(item => item.Valor);

            lblTotalAno.Text = totalAno.ToString();
            lblTotalMes.Text = totalMes.ToString();
            lblTotalCategoria.Text = totalCategoria.ToString();
        }
    }
}