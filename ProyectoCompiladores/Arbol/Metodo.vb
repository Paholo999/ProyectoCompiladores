Public Class Metodo
    Implements Instruccion

    ' Alamacena el identificador con el que se guardara un metodo
    Private ReadOnly id As String

    ' Almacena el tipo del metodo que se quiere declarar
    Private ReadOnly tipo As Simbolo.Tipo_Var

    Public Sub New()
        'Form1.txt_Ejecucion.Text &= "" & Environment.NewLine
        ' Puedes incluir cualquier lógica necesaria para la acción de encender el motor aquí
    End Sub

    Public Sub New(valor As String)
        If valor.Equals("true") Then
            Form1.txt_Ejecucion.Text &= "El dron esta encendido VARIABLE encender = " & valor & Environment.NewLine
        Else
            Form1.txt_Ejecucion.Text &= "El dron se apago VARIABLE encender = " & valor & Environment.NewLine
        End If

    End Sub

    Public Sub New(Id As String, tipo As Simbolo.Tipo_Var)
        Me.id = Id
        Me.tipo = tipo
    End Sub

    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        'Form1.txt_Ejecucion.Text &= "metodo ..." & Environment.NewLine
        ts.AddLast(New Simbolo(id, tipo))
        Return Nothing
    End Function
End Class
