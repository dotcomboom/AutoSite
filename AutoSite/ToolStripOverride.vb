Imports System.Windows.Forms

Namespace OverrideControls
    Public Class ToolStripOverride
        Inherits ToolStripSystemRenderer

        ' https://www.gorancic.com/blog/removing-white-border-in-a-toolstrip/ thanks 🎉

        Public Sub New()
        End Sub

        Protected Overrides Sub OnRenderToolStripBorder(ByVal e As ToolStripRenderEventArgs)
        End Sub
    End Class
End Namespace