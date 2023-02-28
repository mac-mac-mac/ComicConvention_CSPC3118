<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblComicCon = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.radAuto = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radSuper = New System.Windows.Forms.RadioButton()
        Me.lblRegistrationCost = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComic
        '
        Me.picComic.Image = Global.ComicConvention.My.Resources.Resources.comic
        Me.picComic.Location = New System.Drawing.Point(0, 0)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(835, 250)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 0
        Me.picComic.TabStop = False
        '
        'lblComicCon
        '
        Me.lblComicCon.AutoSize = True
        Me.lblComicCon.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComicCon.ForeColor = System.Drawing.Color.Coral
        Me.lblComicCon.Location = New System.Drawing.Point(176, 253)
        Me.lblComicCon.Name = "lblComicCon"
        Me.lblComicCon.Size = New System.Drawing.Size(484, 45)
        Me.lblComicCon.TabIndex = 1
        Me.lblComicCon.Text = "Comic Convention Registration"
        Me.lblComicCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Coral
        Me.lblGroupSize.Location = New System.Drawing.Point(243, 347)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(171, 31)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group Size:"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.Location = New System.Drawing.Point(461, 344)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(101, 38)
        Me.txtGroupSize.TabIndex = 3
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.SkyBlue
        Me.grpBadgeType.Controls.Add(Me.radConvention)
        Me.grpBadgeType.Controls.Add(Me.radAuto)
        Me.grpBadgeType.Controls.Add(Me.radSuper)
        Me.grpBadgeType.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.Coral
        Me.grpBadgeType.Location = New System.Drawing.Point(184, 420)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(476, 173)
        Me.grpBadgeType.TabIndex = 4
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'radAuto
        '
        Me.radAuto.AutoSize = True
        Me.radAuto.Location = New System.Drawing.Point(65, 85)
        Me.radAuto.Name = "radAuto"
        Me.radAuto.Size = New System.Drawing.Size(302, 28)
        Me.radAuto.TabIndex = 1
        Me.radAuto.TabStop = True
        Me.radAuto.Text = "Convention + Autographs"
        Me.radAuto.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(65, 134)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(152, 28)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radSuper
        '
        Me.radSuper.AutoSize = True
        Me.radSuper.Location = New System.Drawing.Point(65, 41)
        Me.radSuper.Name = "radSuper"
        Me.radSuper.Size = New System.Drawing.Size(411, 28)
        Me.radSuper.TabIndex = 0
        Me.radSuper.TabStop = True
        Me.radSuper.Text = "Convention + Superhero Experience"
        Me.radSuper.UseVisualStyleBackColor = True
        '
        'lblRegistrationCost
        '
        Me.lblRegistrationCost.AutoSize = True
        Me.lblRegistrationCost.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationCost.ForeColor = System.Drawing.Color.Coral
        Me.lblRegistrationCost.Location = New System.Drawing.Point(178, 637)
        Me.lblRegistrationCost.Name = "lblRegistrationCost"
        Me.lblRegistrationCost.Size = New System.Drawing.Size(263, 31)
        Me.lblRegistrationCost.TabIndex = 5
        Me.lblRegistrationCost.Text = "Registration Cost:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Coral
        Me.lblCost.Location = New System.Drawing.Point(526, 637)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(134, 31)
        Me.lblCost.TabIndex = 6
        Me.lblCost.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(184, 716)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(230, 52)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(461, 716)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(199, 52)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 811)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblRegistrationCost)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblComicCon)
        Me.Controls.Add(Me.picComic)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblComicCon As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAuto As RadioButton
    Friend WithEvents radSuper As RadioButton
    Friend WithEvents lblRegistrationCost As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
