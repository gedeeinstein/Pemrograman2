Imports MySql.Data.MySqlClient


Public Class FormLogin
    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        Dim Koneksi As MySqlConnection
        Koneksi = New MySqlConnection("server=localhost;user id=root;password=;database=db_toko_sepatu")


        Koneksi.Open()
        If Koneksi.State <> ConnectionState.Open Then
            'MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
            StatusKoneksi_Label.Text = "Not Connected"
        Else
            'MsgBox("Koneksi Berhasil..!!", MsgBoxStyle.Information, "Selamat Datang")
            StatusKoneksi_Label.Text = "Connected"
        End If

        Dim myadapter As New MySqlDataAdapter

        Dim sqlquery = "SELECT * FROM user where username='" + Trim(txtUsername.Text) + "' And password='" + Trim(txtPassword.Text) + "'"
        Dim mycommand As New MySqlCommand
        mycommand.Connection = Koneksi
        mycommand.CommandText = sqlquery

        myadapter.SelectCommand = mycommand
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()

        If mydata.HasRows = 0 Then
            MsgBox("Username atau Password Anda Salah! Hubungi Administrator", MsgBoxStyle.Exclamation, "Gagal Login")
            Call kosong()
        Else
            userlogin = txtUsername.Text
            Call kosong()
            'Me.Hide()
            FormUtama.ShowDialog()
            'FormLogin.Hide()
        End If
    End Sub

    Sub kosong()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub


    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        Me.Close()
    End Sub


    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtPassword.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Call ButtonLogin_Click(sender, e)
        End If
    End Sub



End Class