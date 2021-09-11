Imports Xunit

Public Class OnePassTests
    <Fact>
    Public Sub Test()
        Assert.Equal("One", OnePass.One())
    End Sub
End Class