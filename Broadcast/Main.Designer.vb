<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnStartFlood = New System.Windows.Forms.Button()
        Me.tmrRunner = New System.Windows.Forms.Timer(Me.components)
        Me.btnStopFlood = New System.Windows.Forms.Button()
        Me.lblCurrentPort = New System.Windows.Forms.Label()
        Me.lblPortNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStartFlood
        '
        Me.btnStartFlood.Location = New System.Drawing.Point(225, 360)
        Me.btnStartFlood.Name = "btnStartFlood"
        Me.btnStartFlood.Size = New System.Drawing.Size(141, 43)
        Me.btnStartFlood.TabIndex = 0
        Me.btnStartFlood.Text = "Start Flood"
        Me.btnStartFlood.UseVisualStyleBackColor = True
        '
        'tmrRunner
        '
        Me.tmrRunner.Interval = 10000
        '
        'btnStopFlood
        '
        Me.btnStopFlood.Enabled = False
        Me.btnStopFlood.Location = New System.Drawing.Point(392, 360)
        Me.btnStopFlood.Name = "btnStopFlood"
        Me.btnStopFlood.Size = New System.Drawing.Size(141, 43)
        Me.btnStopFlood.TabIndex = 1
        Me.btnStopFlood.Text = "Stop Flood"
        Me.btnStopFlood.UseVisualStyleBackColor = True
        '
        'lblCurrentPort
        '
        Me.lblCurrentPort.AutoSize = True
        Me.lblCurrentPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPort.Location = New System.Drawing.Point(230, 32)
        Me.lblCurrentPort.Name = "lblCurrentPort"
        Me.lblCurrentPort.Size = New System.Drawing.Size(278, 54)
        Me.lblCurrentPort.TabIndex = 2
        Me.lblCurrentPort.Text = "Current Port"
        '
        'lblPortNumber
        '
        Me.lblPortNumber.BackColor = System.Drawing.Color.Black
        Me.lblPortNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPortNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortNumber.ForeColor = System.Drawing.Color.White
        Me.lblPortNumber.Location = New System.Drawing.Point(123, 97)
        Me.lblPortNumber.Name = "lblPortNumber"
        Me.lblPortNumber.Size = New System.Drawing.Size(570, 241)
        Me.lblPortNumber.TabIndex = 3
        Me.lblPortNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 415)
        Me.Controls.Add(Me.lblPortNumber)
        Me.Controls.Add(Me.lblCurrentPort)
        Me.Controls.Add(Me.btnStopFlood)
        Me.Controls.Add(Me.btnStartFlood)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "The Packet Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStartFlood As System.Windows.Forms.Button
    Friend WithEvents tmrRunner As System.Windows.Forms.Timer
    Friend WithEvents btnStopFlood As System.Windows.Forms.Button
    Friend WithEvents lblCurrentPort As System.Windows.Forms.Label
    Friend WithEvents lblPortNumber As System.Windows.Forms.Label

End Class
