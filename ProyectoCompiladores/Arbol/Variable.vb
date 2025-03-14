﻿Public Class Variable
    Implements Instruccion

    ' Alamacena el identificador con el que se guardara una variable
    Private ReadOnly id As String

    ' Almacena el tipo de la variable que se quiere declarar
    Private ReadOnly tipo As Simbolo.Tipo_Var

    Private ReadOnly _token As Object
    Public Sub New(token As Object)
        'Form1.txt_Ejecucion.Text &= "Constructor variable " & token & Environment.NewLine
        '_token = token
    End Sub

    ' Constructor de la clase
    ' Esta clase unicamente tendra un constructor ya que la declaracion siempre tiene la misma forma
    ' Un identificador y un tipo
    Public Sub New(Id As String, tipo As Simbolo.Tipo_Var)
        Me.id = Id
        Me.tipo = tipo

    End Sub

    ' Este metodo se enarga de agregar la nueva variable a nuestra tabla de simbolos
    ' La tabla de simbolos es es la que se recibe como parametro
    ' Este metodo se hereda de la interfaz operacion.

    Public Function Ejecutar(ts As TablaSimbolos) As Object Implements Instruccion.Ejecutar
        'Form1.txt_Ejecucion.Text &= "Variable " & id & Environment.NewLine
        'ts.AddFirst(New Simbolo(id, tipo))
        ts.AddLast(New Simbolo(id, tipo))
        Return Nothing
    End Function
End Class
