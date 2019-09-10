Imports System.Text.RegularExpressions

Public Class RomanNumeralConverter
    Private Mode As String = "Number"

    Private Sub txtNum_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress
        Dim Exp As Regex

        ' When you press ENTER, call the appropriate function
        If Asc(e.KeyChar) = "13" Then
            Select Case Mode
                Case "Number"
                    ConvertNumber()
                Case "Roman Numeral"
                    ConvertRoman()
            End Select

            Exit Sub
        ElseIf Asc(e.KeyChar) = "1" Then
            ' This ElseIf is for when you press Ctrl+A to select all.

            e.Handled = False
            Exit Sub
        End If

        Select Case Mode
            Case "Number"
                Exp = New Regex("\d+|Backspace|Delete")
            Case "Roman Numeral"
                Exp = New Regex("M|D|C|L|X|V|I", RegexOptions.IgnoreCase)
        End Select

        If txtNum.Text = "" And e.KeyChar = "0" Then
            e.Handled = True
        End If

        If Exp.IsMatch(e.KeyChar) Or Asc(e.KeyChar) = "8" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Select Case Mode
            Case "Number"
                ConvertNumber()
            Case "Roman Numeral"
                ConvertRoman()
        End Select
    End Sub

    Private Sub ConvertNumber()
        Dim resultNum As String = ""
        Dim val As String = txtNum.Text
        Dim roman As New Dictionary(Of String, Integer) From {
            {"M", 1000},
            {"CM", 900},
            {"D", 500},
            {"CD", 400},
            {"C", 100},
            {"XC", 90},
            {"L", 50},
            {"XL", 40},
            {"X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1}
        }

        If txtNum.Text <> "" AndAlso Integer.Parse(txtNum.Text) <= 3999 Then
            For Each romanNum As KeyValuePair(Of String, Integer) In roman
                Dim repeatNum As Integer = Math.Floor(Integer.Parse(val) / romanNum.Value)
                val -= repeatNum * romanNum.Value
                resultNum += String.Concat(Enumerable.Repeat(romanNum.Key, repeatNum))
            Next

            lblResult.Text = resultNum
        Else
            If txtNum.Text = "" Then
                MessageBox.Show("Please enter a number", "No input detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Number must be 3,999 or less", "Error: Greater than 3,999", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            txtNum.SelectAll()
        End If
    End Sub

    Private Sub ConvertRoman()
        'Console.WriteLine("Converting Roman Numeral to Number")
        Dim validate As Boolean = ValidateRomanNumeral(txtNum.Text)
        Dim romanInNumber As Integer = 0
        Dim val As String = txtNum.Text
        Dim roman As New Dictionary(Of String, Integer) From {
            {"M", 1000},
            {"CM", 900},
            {"D", 500},
            {"CD", 400},
            {"C", 100},
            {"XC", 90},
            {"L", 50},
            {"XL", 40},
            {"X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1}
        }

        If validate And txtNum.Text <> "" Then
            For Each romanNum As KeyValuePair(Of String, Integer) In roman
                ' Dim reg As Regex = New Regex("^" & romanNum.Key)
                Dim reg As String = "^" & romanNum.Key
                Dim letter As String = ""
                Dim x As Integer = 0
                Dim counter As Integer = 0
                Dim multipler As Integer = 1
                Dim valLen As Integer = txtNum.Text.Length

                If Regex.Match(val, reg).ToString() <> "" Then
                    For x = 0 To valLen
                        If val.Length = 1 OrElse val(0) <> val(1) Then
                            romanInNumber += (multipler * romanNum.Value)
                            val = val.Substring(romanNum.Key.Length)

                            Exit For
                        Else
                            multipler += 1
                            val = val.Substring(romanNum.Key.Length)
                        End If
                    Next
                End If
            Next

            lblResult.Text = romanInNumber.ToString("###,###")
        Else
            If txtNum.Text = "" Then
                MessageBox.Show("Please enter a number", "No input detected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("The roman numeral you typed isn't valid", "Invalid Roman Numeral", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function ValidateRomanNumeral(ByVal str As String)
        Dim romanIsValid As Regex = New Regex("^(?=[MDCLXVI])M{0,3}(C[MD]|D?C{0,3})(X[CL]|L?X{0,3})(I[XV]|V?I{0,3})$", RegexOptions.IgnoreCase)

        If romanIsValid.IsMatch(str) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        Select Case Mode
            Case "Number"
                Mode = "Roman Numeral"
                picBackground.BackgroundImage = My.Resources.Background_Roman2Number
                txtNum.MaxLength = 15
                txtNum.Text = ""
            Case "Roman Numeral"
                Mode = "Number"
                picBackground.BackgroundImage = My.Resources.Background_Number2Roman
                txtNum.MaxLength = 4
                txtNum.Text = ""
        End Select

        lblResult.Text = "- - -"
    End Sub

    Private Sub btnCalculate_MouseEnter(sender As Object, e As EventArgs) Handles btnConvert.MouseEnter, btnSwitch.MouseEnter
        Dim ButtonBackground As Button = CType(sender, Button)

        ButtonBackground.BackgroundImage = My.Resources.ButtonBackground_Hover
        ButtonBackground.ForeColor = Color.White
        ButtonBackground.FlatAppearance.BorderColor = Color.Black
    End Sub

    Private Sub btnCalculate_MouseLeave(sender As Object, e As EventArgs) Handles btnConvert.MouseLeave, btnSwitch.MouseLeave
        Dim ButtonBackground As Button = CType(sender, Button)

        ButtonBackground.BackgroundImage = My.Resources.ButtonBackground
        ButtonBackground.ForeColor = Color.Black
        ButtonBackground.FlatAppearance.BorderColor = Color.Black
    End Sub
End Class