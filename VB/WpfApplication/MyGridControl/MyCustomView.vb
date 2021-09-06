Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Xpf.Grid
Imports System.Windows

Namespace WpfApplication.MyGridControl
	Public Class MyCustomView
		Inherits TableView

		Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Input.MouseEventArgs)
			MyBase.OnMouseMove(e)
			CheckHotTrack(e)
		End Sub

		Private Sub CheckHotTrack(ByVal e As System.Windows.Input.MouseEventArgs)
			Dim hi As TableViewHitInfo = CalcHitInfo(TryCast(e.OriginalSource, DependencyObject))
			If hi.RowHandle <> GridControl.InvalidRowHandle Then
				FocusedRowHandle = hi.RowHandle
			End If
		End Sub



	End Class
End Namespace
