Module Modul_Functions

    Public WhichImage As Integer = 0
#Region "API Calls"
    ' standard API declarations for INI access
    ' changing only "As Long" to "As Int32" (As Integer would work also)
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" _
    Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpString As String,
    ByVal lpFileName As String) As Int32

    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" _
    Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String,
    ByVal lpKeyName As String, ByVal lpDefault As String,
    ByVal lpReturnedString As String, ByVal nSize As Int32,
    ByVal lpFileName As String) As Int32
#End Region
    Public ButtonUnderEdit As Integer = 0
    Public ButtonUnderUpdate As Integer = 0

    Public Button1_Target As String
    Public Button2_Target As String
    Public Button3_Target As String
    Public Button4_Target As String
    Public Button5_Target As String
    Public Button6_Target As String
    Public Button7_Target As String
    Public Button8_Target As String
    Public Button9_Target As String
    Public Button10_Target As String
    Public Button11_Target As String
    Public Button12_Target As String
    Public Button13_Target As String
    Public Button14_Target As String
    Public Button15_Target As String
    Public Button16_Target As String

    Public Button1_Text As String
    Public Button2_Text As String
    Public Button3_Text As String
    Public Button4_Text As String
    Public Button5_Text As String
    Public Button6_Text As String
    Public Button7_Text As String
    Public Button8_Text As String
    Public Button9_Text As String
    Public Button10_Text As String
    Public Button11_Text As String
    Public Button12_Text As String
    Public Button13_Text As String
    Public Button14_Text As String
    Public Button15_Text As String
    Public Button16_Text As String

    Public image1 As String
    Public image2 As String
    Public image3 As String
    Public image4 As String
    Public image5 As String
    Public image6 As String
    Public image7 As String
    Public image8 As String
    Public image9 As String
    Public image10 As String
    Public image11 As String
    Public image12 As String
    Public image13 As String
    Public image14 As String
    Public image15 As String
    Public image16 As String

    Public State As String
    Public AutoExec As String
    Public Mode As String
    Public TimerRounds As Integer = 10

    Public Function INIRead(ByVal INIPath As String,
    ByVal SectionName As String, ByVal KeyName As String,
    ByVal DefaultValue As String) As String
        ' primary version of call gets single value given all parameters
        Dim n As Int32
        Dim sData As String
        sData = Space$(1024) ' allocate some room 
        n = GetPrivateProfileString(SectionName, KeyName, DefaultValue,
        sData, sData.Length, INIPath)
        If n > 0 Then ' return whatever it gave us
            INIRead = sData.Substring(0, n)
        Else
            INIRead = ""
        End If
    End Function

#Region "INIRead Overloads"
    Public Function INIRead(ByVal INIPath As String,
    ByVal SectionName As String, ByVal KeyName As String) As String
        ' overload 1 assumes zero-length default
        Return INIRead(INIPath, SectionName, KeyName, "")
    End Function

    Public Function INIRead(ByVal INIPath As String,
    ByVal SectionName As String) As String
        ' overload 2 returns all keys in a given section of the given file
        Return INIRead(INIPath, SectionName, Nothing, "")
    End Function

    Public Function INIRead(ByVal INIPath As String) As String
        ' overload 3 returns all section names given just path
        Return INIRead(INIPath, Nothing, Nothing, "")
    End Function
#End Region

    Public Sub INIWrite(ByVal INIPath As String, ByVal SectionName As String,
    ByVal KeyName As String, ByVal TheValue As String)
        Call WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath)
    End Sub

    Public Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String,
    ByVal KeyName As String) ' delete single line from section
        Call WritePrivateProfileString(SectionName, KeyName, Nothing, INIPath)
    End Sub

    Public Sub INIDelete(ByVal INIPath As String, ByVal SectionName As String)
        ' delete section from INI file
        Call WritePrivateProfileString(SectionName, Nothing, Nothing, INIPath)
    End Sub

End Module

