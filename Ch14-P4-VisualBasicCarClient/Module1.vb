Imports Ch14_P2_CarLibrary

Module Module1

    Public Class PerformanceCar
        Inherits SportsCar
        Public Overrides Sub TurboBoost()
            Console.WriteLine(" Zero to 60 in a cool 4.8 seconds... ")
        End Sub

    End Class

    Sub Main()


        Console.WriteLine("***** VB CarLibrary Client App *****")
        '' Local variables are declared using the Dim keyword. amazing comment using " ' "
        'Dim myMiniVan As New MiniVan()
        'myMiniVan.TurboBoost()
        'Dim mySportsCar As New SportsCar()
        'mySportsCar.TurboBoost()
        'Console.ReadLine()

        Dim dreamCar As New PerformanceCar()

        'dreamCar.
        dreamCar.PetName = "Hank"
        dreamCar.TurboBoost()

        Console.ReadLine()

    End Sub

End Module
