
namespace ReMax
{
    partial class frmAgentAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgentAdd));
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAdminName = new System.Windows.Forms.ComboBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_Addr = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lblAgent_Charge = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.txt_post = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.Label();
            this.btn_ClearAgent = new System.Windows.Forms.Button();
            this.btn_AddAgent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(111, 31);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(240, 20);
            this.txt_name.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name :";
            // 
            // cbAdminName
            // 
            this.cbAdminName.FormattingEnabled = true;
            this.cbAdminName.Location = new System.Drawing.Point(117, 244);
            this.cbAdminName.Name = "cbAdminName";
            this.cbAdminName.Size = new System.Drawing.Size(121, 21);
            this.cbAdminName.TabIndex = 29;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(187, 66);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(72, 20);
            this.radioButtonFemale.TabIndex = 28;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(120, 66);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(56, 20);
            this.radioButtonMale.TabIndex = 27;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(114, 203);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '#';
            this.txt_pwd.Size = new System.Drawing.Size(240, 20);
            this.txt_pwd.TabIndex = 26;
            // 
            // txt_Addr
            // 
            this.txt_Addr.Location = new System.Drawing.Point(114, 168);
            this.txt_Addr.Name = "txt_Addr";
            this.txt_Addr.Size = new System.Drawing.Size(240, 20);
            this.txt_Addr.TabIndex = 25;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(114, 130);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(240, 20);
            this.txt_mail.TabIndex = 24;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(114, 96);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(240, 20);
            this.txt_phone.TabIndex = 23;
            // 
            // lblAgent_Charge
            // 
            this.lblAgent_Charge.AutoSize = true;
            this.lblAgent_Charge.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgent_Charge.Location = new System.Drawing.Point(10, 240);
            this.lblAgent_Charge.Name = "lblAgent_Charge";
            this.lblAgent_Charge.Size = new System.Drawing.Size(77, 25);
            this.lblAgent_Charge.TabIndex = 22;
            this.lblAgent_Charge.Text = "Added by :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(10, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 25);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(9, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 25);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Address :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 25);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-mail :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(9, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 25);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone :";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(9, 64);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(64, 25);
            this.lbGender.TabIndex = 17;
            this.lbGender.Text = "Gender :";
            // 
            // txt_post
            // 
            this.txt_post.Enabled = false;
            this.txt_post.Location = new System.Drawing.Point(117, 312);
            this.txt_post.Multiline = true;
            this.txt_post.Name = "txt_post";
            this.txt_post.Size = new System.Drawing.Size(240, 22);
            this.txt_post.TabIndex = 31;
            this.txt_post.Text = "Agent";
            this.txt_post.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.Location = new System.Drawing.Point(10, 309);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(57, 25);
            this.Position.TabIndex = 30;
            this.Position.Text = "Notes :";
            // 
            // btn_ClearAgent
            // 
            this.btn_ClearAgent.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearAgent.Image")));
            this.btn_ClearAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ClearAgent.Location = new System.Drawing.Point(602, 289);
            this.btn_ClearAgent.Name = "btn_ClearAgent";
            this.btn_ClearAgent.Size = new System.Drawing.Size(108, 45);
            this.btn_ClearAgent.TabIndex = 33;
            this.btn_ClearAgent.Text = "Clear Changes";
            this.btn_ClearAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ClearAgent.UseVisualStyleBackColor = true;
            this.btn_ClearAgent.Click += new System.EventHandler(this.btn_ClearAgent_Click);
            // 
            // btn_AddAgent
            // 
            this.btn_AddAgent.Image = global::ReMax.Properties.Resources.add_friend;
            this.btn_AddAgent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddAgent.Location = new System.Drawing.Point(469, 289);
            this.btn_AddAgent.Name = "btn_AddAgent";
            this.btn_AddAgent.Size = new System.Drawing.Size(116, 45);
            this.btn_AddAgent.TabIndex = 32;
            this.btn_AddAgent.Text = "Add Agent";
            this.btn_AddAgent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddAgent.UseVisualStyleBackColor = true;
            this.btn_AddAgent.Click += new System.EventHandler(this.btn_AddAgent_Click);
            // 
            // frmAgentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 353);
            this.Controls.Add(this.btn_ClearAgent);
            this.Controls.Add(this.btn_AddAgent);
            this.Controls.Add(this.txt_post);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.cbAdminName);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_Addr);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lblAgent_Charge);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgentAdd";
            this.Text = "Agent Management";
            this.Load += new System.EventHandler(this.frmAgentAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAdminName;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_Addr;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lblAgent_Charge;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Button btn_ClearAgent;
        private System.Windows.Forms.Button btn_AddAgent;
        private System.Windows.Forms.TextBox txt_post;
        private System.Windows.Forms.Label Position;
    }
}