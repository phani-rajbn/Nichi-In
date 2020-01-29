namespace SampleWinApp
{
    partial class EmpStore
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
            this.employeeCtrl1 = new SampleWinApp.EmployeeCtrl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeCtrl1
            // 
            this.employeeCtrl1.Employee = null;
            this.employeeCtrl1.Font = new System.Drawing.Font("Inconsolata", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeCtrl1.Location = new System.Drawing.Point(433, 28);
            this.employeeCtrl1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.employeeCtrl1.Name = "employeeCtrl1";
            this.employeeCtrl1.Size = new System.Drawing.Size(916, 614);
            this.employeeCtrl1.TabIndex = 0;
            this.employeeCtrl1.Submit += new System.Action(this.EmployeeCtrl1_Submit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1411, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // EmpStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeCtrl1);
            this.Font = new System.Drawing.Font("Inconsolata", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "EmpStore";
            this.Text = "EmpStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeCtrl employeeCtrl1;
        private System.Windows.Forms.Label label1;
    }
}