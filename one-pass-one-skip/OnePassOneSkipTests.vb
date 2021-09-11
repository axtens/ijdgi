Imports Xunit

Public Class OnePassOneSkipTests
    <Fact>
    Public Sub Test()
        Assert.Equal("One", OnePassOneSkip.One())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Test3()
        Assert.Equal("Three", OnePassOneSkip.One())
    End Sub
End Class