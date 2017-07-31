
Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormMasterMerk


    Dim SQL As String
    Dim Proses As New Koneksi
    Dim tblwarna As DataTable

    Sub Data_Record()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM merk")
        DGMerk.DataSource = tblwarna
        DGMerk.Columns(0).Width = 125
        DGMerk.Columns(1).Width = 180
    End Sub

    Sub Kode_Otomatis()
        tblwarna = Proses.ExecuteQuery("SELECT * FROM merk order by kode_merk desc")

        If tblwarna.Rows.Count = 0 Then
            TxtIDMerk.Text = "MRK-001"
        Else
            With tblwarna.Rows(0)
                TxtIDMerk.Text = .Item("kode_merk")
            End With
            TxtIDMerk.Text = Val(Microsoft.VisualBasic.Mid(TxtIDMerk.Text, 5, 3)) + 1

            If Len(TxtIDMerk.Text) = 1 Then
                TxtIDMerk.Text = "MRK-00" & TxtIDMerk.Text & ""
            ElseIf Len(TxtIDMerk.Text) = 2 Then
                TxtIDMerk.Text = "MRK-0" & TxtIDMerk.Text & ""
            ElseIf Len(TxtIDMerk.Text) = 3 Then
                TxtIDMerk.Text = "MRK-" & TxtIDMerk.Text & ""
            End If
        End If
    End Sub

    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        BtnTambah.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        TxtIDMerk.Enabled = False
        TxtMerk.Text = ""
        TxtMerk.Focus()
    End Sub

    Private Sub DataSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click

        If TxtMerk.Text = "" Then
            MsgBox("Nama Merk Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            TxtMerk.Focus()
        Else

            If MsgBox("Apakah Anda Yakin Akan Menyimpan Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                Try
                    SQL = "INSERT INTO merk VALUES ('" & TxtIDMerk.Text & "','" & TxtMerk.Text & "')"
                    Proses.ExecuteNonQuery(SQL)
                    MsgBox("Data Warna Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
                    Call Atur()


                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
                End Try
            End If
        End If

    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        'If TxtMerk.Text = "" Then TxtMerk.Focus() : Exit Sub

        If TxtMerk.Text = "" Then

            MsgBox("Nama Satuan Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            TxtMerk.Focus() : Exit Sub
        End If

        If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
            Try
                SQL = "UPDATE merk set nama_merk = '" & TxtMerk.Text & "' where kode_MERK ='" & TxtIDMerk.Text & "'"
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
                SQL = "DELETE FROM merk where kode_merk = '" & TxtIDMerk.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data berhasil dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()


            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If


    End Sub
    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        If TxtMerk.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub


    Private Sub DGWarna_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGMerk.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        TxtIDMerk.Text = DGMerk.SelectedCells(0).Value
        TxtMerk.Text = DGMerk.SelectedCells(1).Value

        TxtMerk.Focus()


        BtnHapus.Enabled = True
        BtnUbah.Enabled = True

        BtnTambah.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

    Private Sub TxtWarna_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMerk.KeyPress
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