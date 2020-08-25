<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Log_Form
    Inherits Custom_Form
    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AeroListView1 = New AnonMon.AeroListView()
        Me.SuspendLayout()
        '
        'AeroListView1
        '
        Me.AeroListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AeroListView1.HideSelection = False
        Me.AeroListView1.Location = New System.Drawing.Point(10, 10)
        Me.AeroListView1.Name = "AeroListView1"
        Me.AeroListView1.Size = New System.Drawing.Size(315, 198)
        Me.AeroListView1.TabIndex = 0
        Me.AeroListView1.UseCompatibleStateImageBehavior = False
        Me.AeroListView1.View = System.Windows.Forms.View.List
        '
        'Log_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 218)
        Me.Controls.Add(Me.AeroListView1)
        Me.Name = "Log_Form"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Log_Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AeroListView1 As AeroListView
End Class
