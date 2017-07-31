<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterTransaksiJual
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPembeli = New System.Windows.Forms.TextBox()
        Me.txtUkuran = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtWarna = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNamaSepatu = New System.Windows.Forms.TextBox()
        Me.txtHargaJual = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.cmbSepatu = New System.Windows.Forms.ComboBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txtNoTransaksi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGJualBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.txtTotalAkhir = New System.Windows.Forms.TextBox()
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.lbKembalian = New System.Windows.Forms.Label()
        Me.lbBayar = New System.Windows.Forms.Label()
        Me.lbGrandTotal = New System.Windows.Forms.Label()
        Me.lbDiskon = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGJualBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGreen
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(992, 115)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Transaksi Penjualan Sepatu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtPembeli)
        Me.GroupBox1.Controls.Add(Me.txtUkuran)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtWarna)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtNamaSepatu)
        Me.GroupBox1.Controls.Add(Me.txtHargaJual)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.cmbSepatu)
        Me.GroupBox1.Controls.Add(Me.txtStok)
        Me.GroupBox1.Controls.Add(Me.txtNoTransaksi)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(992, 180)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.search_20
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(553, 83)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 21)
        Me.Button2.TabIndex = 79
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(927, 53)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 25)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtPembeli
        '
        Me.txtPembeli.Location = New System.Drawing.Point(324, 56)
        Me.txtPembeli.Name = "txtPembeli"
        Me.txtPembeli.Size = New System.Drawing.Size(224, 20)
        Me.txtPembeli.TabIndex = 29
        '
        'txtUkuran
        '
        Me.txtUkuran.Location = New System.Drawing.Point(695, 56)
        Me.txtUkuran.Name = "txtUkuran"
        Me.txtUkuran.Size = New System.Drawing.Size(224, 20)
        Me.txtUkuran.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(632, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Ukuran"
        '
        'txtWarna
        '
        Me.txtWarna.Location = New System.Drawing.Point(324, 136)
        Me.txtWarna.Name = "txtWarna"
        Me.txtWarna.Size = New System.Drawing.Size(224, 20)
        Me.txtWarna.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Warna"
        '
        'Label7
        '
        Me.Label7.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.contoh_logo_toko_sepatu_11
        Me.Label7.Location = New System.Drawing.Point(12, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 148)
        Me.Label7.TabIndex = 24
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(695, 30)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(224, 20)
        Me.txtUser.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(647, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "User"
        '
        'txtNamaSepatu
        '
        Me.txtNamaSepatu.Location = New System.Drawing.Point(324, 110)
        Me.txtNamaSepatu.Name = "txtNamaSepatu"
        Me.txtNamaSepatu.Size = New System.Drawing.Size(224, 20)
        Me.txtNamaSepatu.TabIndex = 14
        '
        'txtHargaJual
        '
        Me.txtHargaJual.Location = New System.Drawing.Point(695, 82)
        Me.txtHargaJual.Name = "txtHargaJual"
        Me.txtHargaJual.Size = New System.Drawing.Size(224, 20)
        Me.txtHargaJual.TabIndex = 19
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(695, 134)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(224, 20)
        Me.txtJumlah.TabIndex = 21
        '
        'cmbSepatu
        '
        Me.cmbSepatu.FormattingEnabled = True
        Me.cmbSepatu.Location = New System.Drawing.Point(324, 83)
        Me.cmbSepatu.Name = "cmbSepatu"
        Me.cmbSepatu.Size = New System.Drawing.Size(224, 21)
        Me.cmbSepatu.TabIndex = 13
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(695, 107)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(224, 20)
        Me.txtStok.TabIndex = 20
        '
        'txtNoTransaksi
        '
        Me.txtNoTransaksi.Location = New System.Drawing.Point(324, 30)
        Me.txtNoTransaksi.Name = "txtNoTransaksi"
        Me.txtNoTransaksi.ReadOnly = True
        Me.txtNoTransaksi.Size = New System.Drawing.Size(224, 20)
        Me.txtNoTransaksi.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(634, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Jumlah"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(647, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Stok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(614, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Harga Jual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(225, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nama Sepatu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sepatu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pembeli"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Transaksi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGJualBarang)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(992, 204)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        '
        'DGJualBarang
        '
        Me.DGJualBarang.BackgroundColor = System.Drawing.Color.White
        Me.DGJualBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGJualBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGJualBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGJualBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGJualBarang.Location = New System.Drawing.Point(3, 16)
        Me.DGJualBarang.Name = "DGJualBarang"
        Me.DGJualBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGJualBarang.Size = New System.Drawing.Size(986, 172)
        Me.DGJualBarang.TabIndex = 55
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkTurquoise
        Me.GroupBox3.Controls.Add(Me.txtKembalian)
        Me.GroupBox3.Controls.Add(Me.txtBayar)
        Me.GroupBox3.Controls.Add(Me.txtTotalAkhir)
        Me.GroupBox3.Controls.Add(Me.txtDiskon)
        Me.GroupBox3.Controls.Add(Me.lbKembalian)
        Me.GroupBox3.Controls.Add(Me.lbBayar)
        Me.GroupBox3.Controls.Add(Me.lbGrandTotal)
        Me.GroupBox3.Controls.Add(Me.lbDiskon)
        Me.GroupBox3.Controls.Add(Me.btnTutup)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btnBatal)
        Me.GroupBox3.Controls.Add(Me.btnProses)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 507)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(992, 107)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        '
        'txtKembalian
        '
        Me.txtKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKembalian.Location = New System.Drawing.Point(833, 45)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(142, 20)
        Me.txtKembalian.TabIndex = 77
        '
        'txtBayar
        '
        Me.txtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.Location = New System.Drawing.Point(833, 19)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(142, 20)
        Me.txtBayar.TabIndex = 76
        '
        'txtTotalAkhir
        '
        Me.txtTotalAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAkhir.Location = New System.Drawing.Point(592, 71)
        Me.txtTotalAkhir.Name = "txtTotalAkhir"
        Me.txtTotalAkhir.Size = New System.Drawing.Size(142, 20)
        Me.txtTotalAkhir.TabIndex = 75
        '
        'txtDiskon
        '
        Me.txtDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskon.Location = New System.Drawing.Point(592, 45)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(142, 20)
        Me.txtDiskon.TabIndex = 74
        '
        'lbKembalian
        '
        Me.lbKembalian.AutoSize = True
        Me.lbKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKembalian.Location = New System.Drawing.Point(755, 48)
        Me.lbKembalian.Name = "lbKembalian"
        Me.lbKembalian.Size = New System.Drawing.Size(65, 13)
        Me.lbKembalian.TabIndex = 73
        Me.lbKembalian.Text = "Kembalian"
        Me.lbKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbBayar
        '
        Me.lbBayar.AutoSize = True
        Me.lbBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBayar.Location = New System.Drawing.Point(779, 19)
        Me.lbBayar.Name = "lbBayar"
        Me.lbBayar.Size = New System.Drawing.Size(39, 13)
        Me.lbBayar.TabIndex = 72
        Me.lbBayar.Text = "Bayar"
        Me.lbBayar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbGrandTotal
        '
        Me.lbGrandTotal.AutoSize = True
        Me.lbGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGrandTotal.Location = New System.Drawing.Point(516, 74)
        Me.lbGrandTotal.Name = "lbGrandTotal"
        Me.lbGrandTotal.Size = New System.Drawing.Size(72, 13)
        Me.lbGrandTotal.TabIndex = 71
        Me.lbGrandTotal.Text = "Total Bayar"
        Me.lbGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDiskon
        '
        Me.lbDiskon.AutoSize = True
        Me.lbDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiskon.Location = New System.Drawing.Point(540, 48)
        Me.lbDiskon.Name = "lbDiskon"
        Me.lbDiskon.Size = New System.Drawing.Size(46, 13)
        Me.lbDiskon.TabIndex = 70
        Me.lbDiskon.Text = "Diskon"
        Me.lbDiskon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.icons8_Unavailable_Filled
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTutup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTutup.Location = New System.Drawing.Point(324, 39)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Padding = New System.Windows.Forms.Padding(5, 0, 25, 0)
        Me.btnTutup.Size = New System.Drawing.Size(116, 30)
        Me.btnTutup.TabIndex = 63
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(592, 19)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(142, 20)
        Me.txtTotal.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(514, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Total Harga"
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Red
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.close_24
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(178, 39)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(5, 0, 25, 0)
        Me.btnBatal.Size = New System.Drawing.Size(115, 30)
        Me.btnBatal.TabIndex = 60
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnProses
        '
        Me.btnProses.BackColor = System.Drawing.Color.Yellow
        Me.btnProses.FlatAppearance.BorderSize = 0
        Me.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.floppy_20
        Me.btnProses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProses.Location = New System.Drawing.Point(42, 39)
        Me.btnProses.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Padding = New System.Windows.Forms.Padding(5, 0, 25, 0)
        Me.btnProses.Size = New System.Drawing.Size(115, 30)
        Me.btnProses.TabIndex = 57
        Me.btnProses.Text = "&Proses"
        Me.btnProses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProses.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(957, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(35, 35)
        Me.btnClose.TabIndex = 78
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FormMasterTransaksiJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(992, 614)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMasterTransaksiJual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMasterTransaksiJual"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGJualBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUkuran As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWarna As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSepatu As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents cmbSepatu As System.Windows.Forms.ComboBox
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGJualBarang As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents lbKembalian As System.Windows.Forms.Label
    Friend WithEvents lbBayar As System.Windows.Forms.Label
    Friend WithEvents lbGrandTotal As System.Windows.Forms.Label
    Friend WithEvents lbDiskon As System.Windows.Forms.Label
    Friend WithEvents txtKembalian As System.Windows.Forms.TextBox
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAkhir As System.Windows.Forms.TextBox
    Friend WithEvents txtDiskon As System.Windows.Forms.TextBox
    Friend WithEvents txtPembeli As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
