Imports Apricot

Module Core

    Sub Main(ByVal args() As String)
        If args.Length > 0 Then
            Apricot.buildSite(args(0))
        Else
            Console.WriteLine("No folder was passed. To build " + System.IO.Directory.GetCurrentDirectory() + " strike any key.")
            Console.ReadKey()
            Apricot.buildSite(System.IO.Directory.GetCurrentDirectory())
        End If
    End Sub

End Module
