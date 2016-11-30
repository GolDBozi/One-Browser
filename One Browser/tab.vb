Imports Awesomium.Core

Public Class tab
    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        Settings.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebControl1.Source = New Uri(My.Settings.Homepage)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebControl1.Source = New Uri(My.Settings.Homepage)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
            Try
                WebControl1.Source = New Uri(TextBox1.Text)
            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + TextBox1.Text)
                TextBox1.Text = ("http://" + TextBox1.Text)
            End Try
        Else : WebControl1.Source = New Uri("https://www.google.gr/search?q=" & TextBox1.Text)
        End If
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebControl1.Reload(ignoreCache:=True)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If WebControl1.IsNavigating Then
            WebControl1.Stop()
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As FrameEventArgs) Handles WebControl1.LoadingFrameComplete
        PictureBox1.Visible = False
        Parent.Text = WebControl1.Title
        TextBox1.Text = WebControl1.Source.ToString
    End Sub

    Private Sub WebControl1_LoadingFrame(sender As Object, e As LoadingFrameEventArgs) Handles WebControl1.LoadingFrame
        PictureBox1.Visible = True
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        MessageBox.Show("One man ,one mission,one desirrre!He set out on a journey to counquer the interwebs using only his hands and computer,during his journey he encountered many strange people that didn't know what Games or Anime are?!?!?! But now his project is finished and he will take over from Bill Gates and become king of the nerds.Comming Soon this winter,droping on github and under your christmas tree.", "GolDBozi")
    End Sub

    Private Sub BrowserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowserToolStripMenuItem.Click
        MessageBox.Show("Have you heard of FireFox ? Or maybe Chrome ? Still laughing at Edge? Or are you one of the edgy ones that use Opera ? Forget all that and start using the brand new super-duper-wow-omg-musthave-#like-thumbsup browser from the Aliens of outer space One Browser!!!! It supports html-10,csss5,cs:go and cs:1.6,The Incredile Hulk's shockwave,javascripts and all latest fashions in web-browsing.Download for free,with only 99.98$ a month!", "One Browser")
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        WebBrowser1.ShowSaveAsDialog()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    WebControl1.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)

                End Try
            Else : WebControl1.Source = New Uri("https://www.google.gr/search?newwindow=1&hl=el&site=webhp&q=" & TextBox1.Text)

            End If
        End If
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        WebBrowser1.ShowPrintDialog()

    End Sub
End Class