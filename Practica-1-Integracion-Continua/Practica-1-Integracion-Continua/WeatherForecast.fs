namespace Practica_1_Integracion_Continua

open System

type WeatherForecast =
    { Date: DateTime
      TemperatureC: int
      Summary: string }

    member this.TemperatureF =
        32.0 + (float this.TemperatureC / 0.5556)
