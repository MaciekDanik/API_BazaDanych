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
            SuspendLayout();
            // 
            // btn_LoadData
            // 
            btn_LoadData.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_LoadData.Location = new Point(12, 12);
            btn_LoadData.Name = "btn_LoadData";
            btn_LoadData.Size = new Size(150, 96);
            btn_LoadData.TabIndex = 1;
            btn_LoadData.Text = "DownloadData";
            btn_LoadData.UseVisualStyleBackColor = true;
            btn_LoadData.Click += btn_LoadData_Click;
            // 
            // txtBox_InitialResult
            // 
            txtBox_InitialResult.Location = new Point(428, 12);
            txtBox_InitialResult.Multiline = true;
            txtBox_InitialResult.Name = "txtBox_InitialResult";
            txtBox_InitialResult.ScrollBars = ScrollBars.Vertical;
            txtBox_InitialResult.Size = new Size(444, 195);
            txtBox_InitialResult.TabIndex = 2;
            // 
            // lstBox_Initial
            // 
            lstBox_Initial.ColumnWidth = 600;
            lstBox_Initial.FormattingEnabled = true;
            lstBox_Initial.ItemHeight = 15;
            lstBox_Initial.Location = new Point(281, 228);
            lstBox_Initial.Name = "lstBox_Initial";
            lstBox_Initial.Size = new Size(591, 334);
            lstBox_Initial.TabIndex = 3;
            lstBox_Initial.SelectedIndexChanged += lstBox_Initial_SelectedIndexChanged;
            // 
            // btn_GetDetails
            // 
            btn_GetDetails.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_GetDetails.Location = new Point(168, 12);
            btn_GetDetails.Name = "btn_GetDetails";
            btn_GetDetails.Size = new Size(150, 96);
            btn_GetDetails.TabIndex = 4;
            btn_GetDetails.Text = "Details";
            btn_GetDetails.UseVisualStyleBackColor = true;
            btn_GetDetails.Click += btn_GetDetails_Click;
            // 
            // btn_SortAlc
            // 
            btn_SortAlc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_SortAlc.Location = new Point(75, 268);
            btn_SortAlc.Name = "btn_SortAlc";
            btn_SortAlc.Size = new Size(109, 40);
            btn_SortAlc.TabIndex = 5;
            btn_SortAlc.Text = "Sort Alc";
            btn_SortAlc.UseVisualStyleBackColor = true;
            btn_SortAlc.Click += btn_SortAlc_Click;
            // 
            // btn_SortNonAlc
            // 
            btn_SortNonAlc.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btn_SortNonAlc.Location = new Point(75, 314);
            btn_SortNonAlc.Name = "btn_SortNonAlc";
            btn_SortNonAlc.Size = new Size(109, 40);
            btn_SortNonAlc.TabIndex = 6;
            btn_SortNonAlc.Text = "Sort NonAlc";
            btn_SortNonAlc.UseVisualStyleBackColor = true;
            btn_SortNonAlc.Click += btn_SortNonAlc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 574);
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
    }
}
