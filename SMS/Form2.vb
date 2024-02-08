Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Item As New ListViewItem
        Item.Text = TextBox1.Text
        Item.SubItems.Add(TextBox2.Text)
        Item.SubItems.Add(TextBox3.Text)
        Item.SubItems.Add(TextBox4.Text)
        Item.SubItems.Add(TextBox5.Text)
        ListView1.Items.Add(Item)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
            TextBox4.Text = ListView1.SelectedItems(0).SubItems(3).Text
            TextBox5.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
End Class