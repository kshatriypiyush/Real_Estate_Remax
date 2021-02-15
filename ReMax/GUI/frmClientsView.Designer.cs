
namespace ReMax
{
    partial class frmClientsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientsView));
            this.dataResultClient = new System.Windows.Forms.DataGridView();
            this.lblClients = new System.Windows.Forms.Label();
            this.btn_EditClient = new System.Windows.Forms.Button();
            this.btn_DeleteClient = new System.Windows.Forms.Button();
            this.btn_AddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataResultClient
            // 
            this.dataResultClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataResultClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultClient.Location = new System.Drawing.Point(11, 43);
            this.dataResultClient.Name = "dataResultClient";
            this.dataResultClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataResultClient.Size = new System.Drawing.Size(777, 335);
            this.dataResultClient.TabIndex = 0;
            this.dataResultClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResultClient_CellContentClick);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(287, 9);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(194, 25);
            this.lblClients.TabIndex = 2;
            this.lblClients.Text = "Clients Management";
            // 
            // btn_EditClient
            // 
            this.btn_EditClient.Image = global::ReMax.Properties.Resources.edit;
            this.btn_EditClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditClient.Location = new System.Drawing.Point(188, 394);
            this.btn_EditClient.Name = "btn_EditClient";
            this.btn_EditClient.Size = new System.Drawing.Size(147, 44);
            this.btn_EditClient.TabIndex = 8;
            this.btn_EditClient.Text = "&Edit Client";
            this.btn_EditClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditClient.UseVisualStyleBackColor = true;
            this.btn_EditClient.Click += new System.EventHandler(this.btn_EditClient_Click);
            // 
            // btn_DeleteClient
            // 
            this.btn_DeleteClient.Image = global::ReMax.Properties.Resources.cleaning_tools;
            this.btn_DeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteClient.Location = new System.Drawing.Point(352, 394);
            this.btn_DeleteClient.Name = "btn_DeleteClient";
            this.btn_DeleteClient.Size = new System.Drawing.Size(147, 44);
            this.btn_DeleteClient.TabIndex = 7;
            this.btn_DeleteClient.Text = "&Delete Client";
            this.btn_DeleteClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteClient.UseVisualStyleBackColor = true;
            this.btn_DeleteClient.Click += new System.EventHandler(this.btn_DeleteClient_Click);
            // 
            // btn_AddClient
            // 
            this.btn_AddClient.Image = global::ReMax.Properties.Resources.add_friend;
            this.btn_AddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddClient.Location = new System.Drawing.Point(19, 394);
            this.btn_AddClient.Name = "btn_AddClient";
            this.btn_AddClient.Size = new System.Drawing.Size(147, 44);
            this.btn_AddClient.TabIndex = 6;
            this.btn_AddClient.Text = "&Add Client";
            this.btn_AddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddClient.UseVisualStyleBackColor = true;
            this.btn_AddClient.Click += new System.EventHandler(this.btn_AddClient_Click);
            // 
            // frmClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EditClient);
            this.Controls.Add(this.btn_DeleteClient);
            this.Controls.Add(this.btn_AddClient);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.dataResultClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientsView";
            this.Text = "Client Management";
            this.Load += new System.EventHandler(this.frmClientsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataResultClient;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Button btn_EditClient;
        private System.Windows.Forms.Button btn_DeleteClient;
        private System.Windows.Forms.Button btn_AddClient;
    }
}