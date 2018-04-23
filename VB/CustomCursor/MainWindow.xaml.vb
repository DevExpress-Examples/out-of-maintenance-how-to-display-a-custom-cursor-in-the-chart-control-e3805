Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Input
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Charts

Namespace CustomCursor

	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chartControl1_QueryChartCursor(ByVal sender As Object, ByVal e As QueryChartCursorEventArgs)
			e.Cursor = Cursors.None
			e.CursorImage = New BitmapImage(New Uri("/CustomCursor;component/mycursor.png", UriKind.Relative))
		End Sub

	End Class

End Namespace
