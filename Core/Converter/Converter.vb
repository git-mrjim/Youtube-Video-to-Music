Imports Newtonsoft.Json


' The converter class is reponsible for the main function of the system 
' this is the code for converting the video into music 
Public Class Converter

    ' The function convert is the converting function of the system it's convert 
    ' the provided youtube video url into music and download it to the path 
    ' provided in parameter
    Public Shared Function Convert(url As String, path As String) As Dictionary(Of String, Object)


        Dim result As New Dictionary(Of String, Object)

        Try

            Dim pythonPath As String = "C:\Users\ibayj\AppData\Local\Programs\Python\Python311\python.exe"
            Dim scriptPath As String = "C:\Users\ibayj\source\repos\Youtube Video to Music\Core\Converter\main.py"

            Dim processInfo As New ProcessStartInfo()
            processInfo.FileName = pythonPath
            processInfo.Arguments = $"""{scriptPath}"" ""{url}"" ""{path}"""
            processInfo.UseShellExecute = False
            processInfo.RedirectStandardOutput = True
            processInfo.CreateNoWindow = True

            Dim process As New Process()
            process.StartInfo = processInfo

            process.Start()
            Dim output As String = process.StandardOutput.ReadToEnd()
            process.WaitForExit()

            ' This code is for debuging purposes only it's not part of the system functinality
            If process.ExitCode <> 0 Then
                Throw New Exception($"Python script exited with code {process.ExitCode}")
            End If

            result = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(output.Trim())

            Return result

            ' This code is for debuging purposes only it's not part of the system functinality
        Catch ex As Exception

            result("failed") = True
            result("message") = ex.Message

            Return result

        End Try

    End Function
End Class
