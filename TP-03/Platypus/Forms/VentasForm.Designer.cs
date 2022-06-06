
namespace FrontendPlatypus
{
    partial class VentasForm
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
            this.components = new System.ComponentModel.Container();
            this.searchPanel = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPriceDiscount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewVenta = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.textBox1);
            this.searchPanel.Controls.Add(this.button4);
            this.searchPanel.Controls.Add(this.button3);
            this.searchPanel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchPanel.Location = new System.Drawing.Point(40, 53);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(408, 103);
            this.searchPanel.TabIndex = 19;
            this.searchPanel.TabStop = false;
            this.searchPanel.Text = "Buscar producto por ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(85, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(6, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPriceDiscount);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.labelDiscount);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.labelSupplier);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labelAmount);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.labelCode);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(40, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 254);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // labelPriceDiscount
            // 
            this.labelPriceDiscount.AutoSize = true;
            this.labelPriceDiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceDiscount.Location = new System.Drawing.Point(348, 77);
            this.labelPriceDiscount.Name = "labelPriceDiscount";
            this.labelPriceDiscount.Size = new System.Drawing.Size(14, 20);
            this.labelPriceDiscount.TabIndex = 17;
            this.labelPriceDiscount.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(221, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Precio c/ desc:";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiscount.Location = new System.Drawing.Point(117, 231);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(14, 20);
            this.labelDiscount.TabIndex = 15;
            this.labelDiscount.Text = "-";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(18, 231);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 20);
            this.label24.TabIndex = 14;
            this.label24.Text = "Descuento:";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSupplier.Location = new System.Drawing.Point(116, 192);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(14, 20);
            this.labelSupplier.TabIndex = 13;
            this.labelSupplier.Text = "-";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(18, 192);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 20);
            this.label22.TabIndex = 12;
            this.label22.Text = "Proveedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Descripción:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(280, 36);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(14, 20);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(221, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 20);
            this.label19.TabIndex = 8;
            this.label19.Text = "Precio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(18, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Marca:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(77, 153);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(14, 20);
            this.labelAmount.TabIndex = 7;
            this.labelAmount.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(18, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Stock:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBrand.Location = new System.Drawing.Point(87, 114);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(14, 20);
            this.labelBrand.TabIndex = 6;
            this.labelBrand.Text = "-";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCode.Location = new System.Drawing.Point(92, 36);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(14, 20);
            this.labelCode.TabIndex = 4;
            this.labelCode.Text = "-";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(124, 75);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(14, 20);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridViewVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(566, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 596);
            this.panel1.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(426, 542);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 34);
            this.button5.TabIndex = 11;
            this.button5.Text = "Finalizar venta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(478, 423);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(14, 20);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(426, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total:";
            // 
            // dataGridViewVenta
            // 
            this.dataGridViewVenta.AllowUserToAddRows = false;
            this.dataGridViewVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVenta.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Desc,
            this.Discount,
            this.UnitCost,
            this.FinalPrice});
            this.dataGridViewVenta.GridColor = System.Drawing.Color.White;
            this.dataGridViewVenta.Location = new System.Drawing.Point(25, 53);
            this.dataGridViewVenta.Name = "dataGridViewVenta";
            this.dataGridViewVenta.ReadOnly = true;
            this.dataGridViewVenta.RowHeadersVisible = false;
            this.dataGridViewVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewVenta.RowTemplate.Height = 25;
            this.dataGridViewVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVenta.Size = new System.Drawing.Size(524, 355);
            this.dataGridViewVenta.TabIndex = 0;
            this.dataGridViewVenta.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewVenta_RowsAdded_1);
            this.dataGridViewVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewVenta_RowsRemoved_1);
            // 
            // Cod
            // 
            this.Cod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cod.HeaderText = "Código";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.HeaderText = "Descripción";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discount.HeaderText = "% Desc.";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UnitCost
            // 
            this.UnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitCost.HeaderText = "Precio Unitario";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.ReadOnly = true;
            this.UnitCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FinalPrice
            // 
            this.FinalPrice.HeaderText = "Precio Final";
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 10;
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 596);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox searchPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPriceDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPrice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}