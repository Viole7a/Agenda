Public Class CorUtils

    Public Shared Sub carregaComboCores(ByVal dropDownList As DropDownList)

        dropDownList.Items.Add(New ListItem)

        Dim listColor As New ArrayList
        listColor.Add("#6959CD")
        listColor.Add("#6495ED")
        listColor.Add("#4682B4")
        listColor.Add("#008B8B")
        listColor.Add("#00FA9A")
        listColor.Add("#7CFC00")
        listColor.Add("#A0522D")
        listColor.Add("#BA55D3")
        listColor.Add("#DDA0DD")

        For Each cor In listColor
            Dim item = New ListItem
            item.Value = cor.ToString
            item.Text = "                 ..."
            item.Attributes.Add("style", "background-color:" & cor.ToString)

            dropDownList.Items.Add(item)
        Next

    End Sub


End Class
