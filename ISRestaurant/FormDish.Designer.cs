namespace ISRestaurant
{
    partial class FormDish
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
            this.btnDeleteIng = new System.Windows.Forms.Button();
            this.cmBoxIngredient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsertIngridient = new System.Windows.Forms.Button();
            this.cmBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSale = new System.Windows.Forms.CheckBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_ingredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteIng
            // 
            this.btnDeleteIng.Font = new System.Drawing.Font("Magneto", 11F);
            this.btnDeleteIng.Location = new System.Drawing.Point(344, 227);
            this.btnDeleteIng.Name = "btnDeleteIng";
            this.btnDeleteIng.Size = new System.Drawing.Size(215, 33);
            this.btnDeleteIng.TabIndex = 53;
            this.btnDeleteIng.Text = "Удалить";
            this.btnDeleteIng.UseVisualStyleBackColor = true;
            this.btnDeleteIng.Click += new System.EventHandler(this.btnDeleteIng_Click);
            // 
            // cmBoxIngredient
            // 
            this.cmBoxIngredient.DisplayMember = "name";
            this.cmBoxIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmBoxIngredient.FormattingEnabled = true;
            this.cmBoxIngredient.Location = new System.Drawing.Point(344, 154);
            this.cmBoxIngredient.Name = "cmBoxIngredient";
            this.cmBoxIngredient.Size = new System.Drawing.Size(215, 28);
            this.cmBoxIngredient.TabIndex = 55;
            this.cmBoxIngredient.ValueMember = "id_ingredient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Magneto", 12F);
            this.label5.Location = new System.Drawing.Point(340, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Ингридиент";
            // 
            // btnInsertIngridient
            // 
            this.btnInsertIngridient.Font = new System.Drawing.Font("Magneto", 11F);
            this.btnInsertIngridient.Location = new System.Drawing.Point(344, 188);
            this.btnInsertIngridient.Name = "btnInsertIngridient";
            this.btnInsertIngridient.Size = new System.Drawing.Size(215, 33);
            this.btnInsertIngridient.TabIndex = 52;
            this.btnInsertIngridient.Text = "Добавить";
            this.btnInsertIngridient.UseVisualStyleBackColor = true;
            this.btnInsertIngridient.Click += new System.EventHandler(this.btnInsertIngridient_Click);
            // 
            // cmBoxCategory
            // 
            this.cmBoxCategory.DisplayMember = "name";
            this.cmBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmBoxCategory.FormattingEnabled = true;
            this.cmBoxCategory.Location = new System.Drawing.Point(54, 296);
            this.cmBoxCategory.Name = "cmBoxCategory";
            this.cmBoxCategory.Size = new System.Drawing.Size(214, 28);
            this.cmBoxCategory.TabIndex = 61;
            this.cmBoxCategory.ValueMember = "id_category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 12F);
            this.label3.Location = new System.Drawing.Point(55, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Категория";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(54, 239);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(214, 26);
            this.numericUpDown1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 12F);
            this.label2.Location = new System.Drawing.Point(54, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Калории";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F);
            this.label1.Location = new System.Drawing.Point(51, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Название";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxName.Location = new System.Drawing.Point(54, 186);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(214, 27);
            this.txtBoxName.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.checkSale);
            this.groupBox1.Controls.Add(this.cmBoxCategory);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(597, -58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 506);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkSale
            // 
            this.checkSale.AutoSize = true;
            this.checkSale.Font = new System.Drawing.Font("Magneto", 12F);
            this.checkSale.Location = new System.Drawing.Point(54, 330);
            this.checkSale.Name = "checkSale";
            this.checkSale.Size = new System.Drawing.Size(198, 24);
            this.checkSale.TabIndex = 62;
            this.checkSale.Text = "Выставить в продажу";
            this.checkSale.UseVisualStyleBackColor = true;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAddDish.Font = new System.Drawing.Font("Magneto", 20F);
            this.btnAddDish.Location = new System.Drawing.Point(417, 350);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(334, 56);
            this.btnAddDish.TabIndex = 63;
            this.btnAddDish.Text = "Добавить Блюдо";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ingredient,
            this.name,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(300, 394);
            this.dataGridView1.TabIndex = 64;
            // 
            // id_ingredient
            // 
            this.id_ingredient.DataPropertyName = "id_ingredient";
            this.id_ingredient.HeaderText = "id_ingredient";
            this.id_ingredient.Name = "id_ingredient";
            this.id_ingredient.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.Width = 150;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataSource = typeof(ISRestaurant.Ingredient);
            // 
            // FormDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteIng);
            this.Controls.Add(this.cmBoxIngredient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertIngridient);
            this.MaximumSize = new System.Drawing.Size(900, 470);
            this.MinimumSize = new System.Drawing.Size(900, 470);
            this.Name = "FormDish";
            this.Text = "Форма Блюда";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteIng;
        private System.Windows.Forms.ComboBox cmBoxIngredient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsertIngridient;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private System.Windows.Forms.ComboBox cmBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ingredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.CheckBox checkSale;
    }
}