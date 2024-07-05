Public Class RegresarPuntoPartida
    Implements Instruccion

    Private WithEvents timer As New Timer
    Public Sub New()
        Form1.pb_dron.Top = 331
        Form1.txt_Ejecucion.Text &= "Constructor Regresar al punto de partida" & Environment.NewLine
        ' Puedes incluir cualquier lógica necesaria para la acción de encender el motor aquí
    End Sub

    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        Form1.txt_Ejecucion.Text &= "Regresar al punto de partida el dron ..." & Environment.NewLine
        Return Nothing
    End Function
End Class
