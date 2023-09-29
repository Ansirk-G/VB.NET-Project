Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Username.Text = ""
        Password.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Call koneksi()
            Dim str As String
            str = "select * from login where username = '" & Username.Text & "' and password = '" & Password.Text & "'"
            cmd = New MySqlCommand(str, con)

            If cmd.ExecuteReader.HasRows Then
                Form2.Show()
                Me.Hide()
            ElseIf Username.Text = "" And Password.Text = "" Then
                MsgBox("Silahkan isi Username Anda & Isikan Password", vbInformation, "Hint")
                Username.Focus()
            ElseIf Username.Text = "" Then
                MsgBox("ID Anda Kosong", vbCritical, "Warning!!")
                Username.Focus()
            ElseIf Password.Text = "" Then
                MsgBox("Harap Masukkan Password", vbCritical, "Warning!!")
                Password.Focus()
            Else
                MsgBox("Login gagal, username atau Password salah", vbCritical, "Warning!!")
                Username.Focus()
            End If
        Catch ex As Exception

        End Try
        TRANSAKSI.TextBox1.Text = Username.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Tutup As String

        Tutup = MessageBox.Show("Yakin Ingin Menutup Aplikasi ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub
End Class
