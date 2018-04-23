Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.rangeTrackBarControl1 = New DevExpress.XtraEditors.RangeTrackBarControl()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.rangeTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl1.SuspendLayout()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' rangeTrackBarControl1
			' 
			Me.rangeTrackBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rangeTrackBarControl1.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 0)
			Me.rangeTrackBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.rangeTrackBarControl1.Name = "rangeTrackBarControl1"
			Me.rangeTrackBarControl1.Properties.AllowFocused = False
			Me.rangeTrackBarControl1.Properties.Maximum = 20
			Me.rangeTrackBarControl1.Properties.ShowValueToolTip = True
			Me.rangeTrackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.Both
			Me.rangeTrackBarControl1.Size = New System.Drawing.Size(200, 85)
			Me.rangeTrackBarControl1.TabIndex = 1
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Controls.Add(Me.simpleButton1)
			Me.popupContainerControl1.Controls.Add(Me.rangeTrackBarControl1)
			Me.popupContainerControl1.Location = New System.Drawing.Point(12, 50)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(200, 85)
			Me.popupContainerControl1.TabIndex = 2
			' 
			' popupContainerEdit1
			' 
			Me.popupContainerEdit1.Location = New System.Drawing.Point(12, 12)
			Me.popupContainerEdit1.Name = "popupContainerEdit1"
			Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEdit1.Properties.Mask.EditMask = "\d{0,5},\d{0,5}"
			Me.popupContainerEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.popupContainerEdit1.Properties.PopupControl = Me.popupContainerControl1
			Me.popupContainerEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
'			Me.popupContainerEdit1.Properties.QueryResultValue += New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(Me.OnQueryResultValue);
			Me.popupContainerEdit1.Size = New System.Drawing.Size(384, 20)
			Me.popupContainerEdit1.TabIndex = 0
'			Me.popupContainerEdit1.QueryPopUp += New System.ComponentModel.CancelEventHandler(Me.OnQueryPopup);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.simpleButton1.Location = New System.Drawing.Point(0, 62)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(200, 23)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Apply"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(604, 376)
			Me.Controls.Add(Me.popupContainerEdit1)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.rangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rangeTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl1.ResumeLayout(False)
			Me.popupContainerControl1.PerformLayout()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private rangeTrackBarControl1 As DevExpress.XtraEditors.RangeTrackBarControl
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private WithEvents popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

