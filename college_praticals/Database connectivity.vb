Imports System.Data.OleDb
Public Class Form1
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim gender As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\university\student.accdb")
        conn.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click
        If RadioButton1.Checked = True Then
            gender = "male"
        Else
            gender = "female"
        End If
        cmd = New OleDbCommand("insert into tbstudent(roll_no,stud_name,Address,gender,dob,hobbies) values(" + txtrollno.Text + ",'" + txtStuName.Text + "','" + txtAdd.Text + "','" + gender + "','" + Format(DateTimePicker1.Value, "dd-MM-yyyy") + "','" + cmbHobbies.Text + "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("The record has been Inserted successfully")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            gender = "male"
        Else
            gender = "female"
        End If
        cmd = New OleDbCommand("Update tbstudent set stud_name='" + txtStuName.Text + "',Address='" + txtAdd.Text + "',gender='" + gender + "',dob='" + Format(DateTimePicker1.Value, "dd-MM-yyyy") + "',hobbies='" + cmbHobbies.Text + "' where roll_no=" + txtrollno.Text + "", conn)
        cmd.ExecuteNonQuery()
        MsgBox("The record has been Updated successfully")
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        da = New OleDbDataAdapter("Select * from tbstudent where roll_no=" + txtrollno.Text + "", conn)
        ds = New DataSet
        da.Fill(ds, "tbstudent")
        txtStuName.Text = ds.Tables("tbstudent").Rows(0)("stud_name").ToString
        txtAdd.Text = ds.Tables("tbstudent").Rows(0)("Address").ToString
        If ds.Tables("tbstudent").Rows(0)("gender") = "male" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If
        DateTimePicker1.Value = ds.Tables("tbstudent").Rows(0)("dob").ToString
        cmbHobbies.Text = ds.Tables("tbstudent").Rows(0)("Hobbies").ToString

    End Sub
End Class
