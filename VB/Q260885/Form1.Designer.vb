Namespace Q260885
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Me.myGridView1 = New DXSample.MyGridView()
            Me.myGridControl1 = New DXSample.MyGridControl()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New Q260885.nwindDataSet()
            Me.myGridView2 = New DXSample.MyGridView()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.categoriesTableAdapter = New Q260885.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.productsTableAdapter = New Q260885.nwindDataSetTableAdapters.ProductsTableAdapter()
            DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myGridView1
            ' 
            Me.myGridView1.GridControl = Me.myGridControl1
            Me.myGridView1.Name = "myGridView1"
            ' 
            ' myGridControl1
            ' 
            Me.myGridControl1.DataSource = Me.categoriesBindingSource
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.LevelTemplate = Me.myGridView1
            gridLevelNode1.RelationName = "CategoriesProducts"
            Me.myGridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.myGridControl1.MainView = Me.myGridView2
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.Size = New System.Drawing.Size(398, 268)
            Me.myGridControl1.TabIndex = 0
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView2, Me.myGridView1})
            ' 
            ' categoriesBindingSource
            ' 
            Me.categoriesBindingSource.DataMember = "Categories"
            Me.categoriesBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' myGridView2
            ' 
            Me.myGridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCategoryName})
            Me.myGridView2.GridControl = Me.myGridControl1
            Me.myGridView2.Name = "myGridView2"
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.Caption = "Category ID"
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.Visible = True
            Me.colCategoryID.VisibleIndex = 0
            ' 
            ' colCategoryName
            ' 
            Me.colCategoryName.Caption = "Category Name"
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.Visible = True
            Me.colCategoryName.VisibleIndex = 1
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(398, 268)
            Me.Controls.Add(Me.myGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private nwindDataSet As nwindDataSet
        Private categoriesBindingSource As System.Windows.Forms.BindingSource
        Private categoriesTableAdapter As Q260885.nwindDataSetTableAdapters.CategoriesTableAdapter
        Private productsTableAdapter As Q260885.nwindDataSetTableAdapters.ProductsTableAdapter
        Private myGridControl1 As DXSample.MyGridControl
        Private myGridView1 As DXSample.MyGridView
        Private myGridView2 As DXSample.MyGridView
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

