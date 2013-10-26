<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.lblFile = New System.Windows.Forms.Label()
		Me.txtFile = New System.Windows.Forms.TextBox()
		Me.btnFile = New System.Windows.Forms.Button()
		Me.ibImage = New Emgu.CV.UI.ImageBox()
		Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
		CType(Me.ibImage,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblFile
		'
		Me.lblFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblFile.Location = New System.Drawing.Point(4, 4)
		Me.lblFile.Name = "lblFile"
		Me.lblFile.Size = New System.Drawing.Size(100, 28)
		Me.lblFile.TabIndex = 0
		Me.lblFile.Text = "choose file:"
		Me.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtFile
		'
		Me.txtFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtFile.Location = New System.Drawing.Point(108, 4)
		Me.txtFile.Name = "txtFile"
		Me.txtFile.Size = New System.Drawing.Size(648, 27)
		Me.txtFile.TabIndex = 1
		'
		'btnFile
		'
		Me.btnFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnFile.Location = New System.Drawing.Point(756, 4)
		Me.btnFile.Name = "btnFile"
		Me.btnFile.Size = New System.Drawing.Size(31, 28)
		Me.btnFile.TabIndex = 2
		Me.btnFile.Text = "..."
		Me.btnFile.UseVisualStyleBackColor = true
		'
		'ibImage
		'
		Me.ibImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ibImage.Location = New System.Drawing.Point(2, 36)
		Me.ibImage.Name = "ibImage"
		Me.ibImage.Size = New System.Drawing.Size(786, 432)
		Me.ibImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.ibImage.TabIndex = 2
		Me.ibImage.TabStop = false
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(791, 471)
		Me.Controls.Add(Me.ibImage)
		Me.Controls.Add(Me.btnFile)
		Me.Controls.Add(Me.txtFile)
		Me.Controls.Add(Me.lblFile)
		Me.Name = "Form1"
		Me.Text = "Pedestrian Detection Example"
		CType(Me.ibImage,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents ibImage As Emgu.CV.UI.ImageBox
    Friend WithEvents ofdFile As System.Windows.Forms.OpenFileDialog

End Class
