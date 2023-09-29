Imports MySql.Data.MySqlClient
Public Class BARANG
    Dim kodesd
    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Label1.Text = "Id Barang"
        Label2.Text = "Nama Barang"
        Label3.Text = "Kategori"
        Label6.Text = "Harga Beli"
        Label7.Text = "Jumlah"
        Label8.Text = "Harga Jual"
        Button1.Text = "Simpan Data"
        Button2.Text = "Update/ Edit Data"
        Button3.Text = "Hapus Data"

        TextBox_Id.ReadOnly = True
        bersih()
    End Sub
    Sub bersih()
        TextBox_Id.Text = ""
        TextBox_Barang.Text = ""
        TextBoxHarga.Text = ""
        TextBoxJual.Text = ""
        TextBoxStok.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""

        Me.Button1.Enabled = True
        Me.Button2.Enabled = False
        Me.Button3.Enabled = False
        tampil_data()
    End Sub

    Sub tampil_data()
        da = New MySqlDataAdapter("select * from data_barang order by id_barang", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_barang")
        Me.DataGridView1.DataSource = (ds.Tables("data_barang"))

        nomor()
    End Sub

    Sub nomor()
        Dim DR As DataRow
        Dim s As String

        DR = SQLTable("select max(id_barang) as nomor from data_barang").Rows(0)

        If DR.IsNull("Nomor") Then
            s = "1"
        Else
            s = "1" & Format(DR("Nomor") + 1)
        End If
        TextBox_Id.Text = s
        TextBox_Id.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox_Id.Text = "" Or Me.TextBox_Barang.Text = "" Or Me.ComboBox1.Text = "" Or
            Me.TextBoxStok.Text = "" Or Me.TextBoxHarga.Text = "" Or Me.TextBoxJual.Text = "" Then
            MsgBox(" Maaf Datanya Belum Lengkap")
        Else
            Dim simpan As String
            MsgBox("Data Anda Akan Disimpan")
            simpan = "insert into data_barang (id_barang,nama_barang,kategori,stock,harga_beli,harga_jual) 
                values('" & Me.TextBox_Id.Text & "','" & Me.TextBox_Barang.Text & "','" & Me.ComboBox1.Text & "'
                ,'" & TextBoxStok.Text & "','" & Me.TextBoxHarga.Text & "','" & TextBoxJual.Text & "')"

            cmd = New MySqlCommand(simpan, con)
            cmd.ExecuteNonQuery()
            bersih()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.TextBox_Id.Text = "" Or Me.TextBox_Barang.Text = "" Or Me.ComboBox1.Text = "" Or
            Me.TextBoxStok.Text = "" Or Me.TextBoxHarga.Text = "" Or Me.TextBoxJual.Text = "" Then
            MsgBox(" Maaf datanya tidak ada yang di update")
        Else
            MsgBox(" anda akan mengupdate datanya")
            Dim edit As String
            edit = "update data_barang set id_barang ='" & Me.TextBox_Id.Text & "' , nama_barang = '" &
                Me.TextBox_Barang.Text & "',kategori ='" & Me.ComboBox1.Text & "',stock = '" & Me.TextBoxStok.Text & "'
                ,harga_beli = '" & Me.TextBoxHarga.Text & "',harga_jual = '" & Me.TextBoxJual.Text & "' where id_barang = '" & Me.TextBox_Id.Text & "'"

            cmd = New MySqlCommand(edit, con)
            cmd.ExecuteNonQuery()
            bersih()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.TextBox_Id.Text = "" Or Me.TextBox_Barang.Text = "" Or Me.ComboBox1.Text = "" Or
            Me.TextBoxHarga.Text = "" Or Me.TextBoxStok.Text = "" Or Me.TextBoxJual.Text = "" Then
            MsgBox(" Maaf datanya tidak ada yang di hapus")
            bersih()
        Else
            If MessageBox.Show(" anda yakin akan menghapus datanya ???", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim hapus As String
                hapus = "delete from data_barang where id_barang = '" & Me.TextBox_Id.Text & "'"
                cmd = New MySqlCommand(hapus, con)
                cmd.ExecuteNonQuery()
                bersih()
            Else
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        kodesd = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox_Id.Text = kodesd
        TextBox_Barang.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBoxStok.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBoxHarga.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBoxJual.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

        Me.Button1.Enabled = False
        Me.Button2.Enabled = True
        Me.Button3.Enabled = True
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        da = New MySqlDataAdapter("select * from data_barang where nama_barang like '%" & Me.TextBox4.Text & "%'", con)
        ds = New DataSet

        da.Fill(ds, "data_barang")
        DataGridView1.DataSource = (ds.Tables("data_barang"))
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        bersih()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub


End Class
