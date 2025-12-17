namespace CoordinatesApp
{
    partial class CoordinatesForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxCoords = new System.Windows.Forms.ListBox();
            this.contextMenuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExportJson = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxImportExport = new System.Windows.Forms.GroupBox();
            this.contextMenuList.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxImportExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCoords
            // 
            this.listBoxCoords.ContextMenuStrip = this.contextMenuList;
            this.listBoxCoords.FormattingEnabled = true;
            this.listBoxCoords.ItemHeight = 15;
            this.listBoxCoords.Location = new System.Drawing.Point(6, 22);
            this.listBoxCoords.Name = "listBoxCoords";
            this.listBoxCoords.Size = new System.Drawing.Size(438, 244);
            this.listBoxCoords.TabIndex = 0;
            this.listBoxCoords.SelectedIndexChanged += new System.EventHandler(this.listBoxCoords_SelectedIndexChanged);
            // 
            // contextMenuList
            // 
            this.contextMenuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuList.Name = "contextMenuList";
            this.contextMenuList.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(60, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(60, 51);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(60, 80);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 23);
            this.txtY.TabIndex = 3;
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(60, 109);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(200, 23);
            this.txtLabel.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "ID:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(6, 54);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 15);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(6, 83);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 15);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Y:";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(6, 112);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(41, 15);
            this.lblLabel.TabIndex = 8;
            this.lblLabel.Text = "Label:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(92, 138);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(6, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(120, 30);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Import (JSON/CSV)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExportJson
            // 
            this.btnExportJson.Location = new System.Drawing.Point(132, 22);
            this.btnExportJson.Name = "btnExportJson";
            this.btnExportJson.Size = new System.Drawing.Size(100, 30);
            this.btnExportJson.TabIndex = 13;
            this.btnExportJson.Text = "Export JSON";
            this.btnExportJson.UseVisualStyleBackColor = true;
            this.btnExportJson.Click += new System.EventHandler(this.btnExportJson_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(238, 22);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(100, 30);
            this.btnExportCsv.TabIndex = 14;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 519);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(474, 22);
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.listBoxCoords);
            this.groupBoxList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(450, 275);
            this.groupBoxList.TabIndex = 16;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Coordinates List";
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.lblId);
            this.groupBoxEdit.Controls.Add(this.txtId);
            this.groupBoxEdit.Controls.Add(this.txtX);
            this.groupBoxEdit.Controls.Add(this.btnDelete);
            this.groupBoxEdit.Controls.Add(this.txtY);
            this.groupBoxEdit.Controls.Add(this.btnUpdate);
            this.groupBoxEdit.Controls.Add(this.txtLabel);
            this.groupBoxEdit.Controls.Add(this.btnAdd);
            this.groupBoxEdit.Controls.Add(this.lblX);
            this.groupBoxEdit.Controls.Add(this.lblLabel);
            this.groupBoxEdit.Controls.Add(this.lblY);
            this.groupBoxEdit.Location = new System.Drawing.Point(12, 293);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(450, 177);
            this.groupBoxEdit.TabIndex = 17;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit Coordinate";
            // 
            // groupBoxImportExport
            // 
            this.groupBoxImportExport.Controls.Add(this.btnImport);
            this.groupBoxImportExport.Controls.Add(this.btnExportJson);
            this.groupBoxImportExport.Controls.Add(this.btnExportCsv);
            this.groupBoxImportExport.Location = new System.Drawing.Point(12, 476);
            this.groupBoxImportExport.Name = "groupBoxImportExport";
            this.groupBoxImportExport.Size = new System.Drawing.Size(450, 40);
            this.groupBoxImportExport.TabIndex = 18;
            this.groupBoxImportExport.TabStop = false;
            // 
            // CoordinatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 541);
            this.Controls.Add(this.groupBoxImportExport);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CoordinatesForm";
            this.Text = "Coordinates Manager";
            this.Load += new System.EventHandler(this.CoordinatesForm_Load);
            this.contextMenuList.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxImportExport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCoords;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExportJson;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.GroupBox groupBoxImportExport;
        private System.Windows.Forms.ContextMenuStrip contextMenuList;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
