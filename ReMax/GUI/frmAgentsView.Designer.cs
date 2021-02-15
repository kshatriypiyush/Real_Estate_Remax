
namespace ReMax
{
    partial class frmAgentsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgentsView));
            this.dataAgentView = new System.Windows.Forms.DataGridView();
            this.lblAgents = new System.Windows.Forms.Label();
            this.btn_EditEmployee = new System.Windows.Forms.Button();
            this.btn_DeleteEmployee = new System.Windows.Forms.Button();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAgentView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAgentView
            // 
            this.dataAgentView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataAgentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAgentView.Location = new System.Drawing.Point(12, 36);
            this.dataAgentView.Name = "dataAgentView";
            this.dataAgentView.Size = new System.Drawing.Size(776, 326);
            this.dataAgentView.TabIndex = 0;
            this.dataAgentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblAgents
            // 
            this.lblAgents.AutoSize = true;
            this.lblAgents.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgents.Location = new System.Drawing.Point(340, 8);
            this.lblAgents.Name = "lblAgents";
            this.lblAgents.Size = new System.Drawing.Size(106, 25);
            this.lblAgents.TabIndex = 2;
            this.lblAgents.Text = "Employees";
            // 
            // btn_EditEmployee
            // 
            this.btn_EditEmployee.Image = global::ReMax.Properties.Resources.edit;
            this.btn_EditEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditEmployee.Location = new System.Drawing.Point(181, 390);
            this.btn_EditEmployee.Name = "btn_EditEmployee";
            this.btn_EditEmployee.Size = new System.Drawing.Size(147, 44);
            this.btn_EditEmployee.TabIndex = 4;
            this.btn_EditEmployee.Text = "&Edit Employee";
            this.btn_EditEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditEmployee.UseVisualStyleBackColor = true;
            this.btn_EditEmployee.Click += new System.EventHandler(this.btn_EditEmployee_Click);
            // 
            // btn_DeleteEmployee
            // 
            this.btn_DeleteEmployee.Image = global::ReMax.Properties.Resources.cleaning_tools;
            this.btn_DeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteEmployee.Location = new System.Drawing.Point(345, 390);
            this.btn_DeleteEmployee.Name = "btn_DeleteEmployee";
            this.btn_DeleteEmployee.Size = new System.Drawing.Size(147, 44);
            this.btn_DeleteEmployee.TabIndex = 3;
            this.btn_DeleteEmployee.Text = "&Delete Employee";
            this.btn_DeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteEmployee.UseVisualStyleBackColor = true;
            this.btn_DeleteEmployee.Click += new System.EventHandler(this.btn_DeleteEmployee_Click);
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Image = global::ReMax.Properties.Resources.add_friend;
            this.btn_AddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddEmployee.Location = new System.Drawing.Point(12, 390);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(147, 44);
            this.btn_AddEmployee.TabIndex = 1;
            this.btn_AddEmployee.Text = "&Add Employee";
            this.btn_AddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // frmAgentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EditEmployee);
            this.Controls.Add(this.btn_DeleteEmployee);
            this.Controls.Add(this.lblAgents);
            this.Controls.Add(this.btn_AddEmployee);
            this.Controls.Add(this.dataAgentView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgentsView";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmAgentsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAgentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAgentView;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Label lblAgents;
        private System.Windows.Forms.Button btn_DeleteEmployee;
        private System.Windows.Forms.Button btn_EditEmployee;
    }
}