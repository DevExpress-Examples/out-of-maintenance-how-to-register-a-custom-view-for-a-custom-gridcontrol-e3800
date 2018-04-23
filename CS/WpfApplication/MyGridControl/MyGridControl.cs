using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpf.Grid;

namespace WpfApplication.MyGridControl
{
    public class MyGridControl : GridControl
    {

        public MyGridControl()
        {

        }

        protected override DataViewBase CreateDefaultView()
        {
            return new MyCustomView();
        }
    }
}
