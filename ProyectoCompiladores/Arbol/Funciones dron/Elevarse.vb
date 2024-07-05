Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Header


Public Class Elevarse
    Implements Instruccion

    Private WithEvents timer As New Timer
    Private timeTop As Integer
    Public Sub New()
        Form1.txt_Ejecucion.Text &= "Constructor Elevarse" & Environment.NewLine
        timer.Interval = 45
        timer.Start()
        timeTop = 160

        ' Puedes incluir cualquier lógica necesaria para la acción de encender el motor aquí
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Form1.pb_dron.Top -= 2

        timeTop -= 1
        If timeTop >= 0 Then
            Form1.label_tiempo.Text = "Tiempo restante: " + timeTop.ToString() + " segundos"
        Else
            timer.Stop()
            Form1.label_tiempo.Text = "¡Tiempo agotado!"
        End If
    End Sub

    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        Form1.txt_Ejecucion.Text &= "Elevar el dron ..." & Environment.NewLine
        Return Nothing
    End Function
End Class
