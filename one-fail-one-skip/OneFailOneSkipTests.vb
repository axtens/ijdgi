Imports Xunit

Public Class OneFailOneSKipTests
    <Fact>
    Public Sub Test()
        Assert.Equal("Two", OneFailOneSkip.One())
    End Sub

    <Fact(Skip:="Remove this Skip property to run this test")>
    Public Sub Test3()
        Assert.Equal("Three", OneFailOneSkip.One())
    End Sub
End Class