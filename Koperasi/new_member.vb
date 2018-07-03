Public Class new_member
    Private Sub new_member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Dim table As New DataTable("Table")
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Id", Type.GetType("System.Int32"))
        table.Columns.Add("First Name", Type.GetType("System.String"))
        table.Columns.Add("Last Name", Type.GetType("System.String"))
        table.Columns.Add("Age", Type.GetType("System.Int32"))

        table.Rows.Add(1, "XXXX", "YYYYY", 21)
        table.Rows.Add(2, "SSDD", "hGSQ", 33)
        table.Rows.Add(3, "fgfgd", "jgfdd", 53)
        table.Rows.Add(4, "cvfghyghj", "sdrgtyh", 19)
        table.Rows.Add(5, "hghfd", "ghjgdf", 36)
        table.Rows.Add(6, "cvvdfgh", "juyrfdvc", 63)

        DataGridView1.DataSource = table
    End Sub
End Class