<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterBarang))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSatuan = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbUkuran = New System.Windows.Forms.ComboBox()
        Me.cmbWarna = New System.Windows.Forms.ComboBox()
        Me.cmbMerk = New System.Windows.Forms.ComboBox()
        Me.cmbKategori = New System.Windows.Forms.ComboBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.txtHargaBeli = New System.Windows.Forms.TextBox()
        Me.txtNamaSepatu = New System.Windows.Forms.TextBox()
        Me.txtKodeSepatu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RbUkuran = New System.Windows.Forms.RadioButton()
        Me.RbKategori = New System.Windows.Forms.RadioButton()
        Me.RbMerk = New System.Windows.Forms.RadioButton()
        Me.RbNama = New System.Windows.Forms.RadioButton()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.BtnKoreksiStock = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 60.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(990, 114)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Master Data Sepatu"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Sepatu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSatuan)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbUkuran)
        Me.GroupBox1.Controls.Add(Me.cmbWarna)
        Me.GroupBox1.Controls.Add(Me.cmbMerk)
        Me.GroupBox1.Controls.Add(Me.cmbKategori)
        Me.GroupBox1.Controls.Add(Me.txtStok)
        Me.GroupBox1.Controls.Add(Me.txtHargaJual)
        Me.GroupBox1.Controls.Add(Me.txtHargaBeli)
        Me.GroupBox1.Controls.Add(Me.txtNamaSepatu)
        Me.GroupBox1.Controls.Add(Me.txtKodeSepatu)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightYellow
        Me.GroupBox1.Location = New System.Drawing.Point(10, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 177)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Sepatu"
        '
        'cmbSatuan
        '
        Me.cmbSatuan.FormattingEnabled = True
        Me.cmbSatuan.Location = New System.Drawing.Point(460, 57)
        Me.cmbSatuan.Name = "cmbSatuan"
        Me.cmbSatuan.Size = New System.Drawing.Size(151, 21)
        Me.cmbSatuan.TabIndex = 41
        Me.cmbSatuan.Text = "Pilih Satuan Barang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(354, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Satuan"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbUkuran
        '
        Me.cmbUkuran.FormattingEnabled = True
        Me.cmbUkuran.Location = New System.Drawing.Point(460, 31)
        Me.cmbUkuran.Name = "cmbUkuran"
        Me.cmbUkuran.Size = New System.Drawing.Size(151, 21)
        Me.cmbUkuran.TabIndex = 39
        Me.cmbUkuran.Text = "Pilih Ukuran"
        '
        'cmbWarna
        '
        Me.cmbWarna.FormattingEnabled = True
        Me.cmbWarna.Location = New System.Drawing.Point(118, 134)
        Me.cmbWarna.Name = "cmbWarna"
        Me.cmbWarna.Size = New System.Drawing.Size(151, 21)
        Me.cmbWarna.TabIndex = 38
        Me.cmbWarna.Text = "Pilih Warna"
        '
        'cmbMerk
        '
        Me.cmbMerk.FormattingEnabled = True
        Me.cmbMerk.Location = New System.Drawing.Point(118, 108)
        Me.cmbMerk.Name = "cmbMerk"
        Me.cmbMerk.Size = New System.Drawing.Size(151, 21)
        Me.cmbMerk.TabIndex = 37
        Me.cmbMerk.Text = "Pilih Merk"
        '
        'cmbKategori
        '
        Me.cmbKategori.FormattingEnabled = True
        Me.cmbKategori.Location = New System.Drawing.Point(118, 82)
        Me.cmbKategori.Name = "cmbKategori"
        Me.cmbKategori.Size = New System.Drawing.Size(151, 21)
        Me.cmbKategori.TabIndex = 36
        Me.cmbKategori.Text = "Pilih Kategori"
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(460, 135)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(151, 20)
        Me.txtStok.TabIndex = 33
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Location = New System.Drawing.Point(460, 109)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(151, 20)
        Me.txtHargaJual.TabIndex = 32
        '
        'txtHargaBeli
        '
        Me.txtHargaBeli.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtHargaBeli.Location = New System.Drawing.Point(460, 83)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Size = New System.Drawing.Size(151, 20)
        Me.txtHargaBeli.TabIndex = 31
        '
        'txtNamaSepatu
        '
        Me.txtNamaSepatu.Location = New System.Drawing.Point(118, 56)
        Me.txtNamaSepatu.MaxLength = 3276998
        Me.txtNamaSepatu.Name = "txtNamaSepatu"
        Me.txtNamaSepatu.Size = New System.Drawing.Size(151, 20)
        Me.txtNamaSepatu.TabIndex = 28
        '
        'txtKodeSepatu
        '
        Me.txtKodeSepatu.Location = New System.Drawing.Point(118, 30)
        Me.txtKodeSepatu.Name = "txtKodeSepatu"
        Me.txtKodeSepatu.Size = New System.Drawing.Size(151, 20)
        Me.txtKodeSepatu.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(354, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Stok"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Merk"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(354, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Ukuran"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Warna"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Harga Jual"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Harga Beli"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Kategori"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Sepatu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RbUkuran)
        Me.GroupBox2.Controls.Add(Me.RbKategori)
        Me.GroupBox2.Controls.Add(Me.RbMerk)
        Me.GroupBox2.Controls.Add(Me.RbNama)
        Me.GroupBox2.Controls.Add(Me.txtCari)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.LightYellow
        Me.GroupBox2.Location = New System.Drawing.Point(12, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 54)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Cari Barang"
        '
        'RbUkuran
        '
        Me.RbUkuran.AutoSize = True
        Me.RbUkuran.Location = New System.Drawing.Point(276, 21)
        Me.RbUkuran.Name = "RbUkuran"
        Me.RbUkuran.Size = New System.Drawing.Size(66, 17)
        Me.RbUkuran.TabIndex = 22
        Me.RbUkuran.TabStop = True
        Me.RbUkuran.Text = "&Ukuran"
        Me.RbUkuran.UseVisualStyleBackColor = True
        '
        'RbKategori
        '
        Me.RbKategori.AutoSize = True
        Me.RbKategori.Location = New System.Drawing.Point(127, 21)
        Me.RbKategori.Name = "RbKategori"
        Me.RbKategori.Size = New System.Drawing.Size(72, 17)
        Me.RbKategori.TabIndex = 21
        Me.RbKategori.TabStop = True
        Me.RbKategori.Text = "&Kategori"
        Me.RbKategori.UseVisualStyleBackColor = True
        '
        'RbMerk
        '
        Me.RbMerk.AutoSize = True
        Me.RbMerk.Location = New System.Drawing.Point(214, 21)
        Me.RbMerk.Name = "RbMerk"
        Me.RbMerk.Size = New System.Drawing.Size(53, 17)
        Me.RbMerk.TabIndex = 20
        Me.RbMerk.TabStop = True
        Me.RbMerk.Text = "&Merk"
        Me.RbMerk.UseVisualStyleBackColor = True
        '
        'RbNama
        '
        Me.RbNama.AutoSize = True
        Me.RbNama.Checked = True
        Me.RbNama.Location = New System.Drawing.Point(20, 21)
        Me.RbNama.Name = "RbNama"
        Me.RbNama.Size = New System.Drawing.Size(101, 17)
        Me.RbNama.TabIndex = 19
        Me.RbNama.TabStop = True
        Me.RbNama.Text = "&Nama Sepatu"
        Me.RbNama.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(355, 16)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txtCari.MaximumSize = New System.Drawing.Size(400, 35)
        Me.txtCari.MinimumSize = New System.Drawing.Size(200, 28)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(254, 26)
        Me.txtCari.TabIndex = 16
        Me.txtCari.WordWrap = False
        '
        'DGBarang
        '
        Me.DGBarang.BackgroundColor = System.Drawing.Color.White
        Me.DGBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGBarang.Location = New System.Drawing.Point(10, 373)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBarang.Size = New System.Drawing.Size(968, 204)
        Me.DGBarang.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(744, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 25)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "TheBaliAdivisor"
        '
        'Label13
        '
        Me.Label13.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.contoh_logo_toko_sepatu_11
        Me.Label13.Location = New System.Drawing.Point(654, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(326, 237)
        Me.Label13.TabIndex = 23
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Aqua
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.close_24
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(343, 589)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.btnBatal.Size = New System.Drawing.Size(70, 30)
        Me.btnBatal.TabIndex = 27
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.remove_button_20
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(241, 589)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(70, 30)
        Me.btnHapus.TabIndex = 26
        Me.btnHapus.Text = "&Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.LimeGreen
        Me.btnUbah.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnUbah.FlatAppearance.BorderSize = 0
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUbah.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.pencil_20
        Me.btnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUbah.Location = New System.Drawing.Point(141, 589)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btnUbah.Size = New System.Drawing.Size(70, 30)
        Me.btnUbah.TabIndex = 25
        Me.btnUbah.TabStop = False
        Me.btnUbah.Text = "&Ubah"
        Me.btnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Gold
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.floppy_20
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(39, 589)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(70, 30)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'BtnKoreksiStock
        '
        Me.BtnKoreksiStock.BackColor = System.Drawing.Color.DarkGray
        Me.BtnKoreksiStock.FlatAppearance.BorderSize = 0
        Me.BtnKoreksiStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKoreksiStock.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.edit_button_20
        Me.BtnKoreksiStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKoreksiStock.Location = New System.Drawing.Point(447, 589)
        Me.BtnKoreksiStock.Name = "BtnKoreksiStock"
        Me.BtnKoreksiStock.Size = New System.Drawing.Size(104, 30)
        Me.BtnKoreksiStock.TabIndex = 28
        Me.BtnKoreksiStock.Text = "&Tambah Stok"
        Me.BtnKoreksiStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnKoreksiStock.UseVisualStyleBackColor = False
        '
        'FormMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(990, 634)
        Me.Controls.Add(Me.BtnKoreksiStock)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaSepatu As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeSepatu As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbUkuran As System.Windows.Forms.ComboBox
    Friend WithEvents cmbWarna As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMerk As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Friend WithEvents cmbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnKoreksiStock As System.Windows.Forms.Button
    Public WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents RbUkuran As System.Windows.Forms.RadioButton
    Friend WithEvents RbKategori As System.Windows.Forms.RadioButton
    Friend WithEvents RbMerk As System.Windows.Forms.RadioButton
    Friend WithEvents RbNama As System.Windows.Forms.RadioButton
End Class
