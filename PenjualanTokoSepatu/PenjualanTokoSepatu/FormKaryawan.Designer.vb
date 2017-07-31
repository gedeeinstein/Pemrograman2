<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKaryawan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKaryawan))
        Me.GBDataKaryawan = New System.Windows.Forms.GroupBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.Tgl_Lahir = New System.Windows.Forms.DateTimePicker()
        Me.txtTempatLahir = New System.Windows.Forms.TextBox()
        Me.cmbJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.txtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.txtNIK = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBPencarian = New System.Windows.Forms.GroupBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCari = New System.Windows.Forms.ComboBox()
        Me.GBTombol = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.DGKaryawan = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Label()
        Me.GBDataKaryawan.SuspendLayout()
        Me.GBPencarian.SuspendLayout()
        Me.GBTombol.SuspendLayout()
        CType(Me.DGKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBDataKaryawan
        '
        Me.GBDataKaryawan.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GBDataKaryawan.Controls.Add(Me.txtAlamat)
        Me.GBDataKaryawan.Controls.Add(Me.Tgl_Lahir)
        Me.GBDataKaryawan.Controls.Add(Me.txtTempatLahir)
        Me.GBDataKaryawan.Controls.Add(Me.cmbJenisKelamin)
        Me.GBDataKaryawan.Controls.Add(Me.txtNoTelp)
        Me.GBDataKaryawan.Controls.Add(Me.txtNamaKaryawan)
        Me.GBDataKaryawan.Controls.Add(Me.txtNIK)
        Me.GBDataKaryawan.Controls.Add(Me.Label6)
        Me.GBDataKaryawan.Controls.Add(Me.Label5)
        Me.GBDataKaryawan.Controls.Add(Me.Label4)
        Me.GBDataKaryawan.Controls.Add(Me.Label3)
        Me.GBDataKaryawan.Controls.Add(Me.Label2)
        Me.GBDataKaryawan.Controls.Add(Me.Label1)
        Me.GBDataKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GBDataKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDataKaryawan.ForeColor = System.Drawing.Color.White
        Me.GBDataKaryawan.Location = New System.Drawing.Point(13, 126)
        Me.GBDataKaryawan.Name = "GBDataKaryawan"
        Me.GBDataKaryawan.Size = New System.Drawing.Size(432, 256)
        Me.GBDataKaryawan.TabIndex = 0
        Me.GBDataKaryawan.TabStop = False
        Me.GBDataKaryawan.Text = "Data Karyawan"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(163, 145)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(230, 73)
        Me.txtAlamat.TabIndex = 8
        '
        'Tgl_Lahir
        '
        Me.Tgl_Lahir.CalendarForeColor = System.Drawing.Color.Black
        Me.Tgl_Lahir.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Tgl_Lahir.Location = New System.Drawing.Point(261, 116)
        Me.Tgl_Lahir.Name = "Tgl_Lahir"
        Me.Tgl_Lahir.Size = New System.Drawing.Size(132, 20)
        Me.Tgl_Lahir.TabIndex = 4
        '
        'txtTempatLahir
        '
        Me.txtTempatLahir.Location = New System.Drawing.Point(163, 115)
        Me.txtTempatLahir.Name = "txtTempatLahir"
        Me.txtTempatLahir.Size = New System.Drawing.Size(92, 20)
        Me.txtTempatLahir.TabIndex = 3
        '
        'cmbJenisKelamin
        '
        Me.cmbJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenisKelamin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbJenisKelamin.FormattingEnabled = True
        Me.cmbJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbJenisKelamin.Location = New System.Drawing.Point(163, 88)
        Me.cmbJenisKelamin.Name = "cmbJenisKelamin"
        Me.cmbJenisKelamin.Size = New System.Drawing.Size(149, 21)
        Me.cmbJenisKelamin.TabIndex = 2
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(163, 224)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(149, 20)
        Me.txtNoTelp.TabIndex = 6
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(163, 59)
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(230, 20)
        Me.txtNamaKaryawan.TabIndex = 1
        '
        'txtNIK
        '
        Me.txtNIK.Location = New System.Drawing.Point(163, 30)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(149, 20)
        Me.txtNIK.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No. Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tempat Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'GBPencarian
        '
        Me.GBPencarian.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GBPencarian.Controls.Add(Me.txtCari)
        Me.GBPencarian.Controls.Add(Me.Label8)
        Me.GBPencarian.Controls.Add(Me.cmbCari)
        Me.GBPencarian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPencarian.ForeColor = System.Drawing.Color.White
        Me.GBPencarian.Location = New System.Drawing.Point(451, 126)
        Me.GBPencarian.Name = "GBPencarian"
        Me.GBPencarian.Size = New System.Drawing.Size(766, 79)
        Me.GBPencarian.TabIndex = 1
        Me.GBPencarian.TabStop = False
        Me.GBPencarian.Text = "Cari Data"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(271, 34)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(470, 20)
        Me.txtCari.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Berdasarkan"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCari
        '
        Me.cmbCari.DropDownHeight = 150
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.IntegralHeight = False
        Me.cmbCari.ItemHeight = 13
        Me.cmbCari.Items.AddRange(New Object() {"Nama Karyawan", "NIK", "No Telepon"})
        Me.cmbCari.Location = New System.Drawing.Point(131, 33)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(134, 21)
        Me.cmbCari.TabIndex = 2
        '
        'GBTombol
        '
        Me.GBTombol.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GBTombol.Controls.Add(Me.btnBatal)
        Me.GBTombol.Controls.Add(Me.btnSimpan)
        Me.GBTombol.Controls.Add(Me.btnHapus)
        Me.GBTombol.Controls.Add(Me.btnEdit)
        Me.GBTombol.Location = New System.Drawing.Point(13, 388)
        Me.GBTombol.Name = "GBTombol"
        Me.GBTombol.Size = New System.Drawing.Size(432, 91)
        Me.GBTombol.TabIndex = 2
        Me.GBTombol.TabStop = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.SystemColors.Control
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.close_24
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(230, 33)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btnBatal.Size = New System.Drawing.Size(75, 34)
        Me.btnBatal.TabIndex = 20
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.Control
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.save__save_as_icon_icon__2_
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(20, 33)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(75, 34)
        Me.btnSimpan.TabIndex = 19
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.Control
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.remove_button_20
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(336, 33)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.btnHapus.Size = New System.Drawing.Size(75, 34)
        Me.btnHapus.TabIndex = 18
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.edit_button_20
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(124, 33)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(7, 0, 9, 2)
        Me.btnEdit.Size = New System.Drawing.Size(75, 34)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'DGKaryawan
        '
        Me.DGKaryawan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGKaryawan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGKaryawan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKaryawan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGKaryawan.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGKaryawan.Location = New System.Drawing.Point(451, 218)
        Me.DGKaryawan.Name = "DGKaryawan"
        Me.DGKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGKaryawan.Size = New System.Drawing.Size(766, 261)
        Me.DGKaryawan.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nama Karywan", "NIK", "No Telepon"})
        Me.ComboBox1.Location = New System.Drawing.Point(123, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SeaGreen
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1229, 114)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Data Pegawai"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.AutoSize = True
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(1201, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.btnExit.Size = New System.Drawing.Size(28, 23)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "X"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1229, 491)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGKaryawan)
        Me.Controls.Add(Me.GBTombol)
        Me.Controls.Add(Me.GBPencarian)
        Me.Controls.Add(Me.GBDataKaryawan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormKaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Karyawan"
        Me.GBDataKaryawan.ResumeLayout(False)
        Me.GBDataKaryawan.PerformLayout()
        Me.GBPencarian.ResumeLayout(False)
        Me.GBPencarian.PerformLayout()
        Me.GBTombol.ResumeLayout(False)
        CType(Me.DGKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBDataKaryawan As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents txtNIK As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Tgl_Lahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents GBPencarian As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCari As System.Windows.Forms.ComboBox
    Friend WithEvents GBTombol As System.Windows.Forms.GroupBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents DGKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    'Friend WithEvents DataSet1 As PenjualanTokoSepatu.DataSet1
End Class
