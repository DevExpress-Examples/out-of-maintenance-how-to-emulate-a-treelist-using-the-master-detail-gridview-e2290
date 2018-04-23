using System;
using System.Data;
using System.Windows.Forms;

namespace E2290 {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            // TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.           
            this.categoriesTableAdapter.Fill(this.nwindDataSet.Categories);
            productsTableAdapter.Fill(nwindDataSet.Products);

            this.myGridControl2.DataSource = CreateDataSource();
        }

        private DataTable CreateDataSource() {

            DataSet dataSet = new DataSet();
            DataTable table1 = new DataTable();
            table1.Columns.Add("Id");
            table1.Columns.Add("Name");
            table1.Rows.Add(0, "Sarah");

            DataTable table2 = new DataTable();
            table2.Columns.Add("ParentId");
            table2.Columns.Add("Id");
            table2.Columns.Add("Orders");

            table2.Rows.Add(0, 1, "P7317");
            table2.Rows.Add(0, 2, "P3312");


            DataTable table3 = new DataTable();
            table3.Columns.Add("Id");
            table3.Columns.Add("Address");

            table3.Rows.Add(1, "11 Rich St.");

            dataSet.Tables.Add(table1);
            dataSet.Tables.Add(table2);
            dataSet.Tables.Add(table3);

            dataSet.Relations.Add("Orders", table1.Columns["Id"], table2.Columns["ParentId"]);
            dataSet.Relations.Add("Addresses", table2.Columns["Id"], table3.Columns["Id"]);

            return dataSet.Tables[0];
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(this.barCheckItem1.Checked) {
                this.myGridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
                this.myGridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            }
            else {
                this.myGridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic;
                this.myGridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic;
            }
        }
    }
}
