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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSKS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.Location = New System.Drawing.Point(487, 128)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(69, 25)
        Me.btnHapus.TabIndex = 23
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.Location = New System.Drawing.Point(487, 49)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(69, 25)
        Me.btnSimpan.TabIndex = 22
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnReset.Location = New System.Drawing.Point(487, 88)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(69, 25)
        Me.btnReset.TabIndex = 21
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Prodi"
        '
        'txtProdi
        '
        Me.txtProdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtProdi.Location = New System.Drawing.Point(197, 130)
        Me.txtProdi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(183, 23)
        Me.txtProdi.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "SKS"
        '
        'txtSKS
        '
        Me.txtSKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtSKS.Location = New System.Drawing.Point(197, 103)
        Me.txtSKS.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSKS.Name = "txtSKS"
        Me.txtSKS.Size = New System.Drawing.Size(183, 23)
        Me.txtSKS.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nama MK"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNama.Location = New System.Drawing.Point(197, 76)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(183, 23)
        Me.txtNama.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Kode MK"
        '
        'txtKode
        '
        Me.txtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtKode.Location = New System.Drawing.Point(197, 50)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(183, 23)
        Me.txtKode.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 171)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(565, 166)
        Me.DataGridView1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 386)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSKS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Matakuliah"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSKS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
