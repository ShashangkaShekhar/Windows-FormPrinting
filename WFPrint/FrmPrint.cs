using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPrint.Data;
using WFPrint.Models;
using WFPrint.Utility;

namespace WFPrint
{
    public partial class FrmPrint : Form
    {
        private List<vmItems> data = null;
        private PrintTemplate objPrintTemp = null;

        public FrmPrint()
        {
            InitializeComponent();
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            chkPrintPrv.Text = "Print Preview";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                data = new List<vmItems>();
                data = CartData.GetData();
                new Print(data).PrintDoc();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void chkPrintPrv_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkPrintPrv.Checked)
                {
                    chkPrintPrv.Text = "Generated Preview";

                    PrintPreviewControl ppc;
                    PrintDocument docToPrint = new PrintDocument();
                    PaperSize psize = new PaperSize("Custom", 280, 300);

                    ppc = new PrintPreviewControl();
                    ppc.Name = "PrintPreviewControl1";
                    ppc.Dock = DockStyle.Fill;
                    ppc.Location = new Point(0, 0);
                    ppc.Document = docToPrint;
                    ppc.Zoom = 1;
                    ppc.Document.DocumentName = "c:\\";
                    ppc.UseAntiAlias = true;
                    ppc.Margin = new Padding(0);
                    ppc.BackColor = Color.White;
                    ppc.Document.DefaultPageSettings.PaperSize = psize;
                    ppc.Document.PrintController = new StandardPrintController();

                    tpanelRptPrev.Controls.Clear();
                    tpanelRptPrev.Controls.Add(ppc, 0, 0);

                    objPrintTemp = new PrintTemplate();
                    new PrintTemplate(CartData.GetData());
                    docToPrint.PrintPage += new PrintPageEventHandler(objPrintTemp.Default_Receipt);
                    docToPrint.Dispose();
                }
                else
                {
                    chkPrintPrv.Text = "Print Preview";
                    tpanelRptPrev.Controls.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
