<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterSize
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterSize))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUkuran = New System.Windows.Forms.TextBox()
        Me.txtKodeUkuran = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.DGUkuran = New System.Windows.Forms.DataGridView()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        CType(Me.DGUkuran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.ForestGreen
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(381, 57)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Data Ukuran"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUkuran
        '
        Me.txtUkuran.Location = New System.Drawing.Point(80, 117)
        Me.txtUkuran.Name = "txtUkuran"
        Me.txtUkuran.Size = New System.Drawing.Size(278, 20)
        Me.txtUkuran.TabIndex = 3
        '
        'txtKodeUkuran
        '
        Me.txtKodeUkuran.Location = New System.Drawing.Point(80, 91)
        Me.txtKodeUkuran.Name = "txtKodeUkuran"
        Me.txtKodeUkuran.Size = New System.Drawing.Size(278, 20)
        Me.txtKodeUkuran.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(19, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(19, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Size"
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.close_24
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(294, 407)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.BtnBatal.Size = New System.Drawing.Size(75, 34)
        Me.BtnBatal.TabIndex = 21
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'DGUkuran
        '
        Me.DGUkuran.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGUkuran.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGUkuran.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGUkuran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUkuran.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGUkuran.Location = New System.Drawing.Point(7, 163)
        Me.DGUkuran.Name = "DGUkuran"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGUkuran.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGUkuran.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGUkuran.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGUkuran.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGUkuran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGUkuran.Size = New System.Drawing.Size(368, 237)
        Me.DGUkuran.TabIndex = 17
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.remove_button_20
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(200, 407)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Padding = New System.Windows.Forms.Padding(2, 0, 5, 0)
        Me.BtnHapus.Size = New System.Drawing.Size(75, 34)
        Me.BtnHapus.TabIndex = 20
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(6, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(368, 97)
        Me.Label4.TabIndex = 22
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.edit_button_20
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(106, 407)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Padding = New System.Windows.Forms.Padding(4, 0, 6, 1)
        Me.BtnUbah.Size = New System.Drawing.Size(75, 34)
        Me.BtnUbah.TabIndex = 19
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnSimpan.FlatAppearance.BorderSize = 0
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.floppy_20
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(12, 407)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 34)
        Me.BtnSimpan.TabIndex = 18
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'FormMasterSize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(381, 449)
        Me.Controls.Add(Me.txtUkuran)
        Me.Controls.Add(Me.txtKodeUkuran)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGUkuran)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMasterSize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data Ukuran"
        CType(Me.DGUkuran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUkuran As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeUkuran As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents DGUkuran As System.Windows.Forms.DataGridView
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
