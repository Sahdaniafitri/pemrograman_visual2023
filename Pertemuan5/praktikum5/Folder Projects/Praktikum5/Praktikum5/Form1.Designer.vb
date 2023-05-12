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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtTotalBelanja = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Keterangan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Belanja"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(249, 43)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(50, 24)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtTotalBelanja
        '
        Me.txtTotalBelanja.Location = New System.Drawing.Point(33, 43)
        Me.txtTotalBelanja.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotalBelanja.Name = "txtTotalBelanja"
        Me.txtTotalBelanja.Size = New System.Drawing.Size(213, 20)
        Me.txtTotalBelanja.TabIndex = 2
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(33, 99)
        Me.txtKeterangan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(267, 20)
        Me.txtKeterangan.TabIndex = 4
        '
        'Keterangan
        '
        Me.Keterangan.AutoSize = True
        Me.Keterangan.Location = New System.Drawing.Point(31, 83)
        Me.Keterangan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Size = New System.Drawing.Size(62, 13)
        Me.Keterangan.TabIndex = 3
        Me.Keterangan.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sahdania Fitri - 200511021 - TI20D"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(347, 170)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Keterangan)
        Me.Controls.Add(Me.txtTotalBelanja)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Bonus Belanja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtTotalBelanja As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Keterangan As Label
    Friend WithEvents Label2 As Label
End Class
