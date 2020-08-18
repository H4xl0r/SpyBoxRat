Public Class REMOTE_BUILDER
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub UcBtnExt2_BtnClick(sender As Object, e As EventArgs) Handles UcBtnExt2.BtnClick
        BuilderClass.Build()
    End Sub
End Class