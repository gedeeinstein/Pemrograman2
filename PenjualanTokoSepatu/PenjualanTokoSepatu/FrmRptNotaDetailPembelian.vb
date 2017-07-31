Public Class FrmRptNotaDetailPembelian

    Private Sub FrmRptNotaDetailPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim NotaPembelian As New RptNotaDetailPembelian

        NotaPembelian.SetParameterValue("pmNoTrxPembelian", FormMasterTransaksiBeli.txtNoTransaksi.Text)
        CrystalReportViewer1.ReportSource = NotaPembelian

    End Sub
End Class