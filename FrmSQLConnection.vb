Imports System.Data.SqlClient
'--- MEGA TEST projesi ver:1.2 ------------------

Public Class FrmSQLConnection
    Const strConn As String = "Data Source=YAZILIM4\MEGA;Initial Catalog=MegaData_TEST;Integrated Security=True;Persist Security Info=True;User ID=sa"
    Const strSQL As String = "SELECT * FROM CarAna"

    Dim cnConnect As New SqlConnection
    Dim daAdapter As SqlDataAdapter
    Dim cbCommand As SqlCommand

    Dim dtTable As New DataTable
    Dim iRowPos As Integer = 0


    Private Sub FrmSQLConnection_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        OpenConn()
        OpenTable()

        dgvCarAna.DataSource = dtTable

        KayitGoster()
    End Sub

    Sub OpenConn()
        cnConnect.ConnectionString = strConn
        cnConnect.Open()
    End Sub

    Sub OpenTable()
        Try
            daAdapter = New SqlDataAdapter(strSQL, cnConnect)
            cbCommand = New SqlCommand(strSQL)
            daAdapter.Fill(dtTable)
        Catch e As Exception
            MsgBox("TABLO AÇILAMADI ! " & vbCrLf & e.ToString)
        End Try
        iRowPos = 0
    End Sub

    Sub KayitGoster()
        txtKod.Text = dtTable.Rows(iRowPos).Item("Kod")
        txtAd.Text = mgNullkontrol(dtTable.Rows(iRowPos).Item("Ad"))
    End Sub

    Private Sub btnSonraki_Click(sender As System.Object, e As System.EventArgs) Handles btnSonraki.Click
        iRowPos += 1
        KayitGoster()
    End Sub

    Private Sub btnOnceki_Click(sender As System.Object, e As System.EventArgs) Handles btnOnceki.Click
        If iRowPos > 0 Then
            iRowPos -= 1
            KayitGoster()
        End If
    End Sub

    Private Function mgNullkontrol(strPar As Object) As String
        mgNullkontrol = If(IsDBNull(strPar), "", strPar)
    End Function

    Private Sub btnCikis_Click(sender As System.Object, e As System.EventArgs) Handles btnCikis.Click
        Close()
    End Sub

End Class
