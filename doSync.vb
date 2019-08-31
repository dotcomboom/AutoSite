Imports System.IO
' https://www.experts-exchange.com/questions/21618119/I-need-to-create-a-function-in-VB-NET-to-synchronize-2-directories-w-recursion.html
' https://www.experts-exchange.com/members/AlexCode.html
Public Class doSync

    Dim Dir1 As DirectoryInfo
    Dim Dir2 As DirectoryInfo

    Public Enum SyncResults
        Successful = 0
        Unsuccessful = 1
    End Enum

    Public Sub New(ByVal dir1 As String, ByVal dir2 As String)
        Me.Dir1 = New DirectoryInfo(dir1)
        Me.Dir2 = New DirectoryInfo(dir2)

        'Both directories must exist... if not an exception is thrown
        If (Not Me.Dir1.Exists) OrElse (Not Me.Dir2.Exists) Then Throw New DirectoryNotFoundException
    End Sub

    Public Function BeginSynchronization() As SyncResults

        If Me.SyncProcess(Dir1, Dir2) = SyncResults.Unsuccessful Then Return SyncResults.Unsuccessful
        ' DON'T change source folder:
        'If Me.SyncProcess(Dir2, Dir1) = SyncResults.Unsuccessful Then Return SyncResults.Unsuccessful

        Return SyncResults.Successful

    End Function


    Private Function SyncProcess( _
        ByVal sourceDir As DirectoryInfo, _
        ByVal destinationDir As DirectoryInfo) As SyncResults

        Try
            Me.SyncDir(sourceDir, destinationDir)
        Catch ex As Exception
            Return SyncResults.Unsuccessful
        End Try

        Return SyncResults.Successful
    End Function

    Private Sub SyncDir( _
        ByVal sourceDir As DirectoryInfo, _
        ByVal destinationDir As DirectoryInfo)

        Dim files As FileInfo() = sourceDir.GetFiles
        Dim directories As DirectoryInfo() = sourceDir.GetDirectories

        'Sync files...
        For f As Integer = 0 To files.Length - 1
            If File.Exists(destinationDir.FullName & "\" & files(f).Name) Then
                If files(f).LastWriteTime > File.GetLastAccessTime(destinationDir.FullName & "\" & files(f).Name) Then
                    File.Copy(files(f).FullName, destinationDir.FullName & "\" & files(f).Name, True)
                End If
            Else
                File.Copy(files(f).FullName, destinationDir.FullName & "\" & files(f).Name)
            End If
        Next

        'Sync directories
        For d As Integer = 0 To directories.Length - 1
            If Not Directory.Exists(destinationDir.FullName & "\" & directories(d).Name) Then
                Directory.CreateDirectory(destinationDir.FullName & "\" & directories(d).Name)
            End If

            Me.SyncDir(directories(d), New DirectoryInfo(destinationDir.FullName & "\" & directories(d).Name))
        Next

    End Sub

End Class