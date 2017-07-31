<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterMerk
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtMerk = New System.Windows.Forms.TextBox()
        Me.TxtIDMerk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGMerk = New System.Windows.Forms.DataGridView()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gold
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 57)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Data Merk"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.TxtMerk)
        Me.GroupBox1.Controls.Add(Me.TxtIDMerk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightYellow
        Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 94)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Merk"
        '
        'TxtMerk
        '
        Me.TxtMerk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtMerk.Location = New System.Drawing.Point(65, 55)
        Me.TxtMerk.Name = "TxtMerk"
        Me.TxtMerk.Size = New System.Drawing.Size(284, 20)
        Me.TxtMerk.TabIndex = 3
        '
        'TxtIDMerk
        '
        Me.TxtIDMerk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIDMerk.Location = New System.Drawing.Point(65, 29)
        Me.TxtIDMerk.Name = "TxtIDMerk"
        Me.TxtIDMerk.Size = New System.Drawing.Size(284, 20)
        Me.TxtIDMerk.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Merk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Merk"
        '
        'DGMerk
        '
        Me.DGMerk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGMerk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMerk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGMerk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMerk.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGMerk.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGMerk.GridColor = System.Drawing.Color.DimGray
        Me.DGMerk.Location = New System.Drawing.Point(0, 151)
        Me.DGMerk.Name = "DGMerk"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGMerk.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGMerk.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGMerk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGMerk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMerk.Size = New System.Drawing.Size(381, 237)
        Me.DGMerk.TabIndex = 25
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.SystemColors.Control
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.remove_button_20
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(200, 403)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.BtnHapus.Size = New System.Drawing.Size(75, 34)
        Me.BtnHapus.TabIndex = 31
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.SystemColors.Control
        Me.BtnUbah.FlatAppearance.BorderSize = 0
        Me.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUbah.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.pencil_20
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(106, 403)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnUbah.Size = New System.Drawing.Size(75, 34)
        Me.BtnUbah.TabIndex = 30
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.SystemColors.Control
        Me.BtnBatal.FlatAppearance.BorderSize = 0
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.close_24
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(294, 403)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.BtnBatal.Size = New System.Drawing.Size(75, 34)
        Me.BtnBatal.TabIndex = 32
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.SystemColors.Control
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.floppy_20
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(12, 403)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BtnTambah.Size = New System.Drawing.Size(75, 34)
        Me.BtnTambah.TabIndex = 29
        Me.BtnTambah.Text = "Simpan"
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'FormMasterMerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(381, 449)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DGMerk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMasterMerk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Master Data Merk"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGMerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMerk As System.Windows.Forms.TextBox
    Friend WithEvents TxtIDMerk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGMerk As System.Windows.Forms.DataGridView
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
End Class
