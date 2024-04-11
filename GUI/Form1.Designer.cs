namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBox_InitialResult = new TextBox();
            lstBox_Initial = new ListBox();
            btn_GetDetails = new Button();
            btn_SortAlc = new Button();
            btn_SortNonAlc = new Button();
            lbl_CurrentDrink = new Label();
            lbl_sorting = new Label();
            btn_clearFilter = new Button();
            txtBox_FilterName = new TextBox();
            lbl_FilterName = new Label();
            menuStrip1 = new MenuStrip();
            dataBaseToolStripMenuItem = new ToolStripMenuItem();
            downloadDataToolStripMenuItem = new ToolStripMenuItem();
            btn_FilterFav = new Button();
            btn_AddFav = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBox_InitialResult
            // 
            txtBox_InitialResult.Location = new Point(527, 41);
            txtBox_InitialResult.Margin = new Padding(3, 4, 3, 4);
            txtBox_InitialResult.Name = "txtBox_InitialResult";
            txtBox_InitialResult.ReadOnly = true;
            txtBox_InitialResult.ScrollBars = ScrollBars.Vertical;
            txtBox_InitialResult.Size = new Size(46, 27);
            txtBox_InitialResult.TabIndex = 2;
            // 
            // lstBox_Initial
            // 
            lstBox_Initial.ColumnWidth = 600;
            lstBox_Initial.FormattingEnabled = true;
            lstBox_Initial.Location = new Point(323, 71);
            lstBox_Initial.Margin = new Padding(3, 4, 3, 4);
            lstBox_Initial.Name = "lstBox_Initial";
            lstBox_Initial.Size = new Size(675, 444);
            lstBox_Initial.TabIndex = 3;
            lstBox_Initial.SelectedIndexChanged += lstBox_Initial_SelectedIndexChanged;
            // 
            // btn_GetDetails
            // 
            btn_GetDetails.BackColor = Color.MediumPurple;
            btn_GetDetails.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_GetDetails.Location = new Point(14, 43);
            btn_GetDetails.Margin = new Padding(3, 4, 3, 4);
            btn_GetDetails.Name = "btn_GetDetails";
            btn_GetDetails.Size = new Size(229, 76);
            btn_GetDetails.TabIndex = 4;
            btn_GetDetails.Text = "Details";
            btn_GetDetails.UseVisualStyleBackColor = false;
            btn_GetDetails.Click += btn_GetDetails_Click;
            // 
            // btn_SortAlc
            // 
            btn_SortAlc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_SortAlc.Location = new Point(14, 376);
            btn_SortAlc.Margin = new Padding(3, 4, 3, 4);
            btn_SortAlc.Name = "btn_SortAlc";
            btn_SortAlc.Size = new Size(125, 53);
            btn_SortAlc.TabIndex = 5;
            btn_SortAlc.Text = "Alcoholic";
            btn_SortAlc.UseVisualStyleBackColor = true;
            btn_SortAlc.Click += btn_SortAlc_Click;
            // 
            // btn_SortNonAlc
            // 
            btn_SortNonAlc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_SortNonAlc.Location = new Point(14, 438);
            btn_SortNonAlc.Margin = new Padding(3, 4, 3, 4);
            btn_SortNonAlc.Name = "btn_SortNonAlc";
            btn_SortNonAlc.Size = new Size(125, 53);
            btn_SortNonAlc.TabIndex = 6;
            btn_SortNonAlc.Text = "NonAlcoholic";
            btn_SortNonAlc.UseVisualStyleBackColor = true;
            btn_SortNonAlc.Click += btn_SortNonAlc_Click;
            // 
            // lbl_CurrentDrink
            // 
            lbl_CurrentDrink.AutoSize = true;
            lbl_CurrentDrink.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_CurrentDrink.Location = new Point(323, 43);
            lbl_CurrentDrink.Name = "lbl_CurrentDrink";
            lbl_CurrentDrink.Size = new Size(199, 25);
            lbl_CurrentDrink.TabIndex = 13;
            lbl_CurrentDrink.Text = "Currently highlighted:";
            // 
            // lbl_sorting
            // 
            lbl_sorting.AutoSize = true;
            lbl_sorting.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_sorting.Location = new Point(14, 209);
            lbl_sorting.Name = "lbl_sorting";
            lbl_sorting.Size = new Size(89, 25);
            lbl_sorting.TabIndex = 14;
            lbl_sorting.Text = "Filter by:";
            // 
            // btn_clearFilter
            // 
            btn_clearFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_clearFilter.Location = new Point(14, 499);
            btn_clearFilter.Margin = new Padding(3, 4, 3, 4);
            btn_clearFilter.Name = "btn_clearFilter";
            btn_clearFilter.Size = new Size(125, 53);
            btn_clearFilter.TabIndex = 15;
            btn_clearFilter.Text = "Clear";
            btn_clearFilter.UseVisualStyleBackColor = true;
            btn_clearFilter.Click += btn_clearFilter_Click;
            // 
            // txtBox_FilterName
            // 
            txtBox_FilterName.Location = new Point(83, 261);
            txtBox_FilterName.Margin = new Padding(3, 4, 3, 4);
            txtBox_FilterName.Name = "txtBox_FilterName";
            txtBox_FilterName.ScrollBars = ScrollBars.Vertical;
            txtBox_FilterName.Size = new Size(121, 27);
            txtBox_FilterName.TabIndex = 17;
            txtBox_FilterName.TextChanged += txtBox_FilterName_TextChanged;
            // 
            // lbl_FilterName
            // 
            lbl_FilterName.AutoSize = true;
            lbl_FilterName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_FilterName.Location = new Point(14, 261);
            lbl_FilterName.Name = "lbl_FilterName";
            lbl_FilterName.Size = new Size(69, 25);
            lbl_FilterName.TabIndex = 18;
            lbl_FilterName.Text = "Name:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataBaseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1010, 28);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataBaseToolStripMenuItem
            // 
            dataBaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { downloadDataToolStripMenuItem });
            dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            dataBaseToolStripMenuItem.Size = new Size(86, 24);
            dataBaseToolStripMenuItem.Text = "DataBase";
            // 
            // downloadDataToolStripMenuItem
            // 
            downloadDataToolStripMenuItem.Name = "downloadDataToolStripMenuItem";
            downloadDataToolStripMenuItem.Size = new Size(193, 26);
            downloadDataToolStripMenuItem.Text = "DownloadData";
            downloadDataToolStripMenuItem.Click += downloadDataToolStripMenuItem_Click;
            // 
            // btn_FilterFav
            // 
            btn_FilterFav.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_FilterFav.Location = new Point(14, 315);
            btn_FilterFav.Margin = new Padding(3, 4, 3, 4);
            btn_FilterFav.Name = "btn_FilterFav";
            btn_FilterFav.Size = new Size(125, 53);
            btn_FilterFav.TabIndex = 20;
            btn_FilterFav.Text = "Favourites";
            btn_FilterFav.UseVisualStyleBackColor = true;
            btn_FilterFav.Click += btn_FilterFav_Click;
            // 
            // btn_AddFav
            // 
            btn_AddFav.BackColor = Color.Thistle;
            btn_AddFav.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_AddFav.Location = new Point(14, 127);
            btn_AddFav.Margin = new Padding(3, 4, 3, 4);
            btn_AddFav.Name = "btn_AddFav";
            btn_AddFav.Size = new Size(229, 76);
            btn_AddFav.TabIndex = 21;
            btn_AddFav.Text = "Add To Favourites";
            btn_AddFav.UseVisualStyleBackColor = false;
            btn_AddFav.Click += btn_AddFav_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1010, 565);
            Controls.Add(btn_AddFav);
            Controls.Add(btn_FilterFav);
            Controls.Add(lbl_FilterName);
            Controls.Add(txtBox_FilterName);
            Controls.Add(btn_clearFilter);
            Controls.Add(lbl_sorting);
            Controls.Add(lbl_CurrentDrink);
            Controls.Add(btn_SortNonAlc);
            Controls.Add(btn_SortAlc);
            Controls.Add(btn_GetDetails);
            Controls.Add(lstBox_Initial);
            Controls.Add(txtBox_InitialResult);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBox_InitialResult;
        private ListBox lstBox_Initial;
        private Button btn_GetDetails;
        private Button btn_SortAlc;
        private Button btn_SortNonAlc;
        private Label lbl_CurrentDrink;
        private Label lbl_sorting;
        private Button btn_clearFilter;
        private TextBox txtBox_FilterName;
        private Label lbl_FilterName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataBaseToolStripMenuItem;
        private ToolStripMenuItem downloadDataToolStripMenuItem;
        private Button btn_FilterFav;
        private Button btn_AddFav;
    }
}
