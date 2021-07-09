
namespace Week0502_Task01
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
            this.lbNames = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowCount = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.ItemHeight = 20;
            this.lbNames.Location = new System.Drawing.Point(35, 107);
            this.lbNames.Name = "lbNames";
            this.lbNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNames.Size = new System.Drawing.Size(334, 144);
            this.lbNames.TabIndex = 0;
            this.lbNames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbNames_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ad :";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(31, 301);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(122, 20);
            this.lblSName.TabIndex = 2;
            this.lblSName.Text = "Axtardiginiz Ad :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Elave et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(294, 295);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowCount
            // 
            this.btnShowCount.Location = new System.Drawing.Point(428, 46);
            this.btnShowCount.Name = "btnShowCount";
            this.btnShowCount.Size = new System.Drawing.Size(75, 33);
            this.btnShowCount.TabIndex = 5;
            this.btnShowCount.Text = "Sayi";
            this.btnShowCount.UseVisualStyleBackColor = true;
            this.btnShowCount.Click += new System.EventHandler(this.btnShowCount_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(74, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(214, 26);
            this.tbName.TabIndex = 6;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(159, 298);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(129, 26);
            this.tbSearch.TabIndex = 7;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(428, 150);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 31);
            this.btnShuffle.TabIndex = 8;
            this.btnShuffle.Text = "Qarisdir";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(428, 107);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 29);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 380);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnShowCount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbNames);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowCount;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnRemove;
    }
}

