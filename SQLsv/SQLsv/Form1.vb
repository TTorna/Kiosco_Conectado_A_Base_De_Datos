Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KioskitoDataSet1.golosinas' Puede moverla o quitarla según sea necesario.


        Dim sql As String
        Dim conex As New ConectaSQL
        Try
            sql = "Use Kioskito;Select * from Golosinas;"
            conex.EjecutarSql(sql)
            conex.Dispose()
            MsgBox("los datos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
        Catch ex As Exception
            sql = "Create schema Kioskito;Use Kioskito;Create Table Golosinas (Id tinyint primary key, Nombre varchar(30), Cantidad int, Precio float);"
            conex.EjecutarSql(sql)
            conex.Dispose()
            MsgBox("Se creo la base de datos")
            MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
        Me.GolosinasTableAdapter1.Fill(Me.KioskitoDataSet1.golosinas)
        GuardadoGrid()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim conex As New ConectaSQL
        Try
            sql = "Use Kioskito; Insert INTO Golosinas (Id, Nombre, Cantidad, Precio) Values (" + TxtId.Text + ", '" + TxtNom.Text + "', " + TxtCant.Text + ", " + TxtPrecio.Text + ");"
            conex.EjecutarSql(sql)
            conex.Dispose()
            MsgBox("los datos se ingresaron correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se pudo insertar correctamente")
            MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar datos")
        End Try
        loaddata()
        GuardadoGrid()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim conex As New ConectaSQL
        Try
            sql = "Use Kioskito; SELECT * FROM Golosinas WHERE ID LIKE('" + TxtId.Text + "') OR NOMBRE LIKE('" + TxtNom.Text + "')"
            conex.EjecutarSql(sql)
            conex.DataAdapt = New MySql.Data.MySqlClient.MySqlDataAdapter(conex.micomando)
            conex.DataAdapt.Fill(conex.DataStt)
            DataGridView1.DataSource = conex.DataStt.Tables(0).DefaultView
            conex.Dispose()
            loaddata()
            MsgBox("los datos se Buscaron correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No se encontraron datos con ese id")
        End Try
        GuardadoGrid()
    End Sub

    Private Sub loaddata()
        Me.GolosinasTableAdapter1.Fill(Me.KioskitoDataSet1.golosinas)
    End Sub

    Private Sub GuardadoGrid()
        Me.DataGridView1.ReadOnly = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim sql As String
        Dim conex As New ConectaSQL
        sql = "Use Kioskito; Drop Table Golosinas;Create Table Golosinas (Id tinyint primary key, Nombre varchar(30), Cantidad int, Precio float);"
        conex.EjecutarSql(sql)
        conex.Dispose()
        MsgBox("los datos se Borraron correctamente", MsgBoxStyle.Information)
        loaddata()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Sql As String
        Dim Conex As New ConectaSQL
        Try
            Sql = "use Kioskito; update Golosinas set nombre = '" + TxtNom.Text + "', cantidad= '" + TxtCant.Text + "' ,precio='" + TxtPrecio.Text + "' where id=(' " + TxtId.Text + "');"
            Conex.EjecutarSql(Sql)
            Conex.Dispose()
            MsgBox("Se pudo actualizar")
            loaddata()

        Catch ex As Exception

            MsgBox("No se pudo actualizar")
        End Try
        loaddata()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Sql As String
        Dim Conex As New ConectaSQL
        Try
            Sql = "use Kioskito; delete from Golosinas where id=('" + TxtId.Text + "');"
            Conex.EjecutarSql(Sql)
            Conex.Dispose()
            MsgBox("Se encontro la base de datos")

        Catch ex As Exception
            MsgBox("No se pudo borrar")

        End Try
        loaddata()
    End Sub

    Private Sub BTNAjusPrec_Click(sender As Object, e As EventArgs) Handles BTNAjusPrec.Click
        Dim Sql As String
        Dim Conex As New ConectaSQL
        If RBSubir.Checked = True Then
            Sql = "use Kioskito; update Golosinas set precio = precio + (precio*" + TBAjusPrec.Text + ")/100;"
            Conex.EjecutarSql(Sql)
            Conex.Dispose()

            MsgBox("Se pudo actualizar")
            loaddata()
        ElseIf RBBajar.Checked Then
            Sql = "use Kioskito; update Golosinas set precio = precio- (precio*" + TBAjusPrec.Text + ")/100;"
            Conex.EjecutarSql(Sql)
            Conex.Dispose()

            MsgBox("Se pudo actualizar")
            loaddata()
        End If
    End Sub
End Class
