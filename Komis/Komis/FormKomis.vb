Imports System
Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.Common
Imports System.IO

Public Class FormKomis

    Dim dbConnection As SqlCeConnection
    Dim samochodyDataSet As New wybranyKomisDataSet
    Dim samochodySqlCeDataAdapter As SqlCeDataAdapter
    Dim samochodyDataTable As New DataTable

    'Dim daneWEdycji As New Boolean

    Private Sub FormKomis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControlKomis.TabPages.Remove(TabPageEditor)

        TextBoxClientYear.ReadOnly = True
        TextBoxClientPrice.ReadOnly = True
        TextBoxClientKlima.ReadOnly = True
        TextBoxClientAlarm.ReadOnly = True

        TextBoxid.ReadOnly = True
        TextBoxBrand.ReadOnly = True
        TextBoxModel.ReadOnly = True
        TextBoxEngine.ReadOnly = True
        TextBoxColour.ReadOnly = True
        TextBoxYear.ReadOnly = True
        TextBoxPrice.ReadOnly = True
        ComboBoxEditMetalic.Enabled = False
        ComboBoxEditKlima.Enabled = False
        ComboBoxEditAlarm.Enabled = False
        ButtonAddPhoto.Enabled = False
        TextBoxZdjecie.ReadOnly = True

    End Sub

    Private Sub EdytujToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdytujToolStripMenuItem.Click

        If (TabControlKomis.TabPages.Contains(TabPageEditor) = False) Then

            Dim getPass As New FormPassword()
            getPass.ShowDialog()

            If getPass.Password = "a" Then

                TabControlKomis.TabPages.Add(TabPageEditor)
                EdytujToolStripMenuItem.Text = "Zakoncz edycje"
                dbConnection = Nothing
                samochodyDataSet = Nothing
                samochodyDataSet = New wybranyKomisDataSet
                samochodySqlCeDataAdapter = Nothing

            Else

                MsgBox("Niepoprawne hasło")

            End If

        Else

            TabControlKomis.TabPages.Remove(TabPageEditor)
            EdytujToolStripMenuItem.Text = "Edytuj"

            dbConnection = Nothing
            samochodyDataSet = Nothing
            samochodyDataSet = New wybranyKomisDataSet
            samochodySqlCeDataAdapter = Nothing
            RefreshComboboxBrand()

        End If

    End Sub

    Private Sub KoniecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KoniecToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OProgramieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OProgramieToolStripMenuItem.Click
        MsgBox("Program Komis Samochodowy" & vbCrLf & "Michał Lewandowski 2017")
    End Sub

    Private Sub ButtonFirst_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        BindingSourceSamochody.Position = 0
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        BindingSourceSamochody.Position = BindingSourceSamochody.Count - 1
    End Sub

    Private Sub ButtonPrev_Click(sender As Object, e As EventArgs) Handles ButtonPrev.Click
        BindingSourceSamochody.Position -= 1
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        BindingSourceSamochody.Position += 1
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        TextBoxid.ReadOnly = False
        TextBoxBrand.ReadOnly = False
        TextBoxModel.ReadOnly = False
        TextBoxEngine.ReadOnly = False
        TextBoxColour.ReadOnly = False
        TextBoxYear.ReadOnly = False
        TextBoxPrice.ReadOnly = False
        ComboBoxEditMetalic.Enabled = True
        ComboBoxEditKlima.Enabled = True
        ComboBoxEditAlarm.Enabled = True
        ButtonAddPhoto.Enabled = True

        TextBoxid.Focus()

        Dim iStartRec = BindingSourceSamochody.Position
        BindingSourceSamochody.AddNew()
        Dim obrazek As String = TextBoxZdjecie.Text
        RefreshEditPicture(obrazek)

    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click

        Dim iResponse As DialogResult

        iResponse = MessageBox.Show("Czy chcesz na pewno usunąc wiersz ?", _
        "potwierdz", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iResponse = Windows.Forms.DialogResult.Yes Then
            BindingSourceSamochody.RemoveAt(BindingSourceSamochody.Position)
        End If

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        TextBoxid.ReadOnly = False
        TextBoxBrand.ReadOnly = False
        TextBoxModel.ReadOnly = False
        TextBoxEngine.ReadOnly = False
        TextBoxColour.ReadOnly = False
        TextBoxYear.ReadOnly = False
        TextBoxPrice.ReadOnly = False
        ComboBoxEditMetalic.Enabled = True
        ComboBoxEditKlima.Enabled = True
        ComboBoxEditAlarm.Enabled = True
        TextBoxid.Focus()
        ButtonAddPhoto.Enabled = True

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        Dim iCurrentRecord As Integer
        BindingSourceSamochody.EndEdit()
        iCurrentRecord = BindingSourceSamochody.Position

        If samochodyDataSet.HasChanges() = True Then

            samochodySqlCeDataAdapter.Update(samochodyDataSet, "samochody")
            samochodySqlCeDataAdapter.Fill(samochodyDataSet)

        End If

        TextBoxid.ReadOnly = True
        TextBoxBrand.ReadOnly = True
        TextBoxModel.ReadOnly = True
        TextBoxEngine.ReadOnly = True
        TextBoxColour.ReadOnly = True
        TextBoxYear.ReadOnly = True
        TextBoxPrice.ReadOnly = True
        ComboBoxEditMetalic.Enabled = False
        ComboBoxEditKlima.Enabled = False
        ComboBoxEditAlarm.Enabled = False

        BindingSourceSamochody.Position = iCurrentRecord

        ButtonAddPhoto.Enabled = False

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click

        BindingSourceSamochody.CancelEdit()
        TextBoxid.ReadOnly = True
        TextBoxBrand.ReadOnly = True
        TextBoxModel.ReadOnly = True
        TextBoxEngine.ReadOnly = True
        TextBoxColour.ReadOnly = True
        TextBoxYear.ReadOnly = True
        TextBoxPrice.ReadOnly = True
        ComboBoxEditMetalic.Enabled = False
        ComboBoxEditKlima.Enabled = False
        ComboBoxEditAlarm.Enabled = False

        ButtonAddPhoto.Enabled = False

    End Sub

    Private Sub ButtonSelectDatabase_Click(sender As Object, e As EventArgs) Handles ButtonSelectDatabase.Click

        Dim openFileDialog1 As New OpenFileDialog()
        Dim iResult As DialogResult
        openFileDialog1.Title = "Podaj plik bazy danych"
        openFileDialog1.Filter = "SDF Files (*.sdf) | *.sdf"

        openFileDialog1.CheckFileExists = True
        iResult = openFileDialog1.ShowDialog()

        If iResult <> Windows.Forms.DialogResult.Cancel And openFileDialog1.FileName.Length <> 0 Then

            samochodyDataSet = Nothing
            samochodyDataSet = New wybranyKomisDataSet

            Dim sConStr As String
            sConStr = "Data Source=" & openFileDialog1.FileName & "; Persist Security Info=False" 'zwraca "Data Source=C:\TK2\Komis_2\Komis\Komis\bin\Debug\salonJaponski.sdf; Persist Security Info=False"

            dbConnection = New SqlCeConnection(sConStr)

            samochodySqlCeDataAdapter = Nothing
            samochodySqlCeDataAdapter = New SqlCeDataAdapter("select * from Samochody", dbConnection)

            Dim commandBuilder As New SqlCeCommandBuilder(samochodySqlCeDataAdapter)

            Try
                samochodySqlCeDataAdapter.Fill(samochodyDataSet, "samochody")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            BindingSourceSamochody = Nothing
            BindingSourceSamochody = New BindingSource(samochodyDataSet, "samochody")

            RefreshComboboxBrand()

        End If

    End Sub

    Private Sub ButtonSelectDatabase2_Click(sender As Object, e As EventArgs) Handles ButtonSelectDatabase2.Click

        Dim openFileDialog1 As New OpenFileDialog()
        Dim iResult As DialogResult
        openFileDialog1.Title = "Podaj plik bazy danych"
        openFileDialog1.Filter = "SDF Files (*.sdf) | *.sdf"

        openFileDialog1.CheckFileExists = True
        iResult = openFileDialog1.ShowDialog()

        If iResult <> Windows.Forms.DialogResult.Cancel And openFileDialog1.FileName.Length <> 0 Then

            TextBoxid.DataBindings.Clear()
            TextBoxBrand.DataBindings.Clear()
            TextBoxModel.DataBindings.Clear()
            TextBoxEngine.DataBindings.Clear()
            TextBoxColour.DataBindings.Clear()
            TextBoxYear.DataBindings.Clear()
            TextBoxPrice.DataBindings.Clear()
            ComboBoxEditMetalic.DataBindings.Clear()
            ComboBoxEditKlima.DataBindings.Clear()
            ComboBoxEditAlarm.DataBindings.Clear()
            TextBoxZdjecie.DataBindings.Clear()
            DataGridViewSamochody.DataBindings.Clear()
            samochodyDataSet = Nothing
            samochodyDataSet = New wybranyKomisDataSet

            Dim sConStr As String
            sConStr = "Data Source=" & openFileDialog1.FileName & "; Persist Security Info=False" 'zwraca "Data Source=C:\TK2\Komis_2\Komis\Komis\bin\Debug\salonJaponski.sdf; Persist Security Info=False"
            dbConnection = New SqlCeConnection(sConStr)

            samochodySqlCeDataAdapter = Nothing
            samochodySqlCeDataAdapter = New SqlCeDataAdapter("select * from Samochody", dbConnection)
            Dim commandBuilder As New SqlCeCommandBuilder(samochodySqlCeDataAdapter)

            Try
                samochodySqlCeDataAdapter.Fill(samochodyDataSet, "samochody")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            BindingSourceSamochody = Nothing
            BindingSourceSamochody = New BindingSource(samochodyDataSet, "samochody")

            DataGridViewSamochody.DataSource = BindingSourceSamochody
            TextBoxid.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "Id", True)) ' to działa!!!
            TextBoxBrand.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "marka", True))
            TextBoxModel.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "model", True))
            TextBoxEngine.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "silnik", True))
            TextBoxColour.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "kolor", True))
            TextBoxYear.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "rok", True))
            TextBoxPrice.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "cena", True))
            ComboBoxEditMetalic.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "metalic", False, DataSourceUpdateMode.OnPropertyChanged, False))
            ComboBoxEditKlima.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "klimatyzacja", False, DataSourceUpdateMode.OnPropertyChanged, False))
            ComboBoxEditAlarm.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "alarm", False, DataSourceUpdateMode.OnPropertyChanged, False))
            TextBoxZdjecie.DataBindings.Add(New Binding("Text", BindingSourceSamochody, "zdjecie", True))

        End If

    End Sub

    Private Sub RefreshComboboxBrand()

        Dim listaMarek As List(Of String) = New List(Of String)
        listaMarek.Clear()

        For Each m As DataRowView In BindingSourceSamochody
            If Not (listaMarek.Contains(m.Item("marka"))) Then
                listaMarek.Add(m.Item("marka"))
            End If
        Next

        ComboBoxBrand.DataSource = Nothing
        ComboBoxBrand.DataBindings.Clear()
        ComboBoxBrand.Items.Clear()
        ComboBoxBrand.DataSource = listaMarek

        If ComboBoxBrand.Items.Count <> 0 Then
            ComboBoxBrand.SelectedIndex = 0
            RefreshComboboxModel()
        End If

    End Sub

    Private Sub ComboBoxBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBrand.SelectedIndexChanged
        RefreshComboboxModel()
    End Sub

    Private Sub RefreshComboboxModel()

        Dim listaModeli As List(Of String) = New List(Of String)
        listaModeli.Clear()

        For Each m As DataRowView In BindingSourceSamochody
            If ComboBoxBrand.SelectedItem = m.Item("marka") Then
                If Not (listaModeli.Contains(m.Item("model"))) Then
                    listaModeli.Add(m.Item("model"))
                End If
            End If
        Next

        ComboBoxModel.DataSource = listaModeli

        If ComboBoxModel.Items.Count <> 0 Then
            ComboBoxModel.SelectedIndex = 0
            RefreshComboboxEngine()
        End If

    End Sub

    Private Sub ComboBoxModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxModel.SelectedIndexChanged
        RefreshComboboxEngine()
    End Sub

    Private Sub RefreshComboboxEngine()

        Dim listaSilnikow As List(Of String) = New List(Of String)
        listaSilnikow.Clear()

        For Each m As DataRowView In BindingSourceSamochody
            If (ComboBoxBrand.SelectedItem = m.Item("marka") And ComboBoxModel.SelectedItem = m.Item("model")) Then
                If Not (listaSilnikow.Contains(m.Item("silnik"))) Then
                    listaSilnikow.Add(m.Item("silnik"))
                End If
            End If
        Next

        ComboBoxEngine.DataSource = listaSilnikow

        If ComboBoxEngine.Items.Count <> 0 Then
            ComboBoxEngine.SelectedIndex = 0
            RefreshComboboxColour()
        End If

    End Sub

    Private Sub ComboBoxEngine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEngine.SelectedIndexChanged
        RefreshComboboxColour()
    End Sub

    Private Sub CheckBoxMetalic_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMetalic.CheckedChanged
        RefreshComboboxColour()
    End Sub

    Private Sub RefreshComboboxColour()

        Dim listaKolorow As List(Of String) = New List(Of String)
        listaKolorow.Clear()

        For Each m As DataRowView In BindingSourceSamochody
            If (ComboBoxBrand.SelectedItem = m.Item("marka") And ComboBoxModel.SelectedItem = m.Item("model") And
                _ComboBoxEngine.SelectedItem = m.Item("silnik") And CheckBoxMetalic.Checked = True And m.Item("metalic") = "Tak") Then
                If Not (listaKolorow.Contains(m.Item("kolor"))) Then
                    listaKolorow.Add(m.Item("kolor"))
                End If
            ElseIf (ComboBoxBrand.SelectedItem = m.Item("marka") And ComboBoxModel.SelectedItem = m.Item("model") And
                _ComboBoxEngine.SelectedItem = m.Item("silnik") And CheckBoxMetalic.Checked = False And m.Item("metalic") = "Nie") Then
                If Not (listaKolorow.Contains(m.Item("kolor"))) Then
                    listaKolorow.Add(m.Item("kolor"))
                End If
            End If
        Next


        ComboBoxColour.DataSource = Nothing
        ComboBoxColour.DataBindings.Clear()
        ComboBoxColour.Items.Clear()

        ComboBoxColour.DataSource = listaKolorow

        If ComboBoxColour.Items.Count <> 0 Then
            ComboBoxColour.SelectedIndex = 0
            RefreshAdditionalInformation()
        Else
            ComboBoxColour.SelectedIndex = -1
            RefreshAdditionalInformation()
        End If


    End Sub

    Private Sub ComboBoxColour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxColour.SelectedIndexChanged
        RefreshAdditionalInformation()
    End Sub

    Private Sub RefreshAdditionalInformation()

        TextBoxClientYear.Text = ""
        TextBoxClientPrice.Text = ""
        TextBoxClientKlima.Text = ""
        TextBoxClientAlarm.Text = ""

        For Each m As DataRow In samochodyDataSet.Tables("samochody").Rows

            If (ComboBoxBrand.SelectedItem = m.Item("marka") And ComboBoxModel.SelectedItem = m.Item("model") And
                _ComboBoxEngine.SelectedItem = m.Item("silnik") And ComboBoxColour.SelectedItem = m.Item("kolor")) Then

                TextBoxClientYear.Text = Convert.ToString(m.Item("rok"))
                TextBoxClientPrice.Text = Convert.ToString(m.Item("cena"))
                TextBoxClientKlima.Text = Convert.ToString(m.Item("klimatyzacja"))
                TextBoxClientAlarm.Text = Convert.ToString(m.Item("alarm"))

                PictureBoxSamochod.SizeMode = PictureBoxSizeMode.StretchImage

                Dim sciezka = Path.Combine(Directory.GetCurrentDirectory(), "zdjecia\") + m.Item("zdjecie")
                PictureBoxSamochod.ImageLocation = sciezka
                PictureBoxSamochod.Show()

            End If

            If (ComboBoxColour.SelectedIndex <> -1) Then
                PictureBoxSamochod.Show()
            Else
                PictureBoxSamochod.Hide()
            End If

        Next

    End Sub

    Private Sub ButtonAddPhoto_Click(sender As Object, e As EventArgs) Handles ButtonAddPhoto.Click

        Dim openFileDialog1 As New OpenFileDialog()
        Dim iResult As DialogResult
        openFileDialog1.Title = "Dodaj zdjęcie"
        openFileDialog1.Filter = "JPG Files (*.jpg) | *.jpg"

        openFileDialog1.CheckFileExists = True
        iResult = openFileDialog1.ShowDialog()

        If iResult <> Windows.Forms.DialogResult.Cancel And openFileDialog1.FileName.Length <> 0 Then

            Dim sciezka2 = Path.Combine(Directory.GetCurrentDirectory(), "zdjecia\")
            Dim nazwaObrazka = openFileDialog1.FileName.Replace(sciezka2, "")
            TextBoxZdjecie.Text = nazwaObrazka
            RefreshEditPicture(nazwaObrazka)

        End If

    End Sub

    Private Sub RefreshEditPicture(nazwa As String)

        Dim sciezka = Path.Combine(Directory.GetCurrentDirectory(), "zdjecia\", nazwa)
        PictureBoxEditPicture.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxEditPicture.ImageLocation = sciezka
        PictureBoxEditPicture.Show()
    End Sub


    Private Sub TextBoxZdjecie_TextChanged(sender As Object, e As EventArgs) Handles TextBoxZdjecie.TextChanged
        Dim obrazek As String = TextBoxZdjecie.Text
        RefreshEditPicture(obrazek)
    End Sub
End Class
