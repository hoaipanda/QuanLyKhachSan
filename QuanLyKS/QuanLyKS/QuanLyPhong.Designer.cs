namespace QuanLyKS
{
    partial class QuanLyPhong
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
            this.bntClear = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.txtSophong = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.bntThoat = new System.Windows.Forms.Button();
            this.dtPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // bntClear
            // 
            this.bntClear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntClear.Location = new System.Drawing.Point(60, 204);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 67;
            this.bntClear.Text = "Clear";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Location = new System.Drawing.Point(221, 204);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 66;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(57, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(57, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Số phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(436, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Mã Loại Phòng";
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(183, 101);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(149, 20);
            this.txtMaphong.TabIndex = 51;
            this.txtMaphong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // txtMaLP
            // 
            this.txtMaLP.Location = new System.Drawing.Point(562, 97);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(149, 20);
            this.txtMaLP.TabIndex = 52;
            this.txtMaLP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaLP_KeyDown);
            // 
            // txtSophong
            // 
            this.txtSophong.Location = new System.Drawing.Point(183, 138);
            this.txtSophong.Name = "txtSophong";
            this.txtSophong.Size = new System.Drawing.Size(149, 20);
            this.txtSophong.TabIndex = 54;
            this.txtSophong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSophong_KeyDown);
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(562, 140);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(149, 20);
            this.txtTrangthai.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(436, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Trạng Thái ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(792, 32);
            this.flowLayoutPanel1.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(323, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "QUẢN LÝ PHÒNG";
            // 
            // bntSua
            // 
            this.bntSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntSua.Location = new System.Drawing.Point(367, 205);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(75, 23);
            this.bntSua.TabIndex = 59;
            this.bntSua.Text = "Sửa ";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntXoa.Location = new System.Drawing.Point(510, 205);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 60;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(60, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 62;
            this.button5.Text = "Tìm Kiếm ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(183, 54);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(229, 20);
            this.txtTimkiem.TabIndex = 63;
            // 
            // bntThoat
            // 
            this.bntThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntThoat.Location = new System.Drawing.Point(636, 204);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 65;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // dtPhong
            // 
            this.dtPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPhong.Location = new System.Drawing.Point(58, 257);
            this.dtPhong.Name = "dtPhong";
            this.dtPhong.Size = new System.Drawing.Size(653, 150);
            this.dtPhong.TabIndex = 64;
            this.dtPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPhong_CellContentClick);
            this.dtPhong.SelectionChanged += new System.EventHandler(this.dtPhong_SelectionChanged);
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 413);
            this.Controls.Add(this.bntClear);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.dtPhong);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.txtSophong);
            this.Controls.Add(this.txtMaLP);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "QuanLyPhong";
            this.Text = "QuanLyPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dtPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.TextBox txtSophong;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.DataGridView dtPhong;

    }
}