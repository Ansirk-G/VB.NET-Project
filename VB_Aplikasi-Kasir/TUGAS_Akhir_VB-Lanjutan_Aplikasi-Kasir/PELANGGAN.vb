Imports MySql.Data.MySqlClient
Public Class PELANGGAN
    Dim kodecus
    Private Sub PELANGGAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Label1.Text = "Id Pelanggan"
        Label2.Text = "Nama Pelanggan"
        Label5.Text = "Alamat"
        Label7.Text = "No.Telp"
        Button1.Text = "Simpan Data"
        Button2.Text = "Update/ Edit Data"
        Button3.Text = "Hapus Data"

        TextBoxId.ReadOnly = True
        bersih()
    End Sub
    Sub bersih()
        TextBoxId.Text = ""
        TextBoxNama.Text = ""
        TextBoxAlamat.Text = ""
        TextBoxTelp.Text = ""
        TextBox4.Text = ""

        Me.Button1.Enabled = True
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        tampil_data()
    End Sub

    Sub tampil_data()
        da = New MySqlDataAdapter("select * from pembeli order by id_pembeli", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pembeli")
        Me.DataGridView1.DataSource = (ds.Tables("pembeli"))

        nomor()
    End Sub

    Sub nomor()
        Dim DR As DataRow
        Dim s As String

        DR = SQLTable("select max(id_pembeli) as Nomor from pembeli").Rows(0)

        If DR.IsNull("Nomor") Then
            s = "1"
        Else
            s = "1" & Format(DR("Nomor") + 1)
        End If
        TextBoxId.Text = s
        TextBoxId.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBoxId.Text = "" Or Me.TextBoxNama.Text = "" Or
            Me.TextBoxAlamat.Text = "" Or Me.TextBoxTelp.Text = "" Then
            MsgBox(" Maaf Datanya Belum Lengkap")
        Else
            Dim simpan As String
            MsgBox("Data Anda Akan Disimpan")
            simpan = "insert into pembeli (id_pembeli,nama_pembeli,alamat,telepon) 
                values('" & Me.TextBoxId.Text & "','" & Me.TextBoxNama.Text & "',
                '" & Me.TextBoxAlamat.Text & "','" & Me.TextBoxTelp.Text & "')"

            cmd = New MySqlCommand(simpan, con)
            cmd.ExecuteNonQuery()
            bersih()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.TextBoxId.Text = "" Or Me.TextBoxNama.Text = "" Or
            Me.TextBoxAlamat.Text = "" Or Me.TextBoxTelp.Text = "" Then
            MsgBox(" Maaf datanya tidak ada yang di update")
        Else
            MsgBox(" anda akan mengupdate datanya")
            Dim edit As String
            edit = "update pembeli set id_pembeli ='" & Me.TextBoxId.Text & "' , nama_pembeli = '" &
                Me.TextBoxNama.Text & "',alamat = '" & Me.TextBoxAlamat.Text & "', telepon = '" &
                Me.TextBoxTelp.Text & "' where id_pembeli = '" & Me.TextBoxId.Text & "'"

            cmd = New MySqlCommand(edit, con)
            cmd.ExecuteNonQuery()
            bersih()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.TextBoxId.Text = "" Or Me.TextBoxNama.Text = "" Or
            Me.TextBoxAlamat.Text = "" Or TextBoxTelp.Text = "" Then
            MsgBox(" Maaf datanya tidak ada yang di hapus")
            bersih()
        Else
            If MessageBox.Show(" anda yakin akan menghapus datanya ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String
                hapus = "delete from pembeli where id_pembeli = '" & Me.TextBoxId.Text & "'"
                cmd = New MySqlCommand(hapus, con)
                cmd.ExecuteNonQuery()
                bersih()
            Else
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        kodecus = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBoxId.Text = kodecus
        TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBoxAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBoxTelp.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value

        Me.Button1.Enabled = False
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        da = New MySqlDataAdapter("select * from pembeli where nama_pembeli like '%" & Me.TextBox4.Text & "%'", con)
        ds = New DataSet

        da.Fill(ds, "pembeli")
        DataGridView1.DataSource = (ds.Tables("pembeli"))
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bersih()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class
