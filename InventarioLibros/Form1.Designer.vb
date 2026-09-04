<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvLibros = New DataGridView()
        txtTitulo = New TextBox()
        txtAutor = New TextBox()
        txtCantidad = New TextBox()
        btnAgregar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(dgvLibros, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvLibros
        ' 
        dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLibros.Location = New Point(132, 151)
        dgvLibros.Name = "dgvLibros"
        dgvLibros.Size = New Size(560, 265)
        dgvLibros.TabIndex = 0
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(324, 55)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(175, 23)
        txtTitulo.TabIndex = 1
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(324, 93)
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(175, 23)
        txtAutor.TabIndex = 2
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(324, 122)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(175, 23)
        txtCantidad.TabIndex = 3
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(545, 54)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(108, 23)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(545, 93)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(108, 23)
        btnActualizar.TabIndex = 5
        btnActualizar.Text = "ACTUALIZAR"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(545, 122)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(108, 23)
        btnEliminar.TabIndex = 6
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightGray
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(269, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 23)
        Label1.TabIndex = 7
        Label1.Text = "INVENTARIO DE LIBROS "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Modern No. 20", 8.999999F, FontStyle.Bold)
        Label2.Location = New Point(153, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 15)
        Label2.TabIndex = 8
        Label2.Text = "NOMBRE DE LA OBRA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Modern No. 20", 8.999999F, FontStyle.Bold)
        Label3.Location = New Point(153, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 15)
        Label3.TabIndex = 9
        Label3.Text = "NOMBRE DEL AUTOR"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Modern No. 20", 8.999999F, FontStyle.Bold)
        Label4.Location = New Point(132, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(182, 15)
        Label4.TabIndex = 10
        Label4.Text = "CANTIDADES QUE QUEDAN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 30)
        Label5.TabIndex = 11
        Label5.Text = "ROLANDO REYES 8-957-1779" & vbCrLf & "JEREMY LAMAS    8-983-2241"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.libro_que_tiene_palabra_amor_955834_69952
        ClientSize = New Size(746, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnAgregar)
        Controls.Add(txtCantidad)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Controls.Add(dgvLibros)
        Name = "Form1"
        Text = "Inventario de Libros"
        CType(dgvLibros, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
