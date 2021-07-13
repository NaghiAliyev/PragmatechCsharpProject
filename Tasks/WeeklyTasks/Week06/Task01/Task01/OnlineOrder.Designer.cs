
namespace Task01
{
    partial class OnlineOrder
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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbProductNames = new System.Windows.Forms.ComboBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.cmbDeliveryMethods = new System.Windows.Forms.ComboBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.tbSearchText = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDeliveryMethod = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.chOrderedProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDeliveryMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDeliveryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearchText = new System.Windows.Forms.Label();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(66, 59);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 29);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // cmbProductNames
            // 
            this.cmbProductNames.FormattingEnabled = true;
            this.cmbProductNames.Location = new System.Drawing.Point(240, 59);
            this.cmbProductNames.Name = "cmbProductNames";
            this.cmbProductNames.Size = new System.Drawing.Size(121, 29);
            this.cmbProductNames.TabIndex = 1;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(444, 135);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 27);
            this.nudPrice.TabIndex = 2;
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(444, 60);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(120, 27);
            this.nudWeight.TabIndex = 3;
            // 
            // cmbDeliveryMethods
            // 
            this.cmbDeliveryMethods.FormattingEnabled = true;
            this.cmbDeliveryMethods.Location = new System.Drawing.Point(66, 135);
            this.cmbDeliveryMethods.Name = "cmbDeliveryMethods";
            this.cmbDeliveryMethods.Size = new System.Drawing.Size(121, 29);
            this.cmbDeliveryMethods.TabIndex = 4;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(213, 136);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 27);
            this.dtpDeliveryDate.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(603, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Elave et";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOrderedProductName,
            this.chWeight,
            this.chProductPrice,
            this.chOrderPrice,
            this.chDeliveryMethod,
            this.chDeliveryDate});
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(55, 196);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(647, 219);
            this.lvOrders.TabIndex = 7;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvOrders_KeyDown);
            // 
            // tbSearchText
            // 
            this.tbSearchText.Location = new System.Drawing.Point(186, 442);
            this.tbSearchText.Name = "tbSearchText";
            this.tbSearchText.Size = new System.Drawing.Size(259, 27);
            this.tbSearchText.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(509, 442);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(92, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(95, 21);
            this.lblCategory.TabIndex = 10;
            this.lblCategory.Text = "Kateqoriya";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(267, 28);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(63, 21);
            this.lblProduct.TabIndex = 10;
            this.lblProduct.Text = "Məhsul";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(486, 28);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(43, 21);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "Çəki";
            // 
            // lblDeliveryMethod
            // 
            this.lblDeliveryMethod.AutoSize = true;
            this.lblDeliveryMethod.Location = new System.Drawing.Point(62, 107);
            this.lblDeliveryMethod.Name = "lblDeliveryMethod";
            this.lblDeliveryMethod.Size = new System.Drawing.Size(136, 21);
            this.lblDeliveryMethod.TabIndex = 11;
            this.lblDeliveryMethod.Text = "Çatdırılma Üsulu";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(236, 107);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(136, 21);
            this.lblDeliveryDate.TabIndex = 11;
            this.lblDeliveryDate.Text = "Çatdırılma Vaxtı";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(460, 107);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 21);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Qiyməti";
            // 
            // chOrderedProductName
            // 
            this.chOrderedProductName.Text = "Məhsulun Adı";
            this.chOrderedProductName.Width = 122;
            // 
            // chWeight
            // 
            this.chWeight.Text = "Çəki";
            this.chWeight.Width = 51;
            // 
            // chDeliveryMethod
            // 
            this.chDeliveryMethod.Text = "Çatdırılma Üsulu";
            this.chDeliveryMethod.Width = 87;
            // 
            // chDeliveryDate
            // 
            this.chDeliveryDate.Text = "Çatdırılma Vaxtı";
            this.chDeliveryDate.Width = 105;
            // 
            // chProductPrice
            // 
            this.chProductPrice.Text = "Məhsulun qiyməti";
            this.chProductPrice.Width = 151;
            // 
            // chOrderPrice
            // 
            this.chOrderPrice.Text = "Yekun dəyər";
            this.chOrderPrice.Width = 113;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(86, 445);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(63, 21);
            this.lblSearchText.TabIndex = 12;
            this.lblSearchText.Text = "Axtarış";
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(617, 442);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(75, 27);
            this.btnRemoveOrder.TabIndex = 13;
            this.btnRemoveOrder.Text = "Sil";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // OnlineOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 515);
            this.Controls.Add(this.btnRemoveOrder);
            this.Controls.Add(this.lblSearchText);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblDeliveryMethod);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchText);
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.cmbDeliveryMethods);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.cmbProductNames);
            this.Controls.Add(this.cmbCategories);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OnlineOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Order";
            this.Load += new System.EventHandler(this.OnlineOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ComboBox cmbProductNames;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.ComboBox cmbDeliveryMethods;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.TextBox tbSearchText;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDeliveryMethod;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ColumnHeader chOrderedProductName;
        private System.Windows.Forms.ColumnHeader chWeight;
        private System.Windows.Forms.ColumnHeader chProductPrice;
        private System.Windows.Forms.ColumnHeader chOrderPrice;
        private System.Windows.Forms.ColumnHeader chDeliveryMethod;
        private System.Windows.Forms.ColumnHeader chDeliveryDate;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.Button btnRemoveOrder;
    }
}

