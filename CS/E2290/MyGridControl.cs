using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;
using System.Linq;

namespace DXSample {
    public class MyGridControl : GridControl {
        public MyGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }

    public class MyGridView : GridView {
        public MyGridView() : base() { }
        public MyGridView(GridControl grid) : base(grid) { }

        internal const string MyGridViewName = "MyGridView";
        protected override string ViewName { get { return MyGridViewName; } }
    }

    public class MyGridViewInfoRegistrator : GridInfoRegistrator {
        public MyGridViewInfoRegistrator() : base() { }

        public override string ViewName { get { return MyGridView.MyGridViewName; } }

        public override BaseView CreateView(GridControl grid) {
            return new MyGridView(grid);
        }
        public override BaseViewPainter CreatePainter(BaseView view) {
            return new MyGridViewPainter((MyGridView)view);
        }
    }

    public class MyGridViewPainter : GridPainter {
        public MyGridViewPainter(MyGridView view) : base(view) { }
        protected override void DrawEmbeddedBorder(ViewDrawArgs e) {
            base.DrawEmbeddedBorder(e);
            GridView detailView = e.ViewInfo.View as GridView;
            if (detailView == null) return;
            int sourceRowHandle = detailView.SourceRowHandle;
            GridView parentView = detailView.ParentView as GridView;
            GridViewInfo parentViewInfo = parentView.GetViewInfo() as GridViewInfo;
            GridViewInfo detailViewInfo = (GridViewInfo)detailView.GetViewInfo();
            GridDataRowInfo ri = parentViewInfo.RowsInfo.Where(rinfo => rinfo.RowHandle == sourceRowHandle).First() as GridDataRowInfo;
            if (ri == null)
                return;

            GridCellInfo cell = ri.Cells[parentView.VisibleColumns[0]];
            int center;
            int level = 0;
            Point p1;
            Point p2;
            int lineIndent = 4;

            if (cell != null)
                center = cell.CellButtonRect.Left + cell.CellButtonRect.Width / 2 - lineIndent;
            else
                center = ri.DetailIndentBounds.Left + ri.DetailIndentBounds.Width / 2;

            foreach (GridRowInfo rowInfo in detailViewInfo.RowsInfo) {
                if (detailView.IsRowVisible(rowInfo.RowHandle) != RowVisibleState.Visible) continue;
                level = rowInfo.Bounds.Top + rowInfo.Bounds.Height / 2;
                if (level != 0) {
                    p1 = new Point(center, level);
                    p2 = new Point(ri.IndentRect.Right + parentViewInfo.DetailIndent, level);
                    e.Graphics.DrawLine(Pens.Black, p1, p2);
                }
            }
            if (level != 0) {
                p1 = new Point(center, ri.Bounds.Bottom);
                p2 = new Point(center, level);
                e.Graphics.DrawLine(Pens.Black, p1, p2);
            }
        }
        protected override void DrawRegularRow(GridViewDrawArgs e, GridDataRowInfo ri) {
            base.DrawRegularRow(e, ri);
            if (ri.IsMasterRow && ri.MasterRowExpanded) {
                GridView detailView = View.GetDetailView(ri.RowHandle, 0) as GridView;
                if (detailView == null) return;

                int level = 0;
                Point p1;
                Point p2;

                GridCellInfo cell = ri.Cells[View.VisibleColumns[0]];
                int center;
                if (cell != null) center = cell.CellButtonRect.Left + cell.CellButtonRect.Width / 2;
                else center = ri.DetailIndentBounds.Left + ri.DetailIndentBounds.Width / 2;

                GridViewInfo detailViewInfo = (GridViewInfo)detailView.GetViewInfo();
                foreach (GridRowInfo rowInfo in detailViewInfo.RowsInfo) {
                    if (detailView.IsRowVisible(rowInfo.RowHandle) != RowVisibleState.Visible) continue;
                    level = rowInfo.Bounds.Top + rowInfo.Bounds.Height / 2;
                    p1 = new Point(center, level);
                    p2 = new Point(ri.DetailIndentBounds.Right, level);
                    e.Graphics.DrawLine(Pens.Black, p1, p2);
                }
                p1 = new Point(center, ri.DetailIndentBounds.Top);
                p2 = new Point(center, level);
                e.Graphics.DrawLine(Pens.Black, p1, p2);
            }
        }
    }
}