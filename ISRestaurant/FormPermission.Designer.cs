namespace ISRestaurant
{
    partial class FormPermission
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
            this.lblPosName = new System.Windows.Forms.Label();
            this.groupCategory = new System.Windows.Forms.GroupBox();
            this.checkCategory = new System.Windows.Forms.CheckBox();
            this.categoryRemove = new System.Windows.Forms.CheckBox();
            this.categoryInsert = new System.Windows.Forms.CheckBox();
            this.categoryUpdate = new System.Windows.Forms.CheckBox();
            this.lbl = new System.Windows.Forms.Label();
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.checkDish = new System.Windows.Forms.CheckBox();
            this.dishDelete = new System.Windows.Forms.CheckBox();
            this.dishInsert = new System.Windows.Forms.CheckBox();
            this.dishUpdate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPosition = new System.Windows.Forms.GroupBox();
            this.checkPosition = new System.Windows.Forms.CheckBox();
            this.positionDelete = new System.Windows.Forms.CheckBox();
            this.positionInsert = new System.Windows.Forms.CheckBox();
            this.positionUpdate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupIngredient = new System.Windows.Forms.GroupBox();
            this.checkIngredient = new System.Windows.Forms.CheckBox();
            this.ingredientDelete = new System.Windows.Forms.CheckBox();
            this.ingredientInsert = new System.Windows.Forms.CheckBox();
            this.ingredientUpdate = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupWorker = new System.Windows.Forms.GroupBox();
            this.checkWorker = new System.Windows.Forms.CheckBox();
            this.workerDelete = new System.Windows.Forms.CheckBox();
            this.workerInsert = new System.Windows.Forms.CheckBox();
            this.workerUpdate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupPrice = new System.Windows.Forms.GroupBox();
            this.checkPrice = new System.Windows.Forms.CheckBox();
            this.priceDelete = new System.Windows.Forms.CheckBox();
            this.priceInsert = new System.Windows.Forms.CheckBox();
            this.priceUpdate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupOrder = new System.Windows.Forms.GroupBox();
            this.checkOrder = new System.Windows.Forms.CheckBox();
            this.orderDelete = new System.Windows.Forms.CheckBox();
            this.orderInsert = new System.Windows.Forms.CheckBox();
            this.orderUpdate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckQuerry = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupCategory.SuspendLayout();
            this.groupMenu.SuspendLayout();
            this.groupPosition.SuspendLayout();
            this.groupIngredient.SuspendLayout();
            this.groupWorker.SuspendLayout();
            this.groupPrice.SuspendLayout();
            this.groupOrder.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPosName
            // 
            this.lblPosName.AutoSize = true;
            this.lblPosName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosName.Location = new System.Drawing.Point(12, 20);
            this.lblPosName.Name = "lblPosName";
            this.lblPosName.Size = new System.Drawing.Size(70, 25);
            this.lblPosName.TabIndex = 0;
            this.lblPosName.Text = "label1";
            // 
            // groupCategory
            // 
            this.groupCategory.Controls.Add(this.checkCategory);
            this.groupCategory.Controls.Add(this.categoryRemove);
            this.groupCategory.Controls.Add(this.categoryInsert);
            this.groupCategory.Controls.Add(this.categoryUpdate);
            this.groupCategory.Controls.Add(this.lbl);
            this.groupCategory.Location = new System.Drawing.Point(12, 65);
            this.groupCategory.Name = "groupCategory";
            this.groupCategory.Size = new System.Drawing.Size(551, 50);
            this.groupCategory.TabIndex = 1;
            this.groupCategory.TabStop = false;
            // 
            // checkCategory
            // 
            this.checkCategory.AutoSize = true;
            this.checkCategory.Location = new System.Drawing.Point(20, 20);
            this.checkCategory.Name = "checkCategory";
            this.checkCategory.Size = new System.Drawing.Size(77, 17);
            this.checkCategory.TabIndex = 4;
            this.checkCategory.Text = "Просмотр";
            this.checkCategory.UseVisualStyleBackColor = true;
            this.checkCategory.CheckedChanged += new System.EventHandler(this.checkCategory_CheckedChanged);
            // 
            // categoryRemove
            // 
            this.categoryRemove.AutoSize = true;
            this.categoryRemove.Location = new System.Drawing.Point(450, 20);
            this.categoryRemove.Name = "categoryRemove";
            this.categoryRemove.Size = new System.Drawing.Size(76, 17);
            this.categoryRemove.TabIndex = 3;
            this.categoryRemove.Text = "Удаление";
            this.categoryRemove.UseVisualStyleBackColor = true;
            this.categoryRemove.CheckedChanged += new System.EventHandler(this.categoryRemove_CheckedChanged);
            // 
            // categoryInsert
            // 
            this.categoryInsert.AutoSize = true;
            this.categoryInsert.Location = new System.Drawing.Point(250, 20);
            this.categoryInsert.Name = "categoryInsert";
            this.categoryInsert.Size = new System.Drawing.Size(89, 17);
            this.categoryInsert.TabIndex = 2;
            this.categoryInsert.Text = "Добавление";
            this.categoryInsert.UseVisualStyleBackColor = true;
            this.categoryInsert.CheckedChanged += new System.EventHandler(this.categoryInsert_CheckedChanged);
            // 
            // categoryUpdate
            // 
            this.categoryUpdate.AutoSize = true;
            this.categoryUpdate.Location = new System.Drawing.Point(350, 20);
            this.categoryUpdate.Name = "categoryUpdate";
            this.categoryUpdate.Size = new System.Drawing.Size(88, 17);
            this.categoryUpdate.TabIndex = 1;
            this.categoryUpdate.Text = "Обновление";
            this.categoryUpdate.UseVisualStyleBackColor = true;
            this.categoryUpdate.CheckedChanged += new System.EventHandler(this.categoryUpdate_CheckedChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl.Location = new System.Drawing.Point(100, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(89, 20);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Категории";
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.checkDish);
            this.groupMenu.Controls.Add(this.dishDelete);
            this.groupMenu.Controls.Add(this.dishInsert);
            this.groupMenu.Controls.Add(this.dishUpdate);
            this.groupMenu.Controls.Add(this.label3);
            this.groupMenu.Location = new System.Drawing.Point(12, 115);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(551, 50);
            this.groupMenu.TabIndex = 2;
            this.groupMenu.TabStop = false;
            // 
            // checkDish
            // 
            this.checkDish.AutoSize = true;
            this.checkDish.Location = new System.Drawing.Point(20, 20);
            this.checkDish.Name = "checkDish";
            this.checkDish.Size = new System.Drawing.Size(77, 17);
            this.checkDish.TabIndex = 4;
            this.checkDish.Text = "Просмотр";
            this.checkDish.UseVisualStyleBackColor = true;
            this.checkDish.CheckedChanged += new System.EventHandler(this.checkDish_CheckedChanged);
            // 
            // dishDelete
            // 
            this.dishDelete.AutoSize = true;
            this.dishDelete.Location = new System.Drawing.Point(450, 20);
            this.dishDelete.Name = "dishDelete";
            this.dishDelete.Size = new System.Drawing.Size(76, 17);
            this.dishDelete.TabIndex = 3;
            this.dishDelete.Text = "Удаление";
            this.dishDelete.UseVisualStyleBackColor = true;
            this.dishDelete.CheckedChanged += new System.EventHandler(this.dishDelete_CheckedChanged);
            // 
            // dishInsert
            // 
            this.dishInsert.AutoSize = true;
            this.dishInsert.Location = new System.Drawing.Point(250, 20);
            this.dishInsert.Name = "dishInsert";
            this.dishInsert.Size = new System.Drawing.Size(89, 17);
            this.dishInsert.TabIndex = 2;
            this.dishInsert.Text = "Добавление";
            this.dishInsert.UseVisualStyleBackColor = true;
            this.dishInsert.CheckedChanged += new System.EventHandler(this.dishInsert_CheckedChanged);
            // 
            // dishUpdate
            // 
            this.dishUpdate.AutoSize = true;
            this.dishUpdate.Location = new System.Drawing.Point(350, 20);
            this.dishUpdate.Name = "dishUpdate";
            this.dishUpdate.Size = new System.Drawing.Size(88, 17);
            this.dishUpdate.TabIndex = 1;
            this.dishUpdate.Text = "Обновление";
            this.dishUpdate.UseVisualStyleBackColor = true;
            this.dishUpdate.CheckedChanged += new System.EventHandler(this.dishUpdate_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Меню";
            // 
            // groupPosition
            // 
            this.groupPosition.Controls.Add(this.checkPosition);
            this.groupPosition.Controls.Add(this.positionDelete);
            this.groupPosition.Controls.Add(this.positionInsert);
            this.groupPosition.Controls.Add(this.positionUpdate);
            this.groupPosition.Controls.Add(this.label4);
            this.groupPosition.Location = new System.Drawing.Point(12, 215);
            this.groupPosition.Name = "groupPosition";
            this.groupPosition.Size = new System.Drawing.Size(551, 50);
            this.groupPosition.TabIndex = 4;
            this.groupPosition.TabStop = false;
            // 
            // checkPosition
            // 
            this.checkPosition.AutoSize = true;
            this.checkPosition.Location = new System.Drawing.Point(20, 20);
            this.checkPosition.Name = "checkPosition";
            this.checkPosition.Size = new System.Drawing.Size(77, 17);
            this.checkPosition.TabIndex = 4;
            this.checkPosition.Text = "Просмотр";
            this.checkPosition.UseVisualStyleBackColor = true;
            this.checkPosition.CheckedChanged += new System.EventHandler(this.checkPosition_CheckedChanged);
            // 
            // positionDelete
            // 
            this.positionDelete.AutoSize = true;
            this.positionDelete.Location = new System.Drawing.Point(450, 20);
            this.positionDelete.Name = "positionDelete";
            this.positionDelete.Size = new System.Drawing.Size(76, 17);
            this.positionDelete.TabIndex = 3;
            this.positionDelete.Text = "Удаление";
            this.positionDelete.UseVisualStyleBackColor = true;
            this.positionDelete.CheckedChanged += new System.EventHandler(this.positionDelete_CheckedChanged);
            // 
            // positionInsert
            // 
            this.positionInsert.AutoSize = true;
            this.positionInsert.Location = new System.Drawing.Point(250, 20);
            this.positionInsert.Name = "positionInsert";
            this.positionInsert.Size = new System.Drawing.Size(89, 17);
            this.positionInsert.TabIndex = 2;
            this.positionInsert.Text = "Добавление";
            this.positionInsert.UseVisualStyleBackColor = true;
            this.positionInsert.CheckedChanged += new System.EventHandler(this.positionInsert_CheckedChanged);
            // 
            // positionUpdate
            // 
            this.positionUpdate.AutoSize = true;
            this.positionUpdate.Location = new System.Drawing.Point(350, 20);
            this.positionUpdate.Name = "positionUpdate";
            this.positionUpdate.Size = new System.Drawing.Size(88, 17);
            this.positionUpdate.TabIndex = 1;
            this.positionUpdate.Text = "Обновление";
            this.positionUpdate.UseVisualStyleBackColor = true;
            this.positionUpdate.CheckedChanged += new System.EventHandler(this.positionUpdate_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(100, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Должности";
            // 
            // groupIngredient
            // 
            this.groupIngredient.Controls.Add(this.checkIngredient);
            this.groupIngredient.Controls.Add(this.ingredientDelete);
            this.groupIngredient.Controls.Add(this.ingredientInsert);
            this.groupIngredient.Controls.Add(this.ingredientUpdate);
            this.groupIngredient.Controls.Add(this.label5);
            this.groupIngredient.Location = new System.Drawing.Point(12, 165);
            this.groupIngredient.Name = "groupIngredient";
            this.groupIngredient.Size = new System.Drawing.Size(551, 50);
            this.groupIngredient.TabIndex = 3;
            this.groupIngredient.TabStop = false;
            // 
            // checkIngredient
            // 
            this.checkIngredient.AutoSize = true;
            this.checkIngredient.Location = new System.Drawing.Point(20, 20);
            this.checkIngredient.Name = "checkIngredient";
            this.checkIngredient.Size = new System.Drawing.Size(77, 17);
            this.checkIngredient.TabIndex = 4;
            this.checkIngredient.Text = "Просмотр";
            this.checkIngredient.UseVisualStyleBackColor = true;
            this.checkIngredient.CheckedChanged += new System.EventHandler(this.checkIngredient_CheckedChanged);
            // 
            // ingredientDelete
            // 
            this.ingredientDelete.AutoSize = true;
            this.ingredientDelete.Location = new System.Drawing.Point(450, 20);
            this.ingredientDelete.Name = "ingredientDelete";
            this.ingredientDelete.Size = new System.Drawing.Size(76, 17);
            this.ingredientDelete.TabIndex = 3;
            this.ingredientDelete.Text = "Удаление";
            this.ingredientDelete.UseVisualStyleBackColor = true;
            this.ingredientDelete.CheckedChanged += new System.EventHandler(this.ingredientDelete_CheckedChanged);
            // 
            // ingredientInsert
            // 
            this.ingredientInsert.AutoSize = true;
            this.ingredientInsert.Location = new System.Drawing.Point(250, 20);
            this.ingredientInsert.Name = "ingredientInsert";
            this.ingredientInsert.Size = new System.Drawing.Size(89, 17);
            this.ingredientInsert.TabIndex = 2;
            this.ingredientInsert.Text = "Добавление";
            this.ingredientInsert.UseVisualStyleBackColor = true;
            this.ingredientInsert.CheckedChanged += new System.EventHandler(this.ingredientInsert_CheckedChanged);
            // 
            // ingredientUpdate
            // 
            this.ingredientUpdate.AutoSize = true;
            this.ingredientUpdate.Location = new System.Drawing.Point(350, 20);
            this.ingredientUpdate.Name = "ingredientUpdate";
            this.ingredientUpdate.Size = new System.Drawing.Size(88, 17);
            this.ingredientUpdate.TabIndex = 1;
            this.ingredientUpdate.Text = "Обновление";
            this.ingredientUpdate.UseVisualStyleBackColor = true;
            this.ingredientUpdate.CheckedChanged += new System.EventHandler(this.ingredientUpdate_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(100, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ингидиенты";
            // 
            // groupWorker
            // 
            this.groupWorker.Controls.Add(this.checkWorker);
            this.groupWorker.Controls.Add(this.workerDelete);
            this.groupWorker.Controls.Add(this.workerInsert);
            this.groupWorker.Controls.Add(this.workerUpdate);
            this.groupWorker.Controls.Add(this.label6);
            this.groupWorker.Location = new System.Drawing.Point(12, 315);
            this.groupWorker.Name = "groupWorker";
            this.groupWorker.Size = new System.Drawing.Size(551, 50);
            this.groupWorker.TabIndex = 6;
            this.groupWorker.TabStop = false;
            // 
            // checkWorker
            // 
            this.checkWorker.AutoSize = true;
            this.checkWorker.Location = new System.Drawing.Point(20, 20);
            this.checkWorker.Name = "checkWorker";
            this.checkWorker.Size = new System.Drawing.Size(77, 17);
            this.checkWorker.TabIndex = 4;
            this.checkWorker.Text = "Просмотр";
            this.checkWorker.UseVisualStyleBackColor = true;
            this.checkWorker.CheckedChanged += new System.EventHandler(this.checkWorker_CheckedChanged);
            // 
            // workerDelete
            // 
            this.workerDelete.AutoSize = true;
            this.workerDelete.Location = new System.Drawing.Point(450, 20);
            this.workerDelete.Name = "workerDelete";
            this.workerDelete.Size = new System.Drawing.Size(76, 17);
            this.workerDelete.TabIndex = 3;
            this.workerDelete.Text = "Удаление";
            this.workerDelete.UseVisualStyleBackColor = true;
            this.workerDelete.CheckedChanged += new System.EventHandler(this.workerDelete_CheckedChanged);
            // 
            // workerInsert
            // 
            this.workerInsert.AutoSize = true;
            this.workerInsert.Location = new System.Drawing.Point(250, 20);
            this.workerInsert.Name = "workerInsert";
            this.workerInsert.Size = new System.Drawing.Size(89, 17);
            this.workerInsert.TabIndex = 2;
            this.workerInsert.Text = "Добавление";
            this.workerInsert.UseVisualStyleBackColor = true;
            this.workerInsert.CheckedChanged += new System.EventHandler(this.workerInsert_CheckedChanged);
            // 
            // workerUpdate
            // 
            this.workerUpdate.AutoSize = true;
            this.workerUpdate.Location = new System.Drawing.Point(350, 20);
            this.workerUpdate.Name = "workerUpdate";
            this.workerUpdate.Size = new System.Drawing.Size(88, 17);
            this.workerUpdate.TabIndex = 1;
            this.workerUpdate.Text = "Обновление";
            this.workerUpdate.UseVisualStyleBackColor = true;
            this.workerUpdate.CheckedChanged += new System.EventHandler(this.workerUpdate_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(100, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Работники";
            // 
            // groupPrice
            // 
            this.groupPrice.Controls.Add(this.checkPrice);
            this.groupPrice.Controls.Add(this.priceDelete);
            this.groupPrice.Controls.Add(this.priceInsert);
            this.groupPrice.Controls.Add(this.priceUpdate);
            this.groupPrice.Controls.Add(this.label7);
            this.groupPrice.Location = new System.Drawing.Point(12, 265);
            this.groupPrice.Name = "groupPrice";
            this.groupPrice.Size = new System.Drawing.Size(551, 50);
            this.groupPrice.TabIndex = 5;
            this.groupPrice.TabStop = false;
            // 
            // checkPrice
            // 
            this.checkPrice.AutoSize = true;
            this.checkPrice.Location = new System.Drawing.Point(20, 20);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(77, 17);
            this.checkPrice.TabIndex = 4;
            this.checkPrice.Text = "Просмотр";
            this.checkPrice.UseVisualStyleBackColor = true;
            this.checkPrice.CheckedChanged += new System.EventHandler(this.checkPrice_CheckedChanged);
            // 
            // priceDelete
            // 
            this.priceDelete.AutoSize = true;
            this.priceDelete.Location = new System.Drawing.Point(450, 20);
            this.priceDelete.Name = "priceDelete";
            this.priceDelete.Size = new System.Drawing.Size(76, 17);
            this.priceDelete.TabIndex = 3;
            this.priceDelete.Text = "Удаление";
            this.priceDelete.UseVisualStyleBackColor = true;
            this.priceDelete.CheckedChanged += new System.EventHandler(this.priceDelete_CheckedChanged);
            // 
            // priceInsert
            // 
            this.priceInsert.AutoSize = true;
            this.priceInsert.Location = new System.Drawing.Point(250, 20);
            this.priceInsert.Name = "priceInsert";
            this.priceInsert.Size = new System.Drawing.Size(89, 17);
            this.priceInsert.TabIndex = 2;
            this.priceInsert.Text = "Добавление";
            this.priceInsert.UseVisualStyleBackColor = true;
            this.priceInsert.CheckedChanged += new System.EventHandler(this.priceInsert_CheckedChanged);
            // 
            // priceUpdate
            // 
            this.priceUpdate.AutoSize = true;
            this.priceUpdate.Location = new System.Drawing.Point(350, 20);
            this.priceUpdate.Name = "priceUpdate";
            this.priceUpdate.Size = new System.Drawing.Size(88, 17);
            this.priceUpdate.TabIndex = 1;
            this.priceUpdate.Text = "Обновление";
            this.priceUpdate.UseVisualStyleBackColor = true;
            this.priceUpdate.CheckedChanged += new System.EventHandler(this.priceUpdate_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(100, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Цены";
            // 
            // groupOrder
            // 
            this.groupOrder.Controls.Add(this.checkOrder);
            this.groupOrder.Controls.Add(this.orderDelete);
            this.groupOrder.Controls.Add(this.orderInsert);
            this.groupOrder.Controls.Add(this.orderUpdate);
            this.groupOrder.Controls.Add(this.label2);
            this.groupOrder.Location = new System.Drawing.Point(12, 371);
            this.groupOrder.Name = "groupOrder";
            this.groupOrder.Size = new System.Drawing.Size(551, 50);
            this.groupOrder.TabIndex = 7;
            this.groupOrder.TabStop = false;
            // 
            // checkOrder
            // 
            this.checkOrder.AutoSize = true;
            this.checkOrder.Location = new System.Drawing.Point(20, 20);
            this.checkOrder.Name = "checkOrder";
            this.checkOrder.Size = new System.Drawing.Size(77, 17);
            this.checkOrder.TabIndex = 4;
            this.checkOrder.Text = "Просмотр";
            this.checkOrder.UseVisualStyleBackColor = true;
            this.checkOrder.CheckedChanged += new System.EventHandler(this.checkOrder_CheckedChanged);
            // 
            // orderDelete
            // 
            this.orderDelete.AutoSize = true;
            this.orderDelete.Location = new System.Drawing.Point(450, 20);
            this.orderDelete.Name = "orderDelete";
            this.orderDelete.Size = new System.Drawing.Size(76, 17);
            this.orderDelete.TabIndex = 3;
            this.orderDelete.Text = "Удаление";
            this.orderDelete.UseVisualStyleBackColor = true;
            this.orderDelete.CheckedChanged += new System.EventHandler(this.orderDelete_CheckedChanged);
            // 
            // orderInsert
            // 
            this.orderInsert.AutoSize = true;
            this.orderInsert.Location = new System.Drawing.Point(250, 20);
            this.orderInsert.Name = "orderInsert";
            this.orderInsert.Size = new System.Drawing.Size(89, 17);
            this.orderInsert.TabIndex = 2;
            this.orderInsert.Text = "Добавление";
            this.orderInsert.UseVisualStyleBackColor = true;
            this.orderInsert.CheckedChanged += new System.EventHandler(this.orderInsert_CheckedChanged);
            // 
            // orderUpdate
            // 
            this.orderUpdate.AutoSize = true;
            this.orderUpdate.Location = new System.Drawing.Point(350, 20);
            this.orderUpdate.Name = "orderUpdate";
            this.orderUpdate.Size = new System.Drawing.Size(88, 17);
            this.orderUpdate.TabIndex = 1;
            this.orderUpdate.Text = "Обновление";
            this.orderUpdate.UseVisualStyleBackColor = true;
            this.orderUpdate.CheckedChanged += new System.EventHandler(this.orderUpdate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Заказы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckQuerry);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 50);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CheckQuerry
            // 
            this.CheckQuerry.AutoSize = true;
            this.CheckQuerry.Location = new System.Drawing.Point(20, 20);
            this.CheckQuerry.Name = "CheckQuerry";
            this.CheckQuerry.Size = new System.Drawing.Size(77, 17);
            this.CheckQuerry.TabIndex = 4;
            this.CheckQuerry.Text = "Просмотр";
            this.CheckQuerry.UseVisualStyleBackColor = true;
            this.CheckQuerry.CheckedChanged += new System.EventHandler(this.CheckQuerry_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отчеты";
            // 
            // FormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(586, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupOrder);
            this.Controls.Add(this.groupWorker);
            this.Controls.Add(this.groupPrice);
            this.Controls.Add(this.groupPosition);
            this.Controls.Add(this.groupIngredient);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.groupCategory);
            this.Controls.Add(this.lblPosName);
            this.MaximumSize = new System.Drawing.Size(602, 546);
            this.MinimumSize = new System.Drawing.Size(602, 546);
            this.Name = "FormPermission";
            this.Text = "Форма Распределение Ролей";
            this.groupCategory.ResumeLayout(false);
            this.groupCategory.PerformLayout();
            this.groupMenu.ResumeLayout(false);
            this.groupMenu.PerformLayout();
            this.groupPosition.ResumeLayout(false);
            this.groupPosition.PerformLayout();
            this.groupIngredient.ResumeLayout(false);
            this.groupIngredient.PerformLayout();
            this.groupWorker.ResumeLayout(false);
            this.groupWorker.PerformLayout();
            this.groupPrice.ResumeLayout(false);
            this.groupPrice.PerformLayout();
            this.groupOrder.ResumeLayout(false);
            this.groupOrder.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosName;
        private System.Windows.Forms.GroupBox groupCategory;
        private System.Windows.Forms.CheckBox categoryRemove;
        private System.Windows.Forms.CheckBox categoryInsert;
        private System.Windows.Forms.CheckBox categoryUpdate;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.CheckBox dishDelete;
        private System.Windows.Forms.CheckBox dishInsert;
        private System.Windows.Forms.CheckBox dishUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupPosition;
        private System.Windows.Forms.CheckBox positionDelete;
        private System.Windows.Forms.CheckBox positionInsert;
        private System.Windows.Forms.CheckBox positionUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupIngredient;
        private System.Windows.Forms.CheckBox ingredientDelete;
        private System.Windows.Forms.CheckBox ingredientInsert;
        private System.Windows.Forms.CheckBox ingredientUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupWorker;
        private System.Windows.Forms.CheckBox workerDelete;
        private System.Windows.Forms.CheckBox workerInsert;
        private System.Windows.Forms.CheckBox workerUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupPrice;
        private System.Windows.Forms.CheckBox priceDelete;
        private System.Windows.Forms.CheckBox priceInsert;
        private System.Windows.Forms.CheckBox priceUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkCategory;
        private System.Windows.Forms.CheckBox checkDish;
        private System.Windows.Forms.CheckBox checkPosition;
        private System.Windows.Forms.CheckBox checkIngredient;
        private System.Windows.Forms.CheckBox checkWorker;
        private System.Windows.Forms.CheckBox checkPrice;
        private System.Windows.Forms.GroupBox groupOrder;
        private System.Windows.Forms.CheckBox checkOrder;
        private System.Windows.Forms.CheckBox orderDelete;
        private System.Windows.Forms.CheckBox orderInsert;
        private System.Windows.Forms.CheckBox orderUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckQuerry;
        private System.Windows.Forms.Label label1;
    }
}