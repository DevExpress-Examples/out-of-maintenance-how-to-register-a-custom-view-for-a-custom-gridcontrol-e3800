Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Xpf.Grid

Namespace WpfApplication.MyGridControl
	Public Class MyGridControl
		Inherits GridControl

		Public Sub New()

		End Sub

		Protected Overrides Function CreateDefaultView() As DataViewBase
			Return New MyCustomView()
		End Function
	End Class
End Namespace
