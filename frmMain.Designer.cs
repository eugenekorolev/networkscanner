namespace ListNetworkComputers
{
    partial class mainWindow
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
            this.cmbNetworkComputers = new System.Windows.Forms.ComboBox();
            this.mainPanelPage1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mainControl = new System.Windows.Forms.TabControl();
            this.listPage = new System.Windows.Forms.TabPage();
            this.listPnpDevices = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainPanelPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.mainControl.SuspendLayout();
            this.listPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNetworkComputers
            // 
            this.cmbNetworkComputers.FormattingEnabled = true;
            this.cmbNetworkComputers.Location = new System.Drawing.Point(3, 460);
            this.cmbNetworkComputers.Name = "cmbNetworkComputers";
            this.cmbNetworkComputers.Size = new System.Drawing.Size(213, 21);
            this.cmbNetworkComputers.TabIndex = 0;
            // 
            // mainPanelPage1
            // 
            this.mainPanelPage1.ColumnCount = 1;
            this.mainPanelPage1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanelPage1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.mainPanelPage1.Controls.Add(this.cmbNetworkComputers, 0, 1);
            this.mainPanelPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelPage1.Location = new System.Drawing.Point(3, 3);
            this.mainPanelPage1.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanelPage1.Name = "mainPanelPage1";
            this.mainPanelPage1.RowCount = 2;
            this.mainPanelPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.29892F));
            this.mainPanelPage1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.701078F));
            this.mainPanelPage1.Size = new System.Drawing.Size(336, 485);
            this.mainPanelPage1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 457);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // mainControl
            // 
            this.mainControl.Controls.Add(this.listPage);
            this.mainControl.Controls.Add(this.listPnpDevices);
            this.mainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControl.Location = new System.Drawing.Point(0, 0);
            this.mainControl.Name = "mainControl";
            this.mainControl.SelectedIndex = 0;
            this.mainControl.Size = new System.Drawing.Size(350, 517);
            this.mainControl.TabIndex = 3;
            // 
            // listPage
            // 
            this.listPage.Controls.Add(this.mainPanelPage1);
            this.listPage.Location = new System.Drawing.Point(4, 22);
            this.listPage.Name = "listPage";
            this.listPage.Padding = new System.Windows.Forms.Padding(3);
            this.listPage.Size = new System.Drawing.Size(342, 491);
            this.listPage.TabIndex = 0;
            this.listPage.Text = "Список доступных ПЭВМ";
            this.listPage.UseVisualStyleBackColor = true;
            // 
            // listPnpDevices
            // 
            this.listPnpDevices.Location = new System.Drawing.Point(4, 22);
            this.listPnpDevices.Name = "listPnpDevices";
            this.listPnpDevices.Padding = new System.Windows.Forms.Padding(3);
            this.listPnpDevices.Size = new System.Drawing.Size(342, 491);
            this.listPnpDevices.TabIndex = 1;
            this.listPnpDevices.Text = "Список PnP- устройств в сети";
            this.listPnpDevices.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 517);
            this.Controls.Add(this.mainControl);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сетевой искатель";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainPanelPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.mainControl.ResumeLayout(false);
            this.listPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNetworkComputers;
        private System.Windows.Forms.TableLayoutPanel mainPanelPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl mainControl;
        private System.Windows.Forms.TabPage listPage;
        private System.Windows.Forms.TabPage listPnpDevices;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

