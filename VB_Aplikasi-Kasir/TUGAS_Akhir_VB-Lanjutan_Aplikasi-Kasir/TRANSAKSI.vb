Imports MySql.Data.MySqlClient

Public Class TRANSAKSI
    Dim kodebd
    Private Sub TRANSAKSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        combobox()

        TextHarga1.ReadOnly = True
        TextBoxKode.ReadOnly = True
        TextHarga.ReadOnly = True
    End Sub

    Sub pembayaran()
        Dim Total As Double = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            Total += Convert.ToDouble(row.Cells(4).Value)
        Next
        Label7.Text = Total
        Dim Total2 = Aggregate row As DataGridViewRow In DataGridView1.Rows
        Into Sum(Convert.ToDouble(row.Cells(4).Value))
        Label7.Text = Total

    End Sub


    Sub Clear()
        TextQty1.Text = ""
        TextHarga1.Text = ""
        CmbNama.Text = ""
        TextBoxSearch.Text = ""
        TextBoxKode.Text = ""
        TextPembeli.Text = ""
        TextBayar.Text = ""
        TextHarga.Text = ""
        TextKembali.Text = ""
        Label7.Text = "-"
        TextBoxTot.Text = ""
        tampil_data()
        Dim hapus As String
        hapus = "delete from transaksi"
        cmd = New MySqlCommand(hapus, con)
        cmd.ExecuteNonQuery()
    End Sub

    Sub tampil_data()
        rb.Close()
        da = New MySqlDataAdapter("select * from transaksi order by id_barang", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "transaksi")
        Me.DataGridView1.DataSource = (ds.Tables("transaksi"))
    End Sub


    Private Sub TextBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = vbTrue
    End Sub
    Private Sub TextQty1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextQty1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = vbTrue
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxTot.Text = Val(TextHarga1.Text * TextQty1.Text)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        kodebd = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBoxKode.Text = kodebd
        CmbNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextQty1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextHarga1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBoxTot.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub ButtonData_Click(sender As Object, e As EventArgs) Handles ButtonData.Click
        rb.Close()

        If Me.TextBoxKode.Text = "" Or Me.CmbNama.Text = "" Or Me.TextQty1.Text = "" Or Me.TextHarga1.Text = "" Or Me.TextBoxTot.Text = "" Then
            MsgBox(" Maaf datanya belum lengkap mas bro")
        Else
            Dim simpan As String
            simpan = "insert into transaksi (id_barang,nama_barang,qty,harga,harga_total) values('" & Me.TextBoxKode.Text & "','" &
                Me.CmbNama.Text & "','" & Me.TextQty1.Text & "','" & Me.TextHarga1.Text & "','" & Me.TextBoxTot.Text & "')"
            cmd = New MySqlCommand(simpan, con)
            cmd.ExecuteNonQuery()
        End If

        TextBoxKode.Text = ""
        CmbNama.Text = ""
        TextHarga1.Text = ""
        TextQty1.Text = ""
        TextBoxTot.Text = ""

        tampil_data()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call pembayaran()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        rb.Close()

        search.Show()
        da = New MySqlDataAdapter("select * from data_barang where nama_barang like '%" & Me.TextBoxSearch.Text & "%'", con)
        ds = New DataSet

        da.Fill(ds, "data_barang")
        search.DataGridView1.DataSource = (ds.Tables("data_barang"))
    End Sub

    Private Sub ButtonProses_Click(sender As Object, e As EventArgs) Handles ButtonProses.Click
        TextHarga.Text = Val(Label7.Text)
    End Sub

    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        TextKembali.Text = Val(TextBayar.Text) - Val(TextHarga.Text)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Call Clear()
    End Sub

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        struk.Label3.Text = TextPembeli.Text
        struk.Label4.Text = TextBox1.Text
        struk.TextHarga.Text = TextHarga.Text
        struk.TextBayar.Text = TextBayar.Text
        struk.TextKembali.Text = TextKembali.Text

        If CmbNama.Text = "" Then
            MsgBox("Harap Masukkan Pesanan", vbInformation, "Hint")
            CmbNama.Focus()
        ElseIf TextPembeli.Text = "" Then
            MsgBox("Harap Masukkan Nama Pembeli", vbInformation, "Hint")
            TextPembeli.Focus()
        ElseIf TextBayar.Text = "" Then
            MsgBox("Harap Masukkan Nominal Pembayaran", vbInformation, "Hint")
            TextBayar.Focus()
        ElseIf TextKembali.Text = "" Then
            MsgBox("Harap Proses Hitungan", vbInformation, "Hint")
            ButtonHitung.Focus()
        Else
            struk.Show()
            struk.Select()
        End If

        struk.DataGridView1.DataSource = (ds.Tables("transaksi"))
        struk.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNama.SelectedIndexChanged
        koneksi()


        cmd = New MySqlCommand("select * from data_barang where nama_barang ='" & CmbNama.Text & "'", con)
        rb = cmd.ExecuteReader
        rb.Read()

        If rb.HasRows Then
            TextBoxKode.Text = rb.Item("id_barang")
            TextHarga1.Text = rb.Item("harga_jual")
        End If


    End Sub

    Sub combobox()
        koneksi()

        Try
            cmd = New MySqlCommand("select nama_barang from data_barang order by nama_barang", con)
            rb = cmd.ExecuteReader
            While rb.Read
                CmbNama.Items.Add(rb("nama_barang"))
            End While
        Catch ex As Exception

        End Try
    End Sub


End Class
