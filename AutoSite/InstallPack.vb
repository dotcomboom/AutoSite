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

    ' https://stackoverflow.com/a/8182507
    Sub walkTree(ByVal directory As Shell32.Folder, ByVal parentNode As TreeNode)
        Dim dirnode = parentNode
        For Each item As Shell32.FolderItem In directory.Items
            If item.IsFolder Then
                Dim node = dirnode.Nodes.Add(item.Name)
                node.Tag = item.Path
                'For Each subDir As Shell32.FolderItem In directory.Items
                'walkTree(subDir.GetFolder(), dirnode)
                'Next
            Else
                Dim node = dirnode.Nodes.Add(item.Name)
                node.Tag = item.Path
            End If
            'node.ImageKey = key
            'node.SelectedImageKey = key
            'If My.Settings.systemIcons Then
            '    Try
            '        Dim splt = node.Text.Split(".")
            '        Dim ext = splt(splt.Length - 1)
            '        node.ImageKey = ext
            '        node.SelectedImageKey = ext
            '        'If Not VS2017.Images.ContainsKey(ext) Then
            '            Dim icon As System.Drawing.Icon = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName)
            '            Dim bitmap As System.Drawing.Bitmap = icon.ToBitmap
            '            VS2017.Images.Add(ext, icon)
            '            XP.Images.Add(ext, icon)
            '        End If
            '    Catch ex As Exception
            '    End Try
            'End If
        Next
    End Sub

    Private Sub InstallPack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Text = Pack

        Dim shell As New Shell32.Shell
        'Dim output As Object = shObj.NameSpace((folder))
        Dim input As Shell32.Folder = shell.NameSpace((Pack))

        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add("(Root Node)")

        walkTree(input, TreeView1.Nodes(0))

        'walkTree(My.Computer.FileSystem.GetDirectoryInfo(inPath), "*", pages, "Page", False)
        'walkTree(My.Computer.FileSystem.GetDirectoryInfo(templatePath), "*", templates, "Template", False)
        'walkTree(My.Computer.FileSystem.GetDirectoryInfo(includePath), "*", includes, "Include", False)
    End Sub
End Class
