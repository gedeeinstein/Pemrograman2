Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System

Public Class FormMasterSuplier

    Dim sql As String
    Dim Proses As New Koneksi
    Dim suplier As DataTable


    Dim Kode, Nama, Alamat, Email, Web, Cari As String
    Dim Telp As Int32

    Sub Panggil_Data()

        suplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier ORDER BY kode_supplier ASC")
        DGSuplier.DataSource = suplier
        DGSuplier.Columns(0).Width = 50
        DGSuplier.Columns(1).Width = 110
        DGSuplier.Columns(2).Width = 235
        DGSuplier.Columns(3).Width = 100
        DGSuplier.Columns(4).Width = 150
        DGSuplier.Columns(5).Width = 170

    End Sub

    Sub Data_Edit()

        suplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier where kode_supplier = '" & txtKodeSuplier.Text & "'")
        DGSuplier.DataSource = suplier
        DGSuplier.Columns(0).Width = 50
        DGSuplier.Columns(1).Width = 110
        DGSuplier.Columns(2).Width = 235
        DGSuplier.Columns(3).Width = 100
        DGSuplier.Columns(4).Width = 150
        DGSuplier.Columns(5).Width = 170

    End Sub


    Sub Kode_Supplier_Auto()
        suplier = Proses.ExecuteQuery("SELECT * FROM supplier order by kode_supplier desc")

        If suplier.Rows.Count = 0 Then
            txtKodeSuplier.Text = "SPL-001"
        Else
            With suplier.Rows(0)
                txtKodeSuplier.Text = .Item("kode_supplier")
            End With

            txtKodeSuplier.Text = Val(Microsoft.VisualBasic.Mid(txtKodeSuplier.Text, 5, 3)) + 1

            If Len(txtKodeSuplier.Text) = 1 Then
                txtKodeSuplier.Text = "SPL-00" & txtKodeSuplier.Text & ""
            ElseIf Len(txtKodeSuplier.Text) = 2 Then
                txtKodeSuplier.Text = "SPL-0" & txtKodeSuplier.Text & ""
            ElseIf Len(txtKodeSuplier.Text) = 3 Then
                txtKodeSuplier.Text = "SPL-" & txtKodeSuplier.Text & ""
            End If
        End If



    End Sub

    Sub Set_Awal()
        Call Panggil_Data()
        Call Kode_Supplier_Auto()
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        txtKodeSuplier.Enabled = False
        txtNamaSuplier.ReadOnly = False
        txtNamaSuplier.Text = ""
        txtAlamatSuplier.Text = ""
        txtTelpSuplier.Text = ""
        txtEmailSuplier.Text = ""
        txtWebSuplier.Text = ""
        txtCari.Text = ""
        cmbCari.Text = "Nama Supplier"
        txtNamaSuplier.Focus()
    End Sub

    Private Sub FormMasterSuplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Set_Awal()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtNamaSuplier.Text = "" Then
            MsgBox("Nama Supplier Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtNamaSuplier.Focus()
        ElseIf txtAlamatSuplier.Text = "" Then
            MsgBox("Alamat Supplier Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtAlamatSuplier.Focus()

        ElseIf txtTelpSuplier.Text = "" Then
            MsgBox("Silahkan Masukan No Telp Supplier", MsgBoxStyle.Exclamation, "Gagal")
            txtTelpSuplier.Focus()

        ElseIf txtEmailSuplier.Text = "" Then
            MsgBox("Data Email Tidak Boleh Kosong", MsgBoxStyle.Information, "Gagal")
            txtEmailSuplier.Focus()

        ElseIf txtWebSuplier.Text = "" Then
            MsgBox("Website Dari Supplier Tidak Boleh Kosong", MsgBoxStyle.Information, "Gagal")
            txtWebSuplier.Focus()

        Else
            'Koding Untuk Konfirmasi Yes / No

            If MsgBox("Apakah Anda Yakin Akan Menympan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                Try

                    sql = "INSERT INTO supplier (kode_supplier, nama_supplier, alamat, telepon, email, website) VALUES ('" & txtKodeSuplier.Text & "', '" & txtNamaSuplier.Text & "', '" & txtAlamatSuplier.Text & "', '" & txtTelpSuplier.Text & "', '" & txtEmailSuplier.Text & "', '" & txtWebSuplier.Text & "')"
                    'sql = "INSERT INTO supplier (kode_supplier, nama_supplier, alamat, telepon, email, website) VALUES (@Kode,@Nama,@Alamat, @Telp, @Email, @Website)"
                    'cmd.Parameters.AddWithValue("@kode", MySqlDbType.VarChar).Value = txtKodeSuplier.Text
                    'cmd.Parameters.AddWithValue("@Nama", MySqlDbType.VarChar).Value = txtNamaSuplier
                    'cmd.Parameters.AddWithValue("@Alamat", MySqlDbType.VarChar).Value = txtAlamatSuplier
                    'cmd.Parameters.AddWithValue("@Telp", MySqlDbType.Int32).Value = txtTelpSuplier
                    'cmd.Parameters.AddWithValue("@Email", MySqlDbType.VarChar).Value = txtEmailSuplier
                    'cmd.Parameters.AddWithValue("@Website", MySqlDbType.VarChar).Value = txtWebSuplier
                    Proses.ExecuteNonQuery(sql)
                    MessageBox.Show("Perubahan Data Suplier Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Set_Awal()

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try
            End If

            End If

    End Sub

    'Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click



    '    'Dim conn As New MySqlConnection
    '    'Dim cmd As New MySqlCommand
    '    Dim Cn As New MySqlConnection
    '    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
    '    Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
    '    Dim ds As New DataSet

    '    ' Dim strConnection As String
    '    'conn.ConnectionString = strConnection

    '    Try
    '        Cn.Open()
    '        'cmd.Connection = conn

    '        cmd.CommandText = "INSERT INTO supplier (kode_supplier, nama_supplier, alamat, telepon, email, website) VALUES (@Kode,@Nama,@Alamat, @Telp, @Email, @Website)"
    '        cmd.Prepare()
    '        '(@Kode,@Nama,@Alamat, @Telp, @Email, @Website)
    '        cmd.Parameters.AddWithValue("@kode", MySqlDbType.VarChar).Value = txtKodeSuplier.Text
    '        cmd.Parameters.AddWithValue("@Nama", MySqlDbType.VarChar).Value = txtNamaSuplier
    '        cmd.Parameters.AddWithValue("@Alamat", MySqlDbType.VarChar).Value = txtAlamatSuplier
    '        cmd.Parameters.AddWithValue("@Telp", MySqlDbType.Int32).Value = txtTelpSuplier
    '        cmd.Parameters.AddWithValue("@Email", MySqlDbType.VarChar).Value = txtEmailSuplier
    '        cmd.Parameters.AddWithValue("@Website", MySqlDbType.VarChar).Value = txtWebSuplier

    '        cmd.ExecuteNonQuery()
    '    Catch ex As MySqlException
    '        MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click

        If txtNamaSuplier.Text = "" Then
            MsgBox("Nama Supplier Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtNamaSuplier.Focus()
        ElseIf txtAlamatSuplier.Text = "" Then
            MsgBox("Alamat Supplier Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtAlamatSuplier.Focus()

        ElseIf txtTelpSuplier.Text = "" Then
            MsgBox("Silahkan Masukan No Telp Supplier", MsgBoxStyle.Exclamation, "Gagal")
            txtTelpSuplier.Focus()

        ElseIf txtEmailSuplier.Text = "" Then
            MsgBox("Data Email Tidak Boleh Kosong", MsgBoxStyle.Information, "Gagal")
            txtEmailSuplier.Focus()

        ElseIf txtWebSuplier.Text = "" Then
            MsgBox("Website Dari Supplier Tidak Boleh Kosong", MsgBoxStyle.Information, "Gagal")
            txtWebSuplier.Focus()

        Else
            'Koding Untuk Konfirmasi Yes / No

            If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini?", vbYesNo, "Konfirmasi") = vbYes Then
                Try
                    sql = "UPDATE supplier set nama_supplier = '" & txtNamaSuplier.Text & "', alamat = '" & txtAlamatSuplier.Text & "', telepon = '" & txtTelpSuplier.Text & "', email = '" & txtEmailSuplier.Text & "', website ='" & txtWebSuplier.Text & "' where kode_supplier = '" & txtKodeSuplier.Text & "'"
                    Proses.ExecuteNonQuery(sql)
                    MessageBox.Show("Perubahan Data Suplier Berhasil Diperbaharui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Set_Awal()


                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try

            End If
        End If

    End Sub




    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        'Konfirmasi penghapusan
        If MsgBox("Apakah anda ingin menghapus data ini ?", MsgBoxStyle.OkCancel, "Konfirmasi !") = MsgBoxResult.Ok Then
            Try
                sql = "DELETE FROM supplier WHERE kode_supplier = '" & txtKodeSuplier.Text & "'"
                Proses.ExecuteNonQuery(sql)
                MessageBox.Show("Data Sudah Dihapus...!!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Set_Awal()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If
    End Sub



    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If txtNamaSuplier.Text.Count > 0 Then
            Call Set_Awal()
            txtEmailSuplier.Text = ""
            txtTelpSuplier.Text = ""
            txtAlamatSuplier.Text = ""
            txtEmailSuplier.Text = ""
            txtWebSuplier.Text = ""
            txtCari.Text = ""

        ElseIf txtNamaSuplier.Focus Then
            Me.Close()
        Else
            End
        End If
    End Sub


    Private Sub DGSuplier_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGSuplier.DoubleClick
        txtKodeSuplier.Text = DGSuplier.SelectedCells(0).Value
        txtNamaSuplier.Text = DGSuplier.SelectedCells(1).Value
        txtAlamatSuplier.Text = DGSuplier.SelectedCells(2).Value
        txtTelpSuplier.Text = DGSuplier.SelectedCells(3).Value
        txtEmailSuplier.Text = DGSuplier.SelectedCells(4).Value
        txtWebSuplier.Text = DGSuplier.SelectedCells(5).Value

        txtNamaSuplier.Focus()

        btnUbah.Enabled = True
        btnHapus.Enabled = True
        btnSimpan.Enabled = False
        Call Data_Edit()
    End Sub


    Private Sub txtCari_KeyPress(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged

        'Kode = txtKodeSuplier.Text
        'Nama = txtNamaSuplier.Text
        'Alamat = txtAlamatSuplier.Text
        'Telp = Val(txtTelpSuplier.Text)
        'Email = txtEmailSuplier.Text
        'Web = txtWebSuplier.Text
        'Cari = txtCari.Text

        'txtCari.Text = Cari

        If cmbCari.SelectedItem = "Nama Supplier" Then
            suplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier where nama_supplier like '%" & txtCari.Text & "%' order by kode_supplier asc")
            DGSuplier.DataSource = suplier
            txtCari.Focus()
        ElseIf cmbCari.SelectedItem = "Kode Supplier" Then
            suplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier where kode_supplier like '%" & txtCari.Text & "%' order by kode_supplier asc")
            DGSuplier.DataSource = suplier
            txtCari.Focus()
        ElseIf cmbCari.SelectedItem = "Telepon" Then
            suplier = Proses.ExecuteQuery("SELECT kode_supplier AS 'Kode', nama_supplier AS 'Nama', alamat AS 'ALAMAT', telepon AS 'No. Telp', email AS 'Email', website AS 'Website' FROM supplier where telepon like '%" & txtCari.Text & "%' order by kode_supplier asc")
            DGSuplier.DataSource = suplier
            txtCari.Focus()
        End If
    End Sub

    Private Sub txtCari_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtCari.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            'MsgBox("Masukan Pencarian Tanpa Menggunakan Enter")
            Call DGSuplier_DoubleClick(sender, e)
            txtCari.Text = ""
            txtNamaSuplier.Focus()
        End If
    End Sub

    Private Sub txtNamaSuplier_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaSuplier.KeyDown
        txtAlamatSuplier.Focus()
    End Sub

    Private Sub txtAlamatSuplier_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlamatSuplier.KeyDown
        txtTelpSuplier.Focus()
    End Sub

    Private Sub txtTelpSuplier_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelpSuplier.KeyDown
        txtEmailSuplier.Focus()

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Label9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMinimize_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseHover
        btnMinimize.BackColor = Color.Gray
    End Sub

    Private Sub btnMinimize_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub btnExit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseHover
        btnExit.BackColor = Color.Red
    End Sub

    Private Sub btnExit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub txtNamaSuplier_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaSuplier.KeyPress
        'Koding Agar Tekan Enter Mau Pindah Ke Text Box Berikutnya
        If Asc(e.KeyChar) = 13 Then
            txtAlamatSuplier.Focus()
        End If
    End Sub

    Private Sub txtAlamatSuplier_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlamatSuplier.KeyPress
        'Koding Agar Tekan Enter Mau Pindah Ke Text Box Berikutnya
        If Asc(e.KeyChar) = 13 Then
            txtTelpSuplier.Focus()
        End If
    End Sub

    Private Sub txtTelpSuplier_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelpSuplier.KeyPress
        'Koding Agar Tekan Enter Mau Pindah Ke Text Box Berikutnya
        If Asc(e.KeyChar) = 13 Then
            txtEmailSuplier.Focus()
        End If

        If (Not Char.IsControl(e.KeyChar) _
 AndAlso (Not Char.IsDigit(e.KeyChar) _
 AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmailSuplier_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmailSuplier.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtWebSuplier.Focus()
        End If
    End Sub

    Private Sub txtWebSuplier_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWebSuplier.KeyPress

        If btnSimpan.Enabled = True Then
            If Asc(e.KeyChar) = 13 Then
                btnSimpan_Click(sender, e)
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                btnUbah_Click(sender, e)
            End If
        End If

    End Sub
End Class