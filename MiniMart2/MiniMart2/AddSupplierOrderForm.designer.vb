<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSupplierOrderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Item = New System.Windows.Forms.Label()
        Me.AddNewSupplierOrder = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ItemTextBox = New System.Windows.Forms.TextBox()
        Me.OrderBy = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.Label()
        Me.OrderByTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.OrderDate = New System.Windows.Forms.Label()
        Me.OrderNo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item
        '
        Me.Item.AutoSize = True
        Me.Item.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.Location = New System.Drawing.Point(-45, 226)
        Me.Item.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(40, 17)
        Me.Item.TabIndex = 17
        Me.Item.Text = "Item"
        '
        'AddNewSupplierOrder
        '
        Me.AddNewSupplierOrder.AutoSize = True
        Me.AddNewSupplierOrder.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewSupplierOrder.Location = New System.Drawing.Point(54, 21)
        Me.AddNewSupplierOrder.Name = "AddNewSupplierOrder"
        Me.AddNewSupplierOrder.Size = New System.Drawing.Size(326, 26)
        Me.AddNewSupplierOrder.TabIndex = 26
        Me.AddNewSupplierOrder.Text = "Add New Supplier Order"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NoTextBox)
        Me.GroupBox1.Controls.Add(Me.AddButton)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.ItemTextBox)
        Me.GroupBox1.Controls.Add(Me.OrderBy)
        Me.GroupBox1.Controls.Add(Me.Quantity)
        Me.GroupBox1.Controls.Add(Me.OrderByTextBox)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.OrderDate)
        Me.GroupBox1.Controls.Add(Me.OrderNo)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(851, 178)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(29, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Item"
        '
        'NoTextBox
        '
        Me.NoTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTextBox.Location = New System.Drawing.Point(145, 24)
        Me.NoTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NoTextBox.Multiline = True
        Me.NoTextBox.Name = "NoTextBox"
        Me.NoTextBox.ReadOnly = True
        Me.NoTextBox.Size = New System.Drawing.Size(220, 20)
        Me.NoTextBox.TabIndex = 37
        Me.NoTextBox.Text = "<Auto>"
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(701, 119)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(120, 39)
        Me.AddButton.TabIndex = 36
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(422, 133)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.QuantityTextBox.Multiline = True
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(234, 20)
        Me.QuantityTextBox.TabIndex = 35
        '
        'ItemTextBox
        '
        Me.ItemTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTextBox.Location = New System.Drawing.Point(92, 133)
        Me.ItemTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ItemTextBox.Multiline = True
        Me.ItemTextBox.Name = "ItemTextBox"
        Me.ItemTextBox.Size = New System.Drawing.Size(198, 20)
        Me.ItemTextBox.TabIndex = 34
        '
        'OrderBy
        '
        Me.OrderBy.AutoSize = True
        Me.OrderBy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderBy.Location = New System.Drawing.Point(402, 75)
        Me.OrderBy.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.OrderBy.Name = "OrderBy"
        Me.OrderBy.Size = New System.Drawing.Size(75, 17)
        Me.OrderBy.TabIndex = 33
        Me.OrderBy.Text = "Order By"
        '
        'Quantity
        '
        Me.Quantity.AutoSize = True
        Me.Quantity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(326, 136)
        Me.Quantity.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(69, 17)
        Me.Quantity.TabIndex = 32
        Me.Quantity.Text = "Quantity"
        '
        'OrderByTextBox
        '
        Me.OrderByTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderByTextBox.Location = New System.Drawing.Point(540, 75)
        Me.OrderByTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.OrderByTextBox.Multiline = True
        Me.OrderByTextBox.Name = "OrderByTextBox"
        Me.OrderByTextBox.Size = New System.Drawing.Size(281, 20)
        Me.OrderByTextBox.TabIndex = 31
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(540, 21)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(281, 25)
        Me.DateTimePicker1.TabIndex = 30
        '
        'OrderDate
        '
        Me.OrderDate.AutoSize = True
        Me.OrderDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDate.Location = New System.Drawing.Point(402, 27)
        Me.OrderDate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.Size = New System.Drawing.Size(90, 17)
        Me.OrderDate.TabIndex = 29
        Me.OrderDate.Text = "Order Date"
        '
        'OrderNo
        '
        Me.OrderNo.AutoSize = True
        Me.OrderNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderNo.Location = New System.Drawing.Point(29, 23)
        Me.OrderNo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.OrderNo.Name = "OrderNo"
        Me.OrderNo.Size = New System.Drawing.Size(76, 17)
        Me.OrderNo.TabIndex = 28
        Me.OrderNo.Text = "Order No"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SaveButton)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(851, 279)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(546, 239)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(123, 47)
        Me.SaveButton.TabIndex = 30
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, -7)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(851, 236)
        Me.DataGridView1.TabIndex = 29
        '
        'AddSupplierOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 525)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AddNewSupplierOrder)
        Me.Controls.Add(Me.Item)
        Me.Name = "AddSupplierOrderForm"
        Me.Text = "Add Supplier Order Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Item As System.Windows.Forms.Label
    Friend WithEvents AddNewSupplierOrder As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderBy As System.Windows.Forms.Label
    Friend WithEvents Quantity As System.Windows.Forms.Label
    Friend WithEvents OrderByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents OrderDate As System.Windows.Forms.Label
    Friend WithEvents OrderNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
