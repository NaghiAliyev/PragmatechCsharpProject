
namespace Calculator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSelectOperations = new System.Windows.Forms.Label();
            this.nudNumber01 = new System.Windows.Forms.NumericUpDown();
            this.nudNumber02 = new System.Windows.Forms.NumericUpDown();
            this.cmbOperations = new System.Windows.Forms.ComboBox();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.lblOperation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber02)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(335, 28);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(30, 33);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectOperations
            // 
            this.lblSelectOperations.AutoSize = true;
            this.lblSelectOperations.Location = new System.Drawing.Point(48, 123);
            this.lblSelectOperations.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSelectOperations.Name = "lblSelectOperations";
            this.lblSelectOperations.Size = new System.Drawing.Size(138, 21);
            this.lblSelectOperations.TabIndex = 1;
            this.lblSelectOperations.Text = "Emeliyyati secin :";
            // 
            // nudNumber01
            // 
            this.nudNumber01.Location = new System.Drawing.Point(246, 116);
            this.nudNumber01.Name = "nudNumber01";
            this.nudNumber01.Size = new System.Drawing.Size(120, 27);
            this.nudNumber01.TabIndex = 2;
            // 
            // nudNumber02
            // 
            this.nudNumber02.Location = new System.Drawing.Point(246, 200);
            this.nudNumber02.Name = "nudNumber02";
            this.nudNumber02.Size = new System.Drawing.Size(120, 27);
            this.nudNumber02.TabIndex = 2;
            // 
            // cmbOperations
            // 
            this.cmbOperations.FormattingEnabled = true;
            this.cmbOperations.Location = new System.Drawing.Point(35, 158);
            this.cmbOperations.Name = "cmbOperations";
            this.cmbOperations.Size = new System.Drawing.Size(162, 29);
            this.cmbOperations.TabIndex = 3;
            this.cmbOperations.SelectedIndexChanged += new System.EventHandler(this.cmbOperations_SelectedIndexChanged);
            // 
            // btnGetResult
            // 
            this.btnGetResult.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetResult.Location = new System.Drawing.Point(270, 263);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(75, 36);
            this.btnGetResult.TabIndex = 4;
            this.btnGetResult.Text = "=";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.Location = new System.Drawing.Point(288, 154);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(33, 33);
            this.lblOperation.TabIndex = 5;
            this.lblOperation.Text = "^";
            this.lblOperation.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 340);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.cmbOperations);
            this.Controls.Add(this.nudNumber02);
            this.Controls.Add(this.nudNumber01);
            this.Controls.Add(this.lblSelectOperations);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSelectOperations;
        private System.Windows.Forms.NumericUpDown nudNumber01;
        private System.Windows.Forms.NumericUpDown nudNumber02;
        private System.Windows.Forms.ComboBox cmbOperations;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Label lblOperation;
    }
}

