Imports Xunit

Public Class OneFailTests
    <Fact>
    Public Sub Test()
        Assert.Equal("One", OneFail.One())
    End Sub
End Class