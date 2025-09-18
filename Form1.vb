Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'this gets the values from the input box and asigns it to variables
        Dim length, width As String

        length = lengthInput.Text
        width = widthInput.Text

        'created variables to use 
        'i will use inch to calculate as default and convert to foot when displaying

        Dim volumeFt, volumeYrd, depth As Decimal

        depth = 4

        If length = "" Or width = "" Then

            MessageBox.Show("Please input Value(s)")

        Else
            'this checks if the inch value was checked
            If inchCheck.Checked = True And footCheck.Checked = False Then

                'the turn the strings into integers and convert them to foot than give depth a value
                length = CDec(length) * 0.075
                width = CDec(width) * 0.075

                volumeFt = (length * depth * width)
                volumeYrd = (length * depth * width) / 3 ^ 3

                'the new values are now assigned on the window fom

                volumeCu.Text = volumeFt.ToString("0.00") & " cu. Ft "
                volumeYds.Text = volumeYrd.ToString("0.00") & " cu. Yds"


                'this checks if the foot value was chechked
            ElseIf inchCheck.Checked = False And footCheck.Checked = True Then
                'the turn the strings into integers and give depth a value
                length = CDec(length)
                width = CDec(width)

                volumeFt = (length * depth * width)
                volumeYrd = (length * depth * width) / 3 ^ 3

                'the new values are now assigned on the window fom

                volumeCu.Text = volumeFt.ToString("0.00") & " cu. Ft "
                volumeYds.Text = volumeYrd.ToString("0.00") & " cu. Yds"

            Else

                MessageBox.Show("Please Choose one unit type")

            End If

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lengthInput.Text = ""
        widthInput.Text = ""
        volumeCu.Text = " 0.00 cu. Ft "
        volumeYds.Text = " 0.00 cu. Yds"
        inchCheck.Checked = False
        footCheck.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class