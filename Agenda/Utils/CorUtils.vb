Public Class CorUtils
    Public Shared Function ConvertToRbg(ByVal HexColor As String) As Drawing.Color
        Dim Red As String
        Dim Green As String
        Dim Blue As String
        HexColor = Replace(HexColor, "#", "")
        Red = Val("&H" & Mid(HexColor, 1, 2))
        Green = Val("&H" & Mid(HexColor, 3, 2))
        Blue = Val("&H" & Mid(HexColor, 5, 2))
        Return Drawing.Color.FromArgb(Red, Green, Blue)
    End Function

End Class
