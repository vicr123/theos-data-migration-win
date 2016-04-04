<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StorageDevice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StorageDevice))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StoragePane = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.StorageDevices = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PlacesToBackupPane = New System.Windows.Forms.Panel()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EnvironmentPane = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StoragePane.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PlacesToBackupPane.SuspendLayout()
        Me.EnvironmentPane.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 25)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "theOS Data Migration Tool"
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Marlett", 8.25!)
        Me.Button3.Location = New System.Drawing.Point(391, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "0"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Marlett", 8.25!)
        Me.Button2.Location = New System.Drawing.Point(415, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "r"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Choose a storage device"
        '
        'StoragePane
        '
        Me.StoragePane.Controls.Add(Me.Panel4)
        Me.StoragePane.Controls.Add(Me.Label2)
        Me.StoragePane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StoragePane.Location = New System.Drawing.Point(0, 25)
        Me.StoragePane.Name = "StoragePane"
        Me.StoragePane.Size = New System.Drawing.Size(453, 216)
        Me.StoragePane.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.StorageDevices)
        Me.Panel4.Location = New System.Drawing.Point(7, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(434, 23)
        Me.Panel4.TabIndex = 13
        '
        'StorageDevices
        '
        Me.StorageDevices.BackColor = System.Drawing.Color.White
        Me.StorageDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StorageDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StorageDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StorageDevices.FormattingEnabled = True
        Me.StorageDevices.Location = New System.Drawing.Point(0, 0)
        Me.StorageDevices.Name = "StorageDevices"
        Me.StorageDevices.Size = New System.Drawing.Size(432, 21)
        Me.StorageDevices.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ExitButton)
        Me.Panel3.Controls.Add(Me.BackButton)
        Me.Panel3.Controls.Add(Me.NextButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 241)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(9, 0, 9, 9)
        Me.Panel3.Size = New System.Drawing.Size(453, 41)
        Me.Panel3.TabIndex = 13
        '
        'ExitButton
        '
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Image = Global.theOS_Data_Migration_Tool.My.Resources.Resources._exit
        Me.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExitButton.Location = New System.Drawing.Point(9, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 32)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Cancel"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.theOS_Data_Migration_Tool.My.Resources.Resources.backwards
        Me.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BackButton.Location = New System.Drawing.Point(294, 0)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 32)
        Me.BackButton.TabIndex = 1
        Me.BackButton.Text = "Back"
        Me.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BackButton.UseVisualStyleBackColor = True
        Me.BackButton.Visible = False
        '
        'NextButton
        '
        Me.NextButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.NextButton.Enabled = False
        Me.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Image = Global.theOS_Data_Migration_Tool.My.Resources.Resources.forwards
        Me.NextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NextButton.Location = New System.Drawing.Point(369, 0)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 32)
        Me.NextButton.TabIndex = 0
        Me.NextButton.Text = "Next"
        Me.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PlacesToBackupPane
        '
        Me.PlacesToBackupPane.Controls.Add(Me.CheckedListBox1)
        Me.PlacesToBackupPane.Controls.Add(Me.Label3)
        Me.PlacesToBackupPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlacesToBackupPane.Location = New System.Drawing.Point(0, 25)
        Me.PlacesToBackupPane.Name = "PlacesToBackupPane"
        Me.PlacesToBackupPane.Size = New System.Drawing.Size(453, 216)
        Me.PlacesToBackupPane.TabIndex = 14
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Documents folder", "Music folder", "Pictures folder", "Videos folder"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(7, 29)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(433, 167)
        Me.CheckedListBox1.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(5, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Choose what to transfer"
        '
        'EnvironmentPane
        '
        Me.EnvironmentPane.Controls.Add(Me.Label8)
        Me.EnvironmentPane.Controls.Add(Me.Panel5)
        Me.EnvironmentPane.Controls.Add(Me.Panel2)
        Me.EnvironmentPane.Controls.Add(Me.Label5)
        Me.EnvironmentPane.Controls.Add(Me.Label4)
        Me.EnvironmentPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EnvironmentPane.Location = New System.Drawing.Point(0, 25)
        Me.EnvironmentPane.Name = "EnvironmentPane"
        Me.EnvironmentPane.Size = New System.Drawing.Size(453, 216)
        Me.EnvironmentPane.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(6, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(438, 29)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "You should also make sure that all other applications are closed so that the file" &
    "s are transferred properly."
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(9, 82)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(431, 32)
        Me.Panel5.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Your PC is connected to power."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.theOS_Data_Migration_Tool.My.Resources.Resources.yes
        Me.PictureBox3.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(9, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(431, 32)
        Me.Panel2.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "The drive has enough space for the transfer."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.theOS_Data_Migration_Tool.My.Resources.Resources.yes
        Me.PictureBox2.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Before we begin to transfer, ensure that"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(5, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 21)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Checking Environment"
        '
        'StorageDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(453, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.EnvironmentPane)
        Me.Controls.Add(Me.PlacesToBackupPane)
        Me.Controls.Add(Me.StoragePane)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "StorageDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StoragePane.ResumeLayout(False)
        Me.StoragePane.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PlacesToBackupPane.ResumeLayout(False)
        Me.PlacesToBackupPane.PerformLayout()
        Me.EnvironmentPane.ResumeLayout(False)
        Me.EnvironmentPane.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StoragePane As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents NextButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StorageDevices As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PlacesToBackupPane As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents EnvironmentPane As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
End Class
