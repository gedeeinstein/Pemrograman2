Imports vb = Microsoft.VisualBasic


Public Class FormMasterBarang
    Dim SQL As String
    Dim Proses As New Koneksi
    Dim barang As DataTable
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer


    Public Sub singleqoute()
        Dim ctrl As Control
        Dim txt As TextBox

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is TextBox Then
                txt = CType(ctrl, TextBox)
                txt.Text = Replace(txt.Text, "'", "''")
            End If
        Next

    End Sub

    Sub Data_Record()
        'barang = Proses.ExecuteQuery("SELECT * FROM barang")
        'tblbarang = Proses.ExecuteQuery("SELECT tblbarang.id_barang, tblbarang.nm_barang, tblmerk.merk, tblsatuan.satuan, tblbarang.hrg_beli, tblbarang.hrg_jual, tblbarang.stock FROM tblbarang INNER JOIN tblmerk INNER JOIN tblsatuan ON tblbarang.merk_barang = tblmerk.id_merk AND tblsatuan.id_satuan = tblbarang.satuan")

        barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                     & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                     & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                     & "FROM barang " _
                                     & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                     & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                     & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                     & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                     & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan ORDER BY kode_barang ASC")

        'barang = Proses.ExecuteQuery("SELECT * From Barang ORDER BY kode_barang ASC")

        'barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'KD BRG', barang.nama_barang AS 'NAMA BRG', kategori.nama_kategori AS 'KATEGORI', merk.nama_merk AS 'MERK', barang.harga_beli AS 'BELI', barang.harga_jual AS 'JUAL',warna.nama_warna AS 'WARNA', size.nama_size AS 'UKURAN', barang.stok AS 'STOK' , satuan.keterangan as 'SATUAN' FROM barang INNER JOIN kategori ON barang.kategori = kategori.kode_kategori INNER JOIN merk ON barang.kode_merk = merk.kode_merk INNER JOIN warna ON barang.kode_warna = warna.kode_warna INNER JOIN size ON barang.kode_size = size.kode_size INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan")

        DGBarang.DataSource = barang
        DGBarang.Columns(0).Width = 50
        DGBarang.Columns(1).Width = 220
        DGBarang.Columns(6).Width = 80
        DGBarang.Columns(7).Width = 50
        DGBarang.Columns(8).Width = 50
        DGBarang.Columns(9).Width = 70


        DGBarang.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGBarang.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'DGBarang.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGBarang.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGBarang.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGBarang.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGBarang.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub


    Sub Data_Kategori()
        barang = Proses.ExecuteQuery("SELECT * FROM kategori")
        If barang.Rows.Count = 0 Then
        Else
            cmbKategori.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    cmbKategori.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Data_Merk()
        barang = Proses.ExecuteQuery("SELECT * FROM merk")
        If barang.Rows.Count = 0 Then
        Else
            cmbMerk.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    cmbMerk.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub


    Sub Data_Warna()
        barang = Proses.ExecuteQuery("SELECT * FROM warna")
        If barang.Rows.Count = 0 Then
        Else
            cmbWarna.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    cmbWarna.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub Data_Ukuran()
        barang = Proses.ExecuteQuery("SELECT * FROM size")
        If barang.Rows.Count = 0 Then
        Else
            cmbUkuran.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    cmbUkuran.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub


    Sub Data_Satuan()
        barang = Proses.ExecuteQuery("Select * From satuan")
        If barang.Rows.Count = 0 Then
        Else
            CmbSatuan.Items.Clear()
            With barang.Columns(1)
                For a = 0 To barang.Rows.Count - 1
                    cmbSatuan.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Private Sub txtNamaSepatu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNamaSepatu.KeyPress

        If Asc(e.KeyChar) = 13 Then
            cmbKategori.Focus()
        End If
    End Sub

    Private Sub cmbKategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKategori.SelectedIndexChanged
        cmbMerk.Focus()
    End Sub

    Private Sub cmbMerk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMerk.SelectedIndexChanged
        cmbWarna.Focus()
    End Sub

    Private Sub cmbWarna_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWarna.SelectedIndexChanged
        cmbUkuran.Focus()
    End Sub

    Private Sub cmbUkuran_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUkuran.SelectedIndexChanged
        cmbSatuan.Focus()
    End Sub

    Private Sub cmbSatuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSatuan.SelectedIndexChanged
        txtHargaBeli.Focus()
    End Sub



    Private Sub txtHargaBeli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaBeli.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txtHargaJual.Focus()
        End If

    End Sub


    Private Sub txtHargaJual_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHargaJual.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            txtStok.Focus()
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStok.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

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


    Sub Kode_Otomatis()
        barang = Proses.ExecuteQuery("Select * From barang order by kode_barang desc")
        If barang.Rows.Count = 0 Then
            txtKodeSepatu.Text = "SPT-001"
        Else
            With barang.Rows(0)
                txtKodeSepatu.Text = .Item("kode_barang")
            End With
            txtKodeSepatu.Text = Val(Microsoft.VisualBasic.Mid(txtKodeSepatu.Text, 5, 3)) + 1
            If Len(txtKodeSepatu.Text) = 1 Then
                txtKodeSepatu.Text = "SPT-00" & txtKodeSepatu.Text & ""
            ElseIf Len(txtKodeSepatu.Text) = 2 Then
                txtKodeSepatu.Text = "SPT-0" & txtKodeSepatu.Text & ""
            ElseIf Len(txtKodeSepatu.Text) = 3 Then
                txtKodeSepatu.Text = "SPT-" & txtKodeSepatu.Text & ""
            End If
        End If
    End Sub


    Sub Atur()
        txtKodeSepatu.Enabled = False
        txtKodeSepatu.Text = ""
        txtNamaSepatu.Text = ""
        txtNamaSepatu.MaxLength = 100
        txtStok.MaxLength = 100
        cmbKategori.Text = "Pilih Kategori"
        cmbMerk.Text = "Pilih Merk"
        cmbSatuan.Text = "Pilih Satuan"
        cmbWarna.Text = "Pilih Warna"
        cmbUkuran.Text = "Pilih Ukuran"
        txtHargaBeli.Text = ""
        txtHargaJual.Text = ""
        txtStok.Text = ""

        ''Mengatur Fungsi Tombol
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False
        BtnKoreksiStock.Enabled = False
        txtNamaSepatu.Focus()

        Call Data_Record()
        Call Data_Kategori()
        Call Data_Merk()
        Call Data_Warna()
        Call Data_Ukuran()
        Call Data_Satuan()

        Call Kode_Otomatis()

    End Sub

    ' I Gede Adi Surya Eka Pramana Putra

    Private Sub FormBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click

        If txtNamaSepatu.Text = "" Then
            MsgBox("Nama Sepatu Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtNamaSepatu.Focus()
        ElseIf txtHargaBeli.Text = "" Then
            MsgBox("Harga Beli Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtHargaBeli.Focus()
        ElseIf txtHargaJual.Text = "" Then
            MsgBox("Harga Jual Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtHargaJual.Focus()
        ElseIf txtStok.Text = "" Then
            MsgBox("Stok Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtStok.Focus()
        Else
            Try

                If MsgBox("Apakah Anda Yakin Menyimpan Data Barang Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                    SQL = "INSERT INTO barang(kode_barang,nama_barang,kategori,kode_merk,harga_beli,harga_jual,kode_warna,kode_size,stok,kode_satuan) VALUES ('" & txtKodeSepatu.Text & "','" & txtNamaSepatu.Text & "','" & vb.Left(cmbKategori.SelectedItem, 7) & "','" & vb.Left(cmbMerk.SelectedItem, 7) & "','" & txtHargaBeli.Text & "','" & txtHargaJual.Text & "','" & vb.Left(cmbWarna.SelectedItem, 7) & "','" & vb.Left(cmbUkuran.SelectedItem, 7) & "','" & txtStok.Text & "', '" & vb.Left(cmbSatuan.Text, 7) & "')"
                    Proses.ExecuteNonQuery(SQL)
                    MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Atur()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try

        End If


    End Sub


    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUbah.Click

        If txtNamaSepatu.Text = "" Then
            MsgBox("Nama Sepatu Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtNamaSepatu.Focus()
        ElseIf txtHargaBeli.Text = "" Then
            MsgBox("Harga Beli Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtHargaBeli.Focus()
        ElseIf txtHargaJual.Text = "" Then
            MsgBox("Harga Jual Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtHargaJual.Focus()
        ElseIf txtStok.Text = "" Then
            MsgBox("Stok Tidak Boleh Kosong", MsgBoxStyle.Critical, "Gagal")
            txtStok.Focus()
        Else
            Try
                If MsgBox("Apakah Anda Yakin Akan Memperbaharui Data Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                    SQL = "UPDATE barang set nama_barang ='" & txtNamaSepatu.Text & "', kategori = '" & cmbKategori.Text & "', kode_merk = '" & cmbMerk.Text & "', harga_beli = '" & txtHargaBeli.Text & "', harga_jual = '" & txtHargaJual.Text & "', kode_warna = '" & cmbWarna.Text & "', kode_size = '" & cmbUkuran.Text & "', stok = '" & txtStok.Text & "', kode_satuan = '" & cmbSatuan.Text & "' where kode_barang ='" & txtKodeSepatu.Text & "',"
                    Proses.ExecuteNonQuery(SQL)
                    MessageBox.Show("Data sudah diperbaiki...!!", "Perubahan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Atur()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try
        End If


    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click

        If MsgBox("Apakah Anda Yakin Akan Menghapus Barang Ini ??", vbYesNo, "Konfirmasi") = vbYes Then
            SQL = "DELETE FROM barang where kode_barang ='" & txtKodeSepatu.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data sudah dihapus...!!", "Penghapusan Sukses",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Atur()
        End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If txtNamaSepatu.Text.Count > 0 Then
            Call Atur()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub BtnKoreksiStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKoreksiStock.Click
        Dim Jumlah = InputBox("Masukan Jumlah Penambahan Stok Sepatu", "Tambah Stok Sepatu")
        On Error GoTo Pesan
        Dim Tambah_Stock = Val(txtStok.Text) + Val(Jumlah)
        If MsgBox("Apakah Anda Yakin Akan Mengoreksi Stok Dari Barang Ini ? ", vbYesNo, "Konfirmasi") = vbYes Then
            SQL = "UPDATE barang set stok = '" & Tambah_Stock & "' where id_barang ='" & txtKodeSepatu.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Penambahan Stok Berhasil!!", "Tambah Stok Sepatu",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Atur()
        End If

        Exit Sub
Pesan:
        MsgBox("Masukkan Angka")

    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        If RbNama.Checked = True Then
            barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                         & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                             & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                             & "FROM barang " _
                                             & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                             & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                             & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                             & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                             & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan " _
                                             & "where barang.nama_barang LIKE '%" & txtCari.Text & "%' ORDER BY barang.kode_barang ASC")
            DGBarang.DataSource = barang
            txtCari.Focus()

        ElseIf RbKategori.Checked = True Then
            barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                         & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                         & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                         & "FROM barang " _
                                         & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                         & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                         & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                         & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                         & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan " _
                                         & "where kategori.nama_kategori LIKE '%" & txtCari.Text & "%' ORDER BY barang.kode_barang ASC")
            DGBarang.DataSource = barang
            txtCari.Focus()

        ElseIf RbMerk.Checked = True Then
            barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                         & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                         & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                         & "FROM barang " _
                                         & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                         & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                         & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                         & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                         & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan " _
                                         & "where merk.nama_merk LIKE '%" & txtCari.Text & "%' ORDER BY barang.kode_barang ASC")
            DGBarang.DataSource = barang
            txtCari.Focus()

        ElseIf RbUkuran.Checked = True Then

            barang = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                         & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                         & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                         & "FROM barang " _
                                         & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                         & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                         & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                         & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                         & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan " _
                                         & "where size.nama_size LIKE '%" & Val(txtCari.Text) & "' ORDER BY barang.kode_barang ASC")
            DGBarang.DataSource = barang
            txtCari.Focus()
        End If
    End Sub

    Private Sub DGBarang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGBarang.DoubleClick

        'Proses.ExecuteNonQuery("Select * From Barang")

        'barang = Proses.ExecuteQuery("Select * From barang order by kode_barang desc")
        'If barang.Rows.Count = 0 Then
        '    txtKodeSepatu.Text = "SPT-001"
        'Else
        '    With barang.Rows(0)
        '        txtKodeSepatu.Text = .Item("kode_barang")
        '    End With
        'End If


        txtKodeSepatu.Text = DGBarang.SelectedCells(0).Value
        txtNamaSepatu.Text = DGBarang.SelectedCells(1).Value
        cmbKategori.Text = DGBarang.SelectedCells(2).Value
        cmbMerk.Text = DGBarang.SelectedCells(3).Value
        txtHargaBeli.Text = DGBarang.SelectedCells(4).Value
        txtHargaJual.Text = DGBarang.SelectedCells(5).Value
        cmbWarna.Text = DGBarang.SelectedCells(6).Value
        cmbUkuran.Text = DGBarang.SelectedCells(7).Value
        txtStok.Text = DGBarang.SelectedCells(8).Value
        cmbSatuan.Text = DGBarang.SelectedCells(9).Value


        txtNamaSepatu.Focus()

        btnSimpan.Enabled = False
        btnUbah.Enabled = True
        btnHapus.Enabled = True
        btnBatal.Enabled = True
        BtnKoreksiStock.Enabled = True

        txtNamaSepatu.Focus()

        Call Data_Record()
        Call Data_Kategori()
        Call Data_Merk()
        Call Data_Warna()
        Call Data_Ukuran()
        Call Data_Satuan()

        'Call Kode_Otomatis()
    End Sub

End Class



'Private Sub txtHargaBeli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHargaBeli.TextChanged
'    If System.Text.RegularExpressions.Regex.IsMatch(txtHargaBeli.Text, "[  ^ 0-9]") Then
'        txtHargaBeli.Text = ""
'    End If
'End Sub

'Private Sub txtHargaJual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHargaJual.TextChanged
'    If System.Text.RegularExpressions.Regex.IsMatch(txtHargaJual.Text, "[  ^ 0-9]") Then
'        txtHargaJual.Text = ""
'    End If
'End Sub