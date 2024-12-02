Imports Windows.Win32.UI
Imports System.Windows.Forms
Imports Label = System.Windows.Forms.Label
Imports Button = System.Windows.Forms.Button

Public Class Checkout
    Inherits Form

    'This 
    Private lblByeText As Label
    Private Label3 As Label
    Private lblTotalCost As Label
    Private lblTotalPrice As Label
    Private lblLitre As Label
    Private lblTotalLitres As Label
    Private btnPay As Button
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        lblByeText = New Label()
        Label3 = New Label()
        lblTotalCost = New Label()
        lblTotalPrice = New Label()
        lblLitre = New Label()
        lblTotalLitres = New Label()
        btnPay = New Button()

        ' lblTotalLitres
        lblTotalLitres.AutoSize = True
        lblTotalLitres.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTotalLitres.Location = New Point(209, 59)
        lblTotalLitres.Name = "lblTotalLitres"
        lblTotalLitres.Size = New Size(71, 30)
        lblTotalLitres.Text = Main.totalLitres.ToString("F2")

        ' lblLitre
        lblLitre.AutoSize = True
        lblLitre.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblLitre.Location = New Point(77, 59)
        lblLitre.Name = "lblLitre"
        lblLitre.Size = New Size(126, 30)
        lblLitre.Text = "Total Litres:"

        ' lblTotalCost
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        lblTotalCost.Location = New Point(81, 112)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(122, 30)
        lblTotalCost.Text = "Total Sales:"

        ' lblTotalPrice
        lblTotalPrice.AutoSize = True
        lblTotalPrice.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblTotalPrice.Location = New Point(209, 112)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(71, 30)
        lblTotalPrice.Text = "00.00"

        ' btnPay
        btnPay.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        btnPay.Location = New Point(84, 252)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(196, 41)
        btnPay.Text = "Pay now"
        AddHandler btnPay.Click, AddressOf btnPay_Click
        Controls.Add(btnPay)

        ' Label3
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(127, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 30)
        Label3.Text = "Checkout:"

        ' lblByeText
        lblByeText.FlatStyle = FlatStyle.Flat
        lblByeText.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic)
        lblByeText.Location = New Point(3, 155)
        lblByeText.Name = "lblByeText"
        lblByeText.Size = New Size(350, 94)
        lblByeText.TextAlign = ContentAlignment.TopCenter
        lblByeText.Text = "Thank you for using BMC Fuel Pump Application. Please, press pay now button to pay for your fuel. Have a good day!"

        ' Checkout Form Settings
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(355, 305)
        ControlBox = False
        Controls.Add(lblByeText)
        Controls.Add(Label3)
        Controls.Add(lblTotalCost)
        Controls.Add(lblTotalPrice)
        Controls.Add(lblLitre)
        Controls.Add(lblTotalLitres)
        Name = "Checkout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Checkout"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Shared method for handling the Pay button click
    Shared Sub btnPay_Click(sender As Object, e As EventArgs)
        Dim myForm As New mainForm()
        'MessageBox.Show("Thanks for your payment!")
        Form.ActiveForm.Hide()
        Hidee.cleaning(Form.ActiveForm)
        mainForm.mainShow(myForm)
    End Sub

    Public Shared Sub payment()
        ' Call the instance method (New) to initialize the form
        Dim checkoutForm As New Checkout()
        checkoutForm.Show()
    End Sub
End Class
