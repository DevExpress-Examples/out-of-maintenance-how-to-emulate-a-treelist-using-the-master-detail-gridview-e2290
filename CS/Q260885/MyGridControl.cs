using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DXSample {
    public class MyGridControl :GridControl {
        public MyGridControl() : base() { }

        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }

    public class MyGridView :GridView {
        public MyGridView() : base() { }
        public MyGridView(GridControl grid) : base(grid) { }

        internal const string MyGridViewName = "MyGridView";
        protected override string ViewName { get { return MyGridViewName; } }
    }

    public class MyGridViewInfoRegistrator :GridInfoRegistrator {
        public MyGridViewInfoRegistrator() : base() { }

        public override string ViewName { get { return MyGridView.MyGridViewName; } }

        public override BaseView CreateView(GridControl grid) {
            return new MyGridView(grid);
        }

        public override BaseViewPainter CreatePainter(BaseView view) {
            return new MyGridViewPainter((MyGridView)view);
        }
    }

    public class MyGridViewPainter :GridPainter {
        public MyGridViewPainter(MyGridView view) : base(view) { }

        protected override void DrawRegularRow(GridViewDrawArgs e, GridDataRowInfo ri) {
            base.DrawRegularRow(e, ri);
            if (ri.IsMasterRow && ri.MasterRowExpanded) {
                GridView detailView = View.GetDetailView(ri.RowHandle, 0) as GridView;
                if (detailView == null) return;

                GridCellInfo cell = ri.Cells[View.VisibleColumns[0]];
                int center;
                if (cell != null) center = cell.CellButtonRect.Left + cell.CellButtonRect.Width / 2;
                else center = ri.DetailIndentBounds.Left + ri.DetailIndentBounds.Width / 2 ;

                GridViewInfo detailViewInfo = (GridViewInfo)detailView.GetViewInfo();
                int level = 0;
                Point p1;
                Point p2;
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