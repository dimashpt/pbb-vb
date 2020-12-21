<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BerandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetoranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagementUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahDataWPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahDataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(597, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistem Informasi Pajak Bumi dan Bangunan Kota Bandung"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BerandaToolStripMenuItem, Me.TambahDataToolStripMenuItem, Me.MasterToolStripMenuItem, Me.SetoranToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.ManagementUserToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(887, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BerandaToolStripMenuItem
        '
        Me.BerandaToolStripMenuItem.Name = "BerandaToolStripMenuItem"
        Me.BerandaToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.BerandaToolStripMenuItem.Text = "&Beranda"
        '
        'TambahDataToolStripMenuItem
        '
        Me.TambahDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahDataWPToolStripMenuItem, Me.TambahDataUserToolStripMenuItem})
        Me.TambahDataToolStripMenuItem.Name = "TambahDataToolStripMenuItem"
        Me.TambahDataToolStripMenuItem.Size = New System.Drawing.Size(103, 21)
        Me.TambahDataToolStripMenuItem.Text = "&Tambah Data"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.MasterToolStripMenuItem.Text = "&Master"
        '
        'SetoranToolStripMenuItem
        '
        Me.SetoranToolStripMenuItem.Name = "SetoranToolStripMenuItem"
        Me.SetoranToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.SetoranToolStripMenuItem.Text = "&Setoran"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.LaporanToolStripMenuItem.Text = "&Laporan"
        '
        'ManagementUserToolStripMenuItem
        '
        Me.ManagementUserToolStripMenuItem.Name = "ManagementUserToolStripMenuItem"
        Me.ManagementUserToolStripMenuItem.Size = New System.Drawing.Size(128, 21)
        Me.ManagementUserToolStripMenuItem.Text = "&Management User"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.KeluarToolStripMenuItem.Text = "&Keluar"
        '
        'TambahDataWPToolStripMenuItem
        '
        Me.TambahDataWPToolStripMenuItem.Name = "TambahDataWPToolStripMenuItem"
        Me.TambahDataWPToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.TambahDataWPToolStripMenuItem.Text = "Tambah Data WP"
        '
        'TambahDataUserToolStripMenuItem
        '
        Me.TambahDataUserToolStripMenuItem.Name = "TambahDataUserToolStripMenuItem"
        Me.TambahDataUserToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.TambahDataUserToolStripMenuItem.Text = "Tambah Data User"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(887, 477)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "beranda_pbb"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BerandaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDataWPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetoranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManagementUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDataUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
