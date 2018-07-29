namespace Pro_SSH
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewUID = new System.Windows.Forms.TextBox();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.txtNewPasswd = new System.Windows.Forms.TextBox();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.btnNewCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "User name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Add Name or UID!";
            // 
            // txtNewUID
            // 
            this.txtNewUID.Location = new System.Drawing.Point(33, 41);
            this.txtNewUID.Name = "txtNewUID";
            this.txtNewUID.Size = new System.Drawing.Size(100, 20);
            this.txtNewUID.TabIndex = 11;
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(33, 90);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(157, 20);
            this.txtNewAddress.TabIndex = 12;
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(33, 140);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserName.TabIndex = 13;
            // 
            // txtNewPasswd
            // 
            this.txtNewPasswd.Location = new System.Drawing.Point(33, 192);
            this.txtNewPasswd.Name = "txtNewPasswd";
            this.txtNewPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtNewPasswd.TabIndex = 14;
            // 
            // btnNewSave
            // 
            this.btnNewSave.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewSave.Location = new System.Drawing.Point(33, 246);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(82, 23);
            this.btnNewSave.TabIndex = 15;
            this.btnNewSave.Text = "Save";
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // btnNewCancel
            // 
            this.btnNewCancel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewCancel.Location = new System.Drawing.Point(121, 246);
            this.btnNewCancel.Name = "btnNewCancel";
            this.btnNewCancel.Size = new System.Drawing.Size(82, 23);
            this.btnNewCancel.TabIndex = 16;
            this.btnNewCancel.Text = "Cancel";
            this.btnNewCancel.UseVisualStyleBackColor = true;
            this.btnNewCancel.Click += new System.EventHandler(this.btnNewCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 297);
            this.Controls.Add(this.btnNewCancel);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.txtNewPasswd);
            this.Controls.Add(this.txtNewUserName);
            this.Controls.Add(this.txtNewAddress);
            this.Controls.Add(this.txtNewUID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewUID;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.TextBox txtNewPasswd;
        private System.Windows.Forms.Button btnNewSave;
        private System.Windows.Forms.Button btnNewCancel;
    }
}