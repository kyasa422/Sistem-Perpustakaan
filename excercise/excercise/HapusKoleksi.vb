Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        LabelHapusKoleksi.Text = Perpus.dataPerpustakaan.GSdelete
        LabelHapusKoleksi.Text = Perpus.selectedRow.Cells(1).Value

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Dim indexItem = 0
        'Perpus.ListBoxKoleksi.Items.RemoveAt(Perpus.ListBoxKoleksi.SelectedIndex)
        'MessageBox.Show("Data berhasil dihapus")



        'For Each item In Perpus.dataPerpustakaan.getKoleksiDataTable()
        '    If item(0) Is Perpus.ListBoxKoleksi.SelectedItem() Then
        '        indexItem = Perpus.dataPerpustakaan.getKoleksiDataTable().IndexOf(item)

        '    End If
        'Next

        'Perpus.dataPerpustakaan.removeKoleksiDataTable(indexItem)

        Perpus.dataPerpustakaan.DeleteDataKoleksiByIDDatabase(Perpus.selectedTableKoleksi)

        Me.Close()

    End Sub
End Class