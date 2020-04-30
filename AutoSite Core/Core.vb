Module Core

    Sub Main(ByVal args() As String)
        Dim version = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        If My.Application.Info.Version.Build > 0 Then
            version &= "." & My.Application.Info.Version.Build
        End If
        If My.Application.Info.Version.Revision > 0 Then
            version &= "." & My.Application.Info.Version.Revision
        End If
        version &= " " & My.Application.Info.Description
        Console.Title = My.Application.Info.ProductName & " " & version
        Console.WriteLine(" _______       _____      _________________        ")
        Console.WriteLine(" ___    |___  ___  /________  ___/__(_)_  /_____   ")
        Console.WriteLine(" __  /| |  / / /  __/  __ \____ \__  /_  __/  _ \  Core")
        Console.WriteLine(" _  ___ / /_/ // /_ / /_/ /___/ /_  / / /_ /  __/  " & version)
        Console.WriteLine(" /_/  |_\__,_/ \__/ \____//____/ /_/  \__/ \___/ ")
        Console.WriteLine()
        If args.Length > 0 Then
            Apricot.buildSite(args(0))
        Else
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory())
            Console.WriteLine()
            Console.Write("To build, strike any key. ")
            Console.ReadKey()
            Console.WriteLine()
            Apricot.buildSite(System.IO.Directory.GetCurrentDirectory())
        End If
    End Sub

End Module