namespace GUI
{
    partial class Details
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
            lbl_drinkName = new Label();
            lbl_Category = new Label();
            lbl_drinkGlass = new Label();
            lbl_ingredients_measures = new Label();
            lbl_drinkInstructions = new Label();
            txtBox_drinkName = new TextBox();
            txtBox_drinkCategory = new TextBox();
            txtBox_drinkGlass = new TextBox();
            txtBox_recepie = new TextBox();
            txtBox_ingredients = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_drinkName
            // 
            lbl_drinkName.AutoSize = true;
            lbl_drinkName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_drinkName.Location = new Point(11, 19);
            lbl_drinkName.Name = "lbl_drinkName";
            lbl_drinkName.Size = new Size(69, 25);
            lbl_drinkName.TabIndex = 0;
            lbl_drinkName.Text = "Name:";
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_Category.Location = new Point(11, 100);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(96, 25);
            lbl_Category.TabIndex = 1;
            lbl_Category.Text = "Category:";
            // 
            // lbl_drinkGlass
            // 
            lbl_drinkGlass.AutoSize = true;
            lbl_drinkGlass.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_drinkGlass.Location = new Point(11, 179);
            lbl_drinkGlass.Name = "lbl_drinkGlass";
            lbl_drinkGlass.Size = new Size(61, 25);
            lbl_drinkGlass.TabIndex = 2;
            lbl_drinkGlass.Text = "Glass:";
            // 
            // lbl_ingredients_measures
            // 
            lbl_ingredients_measures.AutoSize = true;
            lbl_ingredients_measures.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_ingredients_measures.Location = new Point(11, 332);
            lbl_ingredients_measures.Name = "lbl_ingredients_measures";
            lbl_ingredients_measures.Size = new Size(237, 25);
            lbl_ingredients_measures.TabIndex = 3;
            lbl_ingredients_measures.Text = "Ingredients and measures:";
            // 
            // lbl_drinkInstructions
            // 
            lbl_drinkInstructions.AutoSize = true;
            lbl_drinkInstructions.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_drinkInstructions.Location = new Point(447, 20);
            lbl_drinkInstructions.Name = "lbl_drinkInstructions";
            lbl_drinkInstructions.Size = new Size(83, 25);
            lbl_drinkInstructions.TabIndex = 4;
            lbl_drinkInstructions.Text = "Recepie:";
            lbl_drinkInstructions.Click += lbl_drinkInstructions_Click;
            // 
            // txtBox_drinkName
            // 
            txtBox_drinkName.Location = new Point(105, 16);
            txtBox_drinkName.Margin = new Padding(3, 4, 3, 4);
            txtBox_drinkName.Name = "txtBox_drinkName";
            txtBox_drinkName.ReadOnly = true;
            txtBox_drinkName.Size = new Size(177, 27);
            txtBox_drinkName.TabIndex = 6;
            txtBox_drinkName.TextChanged += txtBox_drinkName_TextChanged;
            // 
            // txtBox_drinkCategory
            // 
            txtBox_drinkCategory.Location = new Point(105, 101);
            txtBox_drinkCategory.Margin = new Padding(3, 4, 3, 4);
            txtBox_drinkCategory.Name = "txtBox_drinkCategory";
            txtBox_drinkCategory.ReadOnly = true;
            txtBox_drinkCategory.Size = new Size(177, 27);
            txtBox_drinkCategory.TabIndex = 7;
            // 
            // txtBox_drinkGlass
            // 
            txtBox_drinkGlass.Location = new Point(105, 180);
            txtBox_drinkGlass.Margin = new Padding(3, 4, 3, 4);
            txtBox_drinkGlass.Name = "txtBox_drinkGlass";
            txtBox_drinkGlass.ReadOnly = true;
            txtBox_drinkGlass.Size = new Size(177, 27);
            txtBox_drinkGlass.TabIndex = 8;
            txtBox_drinkGlass.TextChanged += txtBox_drinkGlass_TextChanged;
            // 
            // txtBox_recepie
            // 
            txtBox_recepie.Location = new Point(529, 16);
            txtBox_recepie.Margin = new Padding(3, 4, 3, 4);
            txtBox_recepie.Multiline = true;
            txtBox_recepie.Name = "txtBox_recepie";
            txtBox_recepie.ReadOnly = true;
            txtBox_recepie.ScrollBars = ScrollBars.Vertical;
            txtBox_recepie.Size = new Size(437, 341);
            txtBox_recepie.TabIndex = 9;
            // 
            // txtBox_ingredients
            // 
            txtBox_ingredients.Location = new Point(14, 363);
            txtBox_ingredients.Margin = new Padding(3, 4, 3, 4);
            txtBox_ingredients.Multiline = true;
            txtBox_ingredients.Name = "txtBox_ingredients";
            txtBox_ingredients.ReadOnly = true;
            txtBox_ingredients.ScrollBars = ScrollBars.Vertical;
            txtBox_ingredients.Size = new Size(452, 333);
            txtBox_ingredients.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(656, 433);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(995, 713);
            Controls.Add(pictureBox1);
            Controls.Add(txtBox_ingredients);
            Controls.Add(txtBox_recepie);
            Controls.Add(txtBox_drinkGlass);
            Controls.Add(txtBox_drinkCategory);
            Controls.Add(txtBox_drinkName);
            Controls.Add(lbl_drinkInstructions);
            Controls.Add(lbl_ingredients_measures);
            Controls.Add(lbl_drinkGlass);
            Controls.Add(lbl_Category);
            Controls.Add(lbl_drinkName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Details";
            Text = "Details";
            Load += Details_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_drinkName;
        private Label lbl_Category;
        private Label lbl_drinkGlass;
        private Label lbl_ingredients_measures;
        private Label lbl_drinkInstructions;
        private TextBox txtBox_drinkName;
        private TextBox txtBox_drinkCategory;
        private TextBox txtBox_drinkGlass;
        private TextBox txtBox_recepie;
        private TextBox txtBox_ingredients;
        private PictureBox pictureBox1;
    }
}