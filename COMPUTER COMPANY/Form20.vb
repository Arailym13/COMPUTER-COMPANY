Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data As New Dictionary(Of String, List(Of Decimal)) From {
           {"Germany", New List(Of Decimal) From {199.99D, 299.99D}},
           {"Japan", New List(Of Decimal) From {49.99D, 79.99D}},
           {"South Korea", New List(Of Decimal) From {89.99D, 129.99D}},
           {"China", New List(Of Decimal) From {89.99D, 159.99D}},
           {"UK", New List(Of Decimal) From {79.99D, 129.99D}},
           {"USA", New List(Of Decimal) From {599.99D, 399.99D, 299.99D, 119.99D, 499.99D}}
       }

        ' Очистка данных
        Chart1.Series(0).Points.Clear()
        Chart1.Legends.Clear()

        ' Установка цветов для каждой страны
        Dim countryColors As New Dictionary(Of String, Color) From {
            {"Germany", Color.Red},
            {"Japan", Color.Blue},
            {"South Korea", Color.Green},
            {"China", Color.Orange},
            {"UK", Color.Purple},
            {"USA", Color.Cyan}
        }

        ' Добавление легенды

        Dim legend As New Legend("Countries")
        legend.Docking = Docking.Right
        Chart1.Legends.Clear() ' Убедимся, что удалены старые легенды
        Chart1.Legends.Add(legend)

        Chart1.Series(0).Legend = "Countries" ' Указываем имя существующей легенды


        ' Добавление данных в диаграмму
        For Each country In data
            Dim avgPrice = country.Value.Average()
            Dim point = Chart1.Series(0).Points.AddXY(country.Key, avgPrice)
            Chart1.Series(0).Points(point).Color = countryColors(country.Key)
        Next

        ' Настройка оси X
        Chart1.ChartAreas(0).AxisX.Title = "Страны"
        Chart1.ChartAreas(0).AxisX.Interval = 1

        ' Настройка оси Y
        Chart1.ChartAreas(0).AxisY.Title = "Средняя цена (USD)"
        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "${0}"
    End Sub
End Class