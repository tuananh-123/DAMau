using DAMau_DAL.IRepositories;
using DAMau_DAL.Repostiories;
using System.Data;

namespace DAMau_Presentation
{
    public partial class Form1 : Form
    {
        private readonly ISanPhamsRepository _sanPhamsRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dataset = _sanPhamsRepository.SelectAll();
            //DataView custDV = new DataView(
            //    dataset.Tables["SanPhams"],
            //    "SoLuong",
            //    DataViewRowState.CurrentRows
            //);
            
           
             DataView custDV = new DataView(dataset.Tables["SanPhams"],
               "TrangThai = 2",
               "SoLuong",
               DataViewRowState.CurrentRows);

            DataView cusDV2 = new DataView(dataset.Tables["SanPhams"],
                "",
                "SoLuong",
                DataViewRowState.CurrentRows);

            DataRowView newDRV = cusDV2.AddNew();
            newDRV["MaHang"] = 1;
            newDRV["TenHang"] = "ABC";
            newDRV.EndEdit();

            dataGridView_SanPhams.DataSource = cusDV2;

        }
    }
}
