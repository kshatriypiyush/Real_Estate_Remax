
namespace ReMax
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAgents = new System.Windows.Forms.RadioButton();
            this.rdHouses = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataResultSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAgents);
            this.groupBox1.Controls.Add(this.rdHouses);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By";
            // 
            // rdAgents
            // 
            this.rdAgents.AutoSize = true;
            this.rdAgents.Location = new System.Drawing.Point(6, 51);
            this.rdAgents.Name = "rdAgents";
            this.rdAgents.Size = new System.Drawing.Size(58, 17);
            this.rdAgents.TabIndex = 2;
            this.rdAgents.TabStop = true;
            this.rdAgents.Text = "Agents";
            this.rdAgents.UseVisualStyleBackColor = true;
            this.rdAgents.CheckedChanged += new System.EventHandler(this.rdAgents_CheckedChanged);
            // 
            // rdHouses
            // 
            this.rdHouses.AutoSize = true;
            this.rdHouses.Location = new System.Drawing.Point(6, 29);
            this.rdHouses.Name = "rdHouses";
            this.rdHouses.Size = new System.Drawing.Size(61, 17);
            this.rdHouses.TabIndex = 1;
            this.rdHouses.TabStop = true;
            this.rdHouses.Text = "Houses";
            this.rdHouses.UseVisualStyleBackColor = true;
            this.rdHouses.CheckedChanged += new System.EventHandler(this.rdHouses_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(149, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Keyword";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(430, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataResultSearch
            // 
            this.dataResultSearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataResultSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultSearch.Location = new System.Drawing.Point(12, 143);
            this.dataResultSearch.Name = "dataResultSearch";
            this.dataResultSearch.Size = new System.Drawing.Size(742, 305);
            this.dataResultSearch.TabIndex = 3;
            this.dataResultSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResultSearch_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::ReMax.Properties.Resources.searching;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(646, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 67);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataResultSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAgents;
        private System.Windows.Forms.RadioButton rdHouses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataResultSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}