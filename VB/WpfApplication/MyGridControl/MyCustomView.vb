Imports DevExpress.Xpf.Grid
Imports System.Windows

Namespace WpfApplication.MyGridControl

    Public Class MyCustomView
        Inherits TableView

        Protected Overrides Sub OnMouseMove(ByVal e As Input.MouseEventArgs)
            MyBase.OnMouseMove(e)
            CheckHotTrack(e)
        End Sub

        Private Sub CheckHotTrack(ByVal e As Input.MouseEventArgs)
            Dim hi As TableViewHitInfo = CalcHitInfo(TryCast(e.OriginalSource, DependencyObject))
            If hi.RowHandle <> DataControlBase.InvalidRowHandle Then FocusedRowHandle = hi.RowHandle
        End Sub
    End Class
End Namespace
