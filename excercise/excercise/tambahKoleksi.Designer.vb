<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambahKoleksi
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
        Me.TextBoxNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.ComboBoxJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.LblNamaKoleksi = New System.Windows.Forms.Label()
        Me.LblJenisKoleksi = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.LblPenerbit = New System.Windows.Forms.Label()
        Me.LblTahunTerbit = New System.Windows.Forms.Label()
        Me.RichTextBoxDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TextBoxTahunPenerbit = New System.Windows.Forms.TextBox()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.LBlLokasiRak = New System.Windows.Forms.Label()
        Me.TextBoxLokasiRak = New System.Windows.Forms.TextBox()
        Me.DateTimePickerMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.TextBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.LblBahasa = New System.Windows.Forms.Label()
        Me.LblKategori = New System.Windows.Forms.Label()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.RadiobtnBhsIndo = New System.Windows.Forms.RadioButton()
        Me.RadioBtnBhsInggris = New System.Windows.Forms.RadioButton()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.GroupBoxBahasa = New System.Windows.Forms.GroupBox()
        Me.GroupBoxKategori = New System.Windows.Forms.GroupBox()
        Me.btnTambahKoleksi = New System.Windows.Forms.Button()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.PictureBoxFoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBoxBahasa.SuspendLayout()
        Me.GroupBoxKategori.SuspendLayout()
        CType(Me.PictureBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNamaKoleksi
        '
        Me.TextBoxNamaKoleksi.Location = New System.Drawing.Point(320, 24)
        Me.TextBoxNamaKoleksi.Name = "TextBoxNamaKoleksi"
        Me.TextBoxNamaKoleksi.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxNamaKoleksi.TabIndex = 0
        '
        'ComboBoxJenisKoleksi
        '
        Me.ComboBoxJenisKoleksi.FormattingEnabled = True
        Me.ComboBoxJenisKoleksi.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi ", "Penelitian"})
        Me.ComboBoxJenisKoleksi.Location = New System.Drawing.Point(320, 60)
        Me.ComboBoxJenisKoleksi.Name = "ComboBoxJenisKoleksi"
        Me.ComboBoxJenisKoleksi.Size = New System.Drawing.Size(186, 21)
        Me.ComboBoxJenisKoleksi.TabIndex = 1
        '
        'LblNamaKoleksi
        '
        Me.LblNamaKoleksi.AutoSize = True
        Me.LblNamaKoleksi.Location = New System.Drawing.Point(178, 27)
        Me.LblNamaKoleksi.Name = "LblNamaKoleksi"
        Me.LblNamaKoleksi.Size = New System.Drawing.Size(72, 13)
        Me.LblNamaKoleksi.TabIndex = 3
        Me.LblNamaKoleksi.Text = "Nama Koleksi"
        '
        'LblJenisKoleksi
        '
        Me.LblJenisKoleksi.AutoSize = True
        Me.LblJenisKoleksi.Location = New System.Drawing.Point(178, 63)
        Me.LblJenisKoleksi.Name = "LblJenisKoleksi"
        Me.LblJenisKoleksi.Size = New System.Drawing.Size(68, 13)
        Me.LblJenisKoleksi.TabIndex = 4
        Me.LblJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.Location = New System.Drawing.Point(178, 95)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(50, 13)
        Me.LblDeskripsi.TabIndex = 5
        Me.LblDeskripsi.Text = "Deskripsi"
        '
        'LblPenerbit
        '
        Me.LblPenerbit.AutoSize = True
        Me.LblPenerbit.Location = New System.Drawing.Point(178, 228)
        Me.LblPenerbit.Name = "LblPenerbit"
        Me.LblPenerbit.Size = New System.Drawing.Size(46, 13)
        Me.LblPenerbit.TabIndex = 6
        Me.LblPenerbit.Text = "Penerbit"
        '
        'LblTahunTerbit
        '
        Me.LblTahunTerbit.AutoSize = True
        Me.LblTahunTerbit.Location = New System.Drawing.Point(178, 265)
        Me.LblTahunTerbit.Name = "LblTahunTerbit"
        Me.LblTahunTerbit.Size = New System.Drawing.Size(68, 13)
        Me.LblTahunTerbit.TabIndex = 8
        Me.LblTahunTerbit.Text = "Tahun Terbit"
        '
        'RichTextBoxDeskripsi
        '
        Me.RichTextBoxDeskripsi.Location = New System.Drawing.Point(320, 95)
        Me.RichTextBoxDeskripsi.Name = "RichTextBoxDeskripsi"
        Me.RichTextBoxDeskripsi.Size = New System.Drawing.Size(186, 113)
        Me.RichTextBoxDeskripsi.TabIndex = 2
        Me.RichTextBoxDeskripsi.Text = ""
        '
        'TextBoxTahunPenerbit
        '
        Me.TextBoxTahunPenerbit.Location = New System.Drawing.Point(320, 258)
        Me.TextBoxTahunPenerbit.Name = "TextBoxTahunPenerbit"
        Me.TextBoxTahunPenerbit.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxTahunPenerbit.TabIndex = 9
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Location = New System.Drawing.Point(178, 329)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(118, 13)
        Me.LblTanggal.TabIndex = 11
        Me.LblTanggal.Text = "Tanggal Masuk Koleksi"
        '
        'LBlLokasiRak
        '
        Me.LBlLokasiRak.AutoSize = True
        Me.LBlLokasiRak.Location = New System.Drawing.Point(178, 300)
        Me.LBlLokasiRak.Name = "LBlLokasiRak"
        Me.LBlLokasiRak.Size = New System.Drawing.Size(61, 13)
        Me.LBlLokasiRak.TabIndex = 10
        Me.LBlLokasiRak.Text = "Lokasi Rak"
        '
        'TextBoxLokasiRak
        '
        Me.TextBoxLokasiRak.Location = New System.Drawing.Point(320, 297)
        Me.TextBoxLokasiRak.Name = "TextBoxLokasiRak"
        Me.TextBoxLokasiRak.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxLokasiRak.TabIndex = 12
        '
        'DateTimePickerMasukKoleksi
        '
        Me.DateTimePickerMasukKoleksi.Location = New System.Drawing.Point(320, 329)
        Me.DateTimePickerMasukKoleksi.Name = "DateTimePickerMasukKoleksi"
        Me.DateTimePickerMasukKoleksi.Size = New System.Drawing.Size(186, 20)
        Me.DateTimePickerMasukKoleksi.TabIndex = 13
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(178, 366)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(35, 13)
        Me.LblStock.TabIndex = 14
        Me.LblStock.Text = "Stock"
        '
        'TextBoxPenerbit
        '
        Me.TextBoxPenerbit.Location = New System.Drawing.Point(320, 225)
        Me.TextBoxPenerbit.Name = "TextBoxPenerbit"
        Me.TextBoxPenerbit.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxPenerbit.TabIndex = 7
        '
        'LblBahasa
        '
        Me.LblBahasa.AutoSize = True
        Me.LblBahasa.Location = New System.Drawing.Point(178, 394)
        Me.LblBahasa.Name = "LblBahasa"
        Me.LblBahasa.Size = New System.Drawing.Size(43, 13)
        Me.LblBahasa.TabIndex = 15
        Me.LblBahasa.Text = "Bahasa"
        '
        'LblKategori
        '
        Me.LblKategori.AutoSize = True
        Me.LblKategori.Location = New System.Drawing.Point(178, 480)
        Me.LblKategori.Name = "LblKategori"
        Me.LblKategori.Size = New System.Drawing.Size(46, 13)
        Me.LblKategori.TabIndex = 16
        Me.LblKategori.Text = "Kategori"
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(320, 363)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxStock.TabIndex = 17
        '
        'RadiobtnBhsIndo
        '
        Me.RadiobtnBhsIndo.AutoSize = True
        Me.RadiobtnBhsIndo.Location = New System.Drawing.Point(18, 19)
        Me.RadiobtnBhsIndo.Name = "RadiobtnBhsIndo"
        Me.RadiobtnBhsIndo.Size = New System.Drawing.Size(110, 17)
        Me.RadiobtnBhsIndo.TabIndex = 18
        Me.RadiobtnBhsIndo.TabStop = True
        Me.RadiobtnBhsIndo.Text = "Bahasa Indonesia"
        Me.RadiobtnBhsIndo.UseVisualStyleBackColor = True
        '
        'RadioBtnBhsInggris
        '
        Me.RadioBtnBhsInggris.AutoSize = True
        Me.RadioBtnBhsInggris.Location = New System.Drawing.Point(18, 42)
        Me.RadioBtnBhsInggris.Name = "RadioBtnBhsInggris"
        Me.RadioBtnBhsInggris.Size = New System.Drawing.Size(95, 17)
        Me.RadioBtnBhsInggris.TabIndex = 19
        Me.RadioBtnBhsInggris.TabStop = True
        Me.RadioBtnBhsInggris.Text = "Bahasa Inggris"
        Me.RadioBtnBhsInggris.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(90, 22)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxTeknologi.TabIndex = 20
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(90, 39)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(62, 17)
        Me.CheckBoxBudaya.TabIndex = 21
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(3, 22)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(52, 17)
        Me.CheckBoxSains.TabIndex = 22
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(3, 42)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(54, 17)
        Me.CheckBoxSosial.TabIndex = 23
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'GroupBoxBahasa
        '
        Me.GroupBoxBahasa.Controls.Add(Me.RadioBtnBhsInggris)
        Me.GroupBoxBahasa.Controls.Add(Me.RadiobtnBhsIndo)
        Me.GroupBoxBahasa.Location = New System.Drawing.Point(320, 394)
        Me.GroupBoxBahasa.Name = "GroupBoxBahasa"
        Me.GroupBoxBahasa.Size = New System.Drawing.Size(128, 72)
        Me.GroupBoxBahasa.TabIndex = 24
        Me.GroupBoxBahasa.TabStop = False
        Me.GroupBoxBahasa.Text = "Bahasa"
        '
        'GroupBoxKategori
        '
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBoxKategori.Controls.Add(Me.CheckBoxSains)
        Me.GroupBoxKategori.Location = New System.Drawing.Point(320, 472)
        Me.GroupBoxKategori.Name = "GroupBoxKategori"
        Me.GroupBoxKategori.Size = New System.Drawing.Size(186, 69)
        Me.GroupBoxKategori.TabIndex = 25
        Me.GroupBoxKategori.TabStop = False
        Me.GroupBoxKategori.Text = "Kategori"
        '
        'btnTambahKoleksi
        '
        Me.btnTambahKoleksi.Location = New System.Drawing.Point(197, 568)
        Me.btnTambahKoleksi.Name = "btnTambahKoleksi"
        Me.btnTambahKoleksi.Size = New System.Drawing.Size(117, 23)
        Me.btnTambahKoleksi.TabIndex = 26
        Me.btnTambahKoleksi.Text = "Tambah Koleksi"
        Me.btnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(28, 197)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(117, 23)
        Me.BtnTambahGambar.TabIndex = 27
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'PictureBoxFoto
        '
        Me.PictureBoxFoto.Location = New System.Drawing.Point(28, 45)
        Me.PictureBoxFoto.Name = "PictureBoxFoto"
        Me.PictureBoxFoto.Size = New System.Drawing.Size(117, 131)
        Me.PictureBoxFoto.TabIndex = 28
        Me.PictureBoxFoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 603)
        Me.Controls.Add(Me.PictureBoxFoto)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.btnTambahKoleksi)
        Me.Controls.Add(Me.GroupBoxKategori)
        Me.Controls.Add(Me.GroupBoxBahasa)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.LblKategori)
        Me.Controls.Add(Me.LblBahasa)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.DateTimePickerMasukKoleksi)
        Me.Controls.Add(Me.TextBoxLokasiRak)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.LBlLokasiRak)
        Me.Controls.Add(Me.TextBoxTahunPenerbit)
        Me.Controls.Add(Me.LblTahunTerbit)
        Me.Controls.Add(Me.TextBoxPenerbit)
        Me.Controls.Add(Me.LblPenerbit)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblJenisKoleksi)
        Me.Controls.Add(Me.LblNamaKoleksi)
        Me.Controls.Add(Me.RichTextBoxDeskripsi)
        Me.Controls.Add(Me.ComboBoxJenisKoleksi)
        Me.Controls.Add(Me.TextBoxNamaKoleksi)
        Me.Name = "tambahKoleksi"
        Me.Text = "tambahKoleksi"
        Me.GroupBoxBahasa.ResumeLayout(False)
        Me.GroupBoxBahasa.PerformLayout()
        Me.GroupBoxKategori.ResumeLayout(False)
        Me.GroupBoxKategori.PerformLayout()
        CType(Me.PictureBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNamaKoleksi As TextBox
    Friend WithEvents ComboBoxJenisKoleksi As ComboBox
    Friend WithEvents LblNamaKoleksi As Label
    Friend WithEvents LblJenisKoleksi As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents LblPenerbit As Label
    Friend WithEvents LblTahunTerbit As Label
    Friend WithEvents RichTextBoxDeskripsi As RichTextBox
    Friend WithEvents TextBoxTahunPenerbit As TextBox
    Friend WithEvents LblTanggal As Label
    Friend WithEvents LBlLokasiRak As Label
    Friend WithEvents TextBoxLokasiRak As TextBox
    Friend WithEvents DateTimePickerMasukKoleksi As DateTimePicker
    Friend WithEvents LblStock As Label
    Friend WithEvents TextBoxPenerbit As TextBox
    Friend WithEvents LblBahasa As Label
    Friend WithEvents LblKategori As Label
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents RadiobtnBhsIndo As RadioButton
    Friend WithEvents RadioBtnBhsInggris As RadioButton
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents GroupBoxBahasa As GroupBox
    Friend WithEvents GroupBoxKategori As GroupBox
    Friend WithEvents btnTambahKoleksi As Button
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
