Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormMasterWarna

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblwarna As DataTable

    Sub Data_Record()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM warna")
        DGWarna.DataSource = tblwarna
        DGWarna.Columns(0).Width = 125
        DGWarna.Columns(1).Width = 180
    End Sub

    Sub Kode_Otomatis()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM warna order by kode_warna desc")

        If tblwarna.Rows.Count = 0 Then
            TxtIDWarna.Text = "WRN-001"
        Else
            With tblwarna.Rows(0)
                TxtIDWarna.Text = .Item("kode_warna")
            End With
            TxtIDWarna.Text = Val(Microsoft.VisualBasic.Mid(TxtIDWarna.Text, 5, 3)) + 1

            If Len(TxtIDWarna.Text) = 1 Then
                TxtIDWarna.Text = "WRN-00" & TxtIDWarna.Text & ""
            ElseIf Len(TxtIDWarna.Text) = 2 Then
                TxtIDWarna.Text = "WRN-0" & TxtIDWarna.Text & ""
            ElseIf Len(TxtIDWarna.Text) = 3 Then
                TxtIDWarna.Text = "WRN-" & TxtIDWarna.Text & ""
            End If
        End If
    End Sub

    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        BtnTambah.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        TxtIDWarna.Enabled = False
        TxtWarna.Text = ""
        TxtWarna.Focus()
    End Sub

    Private Sub DataSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click

        If TxtWarna.Text = "" Then
            MsgBox("Nama Warna Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Gagal")
            TxtWarna.Focus() : Exit Sub
        End If


        If MsgBox("Apakah Anda Yakin Akan Menyimpan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try

                SQL = "INSERT INTO warna VALUES ('" & TxtIDWarna.Text & "','" & TxtWarna.Text & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Warna Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If

    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        'If TxtWarna.Text = "" Then TxtWarna.Focus() : Exit Sub
        If TxtWarna.Text = "" Then
            MsgBox("Nama Warna Tidak Boleh Kosong", MsgBoxStyle.Exclamation, "Gagal")
            TxtWarna.Focus() : Exit Sub
        End If

        If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try
                SQL = "UPDATE warna set nama_warna = '" & TxtWarna.Text & "' where kode_warna ='" & TxtIDWarna.Text & "'"
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
                SQL = "DELETE FROM warna where kode_warna = '" & TxtIDWarna.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If


    End Sub
    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        If TxtWarna.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub


    Private Sub DGWarna_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGWarna.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        TxtIDWarna.Text = DGWarna.SelectedCells(0).Value
        TxtWarna.Text = DGWarna.SelectedCells(1).Value


        BtnHapus.Enabled = True
        BtnUbah.Enabled = True

        BtnTambah.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

    Private Sub TxtWarna_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtWarna.KeyPress
        'Koding Agar Tekan Enter Mau Pindah Ke Text Box Berikutnya

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