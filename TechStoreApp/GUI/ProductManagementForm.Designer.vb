﻿' GUI/ProductManagementForm.designer.vb
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductManagementForm
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

    ' Các điều khiển giao diện
    Friend WithEvents dgvProducts As System.Windows.Forms.DataGridView
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblPage As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.ColumnHeadersHeight = 29
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvProducts.Location = New System.Drawing.Point(20, 20)
        Me.dgvProducts.MultiSelect = False
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducts.Size = New System.Drawing.Size(760, 180)
        Me.dgvProducts.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Mô tả"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Giá"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Số lượng"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Danh mục"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(130, 220)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(200, 22)
        Me.txtProductName.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(130, 255)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(200, 22)
        Me.txtDescription.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(130, 290)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 22)
        Me.txtPrice.TabIndex = 3
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(130, 765)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(200, 22)
        Me.txtQuantity.TabIndex = 4
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Location = New System.Drawing.Point(130, 339)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(200, 24)
        Me.cboCategory.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(400, 220)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Thêm"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(400, 255)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Cập nhật"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(400, 290)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Xóa"
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(568, 203)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(40, 30)
        Me.btnPrev.TabIndex = 9
        Me.btnPrev.Text = "←"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(614, 203)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(40, 30)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "→"
        '
        'lblPage
        '
        Me.lblPage.Location = New System.Drawing.Point(660, 210)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(120, 20)
        Me.lblPage.TabIndex = 11
        Me.lblPage.Text = "Trang 1/1"
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(260, 430)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(520, 30)
        Me.lblError.TabIndex = 12
        '
        'lblProductName
        '
        Me.lblProductName.Location = New System.Drawing.Point(20, 220)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(100, 20)
        Me.lblProductName.TabIndex = 13
        Me.lblProductName.Text = "Tên sản phẩm:"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(20, 255)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(100, 20)
        Me.lblDescription.TabIndex = 14
        Me.lblDescription.Text = "Mô tả:"
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(20, 290)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 20)
        Me.lblPrice.TabIndex = 15
        Me.lblPrice.Text = "Giá:"
        '
        'lblQuantity
        '
        Me.lblQuantity.Location = New System.Drawing.Point(20, 765)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 20)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "Số lượng:"
        '
        'lblCategory
        '
        Me.lblCategory.Location = New System.Drawing.Point(20, 343)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(100, 20)
        Me.lblCategory.TabIndex = 17
        Me.lblCategory.Text = "Danh mục:"
        '
        'ProductManagementForm
        '
        Me.ClientSize = New System.Drawing.Size(802, 473)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblPage)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProductManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản Lý Sản Phẩm"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblCategory As Label
End Class