namespace _4
{
    partial class FormQLHangHoa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelMaVach = new System.Windows.Forms.Label();
            this.txtmavach = new System.Windows.Forms.TextBox();
            this.cmdtim = new System.Windows.Forms.Button();
            this.cmdthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(587, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelMaVach
            // 
            this.labelMaVach.AutoSize = true;
            this.labelMaVach.Location = new System.Drawing.Point(12, 44);
            this.labelMaVach.Name = "labelMaVach";
            this.labelMaVach.Size = new System.Drawing.Size(66, 16);
            this.labelMaVach.TabIndex = 1;
            this.labelMaVach.Text = "Mã Vạch: ";
            // 
            // txtmavach
            // 
            this.txtmavach.Location = new System.Drawing.Point(84, 41);
            this.txtmavach.Name = "txtmavach";
            this.txtmavach.Size = new System.Drawing.Size(243, 22);
            this.txtmavach.TabIndex = 2;
            this.txtmavach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmavach_KeyDown_1);
            this.txtmavach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmavach_KeyPress_1);
            // 
            // cmdtim
            // 
            this.cmdtim.Location = new System.Drawing.Point(364, 35);
            this.cmdtim.Name = "cmdtim";
            this.cmdtim.Size = new System.Drawing.Size(88, 34);
            this.cmdtim.TabIndex = 4;
            this.cmdtim.Text = "Tìm kiếm";
            this.cmdtim.UseVisualStyleBackColor = true;
            this.cmdtim.Click += new System.EventHandler(this.cmdtim_Click);
            this.cmdtim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdtim_KeyDown);
            this.cmdtim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdtim_KeyPress);
            // 
            // cmdthoat
            // 
            this.cmdthoat.Location = new System.Drawing.Point(489, 35);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(88, 34);
            this.cmdthoat.TabIndex = 5;
            this.cmdthoat.Text = "Thoát";
            this.cmdthoat.UseVisualStyleBackColor = true;
            this.cmdthoat.Click += new System.EventHandler(this.cmdthoat_Click);
            // 
            // FormQLHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(610, 558);
            this.Controls.Add(this.cmdthoat);
            this.Controls.Add(this.cmdtim);
            this.Controls.Add(this.txtmavach);
            this.Controls.Add(this.labelMaVach);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormQLHangHoa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hàng Hóa";
            this.Load += new System.EventHandler(this.FormQLHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMaVach;
        private System.Windows.Forms.TextBox txtmavach;
        private System.Windows.Forms.Button cmdtim;
        private System.Windows.Forms.Button cmdthoat;
    }
}