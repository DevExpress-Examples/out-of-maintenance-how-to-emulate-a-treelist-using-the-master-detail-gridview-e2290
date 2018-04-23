Namespace E2290
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
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Me.myGridView1 = New DXSample.MyGridView()
            Me.myGridControl1 = New DXSample.MyGridControl()
            Me.categoriesBindingSource = New System.Windows.Forms.BindingSource()
            Me.nwindDataSet = New E2290.nwindDataSet()
            Me.myGridView2 = New DXSample.MyGridView()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.categoriesTableAdapter = New E2290.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.productsTableAdapter = New E2290.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.myGridControl2 = New DXSample.MyGridControl()
            Me.myGridView3 = New DXSample.MyGridView()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager()
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.myGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Left
            gridLevelNode1.LevelTemplate = Me.myGridView1
            gridLevelNode1.RelationName = "CategoriesProducts"
            Me.myGridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.myGridControl1.Location = New System.Drawing.Point(0, 51)
            Me.myGridControl1.MainView = Me.myGridView2
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.Size = New System.Drawing.Size(527, 337)
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
            ' myGridControl2
            ' 
            Me.myGridControl2.DataSource = Me.categoriesBindingSource
            Me.myGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myGridControl2.Location = New System.Drawing.Point(532, 51)
            Me.myGridControl2.MainView = Me.myGridView3
            Me.myGridControl2.Name = "myGridControl2"
            Me.myGridControl2.Size = New System.Drawing.Size(519, 337)
            Me.myGridControl2.TabIndex = 1
            Me.myGridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView3})
            ' 
            ' myGridView3
            ' 
            Me.myGridView3.GridControl = Me.myGridControl2
            Me.myGridView3.Name = "myGridView3"
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Location = New System.Drawing.Point(527, 51)
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(5, 337)
            Me.splitterControl1.TabIndex = 2
            Me.splitterControl1.TabStop = False
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barCheckItem1})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 1
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 1
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.Text = "Tools"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem1)})
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.Caption = "Embedded Mode"
            Me.barCheckItem1.Id = 0
            Me.barCheckItem1.Name = "barCheckItem1"
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(1051, 51)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 388)
            Me.barDockControlBottom.Size = New System.Drawing.Size(1051, 23)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 337)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(1051, 51)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 337)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1051, 411)
            Me.Controls.Add(Me.myGridControl2)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.myGridControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.myGridView3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private nwindDataSet As nwindDataSet
        Private categoriesBindingSource As System.Windows.Forms.BindingSource
        Private categoriesTableAdapter As E2290.nwindDataSetTableAdapters.CategoriesTableAdapter
        Private productsTableAdapter As E2290.nwindDataSetTableAdapters.ProductsTableAdapter
        Private myGridControl1 As DXSample.MyGridControl
        Private myGridView1 As DXSample.MyGridView
        Private myGridView2 As DXSample.MyGridView
        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
        Private myGridControl2 As DXSample.MyGridControl
        Private myGridView3 As DXSample.MyGridView
        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
        Private barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar2 As DevExpress.XtraBars.Bar
        Private WithEvents barCheckItem1 As DevExpress.XtraBars.BarCheckItem
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    End Class
End Namespace

