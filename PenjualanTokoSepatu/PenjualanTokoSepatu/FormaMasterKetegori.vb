Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormaMasterKetegori

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim kategori As DataTable



    Sub Data_Record()
        kategori = Proses.ExecuteQuery("SELECT * FROM kategori")
        DGKategori.DataSource = kategori
        DGKategori.Columns(0).Width = 125
        DGKategori.Columns(1).Width = 180
    End Sub


    Sub Kode_Otomatis()
        kategori = Proses.ExecuteQuery("SELECT * FROM kategori order by kode_kategori desc")

        If kategori.Rows.Count = 0 Then
            txtKodeKategori.Text = "KTG-001"
        Else
            With kategori.Rows(0)
                txtKodeKategori.Text = .Item("kode_kategori")
            End With
            txtKodeKategori.Text = Val(Microsoft.VisualBasic.Mid(txtKodeKategori.Text, 5, 3)) + 1

            If Len(txtKodeKategori.Text) = 1 Then
                txtKodeKategori.Text = "KTG-00" & txtKodeKategori.Text & ""
            ElseIf Len(txtKodeKategori.Text) = 2 Then
                txtKodeKategori.Text = "KTG-0" & txtKodeKategori.Text & ""
            ElseIf Len(txtKodeKategori.Text) = 3 Then
                txtKodeKategori.Text = "KTG-" & txtKodeKategori.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        Call Data_Record()
        Call Kode_Otomatis()
        BtnTambah.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        txtKodeKategori.Enabled = False
        txtNamaKategori.Text = ""
        txtNamaKategori.Focus()
    End Sub



    Private Sub FormMasterSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()

    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        'If txtNamaKategori.Text = "" Then txtNamaKategori.Focus() : Exit Sub


        If txtNamaKategori.Text = "" Then
            MsgBox("Nama Ukuran Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            txtNamaKategori.Focus() : Exit Sub
        End If
        Try
            SQL = "INSERT INTO kategori VALUES ('" & txtKodeKategori.Text & "','" & txtNamaKategori.Text & "')"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data Kategori Berhasil ditambahkan", MsgBoxStyle.OkOnly, "Sukses")
            Call Atur()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        'If txtNamaKategori.Text = "" Then txtNamaKategori.Focus() : Exit Sub

        If txtNamaKategori.Text = "" Then
            MsgBox("Nama Ukuran Belum Diisi", MsgBoxStyle.Exclamation, "Gagal")
            txtNamaKategori.Focus() : Exit Sub

        End If

        Try
            SQL = "UPDATE kategori set nama_kategori = '" & txtNamaKategori.Text & "' where kode_kategori ='" & txtKodeKategori.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MsgBox("Data Berhasil Diperharui", MsgBoxStyle.OkOnly, "Sukses")
            Call Atur()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try
    End Sub


    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If MsgBox("Apakah Anda Yakin Akan Menghapus Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try
                SQL = "DELETE FROM kategori where kode_kategori = '" & txtKodeKategori.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Data Berhasil Dihapus", MsgBoxStyle.OkOnly, "Sukses")
                Call Atur()
                'End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If
    End Sub
    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        If txtNamaKategori.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub DGSatuan_CellContentClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGKategori.DoubleClick

        'Select Case Me.Text()
        '    Case "Data Warna"
        txtKodeKategori.Text = DGKategori.SelectedCells(0).Value
        txtNamaKategori.Text = DGKategori.SelectedCells(1).Value

        txtNamaKategori.Focus()


        BtnHapus.Enabled = True
        BtnUbah.Enabled = True

        BtnTambah.Enabled = False

        '    Case "Data Warna Sepatu"
        ''FormMasterBarang.CmbWarna.Text = "" & DGMerk.SelectedCells(0).Value & "/" & DGMerk.SelectedCells(1).Value & ""
        'Me.Close()
        'End Select

    End Sub

    Private Sub txtNamaKategori_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaKategori.KeyPress
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