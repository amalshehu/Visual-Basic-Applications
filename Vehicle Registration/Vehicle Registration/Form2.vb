
Imports System.Data.OleDb
Imports System.Object
Imports System
Imports System.Data
Imports System.Windows.Forms



Public Class Form2
    Dim provider As String
    Dim datafile, path As String
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Veh1DataSet3.Table_1' table. You can move, or remove it, as needed.
        Me.Table_1TableAdapter.Fill(Me.Veh1DataSet3.Table_1)
        'TODO: This line of code loads data into the 'Veh1DataSet2.Table_1' table. You can move, or remove it, as needed.


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        provider = "Provider=Microsoft.Jet.OleDb.4.0; Data Source="
        path = "C:\Users\Amal Shehu\Documents\Visual Studio 2012\Projects\Vehicle Registration\Vehicle Registration\bin\Debug"
        datafile = path + "\veh1.mdb"
        connString = provider & datafile
        myConnection.ConnectionString = connString
        Dim str As String
        myConnection.Open()
        Dim regno, chno As Integer
        regno = Val(TextBox1.Text)
        chno = Val(TextBox6.Text)
        str = "INSERT INTO Table_1 VALUES('" & regno & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & chno & "','" & TextBox7.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.ExecuteNonQuery()
        myConnection.Close()
        MsgBox("Done")
        Me.Table_1TableAdapter.Fill(Me.Veh1DataSet3.Table_1)
        Me.Hide()
        Form3.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        
        
        Me.Table_1TableAdapter.Fill(Me.Veh1DataSet3.Table_1)


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class