Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module Module1
    Public currentUser As String

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public datatable As New DataTable
    Public data As New DataSet
    Public reader As MySqlDataReader
    Public parameter As New MySqlParameter

    Sub openCon()

        con.ConnectionString = "server=localhost;username=pchs;password=pangantucan;database=pchslibrary;Convert Zero Datetime=True"

        con.Open()
    End Sub

    Sub closeCon()
        con.Close()
    End Sub

    Function GetTable()
        Return datatable
    End Function

    Function GetCurrentUser()
        Return currentUser
    End Function

    Sub SetCurrentUser(user)
        currentUser = user
    End Sub

    Sub command(commands As String)
        cmd.Connection = con
        cmd.CommandText = commands
    End Sub

    Sub execute()
        cmd.ExecuteNonQuery()
    End Sub

    Sub FillTable()
        adapter.SelectCommand = cmd
        datatable.Clear()
        adapter.Fill(datatable)
    End Sub
End Module
