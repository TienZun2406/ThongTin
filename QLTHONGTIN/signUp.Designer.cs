namespace OnTapCK
{
    partial class signUp
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
            this.txtPASS2 = new System.Windows.Forms.TextBox();
            this.txtPASS1 = new System.Windows.Forms.TextBox();
            this.txtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.lblNOILAMVIEC = new System.Windows.Forms.Label();
            this.lblTUOI = new System.Windows.Forms.Label();
            this.lblTEN = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPASS2
            // 
            this.txtPASS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPASS2.Location = new System.Drawing.Point(391, 233);
            this.txtPASS2.Name = "txtPASS2";
            this.txtPASS2.Size = new System.Drawing.Size(200, 30);
            this.txtPASS2.TabIndex = 23;
            // 
            // txtPASS1
            // 
            this.txtPASS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtPASS1.Location = new System.Drawing.Point(391, 181);
            this.txtPASS1.Name = "txtPASS1";
            this.txtPASS1.Size = new System.Drawing.Size(200, 30);
            this.txtPASS1.TabIndex = 22;
            // 
            // txtTAIKHOAN
            // 
            this.txtTAIKHOAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTAIKHOAN.Location = new System.Drawing.Point(391, 131);
            this.txtTAIKHOAN.Name = "txtTAIKHOAN";
            this.txtTAIKHOAN.Size = new System.Drawing.Size(200, 30);
            this.txtTAIKHOAN.TabIndex = 21;
            // 
            // lblNOILAMVIEC
            // 
            this.lblNOILAMVIEC.AutoSize = true;
            this.lblNOILAMVIEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblNOILAMVIEC.Location = new System.Drawing.Point(203, 238);
            this.lblNOILAMVIEC.Name = "lblNOILAMVIEC";
            this.lblNOILAMVIEC.Size = new System.Drawing.Size(168, 25);
            this.lblNOILAMVIEC.TabIndex = 20;
            this.lblNOILAMVIEC.Text = "Nhập lại mật khẩu";
            // 
            // lblTUOI
            // 
            this.lblTUOI.AutoSize = true;
            this.lblTUOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTUOI.Location = new System.Drawing.Point(203, 189);
            this.lblTUOI.Name = "lblTUOI";
            this.lblTUOI.Size = new System.Drawing.Size(93, 25);
            this.lblTUOI.TabIndex = 19;
            this.lblTUOI.Text = "Mật khẩu";
            // 
            // lblTEN
            // 
            this.lblTEN.AutoSize = true;
            this.lblTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTEN.Location = new System.Drawing.Point(203, 136);
            this.lblTEN.Name = "lblTEN";
            this.lblTEN.Size = new System.Drawing.Size(99, 25);
            this.lblTEN.TabIndex = 18;
            this.lblTEN.Text = "Tài khoản";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnDangKy.Location = new System.Drawing.Point(232, 314);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(128, 48);
            this.btnDangKy.TabIndex = 24;
            this.btnDangKy.Text = "Dang ky";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_cancel.Location = new System.Drawing.Point(460, 314);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(110, 48);
            this.btn_cancel.TabIndex = 25;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtPASS2);
            this.Controls.Add(this.txtPASS1);
            this.Controls.Add(this.txtTAIKHOAN);
            this.Controls.Add(this.lblNOILAMVIEC);
            this.Controls.Add(this.lblTUOI);
            this.Controls.Add(this.lblTEN);
            this.Name = "signUp";
            this.Text = "signUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPASS2;
        private System.Windows.Forms.TextBox txtPASS1;
        private System.Windows.Forms.TextBox txtTAIKHOAN;
        private System.Windows.Forms.Label lblNOILAMVIEC;
        private System.Windows.Forms.Label lblTUOI;
        private System.Windows.Forms.Label lblTEN;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btn_cancel;
    }
}