Public Class Perpus

    Public Shared dataPerpustakaan As DataPerpustkaan
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Public Shared selectedRow As DataGridViewRow

    'Public Sub updateDataTableArrayList()
    '    DataGridKoleksi.Rows.Clear()
    '    For Each rowKoleksi In dataPerpustakaan.getKoleksiDataTable()
    '        Dim dataTable As String() = {rowKoleksi(1),
    '                                     rowKoleksi(2),
    '                                     rowKoleksi(3),
    '                                     rowKoleksi(4),
    '                                     rowKoleksi(7),
    '                                     rowKoleksi(9),
    '                                     rowKoleksi(10),
    '                                     rowKoleksi(8),
    '                                     rowKoleksi(9)}
    '        DataGridKoleksi.Rows.Add(dataTable)
    '    Next
    'End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        dataPerpustakaan = New DataPerpustkaan()
        ReloadDataTableDatabase()
        'updateDataTableArrayList()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = dataPerpustakaan.GetDataKoleksiDatabase()
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim pindah = New tambahKoleksi()
        pindah.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim pindah = New tambahKoleksi()
        pindah.Show()
    End Sub

    Private Sub btnRmv_Click(sender As Object, e As EventArgs) Handles btnRmv.Click

        If ListBoxKoleksi.SelectedIndex >= 0 Then
            dataPerpustakaan.GSdelete = ListBoxKoleksi.SelectedItem()
            Dim pindah = New HapusKoleksi()
            pindah.Show()
        Else
            MessageBox.Show("Pilih data terlebih dahulu")
        End If

    End Sub

    Private Sub Perpus_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'updateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Public Sub procHapus(item As String)
        dataPerpustakaan.removeKoleksiDataTable(item)
        ListBoxKoleksi.Items.Remove(item)
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        dataPerpustakaan.GSkategori.Clear()
        Dim dataselected As List(Of String) = dataPerpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        'MessageBox.Show(dataselected.Count)

        dataPerpustakaan.GSfoto = dataselected(2)

        dataPerpustakaan.GSnamaKoleksi = dataselected(1)
        dataPerpustakaan.GSjenisKoleksi = dataselected(5)
        dataPerpustakaan.GSPenerbit = dataselected(4)
        dataPerpustakaan.GStahunterbit = dataselected(7)
        dataPerpustakaan.GSdeskripsi = dataselected(3)
        dataPerpustakaan.GSlokasiRak = dataselected(7)
        dataPerpustakaan.GStanggalMasuk = dataselected(8)
        dataPerpustakaan.GSstock = dataselected(9)
        dataPerpustakaan.GSbahasa = dataselected(10)

        Dim data_koleksi As List(Of String) = dataPerpustakaan.convertStringToKoleksi(dataselected(11))

        For Each info_tambah In data_koleksi
            dataPerpustakaan.addKategori(info_tambah)
        Next

        Dim infoTambah = New infoTambahKoleksi()
        infoTambah.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim selectedKoleksi As List(Of String) = dataPerpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)
        dataPerpustakaan.GSfoto = selectedKoleksi(2)

        dataPerpustakaan.GSnamaKoleksi = selectedKoleksi(1)
        dataPerpustakaan.GSjenisKoleksi = selectedKoleksi(5)
        dataPerpustakaan.GSdeskripsi = selectedKoleksi(3)
        dataPerpustakaan.GSPenerbit = selectedKoleksi(4)
        dataPerpustakaan.GStahunterbit = selectedKoleksi(6)
        dataPerpustakaan.GSlokasiRak = selectedKoleksi(7)
        dataPerpustakaan.GStanggalMasuk = selectedKoleksi(8)
        dataPerpustakaan.GSstock = selectedKoleksi(9)
        dataPerpustakaan.GSbahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = dataPerpustakaan.convertStringToKoleksi(selectedKoleksi(11))

        For Each info_kategori In data_kategori
            dataPerpustakaan.GSkategori.Add(info_kategori)
        Next

        Dim formUpdate = New updateKoleksi()
        formUpdate.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim formHapus = New HapusKoleksi()
        formHapus.Show()
    End Sub
End Class