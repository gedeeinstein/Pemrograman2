<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.StatusKoneksi_Label = New System.Windows.Forms.Label()
        Me.labelNamaForm = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonBatal)
        Me.GroupBox1.Controls.Add(Me.ButtonLogin)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.icon_login
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.login_icon
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.Login
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.Delete_32x32
        resources.ApplyResources(Me.ButtonBatal, "ButtonBatal")
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.Yes
        resources.ApplyResources(Me.ButtonLogin, "ButtonLogin")
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        resources.ApplyResources(Me.txtUsername, "txtUsername")
        Me.txtUsername.Name = "txtUsername"
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'StatusKoneksi_Label
        '
        resources.ApplyResources(Me.StatusKoneksi_Label, "StatusKoneksi_Label")
        Me.StatusKoneksi_Label.Name = "StatusKoneksi_Label"
        '
        'labelNamaForm
        '
        Me.labelNamaForm.AllowDrop = True
        Me.labelNamaForm.BackColor = System.Drawing.Color.White
        Me.labelNamaForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.labelNamaForm, "labelNamaForm")
        Me.labelNamaForm.ForeColor = System.Drawing.Color.Honeydew
        Me.labelNamaForm.Image = Global.PenjualanTokoSepatu.My.Resources.Resources.BG
        Me.labelNamaForm.Name = "labelNamaForm"
        '
        'FormLogin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.StatusKoneksi_Label)
        Me.Controls.Add(Me.labelNamaForm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents labelNamaForm As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusKoneksi_Label As System.Windows.Forms.Label
End Class
