using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App_Disk_Pizza_Nostra_Casa.Model;
using App_Disk_Pizza_Nostra_Casa.Service;

using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace App_Disk_Pizza_Nostra_Casa.Model
{

    public class PDF
    {

        /*public string? data_venda { get; set; }

        public List<Venda_Produto_Assoc>? itens_venda { get; set; }

        public List<string>? fornecedores_itens { get; set; }

        public string? funcionario { get; set; }

        public string? cliente { get; set; }

        public void Generation(string? caminho)
        {

            // Preparando o arquivo PDF.

            string caminho_arquivo = Path.GetFullPath(@"Pedido.pdf");

            FileStream arquivo = new FileStream(caminho_arquivo, FileMode.Create);

            Document documento = new Document(PageSize.A4, 3, 2, 3, 2);

            PdfWriter editor_pdf = PdfWriter.GetInstance(documento, arquivo);

            // Criando o conteúdo textual do arquivo PDF.

            List<Paragraph> conteudo_pdf = new List<Paragraph>();

            Paragraph titulo = new Paragraph("Pedido\n\n", new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int) iTextSharp.text.Font.BOLD)));

            titulo.Alignment = Element.ALIGN_CENTER;

            conteudo_pdf.Add(titulo);

            string mensagem_explicacao = "  O pedido do cliente " + this.cliente + " feito pelo funcionário " + this.funcionario + " em " + this.venda.data_venda + " se encontra abaixo:";

            Paragraph explicacao = new Paragraph(mensagem_explicacao, new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12)));

            explicacao.Alignment = Element.ALIGN_LEFT;

            conteudo_pdf.Add(explicacao);

            Paragraph data_emissao_documento = new Paragraph("Documento gerado em: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), new iTextSharp.text.Font(new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10)));

            data_emissao_documento.Alignment = Element.ALIGN_LEFT;

            conteudo_pdf.Add(data_emissao_documento);

            // Pegando uma imagem que será colocada no arquivo PDF.

            //iTextSharp.text.Image logotipo = iTextSharp.text.Image.GetInstance(Path.GetFullPath(@""));

            // Adicionando o conteúdo ao documento.

            documento.Open();
           
            foreach (Paragraph paragrafo in conteudo_pdf)
            {

                documento.Add(paragrafo);

            }

            documento.Close();

        }*/

    }

}