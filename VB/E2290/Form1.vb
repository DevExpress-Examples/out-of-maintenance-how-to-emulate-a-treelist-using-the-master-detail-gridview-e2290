Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace E2290
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            ' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.           
            Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
            productsTableAdapter.Fill(nwindDataSet.Products)

            Me.myGridControl2.DataSource = CreateDataSource()
        End Sub

        Private Function CreateDataSource() As DataTable

            Dim dataSet As New DataSet()
            Dim table1 As New DataTable()
            table1.Columns.Add("Id")
            table1.Columns.Add("Name")
            table1.Rows.Add(0, "Sarah")

            Dim table2 As New DataTable()
            table2.Columns.Add("ParentId")
            table2.Columns.Add("Id")
            table2.Columns.Add("Orders")

            table2.Rows.Add(0, 1, "P7317")
            table2.Rows.Add(0, 2, "P3312")


            Dim table3 As New DataTable()
            table3.Columns.Add("Id")
            table3.Columns.Add("Address")

            table3.Rows.Add(1, "11 Rich St.")

            dataSet.Tables.Add(table1)
            dataSet.Tables.Add(table2)
            dataSet.Tables.Add(table3)

            dataSet.Relations.Add("Orders", table1.Columns("Id"), table2.Columns("ParentId"))
            dataSet.Relations.Add("Addresses", table2.Columns("Id"), table3.Columns("Id"))

            Return dataSet.Tables(0)
        End Function

        Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barCheckItem1.CheckedChanged
            If Me.barCheckItem1.Checked Then
                Me.myGridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
                Me.myGridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
            Else
                Me.myGridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic
                Me.myGridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic
            End If
        End Sub
    End Class
End Namespace
