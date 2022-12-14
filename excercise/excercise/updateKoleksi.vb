Public Class updateKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBoxFoto.Load(Perpus.dataPerpustakaan.GSfoto)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerMasukKoleksi.CustomFormat = "yyyy/MM/dd"
        TextBoxNamaKoleksi.Text = Perpus.dataPerpustakaan.GSnamaKoleksi
        ComboBoxJenisKoleksi.SelectedItem() = Perpus.dataPerpustakaan.GSjenisKoleksi
        RichTextBoxDeskripsi.Text = Perpus.dataPerpustakaan.GSdeskripsi
        TextBoxPenerbit.Text = Perpus.dataPerpustakaan.GSPenerbit
        TextBoxTahunPenerbit.Text = Perpus.dataPerpustakaan.GStahunterbit
        TextBoxLokasiRak.Text = Perpus.dataPerpustakaan.GSlokasiRak
        DateTimePickerMasukKoleksi.Value = Perpus.dataPerpustakaan.GStanggalMasuk
        TextBoxStock.Text = Perpus.dataPerpustakaan.GSstock

        'If String.Compare(Perpustakaan.koleksi.GSBahasa, "Indonesia") = 0 Then
        '    RadioButtonBIndo.Checked = True
        'ElseIf String.Compare(Perpustakaan.koleksi.GSBahasa, "Inggris") = 0 Then
        '    RadioButtonBIng.Checked = True
        'End If

        'For Each kategoriItem In Perpustakaan.koleksi.getKategoriItem()
        '    If String.Compare(kategoriItem, "Sains") = 0 Then
        '        CheckBoxSains.Checked = True
        '    ElseIf String.Compare(kategoriItem, "Social") = 0 Then
        '        CheckBoxSosial.Checked = True
        '    ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
        '        CheckBoxTeknologi.Checked = True
        '    ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
        '        CheckBoxBudaya.Checked = True
        '    End If
        'Next

        If Perpus.dataPerpustakaan.GSbahasa() = "Bahasa Indonesia" Then
            RadiobtnBhsIndo.Checked = True
        Else
            RadioBtnBhsInggris.Checked = True
        End If


        For Each info_tambah In Perpus.dataPerpustakaan.GSkategori()

            If info_tambah = "Sains" Then
                CheckBoxSains.Checked = True
            End If
            If info_tambah = "Sosial" Then
                CheckBoxSosial.Checked = True
            End If
            If info_tambah = "Teknologi" Then
                CheckBoxTeknologi.Checked = True
            End If
            If info_tambah = "Budaya" Then
                CheckBoxBudaya.Checked = True
            End If
        Next

        Perpus.dataPerpustakaan.GSkategori.Clear()

    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Gambar Koleksi"
        OpenFileDialog1.Filter = "All Format|*.*|BMP|*.bmp|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialog1.ShowDialog()

        Dim PicKoleksiDir As String = OpenFileDialog1.FileName

        PictureBoxFoto.Load(PicKoleksiDir)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        'Perpustakaan.koleksi.GSFoto = OpenFileDialog1.FileName

        Perpus.dataPerpustakaan.GSfoto = PicKoleksiDir.ToString()
        Perpus.dataPerpustakaan.GSfoto = Perpus.dataPerpustakaan.GSfoto.Replace("\", "/")
    End Sub

    Private Sub btnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles btnUpdateKoleksi.Click
        Perpus.dataPerpustakaan.GSnamaKoleksi = TextBoxNamaKoleksi.Text.ToString()
        Perpus.dataPerpustakaan.GSjenisKoleksi = ComboBoxJenisKoleksi.SelectedItem().ToString()
        Perpus.dataPerpustakaan.GSdeskripsi = RichTextBoxDeskripsi.Text.ToString()
        Perpus.dataPerpustakaan.GSPenerbit = TextBoxPenerbit.Text.ToString()
        Perpus.dataPerpustakaan.GStahunterbit = Integer.Parse(TextBoxTahunPenerbit.Text)

        Perpus.dataPerpustakaan.GSlokasiRak = TextBoxLokasiRak.Text.ToString()
        Perpus.dataPerpustakaan.GStanggalMasuk = DateTimePickerMasukKoleksi.Value.ToString("yyyy/MM/dd")
        Perpus.dataPerpustakaan.GSstock = Integer.Parse(TextBoxStock.Text)

        If RadiobtnBhsIndo.Checked Then
            Perpus.dataPerpustakaan.GSbahasa = "Indonesia"
        ElseIf RadioBtnBhsInggris.Checked Then
            Perpus.dataPerpustakaan.GSbahasa = "Inggris"
        End If

        If CheckBoxSains.Checked() Then
            Perpus.dataPerpustakaan.GSkategori.Add("Sains")
        End If

        If CheckBoxSosial.Checked() Then
            Perpus.dataPerpustakaan.GSkategori.Add("Sosial")
        End If

        If CheckBoxTeknologi.Checked() Then
            Perpus.dataPerpustakaan.GSkategori.Add("Teknologi")
        End If

        If CheckBoxBudaya.Checked() Then
            Perpus.dataPerpustakaan.GSkategori.Add("Budaya")
        End If



        Perpus.dataPerpustakaan.AddKoleksi(TextBoxNamaKoleksi.Text)

        Dim convertedKoleksi = Perpus.dataPerpustakaan.convertKoleksiToString(Perpus.dataPerpustakaan.GSkategori)
        Perpus.dataPerpustakaan.UpdateDataKoleksiByIDDatabase(Perpus.selectedTableKoleksi,
                                                           Perpus.dataPerpustakaan.GSfoto,
                                                           Perpus.dataPerpustakaan.GSnamaKoleksi,
                                                           Perpus.dataPerpustakaan.GSjenisKoleksi,
                                                           Perpus.dataPerpustakaan.GSPenerbit,
                                                           Perpus.dataPerpustakaan.GStahunterbit,
                                                           Perpus.dataPerpustakaan.GSdeskripsi,
                                                           Perpus.dataPerpustakaan.GSlokasiRak,
                                                           Perpus.dataPerpustakaan.GStanggalMasuk,
                                                           Perpus.dataPerpustakaan.GSstock,
                                                           Perpus.dataPerpustakaan.GSbahasa,
                                                           convertedKoleksi
                                                           )
        Dim infotambah = New infoTambahKoleksi()
        infotambah.Show()

        Me.Close()
    End Sub
End Class