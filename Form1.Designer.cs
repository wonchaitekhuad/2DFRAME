namespace CoordinateApp
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstCoordinates = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.lblCanvas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 15);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 41);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(38, 12);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(38, 38);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 3;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "เพิ่ม (Add)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(38, 93);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "ลบ (Remove)";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstCoordinates
            // 
            this.lstCoordinates.FormattingEnabled = true;
            this.lstCoordinates.Location = new System.Drawing.Point(15, 145);
            this.lstCoordinates.Name = "lstCoordinates";
            this.lstCoordinates.Size = new System.Drawing.Size(150, 290);
            this.lstCoordinates.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(185, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 405);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinates.Location = new System.Drawing.Point(12, 127);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(123, 15);
            this.lblCoordinates.TabIndex = 8;
            this.lblCoordinates.Text = "รายการพิกัด (List)";
            // 
            // lblCanvas
            // 
            this.lblCanvas.AutoSize = true;
            this.lblCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanvas.Location = new System.Drawing.Point(182, 12);
            this.lblCanvas.Name = "lblCanvas";
            this.lblCanvas.Size = new System.Drawing.Size(151, 15);
            this.lblCanvas.TabIndex = 9;
            this.lblCanvas.Text = "พื้นที่แสดงผล (Canvas)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCanvas);
            this.Controls.Add(this.lblCoordinates);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lstCoordinates);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Graphical 2D Frame - Coordinate Input";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstCoordinates;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Label lblCanvas;
    }
}
