Public Class Expresion
    Implements Instruccion

    Private ReadOnly tipo As Tipo_operacion         'Almacena eltipo de operacion a realizar,es una enumeración declarada mas abajo
    Private valor As Object                         'En caso de no ser una oepración, se almacena el valor 

    Public Sub New()
        Form1.txt_Ejecucion.Text &= "Constructor expresion " & Environment.NewLine
    End Sub

    ' Este constructor se utiliza para el acceso a las variables
    Public Sub New(a As String, tipo As Tipo_operacion)
        Me.valor = a
        Me.tipo = tipo
    End Sub

    ' Constructor que se utiliza para los números
    Public Sub New(a As Double)
        Me.valor = a
        Me.tipo = Tipo_operacion.NUMERO

    End Sub

    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        Form1.txt_Ejecucion.Text &= "Ejecutar simbolos" & Environment.NewLine

        If tipo = Tipo_operacion.LOGICO Then
            Return valor.ToString
        ElseIf tipo = Tipo_operacion.NUMERO Then
            Return Double.Parse(valor.ToString)
        ElseIf tipo = Tipo_operacion.IDENTIFICADOR Then
            Return ts.GetValor(valor.ToString())
        Else
            Return Nothing
        End If
    End Function

    ' Esta enumeración almacena todos los tipos posibles de operaciones.
    ' Si se desea escalar este ejemplo seria util crear una interfaz expresion
    ' Y separar cada uno de los tipos de operacion en una clase aparte en la que todas hereden de expresion
    Public Enum Tipo_operacion
        LOGICO
        NUMERO
        IDENTIFICADOR
    End Enum
End Class
