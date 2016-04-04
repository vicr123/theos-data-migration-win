Public Class StorageDevice
    Enum PaneTypes As Integer
        StorageDevice = 0
        PlacesToBackup = 1
        Environment = 2
    End Enum
    Dim currentPane As PaneTypes = PaneTypes.StorageDevice
    Dim installedApps As New List(Of String)
    Dim appsDone As Boolean = False

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim notify As New ContemporarySet.PopupBox
        notify.Title = "Cancel"
        notify.Text = "Are you sure you want to cancel?"
        notify.NoButton = True
        If notify.ShowDialog(Me) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub StorageDevice_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChangeToPane(PaneTypes.StorageDevice)

        Dim appReader As New Threading.Thread(Sub()
                                                  Dim p As New Process
                                                  p.StartInfo.FileName = "wmic"
                                                  p.StartInfo.Arguments = "product get name /format:csv"
                                                  p.StartInfo.RedirectStandardOutput = True
                                                  p.StartInfo.UseShellExecute = False
                                                  p.StartInfo.CreateNoWindow = True
                                                  p.Start()
                                                  Dim apps As String = p.StandardOutput.ReadToEnd
                                                  p.WaitForExit()
                                                  For Each app As String In apps.Split(vbLf)
                                                      Try
                                                          app = app.Trim.Split(",")(1)
                                                          If app <> "Name" Then
                                                              installedApps.Add(app)
                                                          End If
                                                      Catch
                                                      End Try
                                                  Next
                                                  appsDone = True
                                                  'installedApps = apps.Replace("Name" + vbLf, "").Replace("  ", "").Split(vbLf)
                                              End Sub)
        appReader.Name = "AppReader"
        appReader.Start()
    End Sub

    Private Sub StorageDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StorageDevices.SelectedIndexChanged
        If StorageDevices.SelectedIndex <> -1 Then
            NextButton.Enabled = True
        Else
            NextButton.Enabled = False
        End If
    End Sub

    Private Sub ChangeToPane(pane As PaneTypes)
        currentPane = pane 'Set the current pane

        'Set all panes to invisible
        StoragePane.Visible = False
        PlacesToBackupPane.Visible = False
        EnvironmentPane.Visible = False

        'Set the wanted pane to visible and run setup function
        Select Case pane
            Case PaneTypes.StorageDevice
                SetupStorageDevices()
                StoragePane.Visible = True
            Case PaneTypes.PlacesToBackup
                SetupPlacesToBackup()
                PlacesToBackupPane.Visible = True
            Case PaneTypes.Environment
                SetupEnvironmentCheck()
                EnvironmentPane.Visible = True
        End Select

        If pane >= 1 Then
            BackButton.Visible = True
        Else
            BackButton.Visible = False
        End If
    End Sub

    Private Sub SetupEnvironmentCheck()
        If SystemInformation.PowerStatus.BatteryChargeStatus = BatteryChargeStatus.NoSystemBattery Then
            Panel5.Visible = False
        Else
            If SystemInformation.PowerStatus.BatteryChargeStatus.HasFlag(BatteryChargeStatus.Charging) Or
                SystemInformation.PowerStatus.BatteryLifePercent = 1 Then
                PictureBox3.Image = My.Resources.yes
            Else
                PictureBox3.Image = My.Resources.no
            End If
        End If
    End Sub

    Private Sub SetupStorageDevices()
        StorageDevices.Items.Clear()
        For Each drive As IO.DriveInfo In My.Computer.FileSystem.Drives
            'If drive.DriveType = IO.DriveType.Removable Then
            Try
                StorageDevices.Items.Add(drive.Name & " " & drive.VolumeLabel)
            Catch
            End Try
            'End If
        Next
    End Sub

    Private Sub SetupPlacesToBackup()
        If (CheckedListBox1.CheckedIndices.Count = 0) Then
            NextButton.Enabled = False
        Else
            NextButton.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If currentPane = PaneTypes.Environment Then
            If Not (SystemInformation.PowerStatus.BatteryChargeStatus.HasFlag(BatteryChargeStatus.Charging) Or
                SystemInformation.PowerStatus.BatteryLifePercent = 1) Then
                Dim notify As New ContemporarySet.PopupBox
                notify.Title = "Not connected to power"
                notify.Text = "If you don't connect your PC to power, the transfer could be incomplete. Do you want to continue anyway?"
                notify.NoButton = True
                If notify.ShowDialog(Me) = DialogResult.Yes Then

                End If
            End If
        Else
            ChangeToPane(currentPane + 1)
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ChangeToPane(currentPane - 1)
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        If (CheckedListBox1.CheckedIndices.Count = 1 And e.NewValue = CheckState.Unchecked) Then
            NextButton.Enabled = False
        Else
            NextButton.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ExitButton.PerformClick()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

End Class