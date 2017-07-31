Imports System.Data.Odbc

Public Class FormKaryawan

    Private PathFile As String = Nothing
    Dim sql As String
    Dim Proses As New Koneksi
    Dim karyawan As DataTable

    Sub Data_Record()
        karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan ORDER BY nik ASC")
        DGKaryawan.DataSource = karyawan
        DGKaryawan.Columns(0).Width = 50
        DGKaryawan.Columns(1).Width = 170
        DGKaryawan.Columns(2).Width = 70
        DGKaryawan.Columns(3).Width = 80
        DGKaryawan.Columns(4).Width = 80
        DGKaryawan.Columns(5).Width = 170
        DGKaryawan.Columns(6).Width = 100
    End Sub


    Sub Data_Edit()
        karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan where nik ='" & txtNIK.Text & "'")
        DGKaryawan.DataSource = karyawan
        DGKaryawan.Columns(0).Width = 50
        DGKaryawan.Columns(1).Width = 170
        DGKaryawan.Columns(2).Width = 70
        DGKaryawan.Columns(3).Width = 80
        DGKaryawan.Columns(4).Width = 80
        DGKaryawan.Columns(5).Width = 170
        DGKaryawan.Columns(6).Width = 100
    End Sub

    Sub Kode_Otomatis()

        'nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan
        karyawan = Proses.ExecuteQuery("SELECT * FROM karyawan order by nik desc")

        'karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan order by nik desc")

        If karyawan.Rows.Count = 0 Then
            txtNIK.Text = "NIK-001"
        Else
            With karyawan.Rows(0)
                txtNIK.Text = .Item("nik")
            End With

            txtNIK.Text = Val(Microsoft.VisualBasic.Mid(txtNIK.Text, 5, 3)) + 1

            If Len(txtNIK.Text) = 1 Then
                txtNIK.Text = "NIK-00" & txtNIK.Text & ""
            ElseIf Len(txtNIK.Text) = 2 Then
                txtNIK.Text = "NIK-0" & txtNIK.Text & ""
            ElseIf Len(txtNIK.Text) = 3 Then
                txtNIK.Text = "NIK-" & txtNIK.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
        txtNIK.Enabled = False
        txtNamaKaryawan.ReadOnly = False
        txtNamaKaryawan.Text = ""
        txtAlamat.Text = ""
        txtNoTelp.Text = ""
        Tgl_Lahir.Text = Format(Now, "")
        txtTempatLahir.Text = ""
        txtCari.Text = ""
        cmbCari.Text = "Nama Karyawan"
        txtNamaKaryawan.Focus()
    End Sub


    Private Sub FormKaryawan_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()

    End Sub


    Private Sub btnSimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click

        Dim tgl = Format(Tgl_Lahir.Value.Date, "yyyy-MM-dd")

        If txtNamaKaryawan.Text = "" Then
            MsgBox("Nama Karyawan Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtNamaKaryawan.Focus()
        ElseIf txtAlamat.Text = "" Then
            MsgBox("Alamat Karyawan Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtAlamat.Focus()

        ElseIf cmbJenisKelamin.Text = "" Then
            MsgBox("Silahkan Pilih Jenis Kelamin", MsgBoxStyle.Exclamation, "Gagal")
            cmbJenisKelamin.Focus()

        ElseIf txtTempatLahir.Text = "" Then
            MsgBox("Tempat Lahir Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Gagal")
            txtTempatLahir.Focus()

        ElseIf Tgl_Lahir.Text = Format(Now, ) Then
            MsgBox("Pilih tanggal lahir karyawan")
            Tgl_Lahir.Focus()

        ElseIf txtNoTelp.Text = "" Then
            MsgBox("Nomor Telepon Tidak Boleh Kosong", MsgBoxStyle.Critical, "error")
            txtNoTelp.Focus()

        Else

            If MsgBox("Apakah Anda Yakin Akan Menyimpan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

                Try
                    sql = "insert into karyawan (nik, nama, jenis_kelamin, tempat_lahir, tanggal_lahir, alamat, no_telepon) values ( '" & txtNIK.Text & "','" & txtNamaKaryawan.Text & "','" & cmbJenisKelamin.Text & "','" & txtTempatLahir.Text & "','" & tgl & "', '" & txtAlamat.Text & "','" & txtNoTelp.Text & "')"
                    Proses.ExecuteNonQuery(sql)
                    MessageBox.Show("data baru telah disimpan..!!", "penyimpanan sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Atur()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try
            End If

        End If

    End Sub


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim tgl = Format(Tgl_Lahir.Value.Date, "yyyy-MM-dd")

        If txtNamaKaryawan.Text = "" Then
            MsgBox("Nama Karyawan Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtNamaKaryawan.Focus()
        ElseIf txtAlamat.Text = "" Then
            MsgBox("Alamat Karyawan Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtAlamat.Focus()

        ElseIf cmbJenisKelamin.Text = "" Then
            MsgBox("Silahkan Pilih Jenis Kelamin", MsgBoxStyle.Exclamation, "Gagal")
            cmbJenisKelamin.Focus()

        ElseIf txtTempatLahir.Text = "" Then
            MsgBox("Tempat Lahir Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Gagal")
            txtTempatLahir.Focus()

        ElseIf Tgl_Lahir.Text = Format(Now, ) Then
            MsgBox("Pilih tanggal lahir karyawan")
            Tgl_Lahir.Focus()

        ElseIf txtNoTelp.Text = "" Then
            MsgBox("Nomor Telepon Tidak Boleh Kosong", MsgBoxStyle.Critical, "error")
            txtNoTelp.Focus()

        Else
            If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                Try
                sql = "UPDATE karyawan set nama = '" & txtNamaKaryawan.Text & "', jenis_kelamin = '" & cmbJenisKelamin.Text & "', tempat_lahir = '" & txtTempatLahir.Text & "', tanggal_lahir = '" & tgl & "', alamat ='" & txtAlamat.Text & "', no_telepon ='" & txtNoTelp.Text & "' where nik = '" & txtNIK.Text & "'"
                Proses.ExecuteNonQuery(sql)
                MessageBox.Show("Data sudah diperbaiki...!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Atur()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try
            End If

        End If

            'sql = "UPDATE karyawan set nama = '" & txtNamaKaryawan.Text & "', jenis_kelamin = '" & cmbJenisKelamin.Text & "', tempat_lahir = '" & txtTempatLahir.Text & "', tanggal_lahir = '" & tgl & "', alamat ='" & txtAlamat.Text & "', no_telepon ='" & txtNoTelp.Text & "' where nik = '" & txtNIK.Text & "'"
            '    Proses.ExecuteNonQuery(sql)
            '    MessageBox.Show("Data sudah diperbaiki...!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Call Atur()

    End Sub



    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        'Konfirmasi penghapusan
        If MsgBox("Apakah anda ingin menghapus data ini ?", MsgBoxStyle.OkCancel, "Konfirmasi !") = MsgBoxResult.Ok Then
            Try

                sql = "DELETE FROM karyawan WHERE nik = '" & txtNIK.Text & "'; "
                Proses.ExecuteNonQuery(sql)
                MessageBox.Show("Data sudah dihapus...!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If
    End Sub



    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If txtNamaKaryawan.Text.Count > 0 Then
            Call Atur()
            txtNoTelp.Text = ""
            txtAlamat.Text = ""
            txtTempatLahir.Text = ""
            Format(Tgl_Lahir.Value, "YYYY-MM-DD")
        ElseIf txtNamaKaryawan.Focus Then
            Me.Close()
        Else
            End
        End If
    End Sub



    Private Sub DGKaryawan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGKaryawan.DoubleClick
        txtNIK.Text = DGKaryawan.SelectedCells(0).Value
        txtNamaKaryawan.Text = DGKaryawan.SelectedCells(1).Value
        cmbJenisKelamin.Text = DGKaryawan.SelectedCells(2).Value
        txtTempatLahir.Text = DGKaryawan.SelectedCells(3).Value
        Tgl_Lahir.Value = DGKaryawan.SelectedCells(4).Value
        txtAlamat.Text = DGKaryawan.SelectedCells(5).Value
        txtNoTelp.Text = DGKaryawan.SelectedCells(6).Value
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        btnSimpan.Enabled = False
        txtNamaKaryawan.Focus()
        Call Data_Edit()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCari_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged

        If cmbCari.SelectedItem = "Nama Karyawan" Then
            karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan where nama like '%" & txtCari.Text & "%' order by nik asc")
            DGKaryawan.DataSource = karyawan
            txtCari.Focus()
        ElseIf cmbCari.SelectedItem = "NIK" Then
            karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan where NIK like '%" & txtCari.Text & "%' order by nik asc")
            DGKaryawan.DataSource = karyawan
            txtCari.Focus()
        ElseIf cmbCari.SelectedItem = "No Telepon" Then
            karyawan = Proses.ExecuteQuery("SELECT nik as 'NIK', nama as 'NAMA', jenis_kelamin as 'JK', tempat_lahir as 'TEMPAT LAHIR', tanggal_lahir as 'TGL LAHIR', alamat as 'ALAMAT', no_telepon as 'No. Telp' FROM karyawan where no_telepon like '%" & txtCari.Text & "%' order by nik asc")
            DGKaryawan.DataSource = karyawan
            txtCari.Focus()
        End If


    End Sub

    Private Sub txtCari_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtCari.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            'MsgBox("Masukan Pencarian Tanpa Menggunakan Enter")
            Call DGKaryawan_DoubleClick(sender, e)
            txtCari.Text = ""
            txtNamaKaryawan.Focus()
        End If
    End Sub

    Private Sub txtNamaKaryawan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaKaryawan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbJenisKelamin.Focus()
        End If
    End Sub

    Private Sub cmbJenisKelamin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJenisKelamin.SelectedIndexChanged
        txtTempatLahir.Focus()

    End Sub

    Private Sub txtTempatLahir_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempatLahir.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Tgl_Lahir.Focus()
        End If
    End Sub

    Private Sub txtAlamat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlamat.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNoTelp.Focus()
        End If
    End Sub

    Private Sub txtNoTelp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
     AndAlso (Not Char.IsDigit(e.KeyChar) _
     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If btnSimpan.Enabled = True Then
            If Asc(e.KeyChar) = 13 Then
                btnSimpan.Focus()
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                btnEdit.Focus()
            End If
        End If



    End Sub

    Private Sub btnSimpan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnSimpan.KeyPress

        If btnSimpan.Enabled = True Then
            If Asc(e.KeyChar) = 13 Then
                btnSimpan_Click_1(sender, e)
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                btnEdit_Click(sender, e)

            End If
        End If

    End Sub
End Class