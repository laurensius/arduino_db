Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ListBox1.Items.Add("Aplikasi dijalankan . . . ")
        ListBox1.Items.Add("Menunggu koneksi ke COM Port . . . ")
        ListBox1.Items.Add("Menunggu koneksi ke Database . . . ")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add("Terhubung di COM 1 . . . ")
        ListBox1.Items.Add("Terhubung ke Database . . . ")
        ListBox1.Items.Add("Diterima data dari Serial . . .")
        ListBox1.Items.Add("Data disimpan ke Database . .  .")
        ComboBox1.Enabled = False
        Button2.Text = "Disconnect COM Port"
        Button2.Enabled = False

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Button1.Text = "Disconnect DB"
        Button1.Enabled = False

        Button3.Text = "Berhenti Baca dan Simpan Data"
    End Sub
End Class
