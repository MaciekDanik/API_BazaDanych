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
            btn_LoadData = new Button();
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
            SuspendLayout();
            // 
            // btn_LoadData
            // 
            btn_LoadData.BackColor = Color.Salmon;
            btn_LoadData.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_LoadData.ForeColor = SystemColors.ControlText;
            btn_LoadData.Location = new Point(12, 10);
            btn_LoadData.Name = "btn_LoadData";
            btn_LoadData.Size = new Size(97, 57);
            btn_LoadData.TabIndex = 1;
            btn_LoadData.Text = "Download Data";
            btn_LoadData.UseVisualStyleBackColor = false;
            btn_LoadData.Click += btn_LoadData_Click;
            // 
            // txtBox_InitialResult
            // 
            txtBox_InitialResult.Location = new Point(463, 5);
            txtBox_InitialResult.Name = "txtBox_InitialResult";
            txtBox_InitialResult.ReadOnly = true;
            txtBox_InitialResult.ScrollBars = ScrollBars.Vertical;
            txtBox_InitialResult.Size = new Size(41, 23);
            txtBox_InitialResult.TabIndex = 2;
            // 
            // lstBox_Initial
            // 
            lstBox_Initial.ColumnWidth = 600;
            lstBox_Initial.FormattingEnabled = true;
            lstBox_Initial.ItemHeight = 15;
            lstBox_Initial.Location = new Point(284, 28);
            lstBox_Initial.Name = "lstBox_Initial";
            lstBox_Initial.Size = new Size(591, 334);
            lstBox_Initial.TabIndex = 3;
            lstBox_Initial.SelectedIndexChanged += lstBox_Initial_SelectedIndexChanged;
            // 
            // btn_GetDetails
            // 
            btn_GetDetails.BackColor = Color.MediumPurple;
            btn_GetDetails.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_GetDetails.Location = new Point(115, 10);
            btn_GetDetails.Name = "btn_GetDetails";
            btn_GetDetails.Size = new Size(100, 57);
            btn_GetDetails.TabIndex = 4;
            btn_GetDetails.Text = "Details";
            btn_GetDetails.UseVisualStyleBackColor = false;
            btn_GetDetails.Click += btn_GetDetails_Click;
            // 
            // btn_SortAlc
            // 
            btn_SortAlc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_SortAlc.Location = new Point(12, 280);
            btn_SortAlc.Name = "btn_SortAlc";
            btn_SortAlc.Size = new Size(109, 40);
            btn_SortAlc.TabIndex = 5;
            btn_SortAlc.Text = "Alcoholic";
            btn_SortAlc.UseVisualStyleBackColor = true;
            btn_SortAlc.Click += btn_SortAlc_Click;
            // 
            // btn_SortNonAlc
            // 
            btn_SortNonAlc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_SortNonAlc.Location = new Point(12, 326);
            btn_SortNonAlc.Name = "btn_SortNonAlc";
            btn_SortNonAlc.Size = new Size(109, 40);
            btn_SortNonAlc.TabIndex = 6;
            btn_SortNonAlc.Text = "NonAlcoholic";
            btn_SortNonAlc.UseVisualStyleBackColor = true;
            btn_SortNonAlc.Click += btn_SortNonAlc_Click;
            // 
            // lbl_CurrentDrink
            // 
            lbl_CurrentDrink.AutoSize = true;
            lbl_CurrentDrink.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_CurrentDrink.Location = new Point(284, 7);
            lbl_CurrentDrink.Name = "lbl_CurrentDrink";
            lbl_CurrentDrink.Size = new Size(162, 20);
            lbl_CurrentDrink.TabIndex = 13;
            lbl_CurrentDrink.Text = "Currently highlighted:";
            // 
            // lbl_sorting
            // 
            lbl_sorting.AutoSize = true;
            lbl_sorting.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_sorting.Location = new Point(12, 157);
            lbl_sorting.Name = "lbl_sorting";
            lbl_sorting.Size = new Size(70, 20);
            lbl_sorting.TabIndex = 14;
            lbl_sorting.Text = "Filter by:";
            // 
            // btn_clearFilter
            // 
            btn_clearFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_clearFilter.Location = new Point(12, 372);
            btn_clearFilter.Name = "btn_clearFilter";
            btn_clearFilter.Size = new Size(109, 40);
            btn_clearFilter.TabIndex = 15;
            btn_clearFilter.Text = "Clear";
            btn_clearFilter.UseVisualStyleBackColor = true;
            btn_clearFilter.Click += btn_clearFilter_Click;
            // 
            // txtBox_FilterName
            // 
            txtBox_FilterName.Location = new Point(73, 196);
            txtBox_FilterName.Name = "txtBox_FilterName";
            txtBox_FilterName.ScrollBars = ScrollBars.Vertical;
            txtBox_FilterName.Size = new Size(106, 23);
            txtBox_FilterName.TabIndex = 17;
            txtBox_FilterName.TextChanged += txtBox_FilterName_TextChanged;
            // 
            // lbl_FilterName
            // 
            lbl_FilterName.AutoSize = true;
            lbl_FilterName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_FilterName.Location = new Point(12, 196);
            lbl_FilterName.Name = "lbl_FilterName";
            lbl_FilterName.Size = new Size(54, 20);
            lbl_FilterName.TabIndex = 18;
            lbl_FilterName.Text = "Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(884, 424);
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
            Controls.Add(btn_LoadData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_LoadData;
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
    }
}
