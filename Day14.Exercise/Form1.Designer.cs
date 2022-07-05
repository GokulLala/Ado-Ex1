
namespace Day14.Exercise
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
            this.lblStCode = new System.Windows.Forms.Label();
            this.lblStName = new System.Windows.Forms.Label();
            this.lblDeptCode = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtStCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDeptCode = new System.Windows.Forms.TextBox();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.btnInsrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStCode
            // 
            this.lblStCode.AutoSize = true;
            this.lblStCode.Location = new System.Drawing.Point(161, 64);
            this.lblStCode.Name = "lblStCode";
            this.lblStCode.Size = new System.Drawing.Size(108, 20);
            this.lblStCode.TabIndex = 0;
            this.lblStCode.Text = "Student Code";
            // 
            // lblStName
            // 
            this.lblStName.AutoSize = true;
            this.lblStName.Location = new System.Drawing.Point(161, 130);
            this.lblStName.Name = "lblStName";
            this.lblStName.Size = new System.Drawing.Size(112, 20);
            this.lblStName.TabIndex = 1;
            this.lblStName.Text = "Student Name";
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.AutoSize = true;
            this.lblDeptCode.Location = new System.Drawing.Point(161, 195);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(136, 20);
            this.lblDeptCode.TabIndex = 2;
            this.lblDeptCode.Text = "Department Code";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(161, 253);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(44, 20);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "DOB";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(161, 302);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtStCode
            // 
            this.txtStCode.Location = new System.Drawing.Point(350, 64);
            this.txtStCode.Name = "txtStCode";
            this.txtStCode.Size = new System.Drawing.Size(119, 26);
            this.txtStCode.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(350, 302);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(119, 26);
            this.txtAddress.TabIndex = 7;
            // 
            // txtDeptCode
            // 
            this.txtDeptCode.Location = new System.Drawing.Point(350, 188);
            this.txtDeptCode.Name = "txtDeptCode";
            this.txtDeptCode.Size = new System.Drawing.Size(119, 26);
            this.txtDeptCode.TabIndex = 8;
            // 
            // txtStName
            // 
            this.txtStName.Location = new System.Drawing.Point(350, 130);
            this.txtStName.Name = "txtStName";
            this.txtStName.Size = new System.Drawing.Size(119, 26);
            this.txtStName.TabIndex = 9;
            // 
            // dtDob
            // 
            this.dtDob.Location = new System.Drawing.Point(350, 253);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(119, 26);
            this.dtDob.TabIndex = 10;
            // 
            // btnInsrt
            // 
            this.btnInsrt.Location = new System.Drawing.Point(124, 365);
            this.btnInsrt.Name = "btnInsrt";
            this.btnInsrt.Size = new System.Drawing.Size(105, 39);
            this.btnInsrt.TabIndex = 11;
            this.btnInsrt.Text = "Insert";
            this.btnInsrt.UseVisualStyleBackColor = true;
            this.btnInsrt.Click += new System.EventHandler(this.btnInsrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsrt);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.txtStName);
            this.Controls.Add(this.txtDeptCode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtStCode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblDeptCode);
            this.Controls.Add(this.lblStName);
            this.Controls.Add(this.lblStCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStCode;
        private System.Windows.Forms.Label lblStName;
        private System.Windows.Forms.Label lblDeptCode;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtStCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDeptCode;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.Button btnInsrt;
    }
}

