namespace WFPrint
{
    partial class FrmPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tpanelRptPrev = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chkPrintPrv = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tpanelRptPrev, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkPrintPrv, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.87037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.63889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.259259F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tpanelRptPrev
            // 
            this.tpanelRptPrev.BackColor = System.Drawing.Color.White;
            this.tpanelRptPrev.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tpanelRptPrev.ColumnCount = 1;
            this.tpanelRptPrev.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpanelRptPrev.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpanelRptPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpanelRptPrev.Location = new System.Drawing.Point(3, 37);
            this.tpanelRptPrev.Name = "tpanelRptPrev";
            this.tpanelRptPrev.RowCount = 1;
            this.tpanelRptPrev.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpanelRptPrev.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tpanelRptPrev.Size = new System.Drawing.Size(315, 351);
            this.tpanelRptPrev.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(3, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(315, 35);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // chkPrintPrv
            // 
            this.chkPrintPrv.AutoSize = true;
            this.chkPrintPrv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPrintPrv.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkPrintPrv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrintPrv.Location = new System.Drawing.Point(187, 3);
            this.chkPrintPrv.Name = "chkPrintPrv";
            this.chkPrintPrv.Size = new System.Drawing.Size(131, 28);
            this.chkPrintPrv.TabIndex = 6;
            this.chkPrintPrv.Text = "Print Preview";
            this.chkPrintPrv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPrintPrv.UseVisualStyleBackColor = true;
            this.chkPrintPrv.CheckedChanged += new System.EventHandler(this.chkPrintPrv_CheckedChanged);
            // 
            // FrmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 432);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printing Service";
            this.Load += new System.EventHandler(this.FrmPrint_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tpanelRptPrev;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox chkPrintPrv;
    }
}

