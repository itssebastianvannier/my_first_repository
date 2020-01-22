Imports System.Data.OleDb
Public Class Form1
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim gender As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\IEUser\Documents\Aditya\Database Connectivity\Database Connectivity\Database1.accdb")
        conn.Open()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInsert.Click
        If selectMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        cmd = New OleDbCommand("insert into table1([Roll No],[Student_name],[DOB],[Address],[Gender]) values (" + inputRollNo.Text + ",'" + inputName.Text + "','" + Format(inputDOB.Value, "dd-MM-yyyy") + "','" + inputAddress.Text + "','" + gender + "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("The record has been Inserted successfully")
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectMale.Checked = True Then
            gender = "male"
        Else
            gender = "female"
        End If
        cmd = New OleDbCommand("Update table1 set [Student_name]='" + inputName.Text + "',[Address]='" + inputAddress.Text + "',[Gender]='" + gender + "',[DOB]='" + Format(inputDOB.Value, "dd-MM-yyyy") + "' where [Roll No]=" + inputRollNo.Text + "", conn)
        cmd.ExecuteNonQuery()
        MsgBox("The record has been Updated successfully")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        da = New OleDbDataAdapter("Select * from table1 where [roll no]=" + inputRollNo.Text + "", conn)
        ds = New DataSet
        da.Fill(ds, "table1")
        inputName.Text = ds.Tables("table1").Rows(0)("Student_name").ToString
        inputAddress.Text = ds.Tables("table1").Rows(0)("Address").ToString
        If ds.Tables("table1").Rows(0)("gender") = "Male" Then
            selectMale.Checked = True
        Else
            selectFemale.Checked = True
        End If
        inputDOB.Value = ds.Tables("table1").Rows(0)("DOB").ToString
        'cmbHobbies.Text = ds.Tables("tbstudent").Rows(0)("Hobbies").ToString

    End Sub
End Class
