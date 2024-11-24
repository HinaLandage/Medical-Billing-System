<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewMedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveMedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchMedicineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportingToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(568, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewMedicineToolStripMenuItem, Me.RemoveMedicineToolStripMenuItem, Me.SearchMedicineToolStripMenuItem, Me.ShowListToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AddNewMedicineToolStripMenuItem
        '
        Me.AddNewMedicineToolStripMenuItem.Name = "AddNewMedicineToolStripMenuItem"
        Me.AddNewMedicineToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AddNewMedicineToolStripMenuItem.Text = "Add new medicine"
        '
        'RemoveMedicineToolStripMenuItem
        '
        Me.RemoveMedicineToolStripMenuItem.Name = "RemoveMedicineToolStripMenuItem"
        Me.RemoveMedicineToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RemoveMedicineToolStripMenuItem.Text = "Remove Medicine"
        '
        'SearchMedicineToolStripMenuItem
        '
        Me.SearchMedicineToolStripMenuItem.Name = "SearchMedicineToolStripMenuItem"
        Me.SearchMedicineToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SearchMedicineToolStripMenuItem.Text = "Search Medicine"
        '
        'ShowListToolStripMenuItem
        '
        Me.ShowListToolStripMenuItem.Name = "ShowListToolStripMenuItem"
        Me.ShowListToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ShowListToolStripMenuItem.Text = "Show List"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaleToolStripMenuItem, Me.PurchaseToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaleToolStripMenuItem.Text = "Sale"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PurchaseToolStripMenuItem.Text = "Purchase"
        '
        'ReportingToolStripMenuItem
        '
        Me.ReportingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseReportToolStripMenuItem, Me.SaleReportToolStripMenuItem})
        Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
        Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ReportingToolStripMenuItem.Text = "Reporting"
        '
        'PurchaseReportToolStripMenuItem
        '
        Me.PurchaseReportToolStripMenuItem.Name = "PurchaseReportToolStripMenuItem"
        Me.PurchaseReportToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PurchaseReportToolStripMenuItem.Text = "Purchase Report"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SaleReportToolStripMenuItem
        '
        Me.SaleReportToolStripMenuItem.Name = "SaleReportToolStripMenuItem"
        Me.SaleReportToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SaleReportToolStripMenuItem.Text = "Sale Report"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 504)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewMedicineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveMedicineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchMedicineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
