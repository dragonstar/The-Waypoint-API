Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        ' Create the GET web request
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create("http://thewaypoint.initforthe.com/api/v1/marinas/101/berths?auth_token=0_D_WgyK6FVYPEpc4-6q"), HttpWebRequest)
        request.Method = "GET"
        request.UserAgent = "VB Mooring Manager GitHub Test Script"
        request.KeepAlive = True


        ' Web Response Output  
        Dim response As HttpWebResponse
        response = DirectCast(request.GetResponse(), HttpWebResponse)

        Dim postreqreader As New StreamReader(response.GetResponseStream())
        Dim thepage As String = postreqreader.ReadToEnd


        RichTextBox1.Text = thepage




    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class



