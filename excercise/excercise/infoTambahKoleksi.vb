Public Class infoTambahKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        If Not String.IsNullOrEmpty(Perpus.dataPerpustakaan.GSfoto) Then
            BoxFoto.Load(Perpus.dataPerpustakaan.GSfoto)
            BoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LabelNamaKoleksiValue.Text = Perpus.dataPerpustakaan.GSnamaKoleksi
        LabelJenisKoleksiValue.Text = Perpus.dataPerpustakaan.GSjenisKoleksi
        LabelDeskripsiValue.Text = Perpus.dataPerpustakaan.GSdeskripsi
        LabelPenerbitValue.Text = Perpus.dataPerpustakaan.GSPenerbit
        LabelTahunTerbitValue.Text = Perpus.dataPerpustakaan.GStahunterbit
        LabelLokasiRakValue.Text = Perpus.dataPerpustakaan.GSlokasiRak
        LabelTanggalValue.Text = Perpus.dataPerpustakaan.GStanggalMasuk
        LabelStockValue.Text = Perpus.dataPerpustakaan.GSstock
        LabelBahasaValue.Text = Perpus.dataPerpustakaan.GSbahasa

        For Each kel In Perpus.dataPerpustakaan.GSkategori
            ListBoxKategoriValue.Items.Add(kel)
        Next

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class