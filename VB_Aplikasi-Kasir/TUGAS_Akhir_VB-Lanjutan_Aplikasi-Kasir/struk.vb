Imports MySql.Data.MySqlClient
Public Class struk
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If Me.Label3.Text = "" Or Me.TextHarga.Text = "" Or Me.TextBayar.Text = "" Or
            Me.TextKembali.Text = "" Or Me.Label14.Text = "" Then
            MsgBox(" Maaf Datanya Belum Lengkap")
        Else
            Dim simpan As String
            MsgBox("Data Anda Akan Disimpan")
            simpan = "insert into histori (nama_pembeli,total_harga,bayar,kembalian,kasir) 
                values('" & Me.Label3.Text & "','" & Me.TextHarga.Text & "','" & Me.TextBayar.Text & "'
                ,'" & Me.TextKembali.Text & "','" & Me.Label4.Text & "')"

            cmd = New MySqlCommand(simpan, con)
            cmd.ExecuteNonQuery()
        End If

        TRANSAKSI.SendToBack()
        TRANSAKSI.Clear()
        Me.Hide()
    End Sub


End Class
