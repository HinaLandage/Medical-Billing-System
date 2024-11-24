Public Class Form2

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AddNewMedicineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewMedicineToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub ShowListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowListToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub SearchMedicineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchMedicineToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub RemoveMedicineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveMedicineToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub PurchaseReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReportToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub SaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleToolStripMenuItem.Click
        Form9.Show()
    End Sub

    Private Sub SaleReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleReportToolStripMenuItem.Click
        Form10.Show()
    End Sub
End Class