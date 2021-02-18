'      Name: Einstein Project
' Programer: Jesse Iberri
'      Date: 02/15/2020
'   Purpose: Show / hide an equation.

Imports System.ComponentModel

Public Class frmMain
    ' Close form on exit button click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' Show Einstein's equation
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If Not picEquation.Visible Then
            picEquation.Visible = True
        End If
    End Sub

    ' Hide Einstein's equation
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        If picEquation.Visible Then
            picEquation.Visible = False
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'some debug for fun
        'Dim responseVal As MsgBoxResult
        'responseVal = Prompt_Exit()
        'MsgBox("Result is " + responseVal.ToString())

        If Prompt_Exit() = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    ' Prompt on exit
    Function Prompt_Exit() As MsgBoxResult
        Return MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, Nothing)
    End Function
End Class
