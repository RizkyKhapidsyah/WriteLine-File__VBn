Imports System.IO

Public Class Form1

    Private Sub tombolCiptakan_Click(sender As Object, e As EventArgs) Handles tombolCiptakan.Click
        'konstanta untuk banyak teman
        Const intBANYAK_TEMAN As Integer = 3

        'variabel-variabel lokal
        Dim strNamaFile As String       'nama file
        Dim strTeman As String          'nama teman
        Dim strTelp As String           'untuk memuat nomor telepon
        Dim intHitung As Integer        'pencacah loop
        Dim fileTeman As StreamWriter   'variabel objek StreamWriter

        'membaca nama file dari user
        strNamaFile = InputBox("Masukkan nama file.")

        Try
            'membuka file
            fileTeman = File.CreateText(strNamaFile)

            'membaca data dan menuliskannya ke dalam file
            For intHitung = 1 To intBANYAK_TEMAN
                'membaca nama teman
                strTeman = InputBox("Masukkan nama teman " &
                "nomor " & intHitung.ToString())

                'membaca nomor telepon teman
                strTelp = InputBox("Masukkan nomor telepon " &
                "teman.")

                'menuliskan data ke dalam file
                fileTeman.WriteLine(strTeman)
                fileTeman.WriteLine(strTelp)
            Next

            'menutup file
            fileTeman.Close()
        Catch
            'pesan error
            MessageBox.Show("File tidak dapat diciptakan.")
        End Try
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class