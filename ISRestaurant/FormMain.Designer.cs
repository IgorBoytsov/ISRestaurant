namespace ISRestaurant
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnIngredient = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnQuerry = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnChangeWorker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategory.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCategory.Location = new System.Drawing.Point(527, 144);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(450, 60);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Категории блюд";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnErrorPer_Click);
            // 
            // btnIngredient
            // 
            this.btnIngredient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIngredient.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIngredient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngredient.Location = new System.Drawing.Point(527, 78);
            this.btnIngredient.Name = "btnIngredient";
            this.btnIngredient.Size = new System.Drawing.Size(450, 60);
            this.btnIngredient.TabIndex = 1;
            this.btnIngredient.Text = "Ингридиенты";
            this.btnIngredient.UseVisualStyleBackColor = false;
            this.btnIngredient.Click += new System.EventHandler(this.btnErrorPer_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrice.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrice.Location = new System.Drawing.Point(527, 210);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(450, 60);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "Цены";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnErrorPer_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrder.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrder.Location = new System.Drawing.Point(527, 276);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(450, 60);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Заказы";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnErrorPer_Click);
            // 
            // btnWorker
            // 
            this.btnWorker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWorker.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWorker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWorker.Location = new System.Drawing.Point(527, 340);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(450, 60);
            this.btnWorker.TabIndex = 4;
            this.btnWorker.Text = "Рабочие";
            this.btnWorker.UseVisualStyleBackColor = false;
            this.btnWorker.Click += new System.EventHandler(this.btnErrorPer_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPosition.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPosition.Location = new System.Drawing.Point(527, 406);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(450, 60);
            this.btnPosition.TabIndex = 5;
            this.btnPosition.Text = "Должности рабочих";
            this.btnPosition.UseVisualStyleBackColor = false;
            this.btnPosition.Click += new System.EventHandler(this.btnErrorPer_Click);
            // 
            // btnQuerry
            // 
            this.btnQuerry.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuerry.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuerry.Location = new System.Drawing.Point(12, 489);
            this.btnQuerry.Name = "btnQuerry";
            this.btnQuerry.Size = new System.Drawing.Size(450, 60);
            this.btnQuerry.TabIndex = 6;
            this.btnQuerry.Text = "Отчеты";
            this.btnQuerry.UseVisualStyleBackColor = false;
            this.btnQuerry.Click += new System.EventHandler(this.btnErrorPer_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Font = new System.Drawing.Font("Magneto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenu.Location = new System.Drawing.Point(527, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(450, 60);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Meню";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnErrorPer_Click);
            // 
            // btnChangeWorker
            // 
            this.btnChangeWorker.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeWorker.Location = new System.Drawing.Point(12, 12);
            this.btnChangeWorker.Name = "btnChangeWorker";
            this.btnChangeWorker.Size = new System.Drawing.Size(134, 42);
            this.btnChangeWorker.TabIndex = 8;
            this.btnChangeWorker.Text = "Сменить пользователя";
            this.btnChangeWorker.UseVisualStyleBackColor = true;
            this.btnChangeWorker.Click += new System.EventHandler(this.btnChangeWorker_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::ISRestaurant.Properties.Resources._583d7a7121a83158b02649f2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnChangeWorker);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnQuerry);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.btnIngredient);
            this.Controls.Add(this.btnCategory);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnIngredient;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnQuerry;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnChangeWorker;
    }
}

