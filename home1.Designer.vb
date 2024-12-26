<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home1))
        Me.toggle = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.SERIES = New Guna.UI2.WinForms.Guna2Button()
        Me.SP = New Guna.UI2.WinForms.Guna2Button()
        Me.PARALLEL = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'toggle
        '
        Me.toggle.BackColor = System.Drawing.Color.Transparent
        Me.toggle.CheckedState.BorderColor = System.Drawing.Color.Lime
        Me.toggle.CheckedState.FillColor = System.Drawing.Color.Lime
        Me.toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle.Location = New System.Drawing.Point(826, 485)
        Me.toggle.Name = "toggle"
        Me.toggle.Size = New System.Drawing.Size(71, 27)
        Me.toggle.TabIndex = 4
        Me.toggle.UncheckedState.BorderColor = System.Drawing.Color.Red
        Me.toggle.UncheckedState.FillColor = System.Drawing.Color.Red
        Me.toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'SERIES
        '
        Me.SERIES.BackColor = System.Drawing.Color.Transparent
        Me.SERIES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SERIES.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SERIES.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SERIES.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SERIES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SERIES.FillColor = System.Drawing.Color.Transparent
        Me.SERIES.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SERIES.ForeColor = System.Drawing.Color.White
        Me.SERIES.Location = New System.Drawing.Point(55, 325)
        Me.SERIES.Name = "SERIES"
        Me.SERIES.Size = New System.Drawing.Size(227, 45)
        Me.SERIES.TabIndex = 5
        '
        'SP
        '
        Me.SP.BackColor = System.Drawing.Color.Transparent
        Me.SP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SP.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SP.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SP.FillColor = System.Drawing.Color.Transparent
        Me.SP.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SP.ForeColor = System.Drawing.Color.White
        Me.SP.Location = New System.Drawing.Point(353, 325)
        Me.SP.Name = "SP"
        Me.SP.Size = New System.Drawing.Size(227, 45)
        Me.SP.TabIndex = 6
        '
        'PARALLEL
        '
        Me.PARALLEL.BackColor = System.Drawing.Color.Transparent
        Me.PARALLEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PARALLEL.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.PARALLEL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.PARALLEL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.PARALLEL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.PARALLEL.FillColor = System.Drawing.Color.Transparent
        Me.PARALLEL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PARALLEL.ForeColor = System.Drawing.Color.White
        Me.PARALLEL.Location = New System.Drawing.Point(658, 325)
        Me.PARALLEL.Name = "PARALLEL"
        Me.PARALLEL.Size = New System.Drawing.Size(227, 45)
        Me.PARALLEL.TabIndex = 7
        '
        'home1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(938, 521)
        Me.Controls.Add(Me.PARALLEL)
        Me.Controls.Add(Me.SP)
        Me.Controls.Add(Me.SERIES)
        Me.Controls.Add(Me.toggle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "home1"
        Me.Text = "T-CPET411LA EXPERIMENT #2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toggle As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents SERIES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SP As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PARALLEL As Guna.UI2.WinForms.Guna2Button
End Class
