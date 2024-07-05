<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txt_Ejecucion = New TextBox()
        btn_Ejecutar = New Button()
        Salir = New Button()
        SuspendLayout()
        ' 
        ' txt_Ejecucion
        ' 
        txt_Ejecucion.BackColor = SystemColors.MenuHighlight
        txt_Ejecucion.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        txt_Ejecucion.ForeColor = SystemColors.Info
        txt_Ejecucion.Location = New Point(12, 50)
        txt_Ejecucion.Multiline = True
        txt_Ejecucion.Name = "txt_Ejecucion"
        txt_Ejecucion.Size = New Size(454, 403)
        txt_Ejecucion.TabIndex = 1
        ' 
        ' btn_Ejecutar
        ' 
        btn_Ejecutar.BackColor = Color.Firebrick
        btn_Ejecutar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Ejecutar.Location = New Point(12, 12)
        btn_Ejecutar.Name = "btn_Ejecutar"
        btn_Ejecutar.Size = New Size(75, 32)
        btn_Ejecutar.TabIndex = 2
        btn_Ejecutar.Text = "Ejecutar"
        btn_Ejecutar.UseVisualStyleBackColor = False
        ' 
        ' Salir
        ' 
        Salir.BackColor = Color.Sienna
        Salir.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Salir.Location = New Point(93, 12)
        Salir.Name = "Salir"
        Salir.Size = New Size(75, 32)
        Salir.TabIndex = 3
        Salir.Text = "Salir"
        Salir.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Sienna
        ClientSize = New Size(478, 468)
        Controls.Add(Salir)
        Controls.Add(btn_Ejecutar)
        Controls.Add(txt_Ejecucion)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btn_Ejecutar As Button
    Public WithEvents txt_Ejecucion As TextBox
    Friend WithEvents Salir As Button

End Class
