Partial Public Class MainPage


    Inherits PhoneApplicationPage
    Shared rn As New Random()
    Private n As Integer
    Private b As Integer
    Private counter As Integer
    Private myname As String


    





    ' Constructor
    Public Sub New()


        InitializeComponent()
        bet.IsEnabled = 0
        quit.Visibility = Windows.Visibility.Collapsed
        enter.Visibility = Windows.Visibility.Collapsed
        'MediaElement1.AutoPlay = True
        'MediaElement2.AutoPlay = False
        'MediaElement3.AutoPlay = False
        MediaElement1.Play()












    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button3.Click
        MessageBox.Show("ABOUT" & vbCrLf & vbCrLf & "Experimental Project: Guess the number " & vbCrLf & "Developed by: Chaelgutierrez(CS322)" & vbCrLf & "Instructor: Jonah Rayos" & vbCrLf & "AI used: Rule Fire & Search Algorithm")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles Button4.Click
        MessageBox.Show("HOW TO PLAY?" & vbCrLf & vbCrLf & "To start with Press Start button" & vbCrLf & "In this game, you will see a box above with QUESTION mark" & vbCrLf & "This box contain the generated number from 1-37" & vbCrLf & "What you have to do is input your bet in the box and press Enter button" & vbCrLf & vbCrLf & "NOTE:" & vbCrLf & vbCrLf & "You only have 3 lives to get the correct number" & vbCrLf & "Every bet you enter,if you failed for every attempts there is a hint about the generated number for you" & vbCrLf & ":) That's all good luck")


    End Sub

    Private Sub PhoneApplicationPage_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded



    End Sub

    Private Sub start_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles start.Click



        t1.Text = ""
        t2.Text = ""
        t3.Text = ""

        quest.Visibility = Windows.Visibility.Visible
        quit.Visibility = Windows.Visibility.Visible
        start.Visibility = Windows.Visibility.Collapsed
        enter.Visibility = Windows.Visibility.Visible
        bet.IsEnabled = 1
        bet.Text = ""
        counter = 0
        cnt.Text = counter



        n = rn.Next(1, 37)
        TextBlock3.Text = n










    End Sub

    Private Sub enter_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles enter.Click



        If bet.Text = "1" Or bet.Text = "2" Or bet.Text = "3" Or bet.Text = "4" Or bet.Text = "5" Or bet.Text = "6" Or bet.Text = "7" Or bet.Text = "8" Or bet.Text = "9" Or bet.Text = "10" Or bet.Text = "11" Or bet.Text = "12" Or bet.Text = "13" Or bet.Text = "14" Or bet.Text = "15" Or bet.Text = "16" Or bet.Text = "17" Or bet.Text = "18" Or bet.Text = "19" Or bet.Text = "20" Or bet.Text = "21" Or bet.Text = "22" Or bet.Text = "23" Or bet.Text = "24" Or bet.Text = "25" Or bet.Text = "26" Or bet.Text = "27" Or bet.Text = "28" Or bet.Text = "29" Or bet.Text = "30" Or bet.Text = "31" Or bet.Text = "32" Or bet.Text = "33" Or bet.Text = "34" Or bet.Text = "35" Or bet.Text = "36" Or bet.Text = "37" Then

            b = Integer.Parse(bet.Text)
            If b = n Then
                MediaElement1.Stop()
                MediaElement3.Play()
                MessageBox.Show("Congratulations you won :)")
                quest.Visibility = Windows.Visibility.Collapsed
                quit.Visibility = Windows.Visibility.Collapsed
                enter.Visibility = Windows.Visibility.Collapsed
                start.Visibility = Windows.Visibility.Visible
                bet.IsEnabled = 0
                counter = counter + 1
                cnt.Text = counter

                If counter = 1 Then
                    t1.Text = b & (" = ?")

                ElseIf counter = 2 Then
                    t2.Text = b & (" = ?")
                ElseIf counter = 3 Then
                    t3.Text = b & (" = ?")
                End If
                MediaElement1.Play()


            ElseIf b > n Then 'mas malaki ang taya\
                MediaElement1.Stop()
                MediaElement2.Play()
                MessageBox.Show("Your bet " & b & " is greater than the generated number")
                counter = counter + 1
                cnt.Text = counter
                bet.Text = ""


                If counter = 1 Then
                    t1.Text = b & (" > ?")
                ElseIf counter = 2 Then
                    t2.Text = b & (" > ?")
                ElseIf counter = 3 Then
                    t3.Text = b & (" > ?")
                End If

                If counter = 3 And b <> n Then
                    MessageBox.Show("Sorry you loose :(")
                    quit.Visibility = Windows.Visibility.Collapsed
                    enter.Visibility = Windows.Visibility.Collapsed
                    start.Visibility = Windows.Visibility.Visible
                    quest.Visibility = Windows.Visibility.Collapsed
                    bet.IsEnabled = 0
                End If

                MediaElement1.Play()



            ElseIf b < n Then 'mas maliit ang taya
                MediaElement1.Stop()
                MediaElement2.Play()
                MessageBox.Show("Your bet " & b & " is less than the generated number")
                counter = counter + 1
                cnt.Text = counter
                bet.Text = ""

                If counter = 1 Then
                    t1.Text = b & (" < ?")
                ElseIf counter = 2 Then
                    t2.Text = b & (" < ?")
                ElseIf counter = 3 Then
                    t3.Text = b & (" < ?")
                End If

                If counter = 3 And b <> n Then
                    MessageBox.Show("Sorry you loose :(")
                    quit.Visibility = Windows.Visibility.Collapsed
                    enter.Visibility = Windows.Visibility.Collapsed
                    start.Visibility = Windows.Visibility.Visible
                    quest.Visibility = Windows.Visibility.Collapsed
                    bet.IsEnabled = 0
                End If



                MediaElement1.Play()


            End If

        ElseIf bet.Text = "" Then 'wala laman ang bet

            MediaElement1.Stop()
            MediaElement4.Play()
            MessageBox.Show("Please input bet!!!")
            MediaElement1.Play()



        Else ' sala ang mga input sa bet
            MediaElement1.Stop()
            MediaElement4.Play()
            MessageBox.Show("Invalid Input Bet!!!" & vbCrLf & "Please Input numbers 1-37 only!!!")
            bet.Text = ""
            MediaElement1.Play()

        End If







    End Sub

    Private Sub bet_TextChanged(sender As System.Object, e As System.Windows.Controls.TextChangedEventArgs) Handles bet.TextChanged

    End Sub

    Private Sub quit_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles quit.Click
        bet.IsEnabled = 0
        MediaElement1.Stop()
        MediaElement4.Play()

        quest.Visibility = Windows.Visibility.Collapsed
        enter.Visibility = Windows.Visibility.Collapsed
        quit.Visibility = Windows.Visibility.Collapsed
        start.Visibility = Windows.Visibility.Visible
        MessageBox.Show("Sorry you loose because you quit the game :(")
        MediaElement1.Play()


    End Sub
End Class
