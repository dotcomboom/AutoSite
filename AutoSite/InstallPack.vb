Imports System.Windows.Forms

Public Class InstallPack

    Public Pack As String = ""

    'https://www.codeproject.com/Tips/257193/Easily-Zip-Unzip-Files-using-Windows-Shell
    Sub UnZip(ByVal zip, ByVal folder)
        Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))
        Dim output As Object = shObj.NameSpace((folder))
        Dim input As Object = shObj.NameSpace((zip))
        output.CopyHere((input.Items), 4)
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub InstallPack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Text = Pack

        Dim shell As New Shell32.Shell
        'Dim output As Object = shObj.NameSpace((folder))
        Dim input As Shell32.Folder = shell.NameSpace((Pack))
        MsgBox(input.Items.Count)

        'walkTree(My.Computer.FileSystem.GetDirectoryInfo(inPath), "*", pages, "Page", False)
        'walkTree(My.Computer.FileSystem.GetDirectoryInfo(templatePath), "*", templates, "Template", False)
        'walkTree(My.Computer.FileSystem.GetDirectoryInfo(includePath), "*", includes, "Include", False)
    End Sub
End Class
