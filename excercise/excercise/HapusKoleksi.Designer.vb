<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HapusKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Labelket = New System.Windows.Forms.Label()
        Me.LabelHapusKoleksi = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Labelket
        '
        Me.Labelket.AutoSize = True
        Me.Labelket.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelket.Location = New System.Drawing.Point(120, 52)
        Me.Labelket.Name = "Labelket"
        Me.Labelket.Size = New System.Drawing.Size(203, 16)
        Me.Labelket.TabIndex = 0
        Me.Labelket.Text = "Apakah yakin ingin menghapus"
        '
        'LabelHapusKoleksi
        '
        Me.LabelHapusKoleksi.AutoSize = True
        Me.LabelHapusKoleksi.Font = New System.Drawing.Font("MS Reference Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHapusKoleksi.ForeColor = System.Drawing.Color.Red
        Me.LabelHapusKoleksi.Location = New System.Drawing.Point(172, 103)
        Me.LabelHapusKoleksi.Name = "LabelHapusKoleksi"
        Me.LabelHapusKoleksi.Size = New System.Drawing.Size(73, 35)
        Me.LabelHapusKoleksi.TabIndex = 1
        Me.LabelHapusKoleksi.Text = "test"
        Me.LabelHapusKoleksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(178, 211)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 276)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LabelHapusKoleksi)
        Me.Controls.Add(Me.Labelket)
        Me.Name = "HapusKoleksi"
        Me.Text = "HapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelket As Label
    Friend WithEvents LabelHapusKoleksi As Label
    Friend WithEvents BtnHapus As Button
End Class
