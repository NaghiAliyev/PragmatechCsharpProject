
namespace Task06
{
    partial class Task06
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
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.cbBodyStyle = new System.Windows.Forms.ComboBox();
            this.cbTransmissionType = new System.Windows.Forms.ComboBox();
            this.cbMotorType = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvCars = new System.Windows.Forms.ListView();
            this.chBrand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFuel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBodyType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTransmission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMotorType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(50, 41);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(121, 29);
            this.cbBrand.TabIndex = 0;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(208, 41);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 29);
            this.cbModel.TabIndex = 0;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // cbFuel
            // 
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(365, 41);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(121, 29);
            this.cbFuel.TabIndex = 0;
            this.cbFuel.SelectedIndexChanged += new System.EventHandler(this.cbFuel_SelectedIndexChanged);
            // 
            // cbBodyStyle
            // 
            this.cbBodyStyle.FormattingEnabled = true;
            this.cbBodyStyle.Location = new System.Drawing.Point(519, 41);
            this.cbBodyStyle.Name = "cbBodyStyle";
            this.cbBodyStyle.Size = new System.Drawing.Size(121, 29);
            this.cbBodyStyle.TabIndex = 0;
            this.cbBodyStyle.SelectedIndexChanged += new System.EventHandler(this.cbBodyStyle_SelectedIndexChanged);
            // 
            // cbTransmissionType
            // 
            this.cbTransmissionType.FormattingEnabled = true;
            this.cbTransmissionType.Location = new System.Drawing.Point(50, 128);
            this.cbTransmissionType.Name = "cbTransmissionType";
            this.cbTransmissionType.Size = new System.Drawing.Size(121, 29);
            this.cbTransmissionType.TabIndex = 0;
            this.cbTransmissionType.SelectedIndexChanged += new System.EventHandler(this.cbTransmissionType_SelectedIndexChanged);
            // 
            // cbMotorType
            // 
            this.cbMotorType.FormattingEnabled = true;
            this.cbMotorType.Location = new System.Drawing.Point(208, 128);
            this.cbMotorType.Name = "cbMotorType";
            this.cbMotorType.Size = new System.Drawing.Size(121, 29);
            this.cbMotorType.TabIndex = 0;
            this.cbMotorType.SelectedIndexChanged += new System.EventHandler(this.cbMotorType_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(519, 128);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(119, 29);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // dtpYear
            // 
            this.dtpYear.Location = new System.Drawing.Point(365, 130);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(121, 27);
            this.dtpYear.TabIndex = 2;
            this.dtpYear.ValueChanged += new System.EventHandler(this.dtpYear_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(503, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Elave et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvCars
            // 
            this.lvCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBrand,
            this.chModel,
            this.chFuel,
            this.chBodyType,
            this.chTransmission,
            this.chMotorType,
            this.chYear,
            this.chColor});
            this.lvCars.HideSelection = false;
            this.lvCars.Location = new System.Drawing.Point(50, 277);
            this.lvCars.Name = "lvCars";
            this.lvCars.Size = new System.Drawing.Size(590, 216);
            this.lvCars.TabIndex = 4;
            this.lvCars.UseCompatibleStateImageBehavior = false;
            this.lvCars.View = System.Windows.Forms.View.Details;
            // 
            // chBrand
            // 
            this.chBrand.Text = "Markası";
            // 
            // chModel
            // 
            this.chModel.Text = "Modeli";
            // 
            // chFuel
            // 
            this.chFuel.Text = "Yanacaq Tipi";
            // 
            // chBodyType
            // 
            this.chBodyType.Text = "Kuza";
            // 
            // chTransmission
            // 
            this.chTransmission.Text = "Sürətlər Qutusu";
            // 
            // chMotorType
            // 
            this.chMotorType.Text = "Motor";
            // 
            // chYear
            // 
            this.chYear.Text = "İli";
            // 
            // chColor
            // 
            this.chColor.Text = "Rengi";
            // 
            // Task06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 540);
            this.Controls.Add(this.lvCars);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbMotorType);
            this.Controls.Add(this.cbTransmissionType);
            this.Controls.Add(this.cbBodyStyle);
            this.Controls.Add(this.cbFuel);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbBrand);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Task06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Task06_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.ComboBox cbBodyStyle;
        private System.Windows.Forms.ComboBox cbTransmissionType;
        private System.Windows.Forms.ComboBox cbMotorType;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvCars;
        private System.Windows.Forms.ColumnHeader chBrand;
        private System.Windows.Forms.ColumnHeader chModel;
        private System.Windows.Forms.ColumnHeader chFuel;
        private System.Windows.Forms.ColumnHeader chBodyType;
        private System.Windows.Forms.ColumnHeader chTransmission;
        private System.Windows.Forms.ColumnHeader chMotorType;
        private System.Windows.Forms.ColumnHeader chYear;
        private System.Windows.Forms.ColumnHeader chColor;
    }
}

