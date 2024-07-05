Imports System.IO
Imports System.Text
Imports ScottPlot.Colormaps

Public Class Form1

    Private Sub btn_Ejecutar_Click(sender As Object, e As EventArgs) Handles btn_Ejecutar.Click

        txt_Ejecucion.Clear()

        Setup()

        Dim filePath As String = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "entrada.txt")
        'Dim fileReader As String = My.Computer.FileSystem.ReadAllText(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "entrada.txt"))
        Dim errores As New StringBuilder()
        Dim correctas As New StringBuilder()
        Dim ejecutadoExitosamente As Boolean = True

        Dim lines As String() = File.ReadAllLines(filePath)

        Try
            For Each line As String In lines
                If Parse(New StringReader(line)) Then
                    Try
                        ObtenerArbol().Ejecutar()
                        correctas.AppendLine("Línea ejecutada exitosamente: " & line & Environment.NewLine)
                        'txt_Ejecucion.Text &= "Ejecutado exitosamente"
                    Catch ex As Exception
                        errores.AppendLine("Error ejecutando la línea: " & line & " - " & ex.Message)
                        'txt_Ejecucion.Text &= "Error" & ex.Message
                        ejecutadoExitosamente = False
                    End Try
                Else
                    errores.AppendLine("Error de análisis en la línea: " & line)
                    'errores.AppendLine("Error de análisis")
                    ejecutadoExitosamente = False
                End If
                'txt_Ejecucion.Text &= "Línea ejecutada exitosamente: " & line & Environment.NewLine

            Next

            'For Each simbolo As Simbolo In ts
            'txt_Ejecucion.Text &= simbolo.Id & Environment.NewLine
            'Next


        Catch ex As Exception
            errores.AppendLine("Error leyendo el archivo: " & ex.Message)
            ejecutadoExitosamente = False
        End Try



        If Not ejecutadoExitosamente Then
            txt_Ejecucion.Text &= "No se pudieron ejecutar todas las líneas:" & Environment.NewLine & errores.ToString()
        Else
            txt_Ejecucion.Text &= correctas.ToString()
        End If




    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ts = New TablaSimbolos()
        ts2 = New TablaSimbolos()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub
End Class
