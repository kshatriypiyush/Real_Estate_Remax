
namespace ReMax
{
    partial class frmHouses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHouses));
            this.dataHouses = new System.Windows.Forms.DataGridView();
            this.btn_DeleteHouse = new System.Windows.Forms.Button();
            this.btn_EditHouse = new System.Windows.Forms.Button();
            this.btn_AddHouse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataHouses
            // 
            this.dataHouses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHouses.Location = new System.Drawing.Point(12, 21);
            this.dataHouses.Name = "dataHouses";
            this.dataHouses.Size = new System.Drawing.Size(776, 376);
            this.dataHouses.TabIndex = 0;
            this.dataHouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHouses_CellContentClick);
            // 
            // btn_DeleteHouse
            // 
            this.btn_DeleteHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteHouse.Image = global::ReMax.Properties.Resources.demolish;
            this.btn_DeleteHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteHouse.Location = new System.Drawing.Point(245, 426);
            this.btn_DeleteHouse.Name = "btn_DeleteHouse";
            this.btn_DeleteHouse.Size = new System.Drawing.Size(124, 38);
            this.btn_DeleteHouse.TabIndex = 3;
            this.btn_DeleteHouse.Text = "Delete House";
            this.btn_DeleteHouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteHouse.UseVisualStyleBackColor = true;
            this.btn_DeleteHouse.Click += new System.EventHandler(this.btn_DeleteHouse_Click);
            // 
            // btn_EditHouse
            // 
            this.btn_EditHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditHouse.Image = global::ReMax.Properties.Resources.edit;
            this.btn_EditHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditHouse.Location = new System.Drawing.Point(130, 426);
            this.btn_EditHouse.Name = "btn_EditHouse";
            this.btn_EditHouse.Size = new System.Drawing.Size(99, 38);
            this.btn_EditHouse.TabIndex = 2;
            this.btn_EditHouse.Text = "Edit House";
            this.btn_EditHouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditHouse.UseVisualStyleBackColor = true;
            this.btn_EditHouse.Click += new System.EventHandler(this.btn_EditHouse_Click);
            // 
            // btn_AddHouse
            // 
            this.btn_AddHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddHouse.Image = global::ReMax.Properties.Resources.house;
            this.btn_AddHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddHouse.Location = new System.Drawing.Point(12, 426);
            this.btn_AddHouse.Name = "btn_AddHouse";
            this.btn_AddHouse.Size = new System.Drawing.Size(99, 38);
            this.btn_AddHouse.TabIndex = 1;
            this.btn_AddHouse.Text = "Add New";
            this.btn_AddHouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddHouse.UseVisualStyleBackColor = true;
            this.btn_AddHouse.Click += new System.EventHandler(this.btn_AddHouse_Click);
            // 
            // frmHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btn_DeleteHouse);
            this.Controls.Add(this.btn_EditHouse);
            this.Controls.Add(this.btn_AddHouse);
            this.Controls.Add(this.dataHouses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHouses";
            this.Text = "House Management";
            this.Load += new System.EventHandler(this.frmHouses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataHouses;
        private System.Windows.Forms.Button btn_AddHouse;
        private System.Windows.Forms.Button btn_EditHouse;
        private System.Windows.Forms.Button btn_DeleteHouse;
    }
}