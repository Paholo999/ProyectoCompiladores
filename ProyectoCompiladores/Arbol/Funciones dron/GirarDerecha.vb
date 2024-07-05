Public Class GirarDerecha
    Implements Instruccion
    Public Sub New()
        Form1.txt_Ejecucion.Text &= "Constructor Girar a la derecha" & Environment.NewLine
        ' Puedes incluir cualquier lógica necesaria para la acción de encender el motor aquí
    End Sub

    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        Form1.txt_Ejecucion.Text &= "Girar a la derecha al dron ..." & Environment.NewLine
        Return Nothing
    End Function
End Class
