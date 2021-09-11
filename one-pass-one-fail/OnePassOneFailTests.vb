Imports Xunit

Public Class OnePassOneFailTests
    <Fact>
    Public Sub Test()
        Assert.Equal("One", OnePassOneFail.One())
    End Sub

    <Fact>
    Public Sub Test2()
        Assert.Equal("Two", OnePassOneFail.One())
    End Sub
End Class