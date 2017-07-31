<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterTransaksiBeli
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterTransaksiBeli))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUkuran = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtWarna = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNamaSepatu = New System.Windows.Forms.TextBox()
        Me.txtHargaBeli = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.cmbSepatu = New System.Windows.Forms.ComboBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.txtNoTransaksi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGBeliBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGBeliBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(933, 96)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Transaksi Pembelian Sepatu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.txtUkuran)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtWarna)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtNamaSepatu)
        Me.GroupBox1.Controls.Add(Me.txtHargaBeli)
        Me.GroupBox1.Controls.Add(Me.txtJumlah)
        Me.GroupBox1.Controls.Add(Me.cmbSepatu)
        Me.GroupBox1.Controls.Add(Me.txtStok)
        Me.GroupBox1.Controls.Add(Me.cmbSupplier)
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
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(933, 191)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'txtUkuran
        '
        Me.txtUkuran.Location = New System.Drawing.Point(667, 30)
        Me.txtUkuran.Name = "txtUkuran"
        Me.txtUkuran.Size = New System.Drawing.Size(224, 20)
        Me.txtUkuran.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(604, 33)
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
        Me.txtUser.Location = New System.Drawing.Point(667, 135)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(224, 20)
        Me.txtUser.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(619, 138)
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
        'txtHargaBeli
        '
        Me.txtHargaBeli.Location = New System.Drawing.Point(667, 56)
        Me.txtHargaBeli.Name = "txtHargaBeli"
        Me.txtHargaBeli.Size = New System.Drawing.Size(224, 20)
        Me.txtHargaBeli.TabIndex = 19
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(667, 108)
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
        Me.txtStok.Location = New System.Drawing.Point(667, 81)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(224, 20)
        Me.txtStok.TabIndex = 20
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(324, 56)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(224, 21)
        Me.cmbSupplier.TabIndex = 12
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
        Me.Label12.Location = New System.Drawing.Point(606, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Jumlah"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(619, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Stok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(586, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Harga Beli"
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
        Me.Label4.Location = New System.Drawing.Point(244, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID Sepatu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Supplier"
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
        'DGBeliBarang
        '
        Me.DGBeliBarang.BackgroundColor = System.Drawing.Color.White
        Me.DGBeliBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBeliBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGBeliBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBeliBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGBeliBarang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGBeliBarang.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGBeliBarang.Location = New System.Drawing.Point(3, 16)
        Me.DGBeliBarang.Name = "DGBeliBarang"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBeliBarang.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGBeliBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBeliBarang.Size = New System.Drawing.Size(927, 179)
        Me.DGBeliBarang.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.DGBeliBarang)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(933, 217)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(667, 25)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(224, 23)
        Me.txtTotal.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(567, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Total Harga"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Controls.Add(Me.btnTutup)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btnBatal)
        Me.GroupBox3.Controls.Add(Me.btnProses)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 488)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(933, 68)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.CadetBlue
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.icons8_Unavailable_Filled
        Me.btnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTutup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnTutup.Location = New System.Drawing.Point(341, 22)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Padding = New System.Windows.Forms.Padding(0, 0, 40, 0)
        Me.btnTutup.Size = New System.Drawing.Size(140, 30)
        Me.btnTutup.TabIndex = 62
        Me.btnTutup.Text = "&Tutup"
        Me.btnTutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Red
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.close_24
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(179, 22)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(0, 0, 40, 0)
        Me.btnBatal.Size = New System.Drawing.Size(140, 30)
        Me.btnBatal.TabIndex = 60
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnProses
        '
        Me.btnProses.BackColor = System.Drawing.Color.Gold
        Me.btnProses.FlatAppearance.BorderSize = 0
        Me.btnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProses.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.floppy_20
        Me.btnProses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProses.Location = New System.Drawing.Point(15, 22)
        Me.btnProses.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Padding = New System.Windows.Forms.Padding(0, 0, 40, 0)
        Me.btnProses.Size = New System.Drawing.Size(141, 30)
        Me.btnProses.TabIndex = 57
        Me.btnProses.Text = "&Proses"
        Me.btnProses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProses.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Gold
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.floppy_20
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(10, 22)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(0, 0, 50, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(151, 30)
        Me.btnSimpan.TabIndex = 57
        Me.btnSimpan.Text = "&Proses"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'FormMasterTransaksiBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(933, 556)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterTransaksiBeli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Pembelian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGBeliBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaSepatu As System.Windows.Forms.TextBox
    Friend WithEvents cmbSepatu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DGBeliBarang As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtUkuran As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtWarna As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class
