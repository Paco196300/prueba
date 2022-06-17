<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BttInicio = New System.Windows.Forms.Button()
        Me.BttSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BttInicio
        '
        Me.BttInicio.Location = New System.Drawing.Point(12, 12)
        Me.BttInicio.Name = "BttInicio"
        Me.BttInicio.Size = New System.Drawing.Size(104, 48)
        Me.BttInicio.TabIndex = 0
        Me.BttInicio.Text = "Inicio"
        Me.BttInicio.UseVisualStyleBackColor = True
        '
        'BttSalir
        '
        Me.BttSalir.Location = New System.Drawing.Point(684, 12)
        Me.BttSalir.Name = "BttSalir"
        Me.BttSalir.Size = New System.Drawing.Size(104, 48)
        Me.BttSalir.TabIndex = 1
        Me.BttSalir.Text = "Salir"
        Me.BttSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 137)
        Me.Controls.Add(Me.BttSalir)
        Me.Controls.Add(Me.BttInicio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BttInicio As Button
    Friend WithEvents BttSalir As Button
End Class
