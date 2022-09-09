Public Class Form1
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        lboNombre.Items.Add(txtNombre.Text)
        lboEdad.Items.Add(txtEdad.Text)
        lboTelefono.Items.Add(txtTelefono.Text)
        lboECivil.Items.Add(IIf(CheckBox1.Checked, "Casado", "Soltero"))
        lboIndice.Items.Add(" " + lboNombre.Items.Count.ToString + " -")
        txtIngresados.Text = lboIndice.Items.Count
        txtNombre.Text = ""
        txtEdad.Text = ""
        txtTelefono.Text = ""
        CheckBox1.CheckState = CheckState.Unchecked
        txtNombre.Focus()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim i As Integer = lboIndice.SelectedIndex
        lboNombre.Items.RemoveAt(i)
        lboEdad.Items.RemoveAt(i)
        lboTelefono.Items.RemoveAt(i)
        lboECivil.Items.RemoveAt(i)
        lboIndice.Items.RemoveAt(lboIndice.Items.Count - 1)
        txtIngresados.Text = lboIndice.Items.Count
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtEdad.Text = ""
        CheckBox1.CheckState = CheckState.Unchecked
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class
