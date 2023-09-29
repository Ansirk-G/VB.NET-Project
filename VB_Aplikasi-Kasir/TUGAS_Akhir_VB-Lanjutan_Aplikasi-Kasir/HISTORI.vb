Imports MySql.Data.MySqlClient
Public Class HISTORI
    Private Sub HISTORI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil_data()
    End Sub

    Sub tampil_data()
        da = New MySqlDataAdapter("select * from histori order by id_transaksi", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "histori")
        Me.DataGridView1.DataSource = (ds.Tables("histori"))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        da = New MySqlDataAdapter("select * from histori where nama_pembeli like '%" & Me.TextBox4.Text & "%'", con)
        ds = New DataSet

        da.Fill(ds, "histori")
        Me.DataGridView1.DataSource = (ds.Tables("histori"))
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class
