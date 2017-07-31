Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms


Public Class FormMasterUser
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblwarna As DataTable

    Sub Data_Record()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM warna")
        DGUser.DataSource = tblwarna
        DGUser.Columns(0).Width = 125
        DGUser.Columns(1).Width = 180
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub FormMasterUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click

    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click

    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click

    End Sub

    Private Sub DGUser_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGUser.DoubleClick

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If BtnTambah.Enabled = True Then
            If Asc(e.KeyChar) = 13 Then
                BtnTambah_Click(sender, e)
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                BtnUbah_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNik.SelectedIndexChanged
        txtUserName.Focus()


    End Sub
End Class