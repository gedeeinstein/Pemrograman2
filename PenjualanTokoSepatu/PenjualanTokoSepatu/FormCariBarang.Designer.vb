<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariBarang
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.RbMerk = New System.Windows.Forms.RadioButton()
        Me.RbNama = New System.Windows.Forms.RadioButton()
        Me.RbKategori = New System.Windows.Forms.RadioButton()
        Me.RbUkuran = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.lbl_totalbarang = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGBarang
        '
        Me.DGBarang.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGBarang.Location = New System.Drawing.Point(3, 126)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBarang.Size = New System.Drawing.Size(968, 204)
        Me.DGBarang.TabIndex = 32
        '
        'txtCari
        '
        Me.txtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(461, 28)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.txtCari.MaximumSize = New System.Drawing.Size(400, 35)
        Me.txtCari.MinimumSize = New System.Drawing.Size(200, 28)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(295, 26)
        Me.txtCari.TabIndex = 16
        Me.txtCari.WordWrap = False
        '
        'RbMerk
        '
        Me.RbMerk.AutoSize = True
        Me.RbMerk.Location = New System.Drawing.Point(313, 33)
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
        Me.RbNama.Location = New System.Drawing.Point(128, 33)
        Me.RbNama.Name = "RbNama"
        Me.RbNama.Size = New System.Drawing.Size(101, 17)
        Me.RbNama.TabIndex = 19
        Me.RbNama.TabStop = True
        Me.RbNama.Text = "&Nama Sepatu"
        Me.RbNama.UseVisualStyleBackColor = True
        '
        'RbKategori
        '
        Me.RbKategori.AutoSize = True
        Me.RbKategori.Location = New System.Drawing.Point(235, 33)
        Me.RbKategori.Name = "RbKategori"
        Me.RbKategori.Size = New System.Drawing.Size(72, 17)
        Me.RbKategori.TabIndex = 21
        Me.RbKategori.TabStop = True
        Me.RbKategori.Text = "&Kategori"
        Me.RbKategori.UseVisualStyleBackColor = True
        '
        'RbUkuran
        '
        Me.RbUkuran.AutoSize = True
        Me.RbUkuran.Location = New System.Drawing.Point(372, 33)
        Me.RbUkuran.Name = "RbUkuran"
        Me.RbUkuran.Size = New System.Drawing.Size(66, 17)
        Me.RbUkuran.TabIndex = 22
        Me.RbUkuran.TabStop = True
        Me.RbUkuran.Text = "&Ukuran"
        Me.RbUkuran.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.RbUkuran)
        Me.GroupBox2.Controls.Add(Me.RbKategori)
        Me.GroupBox2.Controls.Add(Me.RbMerk)
        Me.GroupBox2.Controls.Add(Me.RbNama)
        Me.GroupBox2.Controls.Add(Me.txtCari)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox2.Location = New System.Drawing.Point(3, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(968, 77)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Turquoise
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(775, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "&Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPilih.FlatAppearance.BorderSize = 0
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.Yes
        Me.btnPilih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPilih.Location = New System.Drawing.Point(657, 336)
        Me.btnPilih.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnPilih.Size = New System.Drawing.Size(102, 41)
        Me.btnPilih.TabIndex = 35
        Me.btnPilih.Text = "&Select"
        Me.btnPilih.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.SkyBlue
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.ForeColor = System.Drawing.Color.Black
        Me.btnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.Delete_32x32
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(778, 336)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(0, 0, 18, 0)
        Me.btnBatal.Size = New System.Drawing.Size(102, 41)
        Me.btnBatal.TabIndex = 38
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'lbl_totalbarang
        '
        Me.lbl_totalbarang.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalbarang.Location = New System.Drawing.Point(182, 338)
        Me.lbl_totalbarang.Name = "lbl_totalbarang"
        Me.lbl_totalbarang.Size = New System.Drawing.Size(198, 36)
        Me.lbl_totalbarang.TabIndex = 41
        Me.lbl_totalbarang.Text = "Null"
        Me.lbl_totalbarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 36)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Jumlah Barang"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(297, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 32)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Filter Pencarian Barang"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 401)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_totalbarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCariBarang"
        Me.Text = "FormCariBarang"
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Public WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents RbMerk As System.Windows.Forms.RadioButton
    Friend WithEvents RbNama As System.Windows.Forms.RadioButton
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents RbKategori As System.Windows.Forms.RadioButton
    Friend WithEvents RbUkuran As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_totalbarang As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
