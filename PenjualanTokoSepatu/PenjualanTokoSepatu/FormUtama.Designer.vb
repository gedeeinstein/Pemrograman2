<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsDataMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterSuplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MerkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WarnaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSatuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSuplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TSUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSWaktu = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.GhostWhite
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsDataMaster, Me.ToolsTransaksi, Me.SetupToolStripMenuItem, Me.ToolsLaporan, Me.TentangToolStripMenuItem, Me.ToolsKeluar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(10)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(755, 25)
        Me.MenuStrip1.TabIndex = 0
        '
        'ToolsDataMaster
        '
        Me.ToolsDataMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterBarangToolStripMenuItem, Me.MasterKaryawanToolStripMenuItem, Me.MasterUserToolStripMenuItem, Me.MasterSuplierToolStripMenuItem})
        Me.ToolsDataMaster.Name = "ToolsDataMaster"
        Me.ToolsDataMaster.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolsDataMaster.Size = New System.Drawing.Size(102, 25)
        Me.ToolsDataMaster.Text = "Data &Master"
        '
        'MasterBarangToolStripMenuItem
        '
        Me.MasterBarangToolStripMenuItem.Name = "MasterBarangToolStripMenuItem"
        Me.MasterBarangToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.MasterBarangToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.MasterBarangToolStripMenuItem.Text = "Master &Barang"
        '
        'MasterKaryawanToolStripMenuItem
        '
        Me.MasterKaryawanToolStripMenuItem.Name = "MasterKaryawanToolStripMenuItem"
        Me.MasterKaryawanToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.MasterKaryawanToolStripMenuItem.Text = "Master &Karyawan"
        '
        'MasterUserToolStripMenuItem
        '
        Me.MasterUserToolStripMenuItem.Name = "MasterUserToolStripMenuItem"
        Me.MasterUserToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.MasterUserToolStripMenuItem.Text = "Master &User"
        '
        'MasterSuplierToolStripMenuItem
        '
        Me.MasterSuplierToolStripMenuItem.Name = "MasterSuplierToolStripMenuItem"
        Me.MasterSuplierToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.MasterSuplierToolStripMenuItem.Text = "Master &Suplier"
        '
        'ToolsTransaksi
        '
        Me.ToolsTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanBarangToolStripMenuItem, Me.PembelianToolStripMenuItem})
        Me.ToolsTransaksi.Name = "ToolsTransaksi"
        Me.ToolsTransaksi.Size = New System.Drawing.Size(87, 25)
        Me.ToolsTransaksi.Text = "&Transaksi"
        '
        'PenjualanBarangToolStripMenuItem
        '
        Me.PenjualanBarangToolStripMenuItem.Name = "PenjualanBarangToolStripMenuItem"
        Me.PenjualanBarangToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.PenjualanBarangToolStripMenuItem.Text = "Penjualan Sepatu"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.PembelianToolStripMenuItem.Text = "Pembelian Sepatu"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KategoriToolStripMenuItem, Me.MerkToolStripMenuItem, Me.WarnaToolStripMenuItem, Me.DataSatuanToolStripMenuItem})
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(65, 25)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'KategoriToolStripMenuItem
        '
        Me.KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        Me.KategoriToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.KategoriToolStripMenuItem.Text = "Data Kategori"
        '
        'MerkToolStripMenuItem
        '
        Me.MerkToolStripMenuItem.Name = "MerkToolStripMenuItem"
        Me.MerkToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.MerkToolStripMenuItem.Text = "Data Merk"
        '
        'WarnaToolStripMenuItem
        '
        Me.WarnaToolStripMenuItem.Name = "WarnaToolStripMenuItem"
        Me.WarnaToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.WarnaToolStripMenuItem.Text = "Data Warna"
        '
        'DataSatuanToolStripMenuItem
        '
        Me.DataSatuanToolStripMenuItem.Name = "DataSatuanToolStripMenuItem"
        Me.DataSatuanToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.DataSatuanToolStripMenuItem.Text = "Data Satuan"
        '
        'ToolsLaporan
        '
        Me.ToolsLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.DataKaryawanToolStripMenuItem, Me.DataPenjualanToolStripMenuItem, Me.DataPembelianToolStripMenuItem, Me.DataSuplierToolStripMenuItem})
        Me.ToolsLaporan.Name = "ToolsLaporan"
        Me.ToolsLaporan.Size = New System.Drawing.Size(81, 25)
        Me.ToolsLaporan.Text = "&Laporan"
        '
        'DataBarangToolStripMenuItem
        '
        Me.DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        Me.DataBarangToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.DataBarangToolStripMenuItem.Text = "Data &Barang"
        '
        'DataKaryawanToolStripMenuItem
        '
        Me.DataKaryawanToolStripMenuItem.Name = "DataKaryawanToolStripMenuItem"
        Me.DataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.DataKaryawanToolStripMenuItem.Text = "Data &Karyawan"
        '
        'DataPenjualanToolStripMenuItem
        '
        Me.DataPenjualanToolStripMenuItem.Name = "DataPenjualanToolStripMenuItem"
        Me.DataPenjualanToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.DataPenjualanToolStripMenuItem.Text = "Data &Penjualan"
        '
        'DataPembelianToolStripMenuItem
        '
        Me.DataPembelianToolStripMenuItem.Name = "DataPembelianToolStripMenuItem"
        Me.DataPembelianToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.DataPembelianToolStripMenuItem.Text = "Data Pe&mbelian"
        '
        'DataSuplierToolStripMenuItem
        '
        Me.DataSuplierToolStripMenuItem.Name = "DataSuplierToolStripMenuItem"
        Me.DataSuplierToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.DataSuplierToolStripMenuItem.Text = "Data &Suplier"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuthorToolStripMenuItem, Me.AplikasiToolStripMenuItem})
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(80, 25)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.AuthorToolStripMenuItem.Text = "Author"
        '
        'AplikasiToolStripMenuItem
        '
        Me.AplikasiToolStripMenuItem.Name = "AplikasiToolStripMenuItem"
        Me.AplikasiToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.AplikasiToolStripMenuItem.Text = "Aplikasi"
        '
        'ToolsKeluar
        '
        Me.ToolsKeluar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutAplikasiToolStripMenuItem, Me.KeluarAplikasiToolStripMenuItem})
        Me.ToolsKeluar.Name = "ToolsKeluar"
        Me.ToolsKeluar.Size = New System.Drawing.Size(68, 25)
        Me.ToolsKeluar.Text = "&Keluar"
        '
        'LogoutAplikasiToolStripMenuItem
        '
        Me.LogoutAplikasiToolStripMenuItem.Name = "LogoutAplikasiToolStripMenuItem"
        Me.LogoutAplikasiToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.LogoutAplikasiToolStripMenuItem.Text = "Log &Off Aplikasi"
        '
        'KeluarAplikasiToolStripMenuItem
        '
        Me.KeluarAplikasiToolStripMenuItem.Name = "KeluarAplikasiToolStripMenuItem"
        Me.KeluarAplikasiToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.KeluarAplikasiToolStripMenuItem.Text = "Keluar &Aplikasi"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSUser, Me.TSWaktu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(755, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSUser
        '
        Me.TSUser.Name = "TSUser"
        Me.TSUser.Size = New System.Drawing.Size(61, 17)
        Me.TSUser.Text = "Pengguna"
        '
        'TSWaktu
        '
        Me.TSWaktu.Name = "TSWaktu"
        Me.TSWaktu.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.PenjualanTokoSepatu.My.Resources.Resources.lifestyle_5e
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(755, 447)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Penjualan Sepatu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsDataMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterSuplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsTransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSuplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSWaktu As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MerkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WarnaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSatuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuthorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
