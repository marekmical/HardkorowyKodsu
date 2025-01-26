namespace HardkorowyKodsu.Client
{
    partial class HardkorowyKodsu
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
            tablesViewsTextBox = new Label();
            tableViewColumnsLabel = new Label();
            tablesViewsListBox = new ListBox();
            tableViewColumnsListBox = new ListBox();
            refreshTablesButton = new Button();
            SuspendLayout();
            // 
            // tablesViewsTextBox
            // 
            tablesViewsTextBox.AutoSize = true;
            tablesViewsTextBox.Location = new Point(12, 9);
            tablesViewsTextBox.Name = "tablesViewsTextBox";
            tablesViewsTextBox.Size = new Size(74, 15);
            tablesViewsTextBox.TabIndex = 0;
            tablesViewsTextBox.Text = "Tables/Views";
            tablesViewsListBox.HandleCreated += GetTables;
            tablesViewsListBox.SelectedIndexChanged += GetColumns;
            // 
            // tableViewColumnsLabel
            // 
            tableViewColumnsLabel.AutoSize = true;
            tableViewColumnsLabel.Location = new Point(384, 9);
            tableViewColumnsLabel.Name = "tableViewColumnsLabel";
            tableViewColumnsLabel.Size = new Size(113, 15);
            tableViewColumnsLabel.TabIndex = 1;
            tableViewColumnsLabel.Text = "Table/View columns";
            // 
            // tablesViewsListBox
            // 
            tablesViewsListBox.FormattingEnabled = true;
            tablesViewsListBox.ItemHeight = 15;
            tablesViewsListBox.Location = new Point(12, 27);
            tablesViewsListBox.Name = "tablesViewsListBox";
            tablesViewsListBox.Size = new Size(360, 184);
            tablesViewsListBox.TabIndex = 2;
            // 
            // tableViewColumnsListBox
            // 
            tableViewColumnsListBox.FormattingEnabled = true;
            tableViewColumnsListBox.ItemHeight = 15;
            tableViewColumnsListBox.Location = new Point(384, 27);
            tableViewColumnsListBox.Name = "tableViewColumnsListBox";
            tableViewColumnsListBox.Size = new Size(404, 184);
            tableViewColumnsListBox.TabIndex = 3;
            // 
            // refreshTablesButton
            // 
            refreshTablesButton.Location = new Point(125, 217);
            refreshTablesButton.Name = "refreshTablesButton";
            refreshTablesButton.Size = new Size(111, 23);
            refreshTablesButton.TabIndex = 4;
            refreshTablesButton.Text = "Refresh Table List";
            refreshTablesButton.UseVisualStyleBackColor = true;
            refreshTablesButton.Click += refreshTablesButton_Click;
            // 
            // HardkorowyKodsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 249);
            Controls.Add(refreshTablesButton);
            Controls.Add(tableViewColumnsListBox);
            Controls.Add(tablesViewsListBox);
            Controls.Add(tableViewColumnsLabel);
            Controls.Add(tablesViewsTextBox);
            Name = "HardkorowyKodsu";
            Text = "HardkorowyKodsu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tablesViewsTextBox;
        private Label tableViewColumnsLabel;
        private ListBox tablesViewsListBox;
        private ListBox tableViewColumnsListBox;
        private Button refreshTablesButton;
    }
}
