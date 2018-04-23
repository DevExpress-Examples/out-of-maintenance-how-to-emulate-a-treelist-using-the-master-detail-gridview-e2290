Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DXSample
	Public Class MyGridControl
		Inherits GridControl
		Public Sub New()
			MyBase.New()
		End Sub

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
		End Sub
	End Class

	Public Class MyGridView
		Inherits GridView
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub

		Friend Const MyGridViewName As String = "MyGridView"
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return MyGridViewName
			End Get
		End Property
	End Class

	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return MyGridView.MyGridViewName
			End Get
		End Property

		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(grid)
		End Function

		Public Overrides Function CreatePainter(ByVal view As BaseView) As BaseViewPainter
			Return New MyGridViewPainter(CType(view, MyGridView))
		End Function
	End Class

	Public Class MyGridViewPainter
		Inherits GridPainter
		Public Sub New(ByVal view As MyGridView)
			MyBase.New(view)
		End Sub

		Protected Overrides Sub DrawRegularRow(ByVal e As GridViewDrawArgs, ByVal ri As GridDataRowInfo)
			MyBase.DrawRegularRow(e, ri)
			If ri.IsMasterRow AndAlso ri.MasterRowExpanded Then
				Dim detailView As GridView = TryCast(View.GetDetailView(ri.RowHandle, 0), GridView)
				If detailView Is Nothing Then
					Return
				End If

				Dim cell As GridCellInfo = ri.Cells(View.VisibleColumns(0))
				Dim center As Integer
				If cell IsNot Nothing Then
					center = cell.CellButtonRect.Left + cell.CellButtonRect.Width \ 2
				Else
					center = ri.DetailIndentBounds.Left + ri.DetailIndentBounds.Width \ 2
				End If

				Dim detailViewInfo As GridViewInfo = CType(detailView.GetViewInfo(), GridViewInfo)
				Dim level As Integer = 0
				Dim p1 As Point
				Dim p2 As Point
				For Each rowInfo As GridRowInfo In detailViewInfo.RowsInfo
					If detailView.IsRowVisible(rowInfo.RowHandle) <> RowVisibleState.Visible Then
						Continue For
					End If
					level = rowInfo.Bounds.Top + rowInfo.Bounds.Height \ 2
					p1 = New Point(center, level)
					p2 = New Point(ri.DetailIndentBounds.Right, level)
					e.Graphics.DrawLine(Pens.Black, p1, p2)
				Next rowInfo

				p1 = New Point(center, ri.DetailIndentBounds.Top)
				p2 = New Point(center, level)
				e.Graphics.DrawLine(Pens.Black, p1, p2)
			End If
		End Sub
	End Class
End Namespace