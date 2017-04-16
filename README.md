# EMG

## Intrukcja instalacji
* Polecam Visual Studio 2017 (Community chyba 4gb zajmuje)
* Klonujecie zawartość repozytorium
* Otwieracie (Polecam poprzez plik solucji - `EMG/EMG.sln`)
* W środku są 3 projekty -> kompilujecie `EMGchart` i `EMGforceSensor`
* W EMGtestGUI: `Project` -> `Add reference/dodaj odwołanie (Przeglądaj)` -> `EMG/EMGforceSensor/bin/Debug/EMGforceSensor.dll` oraz `EMG/EMGchart/bin/Debug/EMGchart.dll` (sorka za zamieszanie, .gitignore wywala foldery [Bb]in więc i *.dll przepadły a zwykłe skopiowanie = trzeba kopiować co każdą zmianę w nich...
* Ustawiacie `EMGtestGUI` jako główny projekt (Otwieracie go potem Project -> Ustaw jako startowy)

## Kompilacja
* `F6` - kompiluje całość (W razie zmian w projektach kontrolek)
* `ctrl + F5` - odpala projekt główny (tutaj EMGtestGUI) / `F5` - debugowanie

## Projekty w rozwiązaniu
### `EMGchart`
Kontrolka odpowiadająca za wyświetlanie danych w postaci wykresu

Zakres +/- na sztywno, trzeba będzie zmienić jak już ogarniemy kartę i sprawdzimy jakie sygnały idą ze wzmacniacza
```c#
// EMG/EMGchart/EMGchart.cs linia 37
  private float currentMaxValue = 4.0f;
```

Działa w dwóch trybach
* Z timerem

Odświeżanie wykresu co określoną ilość czasu (niezależne od napływu punktów)
```c#
// EMG/EMGchart/EMGchart.cs linia 31
  public static TimerMode timerMode { get; set; } = TimerMode.Enabled;
// ... linia 50
  this.redrawTimer.Interval = 50;
  this.redrawTimer.Start();
```

* Bez timera

Przerysowanie wykresu co każdy nowy punkt
```c#
// EMG/EMGchart/EMGchart.cs linia 31
  public static TimerMode timerMode { get; set; } = TimerMode.Disabled;
```

### `EMGforceSensor` 
Kontrolka odpowiadająca za wyświetlanie danych z czujników nacisku

Zmiana koloru/liczby w zależności od zadawanej wartości
* Zakres wartości również na sztywno
```c#
// EMG/EMGforceSensor/EMGforceSensor.cs linia 17    
  public static float MIN_FORCE = 0f;
  public static float MAX_FORCE = 100f;
```

### `EMGtestGUI`
Odpowiada za iterfejs graficzny

Chwilowo prócz zawartych w niej kontrolek (wykresy/wskaźniki siły) nie zawiera nic więcej prócz timera, który zarzuca program randomowymi danymi.

### Uwagi
Jak ktoś nie używał wcześcniej Visuala i CeHaszy
* Niektóre pliki z kodem nie są bezpośrednio dostępne z eksploratora projektu - np. kod kryjący się pod kontrolką/GUI -> Próbując otworzyć z menu np. plik EMGtestGUI otworzy nam się kreator okienka a nie sam kod (Klikamy wtedy prawym na okienko -> pokaż kod ew. F7)
* To co powinno interesować mniej wtajemniczonych to tylko pliki nazwa_projektu.cs (np. EMGchart.cs), żadne .Designer.cs etc :P

Co jest
* [x] Rysowanie wykresów
* [x] Wizualizacja siły (kwadratowe kontrolki, ale można dowolnie zmieniać ich kształt -> byle nie za małe by tekst się mieścił :P)
Czego brak
* [ ] Obsługa karty - to niech poczeka aż ją dostaniemy, pliki *.dll z obsługą karty teoretycznie znalazłem 
* [ ] Obsługa samej procedury pomiarowej - to potem
* [ ] No i zapis do pliku/format - też potem :P
* [ ] Trzeba też uzupełnić funkcjonalność okna o jakieś *menu* (nie z żarciem...)
* [ ] Trzeba skleić ładną ikonkę - najlepiej trzymać się tego:
> Application icons and Control Panel items: The full set includes 16x16, 32x32, 48x48, and 256x256 (code scales between 32 and 256).

### Postanowienia końcowe
[Link do Trello](https://trello.com/b/E8R5i1RF/rekawiczka)



