'Alexis Villagran
'RCET 2265
'Spring 2025
'Diner Menu
'https://github.com/alxsvxn/DinerMenu.git

Option Strict On
Option Explicit On
Public Class DinerMenuForm
    Private Sub DinerNameLabel_Click(sender As Object, e As EventArgs) Handles DinerNameLabel.Click
        Me.Text = "Tuki's Pizzaria And Diner"
        DisplaylLabel.Text = "Select a menu option to view todays special!"
    End Sub
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaylLabel.Text =
            "Le Soup Of The Day" & vbCrLf &
            "PIZZA SOUP" & vbCrLf & vbCrLf &
            "Our signature Pizza Soup blends savory tomato broth," & vbCrLf &
            "melted mozzarella, pepperoni bites, and crispy croutons," & vbCrLf &
            "for a tasty, one-of-a-kind meal. It's the pizza you can" & vbCrLf &
            "sip—perfect for a cozy, unique dining experience!"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaylLabel.Text =
           "Le Salad Of The Day" & vbCrLf &
            "Salad A La Pizza" & vbCrLf & vbCrLf &
            "This refreshing twist combines all your favorite pizza" & vbCrLf &
            "toppings—pepperoni, mozzarella, olives, and fresh" & vbCrLf &
            "veggies—tossed over crisp greens with a zesty tomato-basil dressing." & vbCrLf &
            "It’s the perfect way to enjoy pizza in a lighter, refreshing form!"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaylLabel.Text =
             "Le Catch Of The Day" & vbCrLf &
            "Crispy Pizza Fish" & vbCrLf & vbCrLf &
            "Our Crispy Herb-Crusted Fish features a tender fillet coated" & vbCrLf &
            "in a golden, crunchy herb crust, paired with a zesty lemon butter" & vbCrLf &
            "sauce for a burst of flavor. Served alongside roasted vegetables" & vbCrLf &
            "and creamy garlic mashed potatoes, this dish offers the perfect" & vbCrLf &
            "seafood experience that'll keep you coming back for more!"

    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
