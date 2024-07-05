Public Class AST
    Public instrucciones As LinkedList(Of Instruccion)

    Public Sub New(instrucciones As LinkedList(Of Instruccion))
        Me.instrucciones = instrucciones
    End Sub

    Public Sub Ejecutar()
        Dim ts As New TablaSimbolos()
        For Each ins As Instruccion In instrucciones
            ins.Ejecutar(ts)
        Next
    End Sub
End Class
