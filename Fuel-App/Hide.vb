Imports System.ComponentModel

Public Class Hidee

    Public Shared Sub cleaning(ByVal container As Control)
        ' Declare a single-dimension array and set its 4 values.
        Dim numbers = New Integer() {1, 2, 4, 8}

        ' Declare a 4 x 3 multidimensional array and set array element values.
        Dim matrix = New Integer(,) {{1, 2, 3}, {2, 3, 4}, {3, 4, 5}, {4, 5, 6}}

        Dim sales()() As Double = New Double(11)() {}
        For Each txt As TextBox In container.Controls.OfType(Of TextBox)()
            txt.Visible = False
        Next

        For Each rdo As RadioButton In container.Controls.OfType(Of RadioButton)()
            rdo.Visible = False
        Next

        For Each btn As Button In container.Controls.OfType(Of Button)()
            btn.Visible = False
        Next

        For Each lbl As Label In container.Controls.OfType(Of Label)()
            lbl.Visible = False
        Next

        For Each pcbx As PictureBox In container.Controls.OfType(Of PictureBox)()
            pcbx.Visible = False
        Next
    End Sub
End Class