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
        Me.lblPrincipleValue = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblFinalValue = New System.Windows.Forms.Label()
        Me.lblFinalValueAns = New System.Windows.Forms.Label()
        Me.txtPrincipalValue = New System.Windows.Forms.TextBox()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrincipleValue
        '
        Me.lblPrincipleValue.AutoSize = True
        Me.lblPrincipleValue.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipleValue.Location = New System.Drawing.Point(26, 59)
        Me.lblPrincipleValue.Name = "lblPrincipleValue"
        Me.lblPrincipleValue.Size = New System.Drawing.Size(108, 32)
        Me.lblPrincipleValue.TabIndex = 1
        Me.lblPrincipleValue.Text = "Principal Value :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Initial Investment)"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriod.Location = New System.Drawing.Point(31, 118)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(89, 16)
        Me.lblPeriod.TabIndex = 2
        Me.lblPeriod.Text = "Period (Years) :"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestRate.Location = New System.Drawing.Point(31, 168)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(103, 16)
        Me.lblInterestRate.TabIndex = 3
        Me.lblInterestRate.Text = "Interest Rate (%) :"
        '
        'lblFinalValue
        '
        Me.lblFinalValue.AutoSize = True
        Me.lblFinalValue.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalValue.Location = New System.Drawing.Point(35, 217)
        Me.lblFinalValue.Name = "lblFinalValue"
        Me.lblFinalValue.Size = New System.Drawing.Size(73, 16)
        Me.lblFinalValue.TabIndex = 4
        Me.lblFinalValue.Text = "Final Value :"
        '
        'lblFinalValueAns
        '
        Me.lblFinalValueAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFinalValueAns.Location = New System.Drawing.Point(180, 212)
        Me.lblFinalValueAns.Name = "lblFinalValueAns"
        Me.lblFinalValueAns.Size = New System.Drawing.Size(86, 21)
        Me.lblFinalValueAns.TabIndex = 5
        Me.lblFinalValueAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrincipalValue
        '
        Me.txtPrincipalValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrincipalValue.Location = New System.Drawing.Point(183, 59)
        Me.txtPrincipalValue.Name = "txtPrincipalValue"
        Me.txtPrincipalValue.Size = New System.Drawing.Size(83, 20)
        Me.txtPrincipalValue.TabIndex = 6
        Me.txtPrincipalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeriod
        '
        Me.txtPeriod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPeriod.Location = New System.Drawing.Point(183, 114)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(83, 20)
        Me.txtPeriod.TabIndex = 7
        Me.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInterestRate
        '
        Me.txtInterestRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInterestRate.Location = New System.Drawing.Point(183, 164)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(83, 20)
        Me.txtInterestRate.TabIndex = 8
        Me.txtInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(33, 257)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(81, 27)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(183, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 27)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 36)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Enter the values below accordingly " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             and press ""Calculate"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(165, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(278, 329)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtPeriod)
        Me.Controls.Add(Me.txtPrincipalValue)
        Me.Controls.Add(Me.lblFinalValueAns)
        Me.Controls.Add(Me.lblFinalValue)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.lblPrincipleValue)
        Me.Name = "Form1"
        Me.Text = "Simple Interest Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrincipleValue As Label
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblFinalValue As Label
    Friend WithEvents lblFinalValueAns As Label
    Friend WithEvents txtPrincipalValue As TextBox
    Friend WithEvents txtPeriod As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
