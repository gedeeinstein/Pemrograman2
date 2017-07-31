Public Class FrmRptNotaPenjualan

    Private Sub FrmRptNotaPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim NotaPenjualan As New RptNotaPenjualan

        NotaPenjualan.SetParameterValue("pmKodeTransaksi", FormMasterTransaksiJual.txtNoTransaksi.Text)
        CrystalReportViewer1.ReportSource = NotaPenjualan
    End Sub
End Class