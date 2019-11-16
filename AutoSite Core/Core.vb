Imports Apricot

Module Core

    Sub Main(ByVal args() As String)
        If args.Length > 0 Then
            Apricot.buildSite(args(0))
        Else
            Apricot.buildSite(System.IO.Directory.GetCurrentDirectory())
        End If
        Console.Read()
    End Sub

End Module
