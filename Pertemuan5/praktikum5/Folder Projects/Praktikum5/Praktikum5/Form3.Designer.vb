<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Keterangan = New System.Windows.Forms.Label()
        Me.txtKodeGelar = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 147)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sahdania Fitri - 200511021 - TI20D"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(35, 109)
        Me.txtKeterangan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(267, 20)
        Me.txtKeterangan.TabIndex = 16
        '
        'Keterangan
        '
        Me.Keterangan.AutoSize = True
        Me.Keterangan.Location = New System.Drawing.Point(33, 94)
        Me.Keterangan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Size = New System.Drawing.Size(62, 13)
        Me.Keterangan.TabIndex = 15
        Me.Keterangan.Text = "Keterangan"
        '
        'txtKodeGelar
        '
        Me.txtKodeGelar.Location = New System.Drawing.Point(35, 53)
        Me.txtKodeGelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKodeGelar.Name = "txtKodeGelar"
        Me.txtKodeGelar.Size = New System.Drawing.Size(213, 20)
        Me.txtKodeGelar.TabIndex = 14
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(251, 53)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(50, 24)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode Gelar"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(340, 189)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Keterangan)
        Me.Controls.Add(Me.txtKodeGelar)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form3"
        Me.Text = "Kode Gelar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Keterangan As Label
    Friend WithEvents txtKodeGelar As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
End Class
