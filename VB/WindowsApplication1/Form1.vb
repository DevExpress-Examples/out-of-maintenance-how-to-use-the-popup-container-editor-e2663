Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			popupContainerEdit1.Text = ValuesConverter.TrackBarRangeToString(New TrackBarRange(5, 10))
		End Sub


		Private Sub OnQueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles popupContainerEdit1.Properties.QueryResultValue
			e.Value = ValuesConverter.TrackBarRangeToString(rangeTrackBarControl1.Value)
		End Sub

		Private Sub OnQueryPopup(ByVal sender As Object, ByVal e As CancelEventArgs) Handles popupContainerEdit1.QueryPopUp
			Dim value As TrackBarRange = ValuesConverter.StringToTrackBarRange((TryCast(sender, PopupContainerEdit)).Text)
			If value.IsEmpty Then
				e.Cancel = True
			Else
				ApplyValue(value)
			End If
		End Sub
		Private Sub ApplyValue(ByVal value As TrackBarRange)
			Dim properties As RepositoryItemRangeTrackBar = rangeTrackBarControl1.Properties
			properties.Minimum = Math.Min(properties.Minimum, value.Minimum)
			properties.Maximum = Math.Max(properties.Maximum, value.Maximum)
			rangeTrackBarControl1.Value = value
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			popupContainerEdit1.ClosePopup()
		End Sub
	End Class
End Namespace