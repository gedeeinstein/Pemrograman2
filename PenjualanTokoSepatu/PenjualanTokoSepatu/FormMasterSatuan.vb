Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormMasterSatuan

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblsatuan As DataTable


    Sub Data_Record()
        tblsatuan = Proses.ExecuteQuery("SELECT * FROM satuan")
        DGSatuan.DataSource = tblsatuan
        DGSatuan.Columns(0).Width = 125
        DGSatuan.Columns(1).Width = 180
    End Sub


    Sub Kode_Otomatis()
        tblsatuan = Proses.ExecuteQuery("SELECT * FROM satuan order by kode_satuan desc")

        If tblsatuan.Rows.Count = 0 Then
            txtKodeSatuan.Text = "STN-001"
        Else
            With tblsatuan.Rows(0)
                txtKodeSatuan.Text = .Item("kode_satuan")
            End With
            txtKodeSatuan.Text = Val(Microsoft.VisualBasic.Mid(txtKodeSatuan.Text, 5, 3)) + 1

            If Len(txtKodeSatuan.Text) = 1 Then
                txtKodeSatuan.Text = "STN-00" & txtKodeSatuan.Text & ""
            ElseIf Len(txtKodeSatuan.Text) = 2 Then
                txtKodeSatuan.Text = "STN-0" & txtKodeSatuan.Text & ""
            ElseIf Len(txtKodeSatuan.Text) = 3 Then
                txtKodeSatuan.Text = "STN-" & txtKodeSatuan.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        BtnTambah.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        txtKodeSatuan.Enabled = False
        txtNamaSatuan.Text = ""
        txtNamaSatuan.Focus()
    End Sub



    Private Sub FormMasterSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()

    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If txtNamaSatuan.Text = "" Then
            MsgBox("Nama Satuan Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            txtNamaSatuan.Focus() : Exit Sub
        End If

        If MsgBox("Apakah Anda Yakin Akan Menyimpan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try

                SQL = "INSERT INTO satuan VALUES ('" & txtKodeSatuan.Text & "','" & txtNamaSatuan.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Satuan Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If

    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If txtNamaSatuan.Text = "" Then
            MsgBox("Nama Satuan Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            txtNamaSatuan.Focus() : Exit Sub

        End If


        If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                SQL = "UPDATE satuan set keterangan = '" & txtNamaSatuan.Text & "' where kode_satuan ='" & txtKodeSatuan.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil diperharui", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If

    End Sub


    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah Anda Yakin Akan Menghapus Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try

                SQL = "DELETE FROM satuan where kode_satuan = '" & txtKodeSatuan.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try

        End If

    End Sub
    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        If txtNamaSatuan.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub DGSatuan_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGSatuan.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        txtKodeSatuan.Text = DGSatuan.SelectedCells(0).Value
        txtNamaSatuan.Text = DGSatuan.SelectedCells(1).Value

        txtNamaSatuan.Focus()


        BtnHapus.Enabled = True
        BtnUbah.Enabled = True

        BtnTambah.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

    Private Sub txtNamaSatuan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaSatuan.KeyPress
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
End Class