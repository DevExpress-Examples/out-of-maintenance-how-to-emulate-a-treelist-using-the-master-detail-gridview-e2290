Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports System.Linq

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
		Protected Overrides Sub DrawEmbeddedBorder(ByVal e As ViewDrawArgs)
			MyBase.DrawEmbeddedBorder(e)
			Dim detailView As GridView = TryCast(e.ViewInfo.View, GridView)
			If detailView Is Nothing Then
				Return
			End If
			Dim sourceRowHandle As Integer = detailView.SourceRowHandle
			Dim parentView As GridView = TryCast(detailView.ParentView, GridView)
			Dim parentViewInfo As GridViewInfo = TryCast(parentView.GetViewInfo(), GridViewInfo)
			Dim detailViewInfo As GridViewInfo = CType(detailView.GetViewInfo(), GridViewInfo)
			Dim ri As GridDataRowInfo = TryCast(parentViewInfo.RowsInfo.Where(Function(rinfo) rinfo.RowHandle = sourceRowHandle).First(), GridDataRowInfo)
			If ri Is Nothing Then
				Return
			End If

			Dim cell As GridCellInfo = ri.Cells(parentView.VisibleColumns(0))
			Dim center As Integer
			Dim level As Integer = 0
			Dim p1 As Point
			Dim p2 As Point
			Dim lineIndent As Integer = 4

			If cell IsNot Nothing Then
				center = cell.CellButtonRect.Left + cell.CellButtonRect.Width \ 2 - lineIndent
			Else
				center = ri.DetailIndentBounds.Left + ri.DetailIndentBounds.Width \ 2
			End If

			For Each rowInfo As GridRowInfo In detailViewInfo.RowsInfo
				If detailView.IsRowVisible(rowInfo.RowHandle) <> RowVisibleState.Visible Then
					Continue For
				End If
				level = rowInfo.Bounds.Top + rowInfo.Bounds.Height \ 2
				If level <> 0 Then
					p1 = New Point(center, level)
					p2 = New Point(ri.IndentRect.Right + parentViewInfo.DetailIndent, level)
					e.Cache.DrawLine(Pens.Black, p1, p2)
				End If
			Next rowInfo
			If level <> 0 Then
				p1 = New Point(center, ri.Bounds.Bottom)
				p2 = New Point(center, level)
				e.Cache.DrawLine(Pens.Black, p1, p2)
			End If
		End Sub
		Protected Overrides Sub DrawRegularRow(ByVal e As GridViewDrawArgs, ByVal ri As GridDataRowInfo)
			MyBase.DrawRegularRow(e, ri)
			If ri.IsMasterRow AndAlso ri.MasterRowExpanded Then
				Dim detailView As GridView = TryCast(View.GetDetailView(ri.RowHandle, 0), GridView)
				If detailView Is Nothing Then
					Return
				End If

				Dim level As Integer = 0
				Dim p1 As Point
				Dim p2 As Point

				Dim cell As GridCellInfo = ri.Cells(View.VisibleColumns(0))
				Dim center As Integer
				If cell IsNot Nothing Then
					center = cell.CellButtonRect.Left + cell.CellButtonRect.Width \ 2
				Else
					center = ri.DetailIndentBounds.Left + ri.DetailIndentBounds.Width \ 2
				End If

				Dim detailViewInfo As GridViewInfo = CType(detailView.GetViewInfo(), GridViewInfo)
				For Each rowInfo As GridRowInfo In detailViewInfo.RowsInfo
					If detailView.IsRowVisible(rowInfo.RowHandle) <> RowVisibleState.Visible Then
						Continue For
					End If
					level = rowInfo.Bounds.Top + rowInfo.Bounds.Height \ 2
					p1 = New Point(center, level)
					p2 = New Point(ri.DetailIndentBounds.Right, level)
					e.Cache.DrawLine(Pens.Black, p1, p2)
				Next rowInfo
				p1 = New Point(center, ri.DetailIndentBounds.Top)
				p2 = New Point(center, level)
				e.Cache.DrawLine(Pens.Black, p1, p2)
			End If
		End Sub
	End Class
End Namespace