Public Class ApagarMotor
    Implements Instruccion
    Public Sub New()
        Form1.txt_Ejecucion.Text &= "Constructor Apagar el motor" & Environment.NewLine
        ' Puedes incluir cualquier lógica necesaria para la acción de encender el motor aquí
    End Sub

    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        Form1.txt_Ejecucion.Text &= "Apagar el motor ..." & Environment.NewLine
        Return Nothing
    End Function
End Class
