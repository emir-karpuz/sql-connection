<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSQLConnection
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
        Me.btnCikis = New System.Windows.Forms.Button()
        Me.txtKod = New System.Windows.Forms.TextBox()
        Me.btnSonraki = New System.Windows.Forms.Button()
        Me.txtAd = New System.Windows.Forms.TextBox()
        Me.dgvCarAna = New System.Windows.Forms.DataGridView()
        Me.btnOnceki = New System.Windows.Forms.Button()
        CType(Me.dgvCarAna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCikis
        '
        Me.btnCikis.Location = New System.Drawing.Point(679, 12)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(75, 23)
        Me.btnCikis.TabIndex = 0
        Me.btnCikis.Text = "Ç I K I Ş"
        Me.btnCikis.UseVisualStyleBackColor = True
        '
        'txtKod
        '
        Me.txtKod.Location = New System.Drawing.Point(65, 20)
        Me.txtKod.Name = "txtKod"
        Me.txtKod.Size = New System.Drawing.Size(149, 20)
        Me.txtKod.TabIndex = 1
        '
        'btnSonraki
        '
        Me.btnSonraki.Location = New System.Drawing.Point(412, 12)
        Me.btnSonraki.Name = "btnSonraki"
        Me.btnSonraki.Size = New System.Drawing.Size(91, 28)
        Me.btnSonraki.TabIndex = 2
        Me.btnSonraki.Text = "Sonraki Kayıt"
        Me.btnSonraki.UseVisualStyleBackColor = True
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(65, 57)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.Size = New System.Drawing.Size(209, 20)
        Me.txtAd.TabIndex = 3
        '
        'dgvCarAna
        '
        Me.dgvCarAna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarAna.Location = New System.Drawing.Point(65, 118)
        Me.dgvCarAna.Name = "dgvCarAna"
        Me.dgvCarAna.Size = New System.Drawing.Size(660, 263)
        Me.dgvCarAna.TabIndex = 4
        '
        'btnOnceki
        '
        Me.btnOnceki.Location = New System.Drawing.Point(301, 15)
        Me.btnOnceki.Name = "btnOnceki"
        Me.btnOnceki.Size = New System.Drawing.Size(92, 25)
        Me.btnOnceki.TabIndex = 5
        Me.btnOnceki.Text = "Önceki Kayıt"
        Me.btnOnceki.UseVisualStyleBackColor = True
        '
        'FrmSQLConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 406)
        Me.Controls.Add(Me.btnOnceki)
        Me.Controls.Add(Me.dgvCarAna)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.btnSonraki)
        Me.Controls.Add(Me.txtKod)
        Me.Controls.Add(Me.btnCikis)
        Me.Name = "FrmSQLConnection"
        Me.Text = "SQL Connection"
        CType(Me.dgvCarAna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCikis As System.Windows.Forms.Button
    Friend WithEvents txtKod As System.Windows.Forms.TextBox
    Friend WithEvents btnSonraki As System.Windows.Forms.Button
    Friend WithEvents txtAd As System.Windows.Forms.TextBox
    Friend WithEvents dgvCarAna As System.Windows.Forms.DataGridView
    Friend WithEvents btnOnceki As System.Windows.Forms.Button

End Class
