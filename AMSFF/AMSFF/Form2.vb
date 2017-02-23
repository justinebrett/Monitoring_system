Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form2
    Inherits System.Windows.Forms.Form

    Private dataGridView1 As New DataGridView()
    Private bindingSource1 As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private WithEvents reloadButton As New Button()
    Private WithEvents submitButton As New Button()

    <STAThreadAttribute()> _
    Public Shared Sub Main()
        Application.Run(New Form1())
    End Sub

    ' Initialize the form.
    Public Sub Neww()

        Me.dataGridView1.Dock = DockStyle.Fill

        Me.reloadButton.Text = "reload"
        Me.submitButton.Text = "submit"

        Dim panel As New FlowLayoutPanel()
        panel.Dock = DockStyle.Top
        panel.AutoSize = True
        panel.Controls.AddRange(New Control() {Me.reloadButton, Me.submitButton})

        Me.Controls.AddRange(New Control() {Me.dataGridView1, panel})
        Me.Text = "DataGridView databinding and updating demo"

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles Me.Load

        ' Bind the DataGridView to the BindingSource
        ' and load the data from the database.
        Me.dataGridView1.DataSource = Me.bindingSource1
        GetData("select * from Customers")

    End Sub

    Private Sub reloadButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles reloadButton.Click

        ' Reload the data from the database.
        GetData(Me.dataAdapter.SelectCommand.CommandText)

    End Sub

    Private Sub submitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles submitButton.Click

        ' Update the database with the user's changes.
        Me.dataAdapter.Update(CType(Me.bindingSource1.DataSource, DataTable))

    End Sub

    Private Sub GetData(ByVal selectCommand As String)

        Try
            ' Specify a connection string. Replace the given value with a 
            ' valid connection string for a Northwind SQL Server sample
            ' database accessible to your system.
            Dim connectionString As String = "server=localhost; userid=root; password=; database=thesisdb; port=3306"

            ' Create a new data adapter based on the specified query.
            Me.dataAdapter = New SqlDataAdapter(selectCommand, connectionString)

            ' Create a command builder to generate SQL update, insert, and
            ' delete commands based on selectCommand. These are used to
            ' update the database.
            Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)

            ' Populate a new data table and bind it to the BindingSource.
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            Me.dataAdapter.Fill(table)
            Me.bindingSource1.DataSource = table

            ' Resize the DataGridView columns to fit the newly loaded content.
            Me.dataGridView1.AutoResizeColumns( _
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
        Catch ex As SqlException
            MessageBox.Show("To run this example, replace the value of the " + _
                "connectionString variable with a connection string that is " + _
                "valid for your system.")
        End Try

    End Sub

End Class
