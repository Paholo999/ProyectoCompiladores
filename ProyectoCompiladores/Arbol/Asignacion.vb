Public Class Asignacion
    Implements Instruccion

    ' Identificador de la variable que queremos asignar
    Private ReadOnly id As String

    ' Valor que se le desea asignar a la variable
    Private ReadOnly valor As Expresion

    Public Sub New()
        Form1.txt_Ejecucion.Text &= "Constructor asignacion " & Environment.NewLine
    End Sub

    'Constructor de la clase, unicamente tiene un constructor ya que la asignación siempre tiene la misma forma
    ' Un identificador y un valor
    Public Sub New(id As String, valor As Expresion)
        Me.id = id
        Me.valor = valor
    End Sub

    Public Sub New(id As String)
        Form1.txt_Ejecucion.Text &= "Se declaro correctamente la variable: " & id & Environment.NewLine
    End Sub

    ' Método que se encarga de actualizar el valor de la variable
    ' En caso no existiera la variable, el error se reporta en el método SetValor
    ' Este método se hereda de la interfaz instrucción
    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        ts.SetValor(id, valor.Ejecutar(ts))
        Form1.txt_Ejecucion.Text &= "Ejecutar simbolos" & Environment.NewLine
        Return Nothing
    End Function
End Class
