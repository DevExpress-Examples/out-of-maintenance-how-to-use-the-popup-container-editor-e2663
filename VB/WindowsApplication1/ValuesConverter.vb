Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication1
	Public Class ValuesConverter



		Public Shared Function TrackBarRangeToString(ByVal range As TrackBarRange) As String
			Return String.Format("{0},{1}", range.Minimum, range.Maximum)
		End Function

		Public Shared Function StringToTrackBarRange(ByVal value As String) As TrackBarRange
			Dim result As TrackBarRange = TrackBarRange.Empty
			Dim values() As String = value.Split(","c)
			If values.Length = 2 Then
				Dim min As Integer = Convert.ToInt32(values(0))
				Dim max As Integer = Convert.ToInt32(values(1))
				result = New TrackBarRange(min, max)
			End If
			Return result
		End Function


	End Class
End Namespace
