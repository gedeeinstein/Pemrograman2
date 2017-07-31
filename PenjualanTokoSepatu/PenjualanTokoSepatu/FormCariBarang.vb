﻿Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Data
Imports vb = Microsoft.VisualBasic

Public Class FormCariBarang

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim barang As DataTable
    Dim Data As DataSet
    Dim a As Integer
    Dim haha As Integer
    Dim kode_barang, search_name, search_condition, search_d As String



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


        Proses.OpenConn()
        Dim myadapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT barang.kode_barang AS 'Kode', barang.nama_barang AS 'Nama', kategori.nama_kategori AS 'Kategori', " _
                                     & "merk.nama_merk AS 'Merk', barang.harga_beli AS 'Harga Beli', barang.harga_jual AS 'Harga Jual'," _
                                     & "warna.nama_warna AS 'WARNA', size.nama_size AS 'Ukuran', barang.stok AS 'Stok' , satuan.keterangan as 'SATUAN' " _
                                     & "FROM barang " _
                                     & "INNER JOIN kategori ON barang.kategori = kategori.kode_kategori " _
                                     & "INNER JOIN merk ON barang.kode_merk = merk.kode_merk " _
                                     & "INNER JOIN warna ON barang.kode_warna = warna.kode_warna " _
                                     & "INNER JOIN size ON barang.kode_size = size.kode_size " _
                                     & "INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan ORDER BY kode_barang ASC"

        Dim mycommand As New MySqlCommand
        mycommand.Connection = Proses.Cn
        mycommand.CommandText = sqlquery
        myadapter.SelectCommand = mycommand
        Dim totalbarang As Integer
        Dim mydata As MySqlDataReader
        mydata = mycommand.ExecuteReader()

        totalbarang = 0
        If (mydata.HasRows) Then
            While (mydata.Read)
                totalbarang = totalbarang + 1
            End While
        End If
        lbl_totalbarang.Text = Val(totalbarang)
        Proses.CloseConn()



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

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()

    End Sub

    Private Sub DGBarang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGBarang.DoubleClick
    
        'FormMasterTransaksiJual.txtKodeSepatu.Text = DGBarang.SelectedCells(0).Value
        'FormMasterTransaksiJual.txtNamaSepatu.Text = DGBarang.SelectedCells(1).Value
        'FormMasterTransaksiJual.cmbKategori.Text = DGBarang.SelectedCells(2).Value
        'cmbMerk.Text = DGBarang.SelectedCells(3).Value
        'FormMasterTransaksiJual.txtHargaBeli.Text = DGBarang.SelectedCells(4).Value
        'FormMasterTransaksiJual.txtHargaJual.Text = DGBarang.SelectedCells(5).Value
        'FormMasterTransaksiJual.txtWarna.Text = DGBarang.SelectedCells(6).Value
        'FormMasterTransaksiJual.cmbUkuran.Text = DGBarang.SelectedCells(7).Value
        'FormMasterTransaksiJual.txtStok.Text = DGBarang.SelectedCells(8).Value
        'FormMasterTransaksiJual.txt.Text = DGBarang.SelectedCells(9).Value

        FormMasterTransaksiJual.cmbSepatu.Text = DGBarang.SelectedCells(0).Value
        FormMasterTransaksiJual.txtNamaSepatu.Text = DGBarang.SelectedCells(1).Value
        'FormMasterTransaksiJual.txtWarna.Text = DGBarang.SelectedCells(6).Value
        'FormMasterTransaksiJual.txtUkuran.Text = DGBarang.SelectedCells(7).Value
        FormMasterTransaksiJual.txtHargaJual.Text = DGBarang.SelectedCells(5).Value
        FormMasterTransaksiJual.txtStok.Text = DGBarang.SelectedCells(8).Value



        Me.Close()
        FormMasterTransaksiJual.txtJumlah.Focus()

        'btnSimpan.Enabled = False
        'btnUbah.Enabled = True
        'btnHapus.Enabled = True
        'btnBatal.Enabled = True
        'BtnKoreksiStock.Enabled = True

        'txtNamaSepatu.Focus()

        'Call Data_Record()

    End Sub

    Private Sub FormCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Data_Record()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Data_Record()
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        DGBarang_DoubleClick(sender, e)
    End Sub

End Class