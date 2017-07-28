Public Class taskslistpanel
    Private SelectedI As TaskItem
    Event SelectedItemChanged()
    Public Property SelectedItem As TaskItem
        Get
            Return SelectedI
        End Get
        Set(value As TaskItem)
            SelectedI = value
            RaiseEvent SelectedItemChanged()
        End Set
    End Property
End Class
