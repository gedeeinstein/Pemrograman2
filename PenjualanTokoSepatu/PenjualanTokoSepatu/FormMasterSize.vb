Public Class FormMasterSize

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim ukuran As DataTable


    Sub Baca_Data()
        ukuran = Proses.ExecuteQuery("SELECT * FROM size")
        DGUkuran.DataSource = ukuran
        DGUkuran.Columns(0).Width = 152
        DGUkuran.Columns(1).Width = 151
    End Sub


    Sub Kode_Ukuran_Auto()
        ukuran = Proses.ExecuteQuery("SELECT * FROM size order by kode_size desc")

        If ukuran.Rows.Count = 0 Then
            txtKodeUkuran.Text = "SZ-001"
        Else
            With ukuran.Rows(0)
                txtKodeUkuran.Text = .Item("kode_size")
            End With
            txtKodeUkuran.Text = Val(Microsoft.VisualBasic.Mid(txtKodeUkuran.Text, 5, 3)) + 1

            If Len(txtKodeUkuran.Text) = 1 Then
                txtKodeUkuran.Text = "SZ-00" & txtKodeUkuran.Text & ""
            ElseIf Len(txtKodeUkuran.Text) = 2 Then
                txtKodeUkuran.Text = "SZ-0" & txtKodeUkuran.Text & ""
            ElseIf Len(txtKodeUkuran.Text) = 3 Then
                txtKodeUkuran.Text = "SZ-" & txtKodeUkuran.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        Call Baca_Data()
        Call Kode_Ukuran_Auto()

        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        txtKodeUkuran.Enabled = False
        txtUkuran.Text = ""
        txtUkuran.Focus()

    End Sub

    Private Sub FormMasterSize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call Baca_Data()

        Call Atur()

    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        If txtUkuran.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If
    End Sub


    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah Anda Yakin Akan Menghapus Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            SQL = "DELETE FROM size where kode_size = '" & txtKodeUkuran.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data berhasil dihapus", MsgBoxStyle.OkOnly, "Sukses")
            Call Atur()
        End If

    End Sub


    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        'If txtUkuran.Text = "" Then txtUkuran.Focus() : Exit Sub
        If txtUkuran.Text = "" Then
            txtUkuran.Focus() : Exit Sub
            MsgBox("Nama Ukuran Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
        End If


        If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try

                SQL = "UPDATE size set nama_size = '" & txtUkuran.Text & "' where kode_size ='" & txtKodeUkuran.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil diperharui", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If


    End Sub


    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        'If txtUkuran.Text = "" Then txtUkuran.Focus() : Exit Sub
        If txtUkuran.Text = "" Then MsgBox("Nama Ukuran Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
        txtUkuran.Focus() : Exit Sub

        If MsgBox("Apakah Anda Yakin Akan Menambah Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                SQL = "INSERT INTO size VALUES ('" & txtKodeUkuran.Text & "','" & txtUkuran.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If

    End Sub

    Private Sub DGUkuran_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGUkuran.DoubleClick
        'Select Case Me.Text()
        '    Case "Data Ukuran"
        txtKodeUkuran.Text = DGUkuran.SelectedCells(0).Value
        txtUkuran.Text = DGUkuran.SelectedCells(1).Value

        txtUkuran.Focus()

        BtnUbah.Enabled = True
        BtnHapus.Enabled = True
        BtnSimpan.Enabled = False
        '    Case "Data Ukuran Sepatu"
        ''FormMasterBarang.CmbUkuran.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select
    End Sub

    Private Sub txtUkuran_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUkuran.KeyPress

        If BtnSimpan.Enabled = True Then

            If Asc(e.KeyChar) = 13 Then
                BtnTambah_Click(sender, e)
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                BtnUbah_Click(sender, e)
            End If
        End If


    End Sub
End Class