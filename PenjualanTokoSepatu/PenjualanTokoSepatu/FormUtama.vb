Public Class FormUtama

 

    Private Sub MasterKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterKaryawanToolStripMenuItem.Click
        FormKaryawan.ShowDialog()
    End Sub

    Private Sub LogoutAplikasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutAplikasiToolStripMenuItem.Click
        If MsgBox("Apakah yakin akan Log Off / Log Out ?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
        End If

        FormLogin.Show()


        'If MsgBox("Apakah yakin akan Log Off / Log Out ?", vbYesNo, "konfirmasi") = vbYes Then
        '    Me.Close()
        'End If

        'FormLogin.ShowDialog()

        'FormLogin.Show()
    End Sub

    Private Sub KeluarAplikasiToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarAplikasiToolStripMenuItem.Click
        If MsgBox("Apakah yakin akan keluar dari aplikasi?", vbYesNo, "Konfirmasi") = vbYes Then
            Me.Close()
            FormLogin.Close()
        End If
    End Sub







    Private Sub MasterBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterBarangToolStripMenuItem.Click
        FormMasterBarang.ShowDialog()
    End Sub


    Private Sub MasterSuplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterSuplierToolStripMenuItem.Click
        FormMasterSuplier.ShowDialog()

    End Sub

    Private Sub KategoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KategoriToolStripMenuItem.Click
        FormaMasterKetegori.ShowDialog()
    End Sub

    Private Sub WarnaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarnaToolStripMenuItem.Click
        FormMasterWarna.ShowDialog()
    End Sub


    Private Sub MasterUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterUserToolStripMenuItem.Click
        FormMasterUser.ShowDialog()

    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        FormMasterTransaksiBeli.ShowDialog()
    End Sub

    Private Sub FormUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TSUser.Text = userlogin

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TSWaktu.Text = Format(Now, "dd-mm-yy HH:mm:ss")
    End Sub

    Private Sub PenjualanBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanBarangToolStripMenuItem.Click
        FormMasterTransaksiJual.ShowDialog()
    End Sub

    Private Sub MerkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MerkToolStripMenuItem.Click
        FormMasterMerk.ShowDialog()

    End Sub

    Private Sub DataSatuanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSatuanToolStripMenuItem.Click
        FormMasterSatuan.ShowDialog()

    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBarangToolStripMenuItem.Click
        FrmRptDataBarang.ShowDialog()

    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        FrmRptKaryawan.ShowDialog()

    End Sub

    Private Sub DataPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPenjualanToolStripMenuItem.Click
        FrmRptPenjualan.Show()
    End Sub

    Private Sub DataPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPembelianToolStripMenuItem.Click
        FrmRptPembelian.ShowDialog()
    End Sub

    Private Sub DataSuplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSuplierToolStripMenuItem.Click
        FrmRptSuplier.ShowDialog()

    End Sub

    Private Sub AuthorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthorToolStripMenuItem.Click
        TentangAuthor.Show()
    End Sub

    Private Sub AplikasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplikasiToolStripMenuItem.Click
        FrmTentangAplikasi.ShowDialog()

    End Sub
End Class