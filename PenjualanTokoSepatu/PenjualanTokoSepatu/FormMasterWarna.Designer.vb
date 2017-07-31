<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterWarna
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterWarna))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtWarna = New System.Windows.Forms.TextBox()
        Me.TxtIDWarna = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGWarna = New System.Windows.Forms.DataGridView()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGWarna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Warna"
        '
        'TxtWarna
        '
        Me.TxtWarna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtWarna.Location = New System.Drawing.Point(65, 55)
        Me.TxtWarna.Name = "TxtWarna"
        Me.TxtWarna.Size = New System.Drawing.Size(284, 20)
        Me.TxtWarna.TabIndex = 3
        '
        'TxtIDWarna
        '
        Me.TxtIDWarna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIDWarna.Location = New System.Drawing.Point(65, 29)
        Me.TxtIDWarna.Name = "TxtIDWarna"
        Me.TxtIDWarna.Size = New System.Drawing.Size(284, 20)
        Me.TxtIDWarna.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 57)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Data Warna"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.TxtWarna)
        Me.GroupBox1.Controls.Add(Me.TxtIDWarna)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightYellow
        Me.GroupBox1.Location = New System.Drawing.Point(6, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 97)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Warna"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Warna"
        '
        'DGWarna
        '
        Me.DGWarna.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGWarna.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGWarna.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWarna.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGWarna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGWarna.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGWarna.GridColor = System.Drawing.Color.DimGray
        Me.DGWarna.Location = New System.Drawing.Point(6, 160)
        Me.DGWarna.Name = "DGWarna"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWarna.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGWarna.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGWarna.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGWarna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGWarna.Size = New System.Drawing.Size(368, 237)
        Me.DGWarna.TabIndex = 24
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.remove_button_20
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(194, 403)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.BtnHapus.Size = New System.Drawing.Size(75, 34)
        Me.BtnHapus.TabIndex = 27
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.pencil_20
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(104, 403)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnUbah.Size = New System.Drawing.Size(75, 34)
        Me.BtnUbah.TabIndex = 26
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.close_24
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(285, 403)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.BtnBatal.Size = New System.Drawing.Size(75, 34)
        Me.BtnBatal.TabIndex = 28
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.floppy_20
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(15, 403)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BtnTambah.Size = New System.Drawing.Size(75, 34)
        Me.BtnTambah.TabIndex = 25
        Me.BtnTambah.Text = "Simpan"
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'FormMasterWarna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(381, 449)
        Me.Controls.Add(Me.DGWarna)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnTambah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterWarna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Warna Sepatu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGWarna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents TxtWarna As System.Windows.Forms.TextBox
    Friend WithEvents TxtIDWarna As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents DGWarna As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
