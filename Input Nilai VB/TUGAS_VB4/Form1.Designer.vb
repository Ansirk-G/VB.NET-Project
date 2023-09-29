<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonInput = New System.Windows.Forms.Button()
        Me.LabelDaftar = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonHitung = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButtonW = New System.Windows.Forms.RadioButton()
        Me.RadioButtonL = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextAngka = New System.Windows.Forms.TextBox()
        Me.TextHuruf = New System.Windows.Forms.TextBox()
        Me.TextMatkul = New System.Windows.Forms.TextBox()
        Me.TextUas = New System.Windows.Forms.TextBox()
        Me.TextTugas = New System.Windows.Forms.TextBox()
        Me.TextUts = New System.Windows.Forms.TextBox()
        Me.TextHadir = New System.Windows.Forms.TextBox()
        Me.TextDosen = New System.Windows.Forms.TextBox()
        Me.TextNim = New System.Windows.Forms.TextBox()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ButtonUpload)
        Me.GroupBox1.Controls.Add(Me.ButtonExit)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1193, 600)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Cyan
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(365, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(436, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Form Input Nilai Mahasiswa UNSADA: Kelas Malam B"
        '
        'ButtonUpload
        '
        Me.ButtonUpload.BackColor = System.Drawing.Color.DarkBlue
        Me.ButtonUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpload.ForeColor = System.Drawing.Color.Cornsilk
        Me.ButtonUpload.Location = New System.Drawing.Point(507, 558)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(104, 36)
        Me.ButtonUpload.TabIndex = 47
        Me.ButtonUpload.Text = "UPLOAD "
        Me.ButtonUpload.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.SystemColors.ControlText
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.ForeColor = System.Drawing.Color.Cornsilk
        Me.ButtonExit.Location = New System.Drawing.Point(657, 558)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(88, 36)
        Me.ButtonExit.TabIndex = 46
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.ButtonHapus)
        Me.GroupBox2.Controls.Add(Me.ButtonInput)
        Me.GroupBox2.Controls.Add(Me.LabelDaftar)
        Me.GroupBox2.Location = New System.Drawing.Point(728, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 489)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Mahasiswa"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(26, 191)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(366, 260)
        Me.ListBox1.TabIndex = 41
        Me.ListBox1.Tag = ""
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Font = New System.Drawing.Font("Magneto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.Location = New System.Drawing.Point(285, 153)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(107, 32)
        Me.ButtonHapus.TabIndex = 40
        Me.ButtonHapus.Text = "Hapus Data"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonInput
        '
        Me.ButtonInput.Font = New System.Drawing.Font("Magneto", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInput.Location = New System.Drawing.Point(26, 153)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(107, 32)
        Me.ButtonInput.TabIndex = 39
        Me.ButtonInput.Text = "Input Data"
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'LabelDaftar
        '
        Me.LabelDaftar.AutoSize = True
        Me.LabelDaftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDaftar.Location = New System.Drawing.Point(23, 39)
        Me.LabelDaftar.Name = "LabelDaftar"
        Me.LabelDaftar.Size = New System.Drawing.Size(56, 16)
        Me.LabelDaftar.TabIndex = 38
        Me.LabelDaftar.Text = "Label12"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ButtonClear)
        Me.GroupBox3.Controls.Add(Me.ButtonHitung)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.RadioButtonW)
        Me.GroupBox3.Controls.Add(Me.RadioButtonL)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.TextAngka)
        Me.GroupBox3.Controls.Add(Me.TextHuruf)
        Me.GroupBox3.Controls.Add(Me.TextMatkul)
        Me.GroupBox3.Controls.Add(Me.TextUas)
        Me.GroupBox3.Controls.Add(Me.TextTugas)
        Me.GroupBox3.Controls.Add(Me.TextUts)
        Me.GroupBox3.Controls.Add(Me.TextHadir)
        Me.GroupBox3.Controls.Add(Me.TextDosen)
        Me.GroupBox3.Controls.Add(Me.TextNim)
        Me.GroupBox3.Controls.Add(Me.TextNama)
        Me.GroupBox3.Location = New System.Drawing.Point(42, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(644, 489)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "From Input Nilai"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 345)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "NILAI HURUF"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "NILAI ANGKA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(235, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Nilai UAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(92, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Nilai UTS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(235, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Nilai Tugas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Nilai Kehadiran"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "MATKUL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nama Dosen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "NIM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nama Mahasiswa"
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(276, 429)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 26
        Me.ButtonClear.Text = "CLEAR"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonHitung
        '
        Me.ButtonHitung.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ButtonHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHitung.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonHitung.Location = New System.Drawing.Point(153, 429)
        Me.ButtonHitung.Name = "ButtonHitung"
        Me.ButtonHitung.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHitung.TabIndex = 25
        Me.ButtonHitung.Text = "HITUNG"
        Me.ButtonHitung.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(123, 389)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(269, 17)
        Me.CheckBox1.TabIndex = 24
        Me.CheckBox1.Text = "Apakah Data Yang Anda Masukkan Sudah Benar?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButtonW
        '
        Me.RadioButtonW.AutoSize = True
        Me.RadioButtonW.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonW.Location = New System.Drawing.Point(153, 135)
        Me.RadioButtonW.Name = "RadioButtonW"
        Me.RadioButtonW.Size = New System.Drawing.Size(63, 16)
        Me.RadioButtonW.TabIndex = 23
        Me.RadioButtonW.TabStop = True
        Me.RadioButtonW.Text = "Wanita"
        Me.RadioButtonW.UseVisualStyleBackColor = True
        '
        'RadioButtonL
        '
        Me.RadioButtonL.AutoSize = True
        Me.RadioButtonL.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonL.Location = New System.Drawing.Point(55, 135)
        Me.RadioButtonL.Name = "RadioButtonL"
        Me.RadioButtonL.Size = New System.Drawing.Size(74, 16)
        Me.RadioButtonL.TabIndex = 22
        Me.RadioButtonL.TabStop = True
        Me.RadioButtonL.Text = "Laki-Laki"
        Me.RadioButtonL.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Matkul1", "Matkul2", "Matkul3", "Matkul4", "Matkul5"})
        Me.ComboBox1.Location = New System.Drawing.Point(409, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'TextAngka
        '
        Me.TextAngka.Enabled = False
        Me.TextAngka.Location = New System.Drawing.Point(15, 317)
        Me.TextAngka.Name = "TextAngka"
        Me.TextAngka.Size = New System.Drawing.Size(75, 20)
        Me.TextAngka.TabIndex = 20
        '
        'TextHuruf
        '
        Me.TextHuruf.Enabled = False
        Me.TextHuruf.Location = New System.Drawing.Point(15, 361)
        Me.TextHuruf.Name = "TextHuruf"
        Me.TextHuruf.Size = New System.Drawing.Size(75, 20)
        Me.TextHuruf.TabIndex = 19
        '
        'TextMatkul
        '
        Me.TextMatkul.Location = New System.Drawing.Point(449, 97)
        Me.TextMatkul.Name = "TextMatkul"
        Me.TextMatkul.Size = New System.Drawing.Size(181, 20)
        Me.TextMatkul.TabIndex = 18
        '
        'TextUas
        '
        Me.TextUas.Location = New System.Drawing.Point(251, 261)
        Me.TextUas.Name = "TextUas"
        Me.TextUas.Size = New System.Drawing.Size(100, 20)
        Me.TextUas.TabIndex = 17
        '
        'TextTugas
        '
        Me.TextTugas.Location = New System.Drawing.Point(251, 197)
        Me.TextTugas.Name = "TextTugas"
        Me.TextTugas.Size = New System.Drawing.Size(100, 20)
        Me.TextTugas.TabIndex = 16
        '
        'TextUts
        '
        Me.TextUts.Location = New System.Drawing.Point(104, 261)
        Me.TextUts.Name = "TextUts"
        Me.TextUts.Size = New System.Drawing.Size(100, 20)
        Me.TextUts.TabIndex = 15
        '
        'TextHadir
        '
        Me.TextHadir.Location = New System.Drawing.Point(104, 197)
        Me.TextHadir.Name = "TextHadir"
        Me.TextHadir.Size = New System.Drawing.Size(100, 20)
        Me.TextHadir.TabIndex = 14
        '
        'TextDosen
        '
        Me.TextDosen.Location = New System.Drawing.Point(409, 32)
        Me.TextDosen.Name = "TextDosen"
        Me.TextDosen.Size = New System.Drawing.Size(145, 20)
        Me.TextDosen.TabIndex = 13
        '
        'TextNim
        '
        Me.TextNim.Location = New System.Drawing.Point(123, 70)
        Me.TextNim.Name = "TextNim"
        Me.TextNim.Size = New System.Drawing.Size(149, 20)
        Me.TextNim.TabIndex = 12
        '
        'TextNama
        '
        Me.TextNama.Location = New System.Drawing.Point(123, 32)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(149, 20)
        Me.TextNama.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 625)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ButtonInput As Button
    Friend WithEvents LabelDaftar As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonHitung As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButtonW As RadioButton
    Friend WithEvents RadioButtonL As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextAngka As TextBox
    Friend WithEvents TextHuruf As TextBox
    Friend WithEvents TextMatkul As TextBox
    Friend WithEvents TextUas As TextBox
    Friend WithEvents TextTugas As TextBox
    Friend WithEvents TextUts As TextBox
    Friend WithEvents TextHadir As TextBox
    Friend WithEvents TextDosen As TextBox
    Friend WithEvents TextNim As TextBox
    Friend WithEvents TextNama As TextBox
End Class
