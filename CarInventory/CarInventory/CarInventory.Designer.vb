<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPlace = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(69, 47)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(34, 13)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Make"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(69, 86)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(36, 13)
        Me.lblModel.TabIndex = 1
        Me.lblModel.Text = "Model"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(74, 125)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(29, 13)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year"
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Location = New System.Drawing.Point(71, 166)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(34, 13)
        Me.lblPlace.TabIndex = 3
        Me.lblPlace.Text = "Place"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(71, 208)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(29, 13)
        Me.lblNew.TabIndex = 4
        Me.lblNew.Text = "New"
        '
        'cmbMake
        '
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Location = New System.Drawing.Point(142, 44)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 5
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(142, 86)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 6
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(142, 125)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 7
        '
        'txtPlace
        '
        Me.txtPlace.Location = New System.Drawing.Point(142, 166)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(121, 20)
        Me.txtPlace.TabIndex = 8
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(142, 208)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(15, 14)
        Me.chkNew.TabIndex = 9
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colMake, Me.ColumnHeader1})
        Me.ListView1.Location = New System.Drawing.Point(72, 247)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(477, 192)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'frmCarInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 535)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.txtPlace)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPlace)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Name = "frmCarInventory"
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPlace As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents txtPlace As TextBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
