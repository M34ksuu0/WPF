# Formularz

Opis projektu

Program umożliwia wprowadzanie danych kolejnych osób za pomocą prostego interfejsu graficznego. Każda ankieta zawiera informacje o płci, wieku, ulubionym kolorze oraz zgodzie.

Po zapisaniu formularza dane są dodawane do listy w pamięci programu i zapisywane do pliku tekstowego a.txt. Aplikacja automatycznie aktualizuje statystyki na podstawie zebranych odpowiedzi.

Funkcjonalności

    Wybór płci: mężczyzna, kobieta lub inne.
    
    Wprowadzanie wieku w zakresie od 0 do 120 lat.
    
    Wybór koloru spośród dostępnych opcji:
    
      -czerwony,
      -zielony,
      -niebieski,
      -czarny,
      -biały.
    Zaznaczanie lub odznaczanie zgody.
    
    Walidacja danych przed zapisaniem ankiety.
    
    Zapisywanie odpowiedzi do pliku tekstowego.
    
    Automatyczne obliczanie statystyk:
    
    średni wiek ankietowanych,
    najczęściej wybierany kolor,
    liczba mężczyzn,
    liczba kobiet,
    liczba osób, które wyraziły zgodę.
    Automatyczne czyszczenie formularza po zapisaniu odpowiedzi.

Wygląd aplikacji

Interfejs składa się z trzech głównych obszarów:

    Wybór płci – pozwala określić płeć ankietowanej osoby.
    Formularz ankiety – umożliwia wprowadzenie wieku, wybór koloru i zaznaczenie zgody.
    Wyniki – prezentuje aktualne statystyki zebranych odpowiedzi.

Przed zapisaniem ankiety program sprawdza poprawność wprowadzonych danych.

Wiek musi być liczbą całkowitą z zakresu od 0 do 120.

Kolor musi zostać wybrany z listy.

W przypadku nieprawidłowych danych wyświetlany jest komunikat o błędzie, a zapis zostaje przerwany.

Zapis danych

Każda poprawnie wprowadzona ankieta jest zapisywana w pliku a.txt. Dane jednej osoby zajmują osobny wiersz i zawierają płeć, wiek, kolor oraz informację o zgodzie.

Przykładowy wpis:

Płeć: mężczyzna; Wiek: 25; Kolor: niebieski; Zgoda: tak

Plik jest tworzony lub uzupełniany w katalogu bazowym aplikacji. Kolejne odpowiedzi są dopisywane do istniejącej zawartości.

Sposób użycia

    Wybierz płeć ankietowanej osoby.
    
    Wprowadź jej wiek.
    
    Wybierz ulubiony kolor z listy.
    
    Zaznacz zgodę, jeśli została wyrażona.
    
    Kliknij przycisk zapisz.
    
    Sprawdź zaktualizowane statystyki w sekcji wyników.
    
    Wprowadź dane kolejnej osoby.
