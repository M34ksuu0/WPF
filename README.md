# FC 27 Transfer Market

Prosta aplikacja desktopowa stworzona w technologii C# i WPF. Program symuluje rynek transferowy w grze piłkarskiej FC 27, umożliwiając kupowanie piłkarzy za wirtualny budżet oraz zarządzanie listą zakupionych zawodników.

Funkcje

    Budżet transferowy – początkowy budżet wynosi 500 mln €.

    Rynek transferowy – możliwość wyboru piłkarza z listy dostępnych zawodników.

    Kupowanie piłkarzy – zakup zawodnika po sprawdzeniu jego ceny i dostępnego budżetu.

    Lista zakupionych piłkarzy – wyświetlanie wszystkich kupionych zawodników.

    Licznik piłkarzy – automatyczne aktualizowanie liczby zakupionych zawodników.

    Walidacja budżetu – aplikacja blokuje zakup, jeśli użytkownik nie ma wystarczających środków.

    Usuwanie zawodników z rynku – po zakupie piłkarz znika z listy dostępnych transferów.

    Komunikaty statusu – informacje o wyniku zakupu, błędnej cenie lub braku wystarczających środków.

Dostępni piłkarze

    Piłkarz	            Cena

    Raphinha	    70 mln €
    Jude Bellingham	    160 mln €
    Malen	            55 mln €
    Yamal	            220 mln €
Technologie

C# – logika aplikacji i obsługa zakupów.

WPF – tworzenie interfejsu graficznego.

XAML – definiowanie wyglądu okna i elementów interfejsu.

ObservableCollection – przechowywanie listy kupionych piłkarzy i aktualizowanie widoku.

Visual Studio – środowisko do tworzenia i uruchamiania projektu.

Jak korzystać z aplikacji?

Uruchom program.

Sprawdź aktualny budżet transferowy.

Wybierz piłkarza z listy.

Kliknij przycisk KUP PIŁKARZA.

Sprawdź komunikat o wyniku transakcji.

Po udanym zakupie budżet zostanie pomniejszony o cenę zawodnika.

Kupiony piłkarz pojawi się na liście „MOI PIŁKARZE”, a licznik zawodników zostanie zaktualizowany.

Zakupiony zawodnik zniknie z rynku i nie będzie można kupić go ponownie.

Zakupy są możliwe tylko wtedy, gdy dostępny budżet jest wystarczający. Po zakupieniu wszystkich zawodników aplikacja poinformuje, że rynek jest pusty.

Interfejs użytkownika

Aplikacja posiada ciemny interfejs z granatowym tłem i żółtymi akcentami. Okno podzielone jest na dwie części:

Rynek transferowy – wybór zawodnika, aktualny budżet oraz przycisk zakupu.

Moi piłkarze – lista zakupionych zawodników i ich łączna liczba.
