<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGUser = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNik = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        CType(Me.DGUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'DGUser
        '
        Me.DGUser.BackgroundColor = System.Drawing.Color.White
        Me.DGUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUser.GridColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Me.DGUser, "DGUser")
        Me.DGUser.Name = "DGUser"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'cmbNik
        '
        Me.cmbNik.FormattingEnabled = True
        resources.ApplyResources(Me.cmbNik, "cmbNik")
        Me.cmbNik.Name = "cmbNik"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtUserName
        '
        resources.ApplyResources(Me.txtUserName, "txtUserName")
        Me.txtUserName.Name = "txtUserName"
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbNik)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkTurquoise
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.remove_button_20
        resources.ApplyResources(Me.BtnHapus, "BtnHapus")
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.pencil_20
        resources.ApplyResources(Me.BtnUbah, "BtnUbah")
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.close_24
        resources.ApplyResources(Me.BtnBatal, "BtnBatal")
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.floppy_20
        resources.ApplyResources(Me.BtnTambah, "BtnTambah")
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'FormMasterUser
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGUser)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FormMasterUser"
        CType(Me.DGUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGUser As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNik As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
End Class
