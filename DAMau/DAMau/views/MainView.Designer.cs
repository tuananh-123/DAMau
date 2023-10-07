namespace DAMau_Presentation.views
{
    partial class MainView
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
            tableLayoutPanel1=new TableLayoutPanel();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount=1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock=DockStyle.Fill;
            tableLayoutPanel1.Location=new Point(0, 0);
            tableLayoutPanel1.Name="tableLayoutPanel1";
            tableLayoutPanel1.RowCount=2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.222222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.77778F));
            tableLayoutPanel1.Size=new Size(777, 450);
            tableLayoutPanel1.TabIndex=0;
            // 
            // MainView
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(777, 450);
            Controls.Add(tableLayoutPanel1);
            Name="MainView";
            Text="MainView";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
    }
}