namespace DAMau_Presentation
{
    partial class Form1
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
            btnAddName=new Button();
            txtName=new TextBox();
            lstNames=new ListBox();
            label1=new Label();
            dataGridView_SanPhams=new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SanPhams).BeginInit();
            SuspendLayout();
            // 
            // btnAddName
            // 
            btnAddName.Location=new Point(145, 79);
            btnAddName.Name="btnAddName";
            btnAddName.Size=new Size(100, 23);
            btnAddName.TabIndex=0;
            btnAddName.Text="Add Names";
            btnAddName.UseVisualStyleBackColor=true;
            btnAddName.Click+=btnAddName_Click;
            // 
            // txtName
            // 
            txtName.Location=new Point(145, 41);
            txtName.Name="txtName";
            txtName.Size=new Size(100, 23);
            txtName.TabIndex=1;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled=true;
            lstNames.ItemHeight=15;
            lstNames.Items.AddRange(new object[] { "Tuan Anh" });
            lstNames.Location=new Point(12, 41);
            lstNames.Name="lstNames";
            lstNames.Size=new Size(120, 94);
            lstNames.TabIndex=2;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 9);
            label1.Name="label1";
            label1.Size=new Size(44, 15);
            label1.TabIndex=3;
            label1.Text="Names";
            // 
            // dataGridView_SanPhams
            // 
            dataGridView_SanPhams.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SanPhams.Location=new Point(12, 155);
            dataGridView_SanPhams.Name="dataGridView_SanPhams";
            dataGridView_SanPhams.RowTemplate.Height=25;
            dataGridView_SanPhams.Size=new Size(776, 150);
            dataGridView_SanPhams.TabIndex=4;
            dataGridView_SanPhams.CellContentClick+=dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(dataGridView_SanPhams);
            Controls.Add(label1);
            Controls.Add(lstNames);
            Controls.Add(txtName);
            Controls.Add(btnAddName);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_SanPhams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddName;
        private TextBox txtName;
        private ListBox lstNames;
        private Label label1;
        private DataGridView dataGridView_SanPhams;
    }
}