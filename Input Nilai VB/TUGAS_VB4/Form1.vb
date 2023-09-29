Public Class Form1
    Sub Clear()
        TextNama.Text = ""
        TextNim.Text = ""
        ComboBox1.Text = ""
        TextMatkul.Text = ""
        TextHadir.Text = ""
        TextTugas.Text = ""
        TextUts.Text = ""
        TextUas.Text = ""
        TextDosen.Text = ""
        TextAngka.Text = ""
        TextHuruf.Text = ""
        LabelDaftar.Text = ""
        TextNama.Focus()
        TextAngka.Enabled = False
        TextHuruf.Enabled = False
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Call Clear()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dim Tutup As String

        Tutup = MessageBox.Show("Yakin Ingin Menutup Form Ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ButtonHitung_Click(sender As Object, e As EventArgs) Handles ButtonHitung.Click
        Dim Nama As String
        Dim NIM As Integer
        Dim Dosen As String
        Dim Kehadiran As Double
        Dim Tugas As Double
        Dim UTS As Double
        Dim UAS As Double
        Dim Nilai As Double
        Dim Huruf As String

        Nama = TextNama.Text
        NIM = TextNim.Text
        Dosen = TextDosen.Text
        Kehadiran = Val(TextHadir.Text)
        Tugas = Val(TextTugas.Text)
        UTS = Val(TextUts.Text)
        UAS = Val(TextUas.Text)
        Nilai = (0.15 * Kehadiran + 0.2 * Tugas + 0.25 * UTS + 0.4 * UAS)
        TextAngka.Text = Nilai


        If Nilai > 85 <= 100 Then
            Huruf = "A"
        ElseIf Nilai <= 85 Then
            Huruf = "B"
        ElseIf Nilai <= 75 Then
            Huruf = "C"
        ElseIf NIlai <= 65 Then
            Huruf = "D"
        Else
            Huruf = "E"
        End If

        TextHuruf.Text = Huruf

        Select Case Val(TextAngka.Text)
            Case 86 To 100
                MsgBox("Selamat Nilai Anda Sangat Bagus, Harap Dipertahankan Dan Jangan Berpuas Diri", MsgBoxStyle.Information, "SELAMAT")
            Case 76 To 85
                MsgBox("Selamat Nilai Anda Sudah Bagus, Harap Ditingkatkan Dan Jangan Menyerah", MsgBoxStyle.Information, "SELAMAT")
            Case 66 To 75
                MsgBox("Selamat Nilai Anda Sudah Cukup, Harap Ditingkatkan Dan Lebih Giat", MsgBoxStyle.Information, "SELAMAT")
            Case 56 To 65
                MsgBox("Mohon Maaf Nilai Anda Kurang, Harap Lebih Giat Belajar Dan Jangan Menyerah", MsgBoxStyle.Information, "SELAMAT")
            Case Else
                MsgBox("MOHON MAAF NILAI ANDA SANGAT KURANG, TOLONG LEBIH GIAT DALAM BELAJAR DAN KEHADIRANNYA DIKELAS", MsgBoxStyle.Information, "SELAMAT")

        End Select

        LabelDaftar.Text = "Nama : " + TextNama.Text + "; NIM : " + TextAngka.Text + "; Nilai : " + TextAngka.Text
    End Sub

    Private Sub TextHadir_KeyPress(Sender As Object, e As KeyPressEventArgs) Handles TextHadir.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = vbTrue
    End Sub

    Private Sub TextTugas_KeyPress(Sender As Object, e As KeyPressEventArgs) Handles TextTugas.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = vbTrue
    End Sub

    Private Sub TextUTS_KeyPress(Sender As Object, e As KeyPressEventArgs) Handles TextUts.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = vbTrue
    End Sub

    Private Sub TextUAS_KeyPress(Sender As Object, e As KeyPressEventArgs) Handles TextUas.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = vbTrue
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        MsgBox("Anda Sudah Diperbolehkan Memproses Datanya")
        ButtonHitung.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonHitung.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Matkul1"
                TextMatkul.Text = "Anda Memilih Matkul OOP"
            Case "Matkul2"
                TextMatkul.Text = "Anda Memilih Matkul Kalkulus"
            Case "Matkul3"
                TextMatkul.Text = "Anda Memilih Matkul Automata"
            Case "Matkul4"
                TextMatkul.Text = "Anda Memilih Matkul Visual Basic"
            Case "Matkul5"
                TextMatkul.Text = "Anda Memilih Matkul Database 1"
        End Select
    End Sub

    Private Sub TextNim_KeyPress(ByVal sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextNim.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextHadir_Click(sender As Object, e As EventArgs) Handles TextHadir.Click
        Dim int As Integer = InputBox("Anda Akan Memasukkan Nilai Kehadiran......", "Input Nilai")
        If int > 0 <= 100 Then
            TextHadir.Text = int
        End If
    End Sub

    Private Sub TextTugas_Click(sender As Object, e As EventArgs) Handles TextTugas.Click
        Dim int As Integer = InputBox("Anda Akan Memasukkan Nilai Tugas......", "Input Nilai")
        If int > 0 <= 100 Then
            TextTugas.Text = int
        End If
    End Sub

    Private Sub TextUts_Click(sender As Object, e As EventArgs) Handles TextUts.Click
        Dim int As Integer = InputBox("Anda Akan Memasukkan Nilai UTS......", "Input Nilai")
        If int > 0 <= 100 Then
            TextUts.Text = int
        End If
    End Sub

    Private Sub TextUas_Click(sender As Object, e As EventArgs) Handles TextUas.Click
        Dim int As Integer = InputBox("Anda Akan Memasukkan Nilai UAS......", "Input Nilai")
        If int > 0 <= 100 Then
            TextUas.Text = int
        End If
    End Sub

    Private Sub ButtonInput_Click(sender As Object, e As EventArgs) Handles ButtonInput.Click
        With ListBox1
            .Items.Add(LabelDaftar.Text)
        End With
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        MsgBox("Data Sudah Ter-Upload", vbInformation, ("SUKSES"))
        Call Clear()
        ListBox1.Items.Clear()
        ListBox1.Items.Add("	       Daftar Nilai Mahasiswa")
        ListBox1.Items.Add("----------------------------------------------------------------------")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        ListBox1.Items.Add("	       Daftar Nilai Mahasiswa")
        ListBox1.Items.Add("----------------------------------------------------------------------")
    End Sub
End Class
