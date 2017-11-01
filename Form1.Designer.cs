namespace RoomWalkerEditor
{
    partial class Form1
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnSubRow = new System.Windows.Forms.Button();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.btnSubCol = new System.Windows.Forms.Button();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMapGenerator = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.lblExport = new System.Windows.Forms.Label();
            this.btnExportName = new System.Windows.Forms.Button();
            this.grpGrid.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabMapGenerator.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(11, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(287, 16);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Please enter a Row and Column number.";
            // 
            // btnSubRow
            // 
            this.btnSubRow.Location = new System.Drawing.Point(189, 19);
            this.btnSubRow.Name = "btnSubRow";
            this.btnSubRow.Size = new System.Drawing.Size(75, 23);
            this.btnSubRow.TabIndex = 2;
            this.btnSubRow.Text = "Submit";
            this.btnSubRow.UseVisualStyleBackColor = true;
            this.btnSubRow.Click += new System.EventHandler(this.btnSubRow_Click);
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(83, 21);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 3;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(83, 47);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(100, 20);
            this.txtColumns.TabIndex = 4;
            // 
            // btnSubCol
            // 
            this.btnSubCol.Location = new System.Drawing.Point(189, 45);
            this.btnSubCol.Name = "btnSubCol";
            this.btnSubCol.Size = new System.Drawing.Size(75, 23);
            this.btnSubCol.TabIndex = 5;
            this.btnSubCol.Text = "Submit";
            this.btnSubCol.UseVisualStyleBackColor = true;
            this.btnSubCol.Click += new System.EventHandler(this.btnSubCol_Click);
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.btnExportName);
            this.grpGrid.Controls.Add(this.lblExport);
            this.grpGrid.Controls.Add(this.txtExport);
            this.grpGrid.Controls.Add(this.lblCol);
            this.grpGrid.Controls.Add(this.lblRow);
            this.grpGrid.Controls.Add(this.btnExport);
            this.grpGrid.Controls.Add(this.btnGenerate);
            this.grpGrid.Controls.Add(this.btnSubRow);
            this.grpGrid.Controls.Add(this.btnSubCol);
            this.grpGrid.Controls.Add(this.txtRows);
            this.grpGrid.Controls.Add(this.txtColumns);
            this.grpGrid.Location = new System.Drawing.Point(14, 29);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(272, 205);
            this.grpGrid.TabIndex = 6;
            this.grpGrid.TabStop = false;
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(35, 50);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(42, 13);
            this.lblCol.TabIndex = 8;
            this.lblCol.Text = "Column";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(48, 24);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(29, 13);
            this.lblRow.TabIndex = 7;
            this.lblRow.Text = "Row";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(189, 133);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export Map";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(189, 74);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.panel1);
            this.tabMap.Location = new System.Drawing.Point(4, 22);
            this.tabMap.Name = "tabMap";
            this.tabMap.Size = new System.Drawing.Size(477, 433);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Map";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 427);
            this.panel1.TabIndex = 7;
            // 
            // tabMapGenerator
            // 
            this.tabMapGenerator.Controls.Add(this.grpGrid);
            this.tabMapGenerator.Controls.Add(this.lblHeader);
            this.tabMapGenerator.Location = new System.Drawing.Point(4, 22);
            this.tabMapGenerator.Name = "tabMapGenerator";
            this.tabMapGenerator.Size = new System.Drawing.Size(477, 433);
            this.tabMapGenerator.TabIndex = 0;
            this.tabMapGenerator.Text = "Map Generator";
            this.tabMapGenerator.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMapGenerator);
            this.tabControl.Controls.Add(this.tabMap);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(485, 459);
            this.tabControl.TabIndex = 0;
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(85, 106);
            this.txtExport.Name = "txtExport";
            this.txtExport.Size = new System.Drawing.Size(100, 20);
            this.txtExport.TabIndex = 9;
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(23, 113);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(56, 13);
            this.lblExport.TabIndex = 10;
            this.lblExport.Text = "Export File";
            // 
            // btnExportName
            // 
            this.btnExportName.Location = new System.Drawing.Point(189, 104);
            this.btnExportName.Name = "btnExportName";
            this.btnExportName.Size = new System.Drawing.Size(75, 23);
            this.btnExportName.TabIndex = 11;
            this.btnExportName.Text = "Submit";
            this.btnExportName.UseVisualStyleBackColor = true;
            this.btnExportName.Click += new System.EventHandler(this.btnExportName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 475);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Room Walker Map Generator";
            this.grpGrid.ResumeLayout(false);
            this.grpGrid.PerformLayout();
            this.tabMap.ResumeLayout(false);
            this.tabMapGenerator.ResumeLayout(false);
            this.tabMapGenerator.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSubRow;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Button btnSubCol;
        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.Button btnGenerate;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMapGenerator;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportName;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.TextBox txtExport;
    }
}

