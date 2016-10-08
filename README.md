# Xamarin-MSWeatherDemo

### Opis projektu
Pierwszy projekt w środowisku Xamarin. Jest to projekt napisany w pełni z poradnika ze strony: https://msdn.microsoft.com/en-us/library/mt679501.aspx?f=255&amp;MSPPError=-2147217396

Projekt został przepisany w celu zapoznania się ze środowiskiem.

### Pliki i dane potrzebne do kompilacji
Należy założyć konto na stronie http://openweathermap.org/appid oraz pobrać klucz Api, następnie utworzyć klasę ApiKeys w katalogu [MSWeatherDemo/MSWeatherDemo] [ApiKeys] oraz umieścić poniższą treść:
```
namespace MSWeatherDemo
{
    class ApiKeys
    {
        public static string apiKey = "TWÓJ KLUCZ API";
    }
}
```

[ApiKeys]: <https://github.com/pkozak2/Xamarin-MSWeatherDemo/tree/master/MSWeatherDemo/MSWeatherDemo>