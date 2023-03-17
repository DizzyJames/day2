Imports System.Net.Security
Imports FontAwesome.Sharp
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices
Imports Xamarin.Forms

Public Class Form1
    Private CurrentBtn As Guna2Button
    Private leftBorderBtn As Panel
    Public Class Admin
        Private Sub RoundCorners(Obj As Form)
            Obj.FormBorderStyle = FormBorderStyle.None

            Dim DGP As New Drawing2D.GraphicsPath
            DGP.StartFigure()


            DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
            DGP.AddLine(40, 0, Obj.Width - 40, 0)

            DGP.AddArc(New Rectangle(Obj.Width - 40, 0, 40, 40), -90, 90)
            DGP.AddLine(Obj.Width, 40, Obj.Width, Obj.Height - 40)

            DGP.AddArc(New Rectangle(Obj.Width - 40, Obj.Height - 40, 40, 40), 0, 90)
            DGP.AddLine(Obj.Width - 40, Obj.Height, 40, Obj.Height)

            DGP.AddArc(New Rectangle(0, Obj.Height - 40, 40, 40), 90, 90)
            DGP.CloseFigure()

            Obj.Region = New Region(DGP)
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RoundCorners(Me)
        End Sub
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            leftBorderBtn = New Panel
            leftBorderBtn.Size = New Size(7, 71)
            SidePanel.Controls.Add(leftBorderBtn)

        End Sub
        Private Sub ActiveButton(senderBtn As Object, customColor As Color)
            If senderBtn IsNot Nothing Then
                CurrentBtn = CType(senderBtn, IconButton)
                CurrentBtn.BackColor = Color.FromArgb(47, 79, 79)
                CurrentBtn.ForeColor = Color.White
                CurrentBtn.IconColor = Color.White

                leftBorderBtn.BackColor = customColor
                leftBorderBtn.Location = New Point(0, CurrentBtn.Location.Y)
                leftBorderBtn.Visible = True
                leftBorderBtn.BringToFront()

            End If
        End Sub
        Private Sub DisabledButton()
            If CurrentBtn IsNot Nothing Then
                CurrentBtn.BackColor = Color.FromArgb(30, 99, 149)
                CurrentBtn.ForeColor = Color.White
                CurrentBtn.IconColor = Color.White

            End If
        End Sub
        Private Sub addForm(frm As Form)
            MidPanel.Controls.Clear()
            frm.TopLevel = False
            frm.TopMost = True
            frm.Dock = DockStyle.Fill
            MidPanel.Controls.Add(frm)
            frm.Show()

        End Sub
        Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RoundCorners(Me)
            ChangeMenu("DashForm")

        End Sub

        Public Class Colors
            Public Shared TruColor As Color = Color.Chocolate


        End Class


    End Class
    Private Sub addForm(frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()

    End Sub
    Private Sub ChangeMenu(menu As String)
        Select Case menu
            Case "Add a New User"
                addForm(AddUser)
            Case "Delete a User"
                addForm(DelUser)
            Case "Edit"
                addForm(Edit)
            Case "Search"
                addForm(Search)

        End Select
    End Sub
    Private Sub adduse_Click(sender As Object, e As EventArgs) Handles adduse.Click
        ChangeMenu("Add a New User")
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ChangeMenu("Delete a User")
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        ChangeMenu("Edit")
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        ChangeMenu("Search")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub
End Class
