using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpf.Grid;
using System.Windows;

namespace WpfApplication.MyGridControl
{
    public class MyCustomView : TableView
    {
        protected override void OnMouseMove(System.Windows.Input.MouseEventArgs e)
        {
            base.OnMouseMove(e);
            CheckHotTrack(e);
        }

        private void CheckHotTrack(System.Windows.Input.MouseEventArgs e)
        {
            TableViewHitInfo hi =    CalcHitInfo(e.OriginalSource as DependencyObject);
            if (hi.RowHandle != GridControl.InvalidRowHandle)
                FocusedRowHandle = hi.RowHandle;
        }

        
        
    }
}
