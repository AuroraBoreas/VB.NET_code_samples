﻿Imports System.ComponentModel

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = True
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
        Form1.Show()
    End Sub
End Class