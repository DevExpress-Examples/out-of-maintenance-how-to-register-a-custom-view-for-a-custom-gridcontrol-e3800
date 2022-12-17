Namespace WpfApplication

    Public Class ViewModel

        Public Sub New()
        End Sub

        ' Fields...
        Private _DataSource As Object

        Public Property DataSource As Object
            Get
                If _DataSource Is Nothing Then _DataSource = DataHelper.GetDataSource(20)
                Return _DataSource
            End Get

            Set(ByVal value As Object)
                _DataSource = value
            End Set
        End Property
    End Class
End Namespace
