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
            SuspendLayout();
            // 
            // btn_LoadData
            // 
            btn_LoadData.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_LoadData.Location = new Point(14, 13);
            btn_LoadData.Margin = new Padding(3, 4, 3, 4);
            btn_LoadData.Name = "btn_LoadData";
            btn_LoadData.Size = new Size(123, 73);
            btn_LoadData.TabIndex = 1;
            btn_LoadData.Text = "DownloadData";
            btn_LoadData.UseVisualStyleBackColor = true;
            btn_LoadData.Click += btn_LoadData_Click;
            // 
            // txtBox_InitialResult
            // 
            txtBox_InitialResult.Location = new Point(529, 7);
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
            lstBox_Initial.Location = new Point(324, 38);
            lstBox_Initial.Margin = new Padding(3, 4, 3, 4);
            lstBox_Initial.Name = "lstBox_Initial";
            lstBox_Initial.Size = new Size(675, 444);
            lstBox_Initial.TabIndex = 3;
            lstBox_Initial.SelectedIndexChanged += lstBox_Initial_SelectedIndexChanged;
            // 
            // btn_GetDetails
            // 
            btn_GetDetails.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_GetDetails.Location = new Point(143, 13);
            btn_GetDetails.Margin = new Padding(3, 4, 3, 4);
            btn_GetDetails.Name = "btn_GetDetails";
            btn_GetDetails.Size = new Size(123, 73);
            btn_GetDetails.TabIndex = 4;
            btn_GetDetails.Text = "Details";
            btn_GetDetails.UseVisualStyleBackColor = true;
            btn_GetDetails.Click += btn_GetDetails_Click;
            // 
            // btn_SortAlc
            // 
            btn_SortAlc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_SortAlc.Location = new Point(14, 357);
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
            btn_SortNonAlc.Location = new Point(14, 419);
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
            lbl_CurrentDrink.Location = new Point(324, 9);
            lbl_CurrentDrink.Name = "lbl_CurrentDrink";
            lbl_CurrentDrink.Size = new Size(199, 25);
            lbl_CurrentDrink.TabIndex = 13;
            lbl_CurrentDrink.Text = "Currently highlighted:";
            // 
            // lbl_sorting
            // 
            lbl_sorting.AutoSize = true;
            lbl_sorting.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbl_sorting.Location = new Point(12, 328);
            lbl_sorting.Name = "lbl_sorting";
            lbl_sorting.Size = new Size(86, 25);
            lbl_sorting.TabIndex = 14;
            lbl_sorting.Text = "Filter by:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 565);
            Controls.Add(lbl_sorting);
            Controls.Add(lbl_CurrentDrink);
            Controls.Add(btn_SortNonAlc);
            Controls.Add(btn_SortAlc);
            Controls.Add(btn_GetDetails);
            Controls.Add(lstBox_Initial);
            Controls.Add(txtBox_InitialResult);
            Controls.Add(btn_LoadData);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
