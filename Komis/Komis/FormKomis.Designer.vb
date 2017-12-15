<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKomis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdytujToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KoniecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OProgramieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabControlKomis = New System.Windows.Forms.TabControl()
        Me.TabPageViever = New System.Windows.Forms.TabPage()
        Me.TextBoxClientAlarm = New System.Windows.Forms.TextBox()
        Me.TextBoxClientKlima = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBoxSamochod = New System.Windows.Forms.PictureBox()
        Me.CheckBoxMetalic = New System.Windows.Forms.CheckBox()
        Me.TextBoxClientPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxClientYear = New System.Windows.Forms.TextBox()
        Me.ComboBoxColour = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonSelectDatabase = New System.Windows.Forms.Button()
        Me.ComboBoxEngine = New System.Windows.Forms.ComboBox()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxBrand = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPageEditor = New System.Windows.Forms.TabPage()
        Me.ButtonAddPhoto = New System.Windows.Forms.Button()
        Me.TextBoxZdjecie = New System.Windows.Forms.TextBox()
        Me.ComboBoxEditAlarm = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEditKlima = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBoxEditMetalic = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxColour = New System.Windows.Forms.TextBox()
        Me.ButtonSelectDatabase2 = New System.Windows.Forms.Button()
        Me.PictureBoxEditPicture = New System.Windows.Forms.PictureBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxYear = New System.Windows.Forms.TextBox()
        Me.TextBoxEngine = New System.Windows.Forms.TextBox()
        Me.TextBoxModel = New System.Windows.Forms.TextBox()
        Me.TextBoxBrand = New System.Windows.Forms.TextBox()
        Me.TextBoxid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrev = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.DataGridViewSamochody = New System.Windows.Forms.DataGridView()
        Me.BindingSourceSamochody = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControlKomis.SuspendLayout()
        Me.TabPageViever.SuspendLayout()
        CType(Me.PictureBoxSamochod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageEditor.SuspendLayout()
        CType(Me.PictureBoxEditPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewSamochody, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSamochody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlikToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(822, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlikToolStripMenuItem
        '
        Me.PlikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdytujToolStripMenuItem, Me.KoniecToolStripMenuItem})
        Me.PlikToolStripMenuItem.Name = "PlikToolStripMenuItem"
        Me.PlikToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.PlikToolStripMenuItem.Text = "Plik"
        '
        'EdytujToolStripMenuItem
        '
        Me.EdytujToolStripMenuItem.Name = "EdytujToolStripMenuItem"
        Me.EdytujToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.EdytujToolStripMenuItem.Text = "Edytuj"
        '
        'KoniecToolStripMenuItem
        '
        Me.KoniecToolStripMenuItem.Name = "KoniecToolStripMenuItem"
        Me.KoniecToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.KoniecToolStripMenuItem.Text = "Koniec"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OProgramieToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'OProgramieToolStripMenuItem
        '
        Me.OProgramieToolStripMenuItem.Name = "OProgramieToolStripMenuItem"
        Me.OProgramieToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.OProgramieToolStripMenuItem.Text = "O programie"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(822, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabControlKomis
        '
        Me.TabControlKomis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlKomis.Controls.Add(Me.TabPageViever)
        Me.TabControlKomis.Controls.Add(Me.TabPageEditor)
        Me.TabControlKomis.Location = New System.Drawing.Point(12, 27)
        Me.TabControlKomis.Name = "TabControlKomis"
        Me.TabControlKomis.SelectedIndex = 0
        Me.TabControlKomis.Size = New System.Drawing.Size(798, 459)
        Me.TabControlKomis.TabIndex = 2
        '
        'TabPageViever
        '
        Me.TabPageViever.Controls.Add(Me.TextBoxClientAlarm)
        Me.TabPageViever.Controls.Add(Me.TextBoxClientKlima)
        Me.TabPageViever.Controls.Add(Me.Label19)
        Me.TabPageViever.Controls.Add(Me.Label18)
        Me.TabPageViever.Controls.Add(Me.PictureBoxSamochod)
        Me.TabPageViever.Controls.Add(Me.CheckBoxMetalic)
        Me.TabPageViever.Controls.Add(Me.TextBoxClientPrice)
        Me.TabPageViever.Controls.Add(Me.TextBoxClientYear)
        Me.TabPageViever.Controls.Add(Me.ComboBoxColour)
        Me.TabPageViever.Controls.Add(Me.Label13)
        Me.TabPageViever.Controls.Add(Me.ButtonSelectDatabase)
        Me.TabPageViever.Controls.Add(Me.ComboBoxEngine)
        Me.TabPageViever.Controls.Add(Me.ComboBoxModel)
        Me.TabPageViever.Controls.Add(Me.ComboBoxBrand)
        Me.TabPageViever.Controls.Add(Me.Label7)
        Me.TabPageViever.Controls.Add(Me.Label8)
        Me.TabPageViever.Controls.Add(Me.Label9)
        Me.TabPageViever.Controls.Add(Me.Label10)
        Me.TabPageViever.Controls.Add(Me.Label11)
        Me.TabPageViever.Controls.Add(Me.Label12)
        Me.TabPageViever.Location = New System.Drawing.Point(4, 22)
        Me.TabPageViever.Name = "TabPageViever"
        Me.TabPageViever.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageViever.Size = New System.Drawing.Size(790, 433)
        Me.TabPageViever.TabIndex = 0
        Me.TabPageViever.Text = "Oferty"
        Me.TabPageViever.UseVisualStyleBackColor = True
        '
        'TextBoxClientAlarm
        '
        Me.TextBoxClientAlarm.Location = New System.Drawing.Point(120, 339)
        Me.TextBoxClientAlarm.Name = "TextBoxClientAlarm"
        Me.TextBoxClientAlarm.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxClientAlarm.TabIndex = 38
        '
        'TextBoxClientKlima
        '
        Me.TextBoxClientKlima.Location = New System.Drawing.Point(120, 309)
        Me.TextBoxClientKlima.Name = "TextBoxClientKlima"
        Me.TextBoxClientKlima.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxClientKlima.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(32, 342)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Alarm"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(31, 312)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Klimatyzacja"
        '
        'PictureBoxSamochod
        '
        Me.PictureBoxSamochod.Location = New System.Drawing.Point(237, 24)
        Me.PictureBoxSamochod.Name = "PictureBoxSamochod"
        Me.PictureBoxSamochod.Size = New System.Drawing.Size(531, 362)
        Me.PictureBoxSamochod.TabIndex = 34
        Me.PictureBoxSamochod.TabStop = False
        '
        'CheckBoxMetalic
        '
        Me.CheckBoxMetalic.AutoSize = True
        Me.CheckBoxMetalic.Location = New System.Drawing.Point(75, 211)
        Me.CheckBoxMetalic.Name = "CheckBoxMetalic"
        Me.CheckBoxMetalic.Size = New System.Drawing.Size(60, 17)
        Me.CheckBoxMetalic.TabIndex = 31
        Me.CheckBoxMetalic.Text = "Metalic"
        Me.CheckBoxMetalic.UseVisualStyleBackColor = True
        '
        'TextBoxClientPrice
        '
        Me.TextBoxClientPrice.Location = New System.Drawing.Point(120, 280)
        Me.TextBoxClientPrice.Name = "TextBoxClientPrice"
        Me.TextBoxClientPrice.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxClientPrice.TabIndex = 30
        '
        'TextBoxClientYear
        '
        Me.TextBoxClientYear.Location = New System.Drawing.Point(120, 250)
        Me.TextBoxClientYear.Name = "TextBoxClientYear"
        Me.TextBoxClientYear.Size = New System.Drawing.Size(76, 20)
        Me.TextBoxClientYear.TabIndex = 29
        '
        'ComboBoxColour
        '
        Me.ComboBoxColour.FormattingEnabled = True
        Me.ComboBoxColour.Location = New System.Drawing.Point(75, 184)
        Me.ComboBoxColour.Name = "ComboBoxColour"
        Me.ComboBoxColour.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxColour.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Kolor"
        '
        'ButtonSelectDatabase
        '
        Me.ButtonSelectDatabase.Location = New System.Drawing.Point(35, 24)
        Me.ButtonSelectDatabase.Name = "ButtonSelectDatabase"
        Me.ButtonSelectDatabase.Size = New System.Drawing.Size(161, 23)
        Me.ButtonSelectDatabase.TabIndex = 26
        Me.ButtonSelectDatabase.Text = "Wybierz komis"
        Me.ButtonSelectDatabase.UseVisualStyleBackColor = True
        '
        'ComboBoxEngine
        '
        Me.ComboBoxEngine.FormattingEnabled = True
        Me.ComboBoxEngine.Location = New System.Drawing.Point(75, 153)
        Me.ComboBoxEngine.Name = "ComboBoxEngine"
        Me.ComboBoxEngine.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxEngine.TabIndex = 25
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Location = New System.Drawing.Point(75, 123)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxModel.TabIndex = 24
        '
        'ComboBoxBrand
        '
        Me.ComboBoxBrand.FormattingEnabled = True
        Me.ComboBoxBrand.Location = New System.Drawing.Point(75, 93)
        Me.ComboBoxBrand.Name = "ComboBoxBrand"
        Me.ComboBoxBrand.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBrand.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Komis"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Cena"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Rok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Silnik"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Model"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Marka"
        '
        'TabPageEditor
        '
        Me.TabPageEditor.Controls.Add(Me.ButtonAddPhoto)
        Me.TabPageEditor.Controls.Add(Me.TextBoxZdjecie)
        Me.TabPageEditor.Controls.Add(Me.ComboBoxEditAlarm)
        Me.TabPageEditor.Controls.Add(Me.ComboBoxEditKlima)
        Me.TabPageEditor.Controls.Add(Me.Label17)
        Me.TabPageEditor.Controls.Add(Me.Label16)
        Me.TabPageEditor.Controls.Add(Me.Label15)
        Me.TabPageEditor.Controls.Add(Me.ComboBoxEditMetalic)
        Me.TabPageEditor.Controls.Add(Me.Label14)
        Me.TabPageEditor.Controls.Add(Me.TextBoxColour)
        Me.TabPageEditor.Controls.Add(Me.ButtonSelectDatabase2)
        Me.TabPageEditor.Controls.Add(Me.PictureBoxEditPicture)
        Me.TabPageEditor.Controls.Add(Me.TextBoxPrice)
        Me.TabPageEditor.Controls.Add(Me.TextBoxYear)
        Me.TabPageEditor.Controls.Add(Me.TextBoxEngine)
        Me.TabPageEditor.Controls.Add(Me.TextBoxModel)
        Me.TabPageEditor.Controls.Add(Me.TextBoxBrand)
        Me.TabPageEditor.Controls.Add(Me.TextBoxid)
        Me.TabPageEditor.Controls.Add(Me.Label6)
        Me.TabPageEditor.Controls.Add(Me.Label5)
        Me.TabPageEditor.Controls.Add(Me.Label4)
        Me.TabPageEditor.Controls.Add(Me.Label3)
        Me.TabPageEditor.Controls.Add(Me.Label2)
        Me.TabPageEditor.Controls.Add(Me.Label1)
        Me.TabPageEditor.Controls.Add(Me.ButtonCancel)
        Me.TabPageEditor.Controls.Add(Me.ButtonOK)
        Me.TabPageEditor.Controls.Add(Me.ButtonEdit)
        Me.TabPageEditor.Controls.Add(Me.ButtonRemove)
        Me.TabPageEditor.Controls.Add(Me.ButtonAdd)
        Me.TabPageEditor.Controls.Add(Me.ButtonLast)
        Me.TabPageEditor.Controls.Add(Me.ButtonNext)
        Me.TabPageEditor.Controls.Add(Me.ButtonPrev)
        Me.TabPageEditor.Controls.Add(Me.ButtonFirst)
        Me.TabPageEditor.Controls.Add(Me.DataGridViewSamochody)
        Me.TabPageEditor.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEditor.Name = "TabPageEditor"
        Me.TabPageEditor.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEditor.Size = New System.Drawing.Size(790, 433)
        Me.TabPageEditor.TabIndex = 1
        Me.TabPageEditor.Text = "Edycja"
        Me.TabPageEditor.UseVisualStyleBackColor = True
        '
        'ButtonAddPhoto
        '
        Me.ButtonAddPhoto.Location = New System.Drawing.Point(625, 364)
        Me.ButtonAddPhoto.Name = "ButtonAddPhoto"
        Me.ButtonAddPhoto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddPhoto.TabIndex = 44
        Me.ButtonAddPhoto.Text = "Zdjęcie"
        Me.ButtonAddPhoto.UseVisualStyleBackColor = True
        '
        'TextBoxZdjecie
        '
        Me.TextBoxZdjecie.Location = New System.Drawing.Point(347, 400)
        Me.TextBoxZdjecie.Name = "TextBoxZdjecie"
        Me.TextBoxZdjecie.Size = New System.Drawing.Size(272, 20)
        Me.TextBoxZdjecie.TabIndex = 43
        '
        'ComboBoxEditAlarm
        '
        Me.ComboBoxEditAlarm.FormattingEnabled = True
        Me.ComboBoxEditAlarm.Items.AddRange(New Object() {"Tak", "Nie"})
        Me.ComboBoxEditAlarm.Location = New System.Drawing.Point(261, 404)
        Me.ComboBoxEditAlarm.Name = "ComboBoxEditAlarm"
        Me.ComboBoxEditAlarm.Size = New System.Drawing.Size(56, 21)
        Me.ComboBoxEditAlarm.TabIndex = 42
        '
        'ComboBoxEditKlima
        '
        Me.ComboBoxEditKlima.FormattingEnabled = True
        Me.ComboBoxEditKlima.Items.AddRange(New Object() {"Tak", "Nie"})
        Me.ComboBoxEditKlima.Location = New System.Drawing.Point(261, 378)
        Me.ComboBoxEditKlima.Name = "ComboBoxEditKlima"
        Me.ComboBoxEditKlima.Size = New System.Drawing.Size(56, 21)
        Me.ComboBoxEditKlima.TabIndex = 41
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(166, 407)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Alarm"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(166, 381)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Klimatyzacja"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(166, 355)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "metalic"
        '
        'ComboBoxEditMetalic
        '
        Me.ComboBoxEditMetalic.FormattingEnabled = True
        Me.ComboBoxEditMetalic.Items.AddRange(New Object() {"Tak", "Nie"})
        Me.ComboBoxEditMetalic.Location = New System.Drawing.Point(261, 351)
        Me.ComboBoxEditMetalic.Name = "ComboBoxEditMetalic"
        Me.ComboBoxEditMetalic.Size = New System.Drawing.Size(56, 21)
        Me.ComboBoxEditMetalic.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 355)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Kolor"
        '
        'TextBoxColour
        '
        Me.TextBoxColour.Location = New System.Drawing.Point(60, 352)
        Me.TextBoxColour.Name = "TextBoxColour"
        Me.TextBoxColour.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxColour.TabIndex = 33
        '
        'ButtonSelectDatabase2
        '
        Me.ButtonSelectDatabase2.Location = New System.Drawing.Point(18, 209)
        Me.ButtonSelectDatabase2.Name = "ButtonSelectDatabase2"
        Me.ButtonSelectDatabase2.Size = New System.Drawing.Size(148, 23)
        Me.ButtonSelectDatabase2.TabIndex = 23
        Me.ButtonSelectDatabase2.Text = "Wybierz komis"
        Me.ButtonSelectDatabase2.UseVisualStyleBackColor = True
        '
        'PictureBoxEditPicture
        '
        Me.PictureBoxEditPicture.Location = New System.Drawing.Point(347, 218)
        Me.PictureBoxEditPicture.Name = "PictureBoxEditPicture"
        Me.PictureBoxEditPicture.Size = New System.Drawing.Size(272, 177)
        Me.PictureBoxEditPicture.TabIndex = 22
        Me.PictureBoxEditPicture.TabStop = False
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(60, 404)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrice.TabIndex = 21
        '
        'TextBoxYear
        '
        Me.TextBoxYear.Location = New System.Drawing.Point(60, 378)
        Me.TextBoxYear.Name = "TextBoxYear"
        Me.TextBoxYear.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxYear.TabIndex = 20
        '
        'TextBoxEngine
        '
        Me.TextBoxEngine.Location = New System.Drawing.Point(60, 326)
        Me.TextBoxEngine.Name = "TextBoxEngine"
        Me.TextBoxEngine.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEngine.TabIndex = 19
        '
        'TextBoxModel
        '
        Me.TextBoxModel.Location = New System.Drawing.Point(60, 300)
        Me.TextBoxModel.Name = "TextBoxModel"
        Me.TextBoxModel.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxModel.TabIndex = 18
        '
        'TextBoxBrand
        '
        Me.TextBoxBrand.Location = New System.Drawing.Point(60, 274)
        Me.TextBoxBrand.Name = "TextBoxBrand"
        Me.TextBoxBrand.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBrand.TabIndex = 17
        '
        'TextBoxid
        '
        Me.TextBoxid.Enabled = False
        Me.TextBoxid.Location = New System.Drawing.Point(60, 249)
        Me.TextBoxid.Name = "TextBoxid"
        Me.TextBoxid.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxid.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cena"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Rok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Silnik"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Marka"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Id"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(706, 335)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 52)
        Me.ButtonCancel.TabIndex = 9
        Me.ButtonCancel.Text = "Anuluj"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(706, 276)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 53)
        Me.ButtonOK.TabIndex = 8
        Me.ButtonOK.Text = "Ok"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(625, 276)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 7
        Me.ButtonEdit.Text = "Edytuj"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(625, 335)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRemove.TabIndex = 6
        Me.ButtonRemove.Text = "Usuń"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(625, 306)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 5
        Me.ButtonAdd.Text = "Dodaj"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonLast
        '
        Me.ButtonLast.Location = New System.Drawing.Point(706, 247)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLast.TabIndex = 4
        Me.ButtonLast.Text = ">>"
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.Location = New System.Drawing.Point(706, 218)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNext.TabIndex = 3
        Me.ButtonNext.Text = ">"
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrev
        '
        Me.ButtonPrev.Location = New System.Drawing.Point(625, 218)
        Me.ButtonPrev.Name = "ButtonPrev"
        Me.ButtonPrev.Size = New System.Drawing.Size(75, 23)
        Me.ButtonPrev.TabIndex = 2
        Me.ButtonPrev.Text = "<"
        Me.ButtonPrev.UseVisualStyleBackColor = True
        '
        'ButtonFirst
        '
        Me.ButtonFirst.Location = New System.Drawing.Point(625, 247)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFirst.TabIndex = 1
        Me.ButtonFirst.Text = "<<"
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'DataGridViewSamochody
        '
        Me.DataGridViewSamochody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewSamochody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSamochody.Location = New System.Drawing.Point(6, 6)
        Me.DataGridViewSamochody.Name = "DataGridViewSamochody"
        Me.DataGridViewSamochody.Size = New System.Drawing.Size(778, 197)
        Me.DataGridViewSamochody.TabIndex = 0
        '
        'FormKomis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 511)
        Me.Controls.Add(Me.TabControlKomis)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormKomis"
        Me.Text = "Komis"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControlKomis.ResumeLayout(False)
        Me.TabPageViever.ResumeLayout(False)
        Me.TabPageViever.PerformLayout()
        CType(Me.PictureBoxSamochod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageEditor.ResumeLayout(False)
        Me.TabPageEditor.PerformLayout()
        CType(Me.PictureBoxEditPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewSamochody, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSamochody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EdytujToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KoniecToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OProgramieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControlKomis As System.Windows.Forms.TabControl
    Friend WithEvents TabPageViever As System.Windows.Forms.TabPage
    Friend WithEvents TabPageEditor As System.Windows.Forms.TabPage
    Friend WithEvents BindingSourceSamochody As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewSamochody As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonLast As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonPrev As System.Windows.Forms.Button
    Friend WithEvents ButtonFirst As System.Windows.Forms.Button
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxYear As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEngine As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxModel As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBrand As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxEditPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxModel As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxBrand As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEngine As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonSelectDatabase As System.Windows.Forms.Button
    Friend WithEvents ButtonSelectDatabase2 As System.Windows.Forms.Button
    Friend WithEvents CheckBoxMetalic As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxClientPrice As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClientYear As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxColour As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBoxSamochod As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBoxColour As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxEditAlarm As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxEditKlima As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEditMetalic As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxClientAlarm As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClientKlima As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBoxZdjecie As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAddPhoto As System.Windows.Forms.Button

End Class
