Public Class Simpanan
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case (ComboBox2.SelectedItem)
            Case "001"
                Dim table As New DataTable("Table")
                table.Columns.Add("No", Type.GetType("System.Int32"))
                table.Columns.Add("ID Transaksi", Type.GetType("System.String"))
                table.Columns.Add("Jenis Transaksi", Type.GetType("System.String"))
                table.Columns.Add("Jumlah Setoran", Type.GetType("System.Int32"))
                table.Columns.Add("Saldo", Type.GetType("System.Int32"))

                table.Rows.Add(1, "001A1T", "Simpanan Pokok", 50000, 50000)
                table.Rows.Add(2, "001A2T", "Simpanan Wajib", 50000, 100000)


                DataGridView1.DataSource = table
        End Select
    End Sub
End Class