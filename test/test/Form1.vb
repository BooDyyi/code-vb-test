﻿Imports System.Net
Public Class Form1
    Dim web As New WebClient
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Hide()
        Label4.Hide()
        Timer1.Start()
        Label1.Text = web.DownloadString("https://dl.dropbox.com/s/crhekgbkldqozoj/online.txt")
        Label4.Text = web.DownloadString("https://dl.dropbox.com/s/lqxy2waeu4c0p4e/ready.txt")

        XComment("test")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("https://www.facebook.com/BooDyyi") 'vb.net
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Process.Start("hi.txt") 'vb.net
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(9)
        If ProgressBar1.Value = 100 Then

        End If
        Label2.Text = ProgressBar1.Value & ("%")
        If ProgressBar1.Value = 100 Then
            Button1.Show()
            Label2.Hide()
            Label4.Show()
            Label5.Hide()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("we don't have now")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Close()
    End Sub
End Class
