Public Class MenuRepository

    Public Function ObtenerMenuAlimentos() As List(Of ElementoMenu)
        Return New List(Of ElementoMenu) From {
            New ElementoMenu() With {.Nombre = "Dona de chocolate", .Precio = 15},
            New ElementoMenu() With {.Nombre = "Dona de vainilla", .Precio = 15},
            New ElementoMenu() With {.Nombre = "Panini", .Precio = 25},
            New ElementoMenu() With {.Nombre = "Brownie", .Precio = 30},
            New ElementoMenu() With {.Nombre = "Galletas de chocolate", .Precio = 10}
        }

    End Function

    Public Function ObtenerMenuBebidas() As List(Of ElementoMenu)
        Return New List(Of ElementoMenu) From {
            New ElementoMenu() With {.Nombre = "Refresco coca cola", .Precio = 15},
            New ElementoMenu() With {.Nombre = "Refresco Pepsi", .Precio = 15},
            New ElementoMenu() With {.Nombre = "Café americano", .Precio = 15},
            New ElementoMenu() With {.Nombre = "Café expresso", .Precio = 15},
            New ElementoMenu() With {.Nombre = "Agua", .Precio = 20}
        }

    End Function

End Class
