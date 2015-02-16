Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Configuration
Imports System.Collections
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.IO

Module Saving
    Public Function exportSettings(filename As String) As Boolean
        Try
            Using sWriter As New StreamWriter(filename)
                For Each setting As SettingsPropertyValue In My.Settings.PropertyValues
                    If setting.Name <> "mustUpgrade" Then
                        sWriter.WriteLine(setting.Name & "," & setting.PropertyValue.ToString())
                    End If
                Next
            End Using
        Catch
            Return False
        End Try

        Return True
    End Function

    Public Function importSettings(filename As String) As Boolean
        Dim success As Boolean = True
        Try
            Using sReader As New StreamReader(filename)
                While sReader.Peek() > 0
                    Dim input = sReader.ReadLine()
                    ' Split comma delimited data ( SettingName,SettingValue )  
                    Dim dataSplit = input.Split({","c}, 2)
                    Dim exists As Boolean = True
                    Try
                        My.Settings(dataSplit(0)).GetType()
                    Catch ex As Exception
                        exists = False
                    End Try

                    If Not exists Then
                        Continue While
                    End If

                    Try

                        If dataSplit.Length = 1 Then
                            My.Settings(dataSplit(0)) = ""
                        Else
                            Select Case My.Settings(dataSplit(0)).GetType.ToString()
                                Case "System.Boolean"
                                    If dataSplit(1) = "True" Then
                                        My.Settings(dataSplit(0)) = True
                                    Else
                                        My.Settings(dataSplit(0)) = False
                                    End If
                                Case "System.Int32"
                                    My.Settings(dataSplit(0)) = CInt(dataSplit(1))
                                Case "System.Double"
                                    My.Settings(dataSplit(0)) = CDbl(dataSplit(1))
                                Case Else
                                    My.Settings(dataSplit(0)) = dataSplit(1)

                            End Select


                        End If
                    Catch
                        success = False
                    End Try
                End While
            End Using
            My.Settings.Save()
            'Gui.refreshGUI()
        Catch
            Return False
        End Try

        Return success
    End Function

    Public Sub loadDefaultSettings()
        Dim thisExe As System.Reflection.Assembly
        thisExe = System.Reflection.Assembly.GetExecutingAssembly()
        Dim newFilePath As String = Path.GetTempPath() + "defaultSettings.sailplane"
        Using newFile As Stream = New System.IO.FileStream(newFilePath, IO.FileMode.Create)
            thisExe.GetManifestResourceStream("SailPlaneLaunch.defaultSettings.sailplane").CopyTo(newFile)
        End Using
        Saving.importSettings(newFilePath)
    End Sub

End Module
