Public Class KVItem
    Public Key As String
    Public Value As String

    Public Sub New(ByVal k As String, ByVal v As String)
        Key = k
        Value = v
    End Sub

    Public Overrides Function toString() As String
        Return Value
    End Function
End Class
