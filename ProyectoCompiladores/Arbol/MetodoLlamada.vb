Public Class MetodoLlamada
    Implements Instruccion
    Public Sub New()
        'Form1.txt_Ejecucion.Text &= "Constructor metodo llamada " & Environment.NewLine
        ' Puedes incluir cualquier lógica necesaria para la acción de encender el motor aquí
    End Sub

    Public Sub New(nombre As String)
        'Form1.txt_Ejecucion.Text &= "Constructor metodo llamada: " & nombre & Environment.NewLine
        ' Puedes incluir cualquier lógica necesaria para la acción de encender el motor aquí
    End Sub

    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        'Form1.txt_Ejecucion.Text &= "metodo llamada ..." & Environment.NewLine
        Return Nothing
    End Function
End Class
