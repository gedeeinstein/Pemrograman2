Imports vb = Microsoft.VisualBasic


Public Class FormMasterTransaksiJual

    Dim SQL As String
    Dim Proses As New Koneksi
    Dim transaksi_jual As DataTable
    Dim Data As DataSet
    Dim a As Integer
    Dim Disc As Double
    Dim grandtotal As Double
    Dim bayar As Double
    Dim kembalian As Double
    Dim totalNoDiskon As Double


    Sub Data_Record_Penjualan()
        'Dim NoTransaksi As String
        'txtNoTransaksi.Text = NoTransaksi
        'NoTransaksi = txtNoTransaksi.Text

        'transaksibeli = Proses.ExecuteQuery("SELECT kode_trans_beli as 'KODE TRANSAKSI', kode_barang as 'KODE BARANG', nama_barang as 'NAMA BARANG', harga_beli as 'HARGA BELI', jumlah as 'Jumlah', sub_total as 'Total', warna as 'Warna', size as 'Ukuran'  FROM detail_trans_beli where kode_trans_beli = '" & txtNoTransaksi.Text & "' ")
        'transaksi_jual = Proses.ExecuteQuery("SELECT detail_trans_beli.kode_trans_beli AS 'KODE TRANSAKSI', detail_trans_beli.kode_barang AS 'KODE BARANG', detail_trans_beli.nama_barang AS 'NAMA BARANG', detail_trans_beli.harga_beli AS 'HARGA BELI', detail_trans_beli.jumlah AS 'Jumlah', detail_trans_beli.sub_total AS 'Total', warna.nama_warna AS 'Warna', size.nama_size AS 'Ukuran' FROM detail_trans_beli INNER JOIN warna INNER JOIN size ON detail_trans_beli.warna = warna.kode_warna AND detail_trans_beli.size = size.kode_size WHERE kode_trans_beli = '" & txtNoTransaksi.Text & "' ")

        transaksi_jual = Proses.ExecuteQuery("SELECT detail_trans_jual.kode_trans_jual AS 'KODE TRANSAKSI', detail_trans_jual.kode_barang AS 'KODE BARANG', detail_trans_jual.nama_barang AS 'NAMA BARANG', detail_trans_jual.harga_jual AS 'HARGA BELI', detail_trans_jual.jumlah AS 'JML BRG', detail_trans_jual.sub_total AS 'TOTAL', warna.nama_warna AS 'WARNA', size.nama_size AS 'UKURAN' FROM detail_trans_jual INNER JOIN warna INNER JOIN size ON detail_trans_jual.warna = warna.kode_warna AND detail_trans_jual.size = size.kode_size WHERE kode_trans_jual = '" & txtNoTransaksi.Text & "'")

        DGJualBarang.DataSource = transaksi_jual
        DGJualBarang.Columns(0).Visible = False
        DGJualBarang.Columns(1).Width = 80
        DGJualBarang.Columns(2).Width = 260
        DGJualBarang.Columns(3).Width = 120
        DGJualBarang.Columns(4).Width = 50
        DGJualBarang.Columns(5).Width = 160
        DGJualBarang.Columns(6).Width = 200
        DGJualBarang.Columns(7).Width = 80


        DGJualBarang.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGJualBarang.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGJualBarang.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Sub Data_Sepatu()
        transaksi_jual = Proses.ExecuteQuery("SELECT * FROM barang")
        If transaksi_jual.Rows.Count = 0 Then
        Else
            cmbSepatu.Items.Clear()
            With transaksi_jual.Columns(1)
                For a = 0 To transaksi_jual.Rows.Count - 1
                    cmbSepatu.Items.Add("" & .Table.Rows(a).Item(0) & "/" & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub

    Sub No_Transaksi_Otomatis()
        'Dim tgl = Format(Tgl_Lahir.Value.Date, "yyyy-MM-dd")

        transaksi_jual = Proses.ExecuteQuery("SELECT * FROM trans_jual order by kode_trans_jual desc")
        If transaksi_jual.Rows.Count = 0 Then
            txtNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "-001"
        Else
            With transaksi_jual.Rows(0)
                txtNoTransaksi.Text = .Item("kode_trans_jual")
            End With
            txtNoTransaksi.Text = Val(Microsoft.VisualBasic.Mid(txtNoTransaksi.Text, 12, 3)) + 1
            If Len(txtNoTransaksi.Text) = 1 Then
                txtNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "-00" & txtNoTransaksi.Text & ""
            ElseIf Len(txtNoTransaksi.Text) = 2 Then
                txtNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "-0" & txtNoTransaksi.Text & ""
            ElseIf Len(txtNoTransaksi.Text) = 3 Then
                txtNoTransaksi.Text = "" + Format(Now, "yyyy-MM-dd") + "" & txtNoTransaksi.Text & ""
            End If
        End If
    End Sub

    Sub User()

        'txtUser.Text = userlogin

        'If txtUser.Text = "" Then
        '    txtUser.Text = "I Gede Adi Surya Eka Pramana Putra"
        'Else
        txtUser.Text = userlogin
        'End If
    End Sub

    Sub Atur_Awal_Form()

        txtPembeli.Focus()
        cmbSepatu.Text = "Pilih Sepatu"

        txtNamaSepatu.Text = ""
        txtHargaJual.Text = ""
        txtStok.Text = ""
        txtJumlah.Text = ""
        txtTotal.Text = ""
        txtWarna.Text = ""
        txtUkuran.Text = ""

        txtBayar.Text = ""
        txtDiskon.Text = "0"
        txtKembalian.Text = ""
        txtTotalAkhir.Text = ""


        txtNoTransaksi.Enabled = False
        txtUser.Enabled = False
        txtTotalAkhir.Enabled = False
        txtTotal.Enabled = False
        txtKembalian.Enabled = False


        Call Data_Sepatu()
        Call Data_Record_Penjualan()
        Call No_Transaksi_Otomatis()
        Call User()
    End Sub

    Private Sub FormMasterTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Atur_Awal_Form()
        'txtUserTS.Text = userlogin
        'If userlogin = 0 Then
        '    txtUser.Text = "TEST"
        'Else
        '    Call User()
        'End If

    End Sub

    Private Sub cmbSepatu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSepatu.SelectedIndexChanged

        transaksi_jual = Proses.ExecuteQuery("SELECT * FROM barang where kode_barang = '" & vb.Left(cmbSepatu.Text, 7) & "'")

        'transaksibeli = Proses.ExecuteQuery("SELECT barang.kode_barang AS 'KD BRG', barang.nama_barang AS 'NAMA BRG', kategori.nama_kategori AS 'KATEGORI', merk.nama_merk AS 'MERK', barang.harga_beli AS 'BELI', barang.harga_jual AS 'JUAL',warna.nama_warna AS 'WARNA', size.nama_size AS 'UKURAN', barang.stok AS 'STOK' , satuan.keterangan AS 'SATUAN' FROM barang INNER JOIN kategori ON barang.kategori = kategori.kode_kategori INNER JOIN merk ON barang.kode_merk = merk.kode_merk INNER JOIN warna ON barang.kode_warna = warna.kode_warna INNER JOIN size ON barang.kode_size = size.kode_size INNER JOIN satuan ON barang.kode_satuan = satuan.kode_satuan WHERE barang.kode_barang = '" & vb.Left(cmbSepatu.Text, 7) & "'")
        If transaksi_jual.Rows.Count = 0 Then
        Else
            txtNamaSepatu.Text = transaksi_jual.Rows(0).Item("nama_barang")
            txtHargaJual.Text = transaksi_jual.Rows(0).Item("harga_jual")
            txtStok.Text = transaksi_jual.Rows(0).Item("stok")
            txtWarna.Text = transaksi_jual.Rows(0).Item("kode_warna")
            txtUkuran.Text = transaksi_jual.Rows(0).Item("kode_size")
            txtJumlah.Focus()
        End If

    End Sub




    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click

        'On Error GoTo Keluar

        If MsgBox("Apakah Anda Yakin Akan Membatalkan Transaksi Ini ?", vbYesNo, "Konfirmasi") = vbYes Then

            Try
                Dim i As Integer

                i = DGJualBarang.CurrentRow.Index

                For i = 0 To DGJualBarang.Rows.Count - 1
                    transaksi_jual = Proses.ExecuteQuery("SELECT * FROM barang where kode_barang = '" & DGJualBarang.Item(1, i).Value & "'")
                    If transaksi_jual.Rows.Count = 0 Then
                    Else
                        Dim Jumlah = Val(transaksi_jual.Rows(0).Item("stok")) + Val(DGJualBarang.Item(4, i).Value)
                        SQL = "UPDATE barang set stok = '" & CInt(Jumlah) & "' where kode_barang = '" & DGJualBarang.Item(1, i).Value & "'"
                        Proses.ExecuteNonQuery(SQL)
                    End If
                Next
                SQL = "DELETE FROM detail_trans_jual where kode_trans_jual ='" & txtNoTransaksi.Text & "'"
                Proses.ExecuteNonQuery(SQL)
                MessageBox.Show("Transaksi sudah dibatalkan...!!", "Pembatalan Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)

                Call Atur_Awal_Form()
                Call No_Transaksi_Otomatis()
                Call Data_Record_Penjualan()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            End Try

        End If

        'Keluar:
    End Sub


    Private Sub txtPembeli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPembeli.KeyPress
        '   If (Not Char.IsControl(e.KeyChar) _
        'AndAlso (Not Char.IsDigit(e.KeyChar) _
        'AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
        '       e.Handled = True
        '   End If

        Select Case (e.KeyChar)

            Case Chr(13)
                If cmbSepatu.Text = "Pilih Sepatu" Then
                    'If Asc(e.KeyChar) = 13 Then
                    cmbSepatu.Focus() : Exit Sub
                ElseIf txtNamaSepatu.TextLength > 1 Then

                    txtJumlah.Focus()

                End If
            Case Else

        End Select

    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        If MsgBox("Apakah Anda Yakin Akan Menutup Form Pembelian Barang Ini ??", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub txtJumlah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJumlah.KeyPress

        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                txtJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                'If txtPembeli.Text = "" Then txtPembeli.Focus() : Exit Sub
                ''If Val(TxtStockBrg.Text) < Val(TxtJml.Text) Then MsgBox("maaf,stock tidak mencukupi ") : Exit Sub

                If txtPembeli.TextLength < 3 Then
                    MsgBox("Nama Pembeli Tidak Boleh Kurang Dari 3 Karakter", txtPembeli.Focus(), "Salah !!!!") : Exit Sub
                ElseIf txtJumlah.TextLength = 0 Then
                    MsgBox("Masukan Jumlah Pembelian Barang", MsgBoxStyle.Information, "QTY Salah") : Exit Sub
                    txtJumlah.Focus()
                End If

                If Val(txtStok.Text) < Val(txtStok.Text) Then MsgBox("Maaf Stock Tidak Mencukupi", MsgBoxStyle.OkCancel, "Error") : Exit Sub
                Call total_harga()
                Call update_stock()

                If Val(txtDiskon.Text) = 0 Then
                    txtTotalAkhir.Text = Val(txtTotal.Text)
                End If

            Case Else
                e.KeyChar = Chr(0)
        End Select



        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If



    End Sub

    Private Sub total_harga()
        Dim total_harga = Val(txtJumlah.Text) * Val(txtHargaJual.Text)
        SQL = "insert into detail_trans_jual " _
            & "(kode_trans_jual, kode_barang, nama_barang, harga_jual, jumlah, sub_total, warna, size) VALUES " _
            & "('" & txtNoTransaksi.Text & "','" & vb.Left(cmbSepatu.Text, 7) & "','" & txtNamaSepatu.Text & "' " _
            & ",'" & txtHargaJual.Text & "','" & txtJumlah.Text & "','" & total_harga & "','" & txtWarna.Text & "','" & txtUkuran.Text & "')"

        'SQL = "insert into detail_trans_jual " _
        '    & "(kode_barang, nama_barang, harga_jual, jumlah, sub_total) VALUES " _
        '    & "('" & vb.Left(cmbSepatu.Text, 7) & "','" & txtNamaSepatu.Text & "' " _
        '    & ",'" & txtHargaJual.Text & "','" & txtJumlah.Text & "','" & total_harga & "')"
        Proses.ExecuteNonQuery(SQL)

    End Sub

    Private Sub update_stock()
        Dim stok = Val(txtStok.Text) - Val(txtJumlah.Text)
        SQL = "update barang set stok = '" & stok & "' where kode_barang = '" & vb.Left(cmbSepatu.Text, 7) & "'"
        Proses.ExecuteNonQuery(SQL)
        'txtPembeli = ""
        cmbSepatu.Text = "Pilih Sepatu"
        txtNamaSepatu.Text = ""
        txtHargaJual.Text = ""
        txtStok.Text = ""
        txtJumlah.Text = ""
        txtWarna.Text = ""
        txtUkuran.Text = ""
        cmbSepatu.Focus()

        Call Data_Record_Penjualan()
        TxtTotal.Text = ""

        Dim i As Integer
        Dim total As Double

        total = 0
        For i = 0 To DGJualBarang.Rows.Count - 1
            total += Val(DGJualBarang.Item(5, i).Value)
        Next
        txtTotal.Text = Format(Val(Replace(total, ".", "")))


    End Sub




    Sub ProsesTransaksi()
        'SQL = "INSERT INTO trans_jual (kode_trans_jual, pembeli, username, total_belanja, diskon, total_akhir, bayar, kembalian, tanggal_trans_jual) VALUES ('" & txtNoTransaksi.Text & "','" & txtPembeli.Text & "','" & userlogin & "','" & txtTotal.Text & "','" & Val(txtDiskon.Text) & "','" & Val(txtTotalAkhir) & "','" & Val(txtBayar.Text) & "','" & Val(txtKembalian.Text) & "','" & Format(Now.Date) & "')"
        'Proses.ExecuteNonQuery("INSERT INTO trans_jual (kode_trans_jual, pembeli, username, total_belanja, diskon, total_akhir, bayar, kembalian, tanggal_trans_jual) VALUES ('" & txtNoTransaksi.Text & "','" & txtPembeli.Text & "','" & userlogin & "','" & txtTotal.Text & "','" & txtDiskon.Text & "','" & txtTotalAkhir & "','" & txtBayar.Text & "','" & txtKembalian.Text & "','" & Format(Now, da) & "')")

        Try

            If MsgBox("Apakah Anda Yakin Akan Memproses Transaksi Ini ?", vbYesNo, "Konfirmasi") = vbYes Then
                SQL = "INSERT INTO trans_jual (kode_trans_jual, pembeli, username, total_belanja, diskon, total_akhir, bayar, kembalian, tanggal_trans_jual) VALUES ('" & txtNoTransaksi.Text & "','" & txtPembeli.Text & "','" & userlogin & "','" & txtTotal.Text & "','" & Val(txtDiskon.Text) & "','" & Val(txtTotalAkhir.Text) & "','" & Val(txtBayar.Text) & "','" & Val(txtKembalian.Text) & "','" & Format(Now, "yyyy-MM-dd") & "')"
                Proses.ExecuteNonQuery(SQL)
                MsgBox("Transaksi Berhasil Disimpan", MsgBoxStyle.OkOnly, "Sukses")

                FrmRptNotaPenjualan.ShowDialog()
                'Print.FrmRptNotaPenjualan(True)

                Call No_Transaksi_Otomatis()
                Call Atur_Awal_Form()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
        End Try

    End Sub


    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click

        If DGJualBarang.Columns(0).Name = "" Then 'txtBayar.Text = "" Then
            MsgBox("Tidak Ada Sepatu yang Dipilih ", MsgBoxStyle.Critical, "Proses Gagal") : Exit Sub
        ElseIf txtBayar.Text = "" Then 'DGTransaksi.Columns(0).Name = "" Then 
            MsgBox("Masukan Nilai Bayar", MsgBoxStyle.OkOnly, "Proses Gagal")
            txtBayar.Focus() : Exit Sub
        ElseIf bayar < grandtotal Then
            MsgBox("Uang Kurang, Dilarang Ngebon")

        ElseIf Val(txtTotalAkhir.TextLength) = 0 Then
            MsgBox("Tidak Ada Transaksi", MsgBoxStyle.OkOnly, "Error") : Exit Sub
        Else
            'If MsgBox("Apakah Anda Yakin Akan Memproses Transaksi ?", vbYesNo, "Konfirmasi") = vbYes Then
            '    SQL = "INSERT INTO trans_jual (kode_trans_jual, pembeli, username, total_belanja, diskon, total_akhir, bayar, kembalian, tanggal_trans_jual) VALUES ('" & txtNoTransaksi.Text & "','" & txtPembeli.Text & "','" & userlogin & "','" & txtTotal.Text & "','" & Val(txtDiskon.Text) & "','" & Val(txtTotalAkhir) & "','" & Val(txtBayar.Text) & "','" & Val(txtKembalian.Text) & "','" & Format(Now, "yyyy-MM-dd") & "')"

            'End If

            'Proses.ExecuteNonQuery(SQL)
            'Call No_Transaksi_Otomatis()
            'Call Atur_Awal_Form()
            Call ProsesTransaksi()
        End If

    End Sub


    Private Sub txtDiskon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiskon.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If


        Disc = Val(txtDiskon.Text)
        grandtotal = Val(txtTotalAkhir.Text)

        If e.KeyChar = Chr(13) Then
            If (Disc >= 0) And (Disc <= 100) Then
                Disc = Val(txtTotal.Text) * (Disc / 100)
                txtDiskon.Text = Format(Disc, "")
                grandtotal = Val(txtTotal.Text) - Disc
                txtTotalAkhir.Text = Format(grandtotal, "")
            Else
                Disc = Val(txtTotal.Text) - Val(txtDiskon.Text)
                txtDiskon.Text = Val(txtDiskon.Text)
                grandtotal = Val(txtTotal.Text) - Val(txtDiskon.Text)
                txtTotalAkhir.Text = Format(grandtotal, "")
            End If
            txtBayar.Focus()

        End If


    End Sub

    Private Sub txtBayar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBayar.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                   AndAlso (Not Char.IsDigit(e.KeyChar) _
                   AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If

        bayar = Val(txtBayar.Text)
        kembalian = Val(txtKembalian.Text)
        grandtotal = Val(txtTotalAkhir.Text)
        totalNoDiskon = Val(txtTotal.Text)


        If txtDiskon.Text = 0 Then
            Call txtDiskon_KeyPress(sender, e)
        End If

        If e.KeyChar = Chr(13) Then
            'If bayar < grandtotal Then
            '    MsgBox("Uang Kurang, Dilarang Ngebon")

            'Else
            kembalian = bayar - Val(txtTotalAkhir.Text)
            txtKembalian.Text = Format(kembalian, "")
            If e.KeyChar = Chr(13) Then
                btnProses_Click(sender, e)
            End If
            'End If
        End If


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        btnTutup_Click(sender, e)
    End Sub

    Private Sub cmbSepatu_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSepatu.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtJumlah.Focus()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ZHelpUkuranSepatu.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FormCariBarang.ShowDialog()

    End Sub



    Private Sub txtBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBayar.TextChanged
        Dim kembalian1 = Val(txtBayar.Text) - Val(txtTotalAkhir.Text)

        If kembalian1 < 0 Then
            txtKembalian.Text = Nothing
        Else
            txtKembalian.Text = kembalian1
        End If
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    FrmRptNotaPenjualan.ShowDialog()

    'End Sub


End Class