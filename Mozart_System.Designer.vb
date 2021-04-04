<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mozart_System
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mozart_System))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnCrops = New System.Windows.Forms.Button()
        Me.btnOfficeBarn = New System.Windows.Forms.Button()
        Me.btnSafetySystem = New System.Windows.Forms.Button()
        Me.btnFieldSys = New System.Windows.Forms.Button()
        Me.btnEquipSys = New System.Windows.Forms.Button()
        Me.btnWeatherSys = New System.Windows.Forms.Button()
        Me.btnProductSys = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(374, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mozart System"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.BackColor = System.Drawing.Color.Transparent
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.Color.White
        Me.lblOutput.Location = New System.Drawing.Point(300, 155)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Padding = New System.Windows.Forms.Padding(5)
        Me.lblOutput.Size = New System.Drawing.Size(147, 35)
        Me.lblOutput.TabIndex = 9
        Me.lblOutput.Text = "OUTPUT TEXT"
        Me.lblOutput.Visible = False
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(20, 99)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(194, 50)
        Me.btnEmployee.TabIndex = 10
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnCrops
        '
        Me.btnCrops.Location = New System.Drawing.Point(20, 155)
        Me.btnCrops.Name = "btnCrops"
        Me.btnCrops.Size = New System.Drawing.Size(194, 50)
        Me.btnCrops.TabIndex = 11
        Me.btnCrops.Text = "Crops"
        Me.btnCrops.UseVisualStyleBackColor = True
        '
        'btnOfficeBarn
        '
        Me.btnOfficeBarn.Location = New System.Drawing.Point(20, 211)
        Me.btnOfficeBarn.Name = "btnOfficeBarn"
        Me.btnOfficeBarn.Size = New System.Drawing.Size(194, 50)
        Me.btnOfficeBarn.TabIndex = 12
        Me.btnOfficeBarn.Text = "Office Barn"
        Me.btnOfficeBarn.UseVisualStyleBackColor = True
        '
        'btnSafetySystem
        '
        Me.btnSafetySystem.Location = New System.Drawing.Point(20, 267)
        Me.btnSafetySystem.Name = "btnSafetySystem"
        Me.btnSafetySystem.Size = New System.Drawing.Size(194, 50)
        Me.btnSafetySystem.TabIndex = 13
        Me.btnSafetySystem.Text = "Safety System"
        Me.btnSafetySystem.UseVisualStyleBackColor = True
        '
        'btnFieldSys
        '
        Me.btnFieldSys.Location = New System.Drawing.Point(20, 323)
        Me.btnFieldSys.Name = "btnFieldSys"
        Me.btnFieldSys.Size = New System.Drawing.Size(194, 50)
        Me.btnFieldSys.TabIndex = 14
        Me.btnFieldSys.Text = "Field System"
        Me.btnFieldSys.UseVisualStyleBackColor = True
        '
        'btnEquipSys
        '
        Me.btnEquipSys.Location = New System.Drawing.Point(20, 379)
        Me.btnEquipSys.Name = "btnEquipSys"
        Me.btnEquipSys.Size = New System.Drawing.Size(194, 50)
        Me.btnEquipSys.TabIndex = 15
        Me.btnEquipSys.Text = "Equipment System"
        Me.btnEquipSys.UseVisualStyleBackColor = True
        '
        'btnWeatherSys
        '
        Me.btnWeatherSys.Location = New System.Drawing.Point(20, 435)
        Me.btnWeatherSys.Name = "btnWeatherSys"
        Me.btnWeatherSys.Size = New System.Drawing.Size(194, 50)
        Me.btnWeatherSys.TabIndex = 16
        Me.btnWeatherSys.Text = "Weather System"
        Me.btnWeatherSys.UseVisualStyleBackColor = True
        '
        'btnProductSys
        '
        Me.btnProductSys.Location = New System.Drawing.Point(20, 491)
        Me.btnProductSys.Name = "btnProductSys"
        Me.btnProductSys.Size = New System.Drawing.Size(194, 50)
        Me.btnProductSys.TabIndex = 17
        Me.btnProductSys.Text = "Product Storage System"
        Me.btnProductSys.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(20, 547)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(194, 50)
        Me.btnImport.TabIndex = 18
        Me.btnImport.Text = "Import Data"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Mozart_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1088, 640)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnProductSys)
        Me.Controls.Add(Me.btnWeatherSys)
        Me.Controls.Add(Me.btnEquipSys)
        Me.Controls.Add(Me.btnFieldSys)
        Me.Controls.Add(Me.btnSafetySystem)
        Me.Controls.Add(Me.btnOfficeBarn)
        Me.Controls.Add(Me.btnCrops)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Mozart_System"
        Me.Text = "Mozart System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnCrops As Button
    Friend WithEvents btnOfficeBarn As Button
    Friend WithEvents btnSafetySystem As Button
    Friend WithEvents btnFieldSys As Button
    Friend WithEvents btnEquipSys As Button
    Friend WithEvents btnWeatherSys As Button
    Friend WithEvents btnProductSys As Button
    Friend WithEvents btnImport As Button
End Class
