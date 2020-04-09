'Imports System.Windows.Forms
'Imports System.Xml
'Imports System.IO

'Public Class InstallPack

'    Public Pack As String
'    Public tempFolder As String
'    Public openSite As String

'    'https://www.codeproject.com/Tips/257193/Easily-Zip-Unzip-Files-using-Windows-Shell
'    Sub UnZip(ByVal zip, ByVal folder)
'        Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))
'        Dim output As Object = shObj.NameSpace((folder))
'        Dim input As Object = shObj.NameSpace((zip))
'        output.CopyHere((input.Items), 4)
'    End Sub

'    Sub copyTree(ByVal parentNode As TreeNode)
'        For Each node As TreeNode In parentNode.Nodes
'            If My.Computer.FileSystem.DirectoryExists(node.Tag) Then
'                copyTree(node)
'            Else
'                If node.Checked Then
'                    Dim folder As String = node.Tag
'                    folder = folder.Replace(tempFolder & "\", "")
'                    Dim split As New ArrayList
'                    For Each s As String In folder.Split("\")
'                        split.Add(s)
'                    Next
'                    split.RemoveAt(0)
'                    folder = ""
'                    For Each s As String In split
'                        folder &= s & "\"
'                    Next
'                    folder = Apricot.ReplaceLast(folder, "\", "")
'                    My.Computer.FileSystem.CopyFile(node.Tag, Path.Combine(openSite, folder))
'                End If
'            End If
'        Next
'    End Sub

'    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
'        copyTree(TreeView1.Nodes(0))
'        Me.DialogResult = System.Windows.Forms.DialogResult.OK
'        Me.Close()
'    End Sub

'    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
'        My.Computer.FileSystem.DeleteDirectory(tempFolder, FileIO.DeleteDirectoryOption.DeleteAllContents)
'        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
'        Me.Close()
'    End Sub

'    'https://stackoverflow.com/a/16787
'    Private Function GetTempFolder() As String
'        Dim folder As String = Path.Combine(Path.GetTempPath, Path.GetRandomFileName)
'        Do While Directory.Exists(folder) Or File.Exists(folder)
'            folder = Path.Combine(Path.GetTempPath, Path.GetRandomFileName)
'        Loop
'        Return folder
'    End Function

'    ' https://stackoverflow.com/a/8182507
'    Sub walkTree(ByVal directory As Shell32.Folder, ByVal dirnode As TreeNode, ByVal isRoot As Boolean)
'        For Each item As Shell32.FolderItem In directory.Items
'            Dim node = dirnode.Nodes.Add(item.Name)
'            node.Tag = item.Path
'            node.ToolTipText = item.Path
'            node.ImageKey = "Other"
'            node.SelectedImageKey = "Other"
'            If item.IsFolder Then
'                If isRoot Then
'                    node.ImageKey = "Package"
'                    node.SelectedImageKey = "Package"
'                Else
'                    node.ImageKey = "Folder"
'                    node.SelectedImageKey = "Folder"
'                End If
'                If item.Name = "in" Then
'                    node.ImageKey = "Page"
'                    node.SelectedImageKey = "Page"
'                    node.Text = "Pages"
'                ElseIf item.Name = "includes" Then
'                    node.ImageKey = "Include"
'                    node.SelectedImageKey = "Include"
'                    node.Text = "Includes"
'                ElseIf item.Name = "templates" Then
'                    node.ImageKey = "Template"
'                    node.SelectedImageKey = "Template"
'                    node.Text = "Templates"
'                End If
'                Dim s As New Shell32.Shell
'                walkTree(s.NameSpace(item), node, False)
'            Else
'                If directory.Title = "in" Then
'                    node.ImageKey = "Page"
'                    node.SelectedImageKey = "Page"
'                ElseIf directory.Title = "includes" Then
'                    node.ImageKey = "Include"
'                    node.SelectedImageKey = "Include"
'                ElseIf directory.Title = "templates" Then
'                    node.ImageKey = "Template"
'                    node.SelectedImageKey = "Template"
'                End If
'                If isRoot Then
'                    If item.Name = "meta.xml" Then
'                        Using reader As XmlReader = XmlReader.Create(item.Path)
'                            While reader.Read()
'                                If reader.IsStartElement() Then
'                                    If reader.Name = "title" Then
'                                        If reader.Read() Then
'                                            PackTitle.Text = reader.Value.Trim()
'                                        End If
'                                    ElseIf reader.Name = "author" Then
'                                        If reader.Read() Then
'                                            PackAuthor.Text = reader.Value.Trim()
'                                        End If
'                                    ElseIf reader.Name = "description" Then
'                                        If reader.Read() Then
'                                            Description.Text = reader.Value.Trim()
'                                        End If
'                                    End If
'                                End If
'                            End While
'                        End Using
'                    End If
'                    node.Remove()
'                End If
'            End If
'        Next
'    End Sub

'    'node.ImageKey = key
'    'node.SelectedImageKey = key
'    'If My.Settings.systemIcons Then
'    '    Try
'    '        Dim splt = node.Text.Split(".")
'    '        Dim ext = splt(splt.Length - 1)
'    '        node.ImageKey = ext
'    '        node.SelectedImageKey = ext
'    '        'If Not VS2017.Images.ContainsKey(ext) Then
'    '            Dim icon As System.Drawing.Icon = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName)
'    '            Dim bitmap As System.Drawing.Bitmap = icon.ToBitmap
'    '            VS2017.Images.Add(ext, icon)
'    '            XP.Images.Add(ext, icon)
'    '        End If
'    '    Catch ex As Exception
'    '    End Try
'    'End If

'    Private Sub InstallPack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        tempFolder = GetTempFolder()
'        openSite = Main.SiteTree.Nodes(0).Tag

'        If Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled Then
'            Me.BackColor = SystemColors.Control
'        End If

'        Description.Text = Pack

'        TreeView1.Nodes.Clear()
'        Dim split As String() = Pack.Split("\")

'        TreeView1.Nodes.Add(split(split.Length - 1))
'        TreeView1.Nodes(0).ImageKey = "Zip"
'        TreeView1.Nodes(0).SelectedImageKey = "Zip"


'        Dim sc As New Shell32.Shell()
'        IO.Directory.CreateDirectory(tempFolder)
'        Dim output As Shell32.Folder = sc.NameSpace(tempFolder)
'        Dim input As Shell32.Folder = sc.NameSpace(Pack)
'        output.CopyHere(input.Items, 4)

'        walkTree(output, TreeView1.Nodes(0), True)
'    End Sub

'    Private Sub checkNodes(ByVal nodes As TreeNodeCollection, ByVal check As Boolean)
'        For Each node As TreeNode In nodes
'            node.Checked = check
'            checkNodes(node.Nodes, check)
'        Next
'    End Sub

'    Private Sub TreeView1_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
'        checkNodes(e.Node.Nodes, e.Node.Checked)
'    End Sub

'    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

'    End Sub
'End Class
