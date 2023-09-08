# Arbeitsauftrag_1300
Numberguesser

# Projekt-Dokumentation

Julian Hitz

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt habe ich ein NumberGuesser-Programm entwickelt.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |Muss                 |Funktional| Als ein User möchte ich, dass der Computer eine Geheimzahl zwischen 1 und 100 speichert, damit man diese später erraten kann |
| 2  |Muss                 |Funktional| Als ein User möchte ich, dass ich Zahlen raten kann, damit man spielen/gewinnen kann  |
| 3  |Muss                 |Funktional| Als ein User möchte ich, dass ich einen Hinweis für die geratene Zahl erhalte, damit ich die Zahl besser eraten kann |
| 3.1  |Muss                 |Funktional| Als ein User möchte ich, dass wenn die Geheimzahl tiefer ist als die geschätzte Zahl, einen Hinweis dass die Zahl tiefer ist als die geschätzte, damit ich für die nächste Eingabe eine bessere Chance fürs erraten habe  |
| 3.2  |Muss                 |Funktional| Als ein User möchte ich, dass wenn die Geheimzahl höher ist als die geschätzte Zahl, einen Hinweis dass die Zahl höher ist als die geschätzte, damit ich für die nächste Eingabe eine bessere Chance fürs erraten habe.                                |
| 3.3  |Muss                 |Funktional| Als ein User möchte ich, wenn ich die Zahl erraten habe einen Hinweis, dass ich die Zahl errraten habe, damit ich weiss, dass ich es geschaft habe. |
| 4  |Muss               |Funktional     | Als User möchte ich, dass wann die Zahl erraten wurde, dass ausgegeben wird wie viele Versuche benötigt wurden, damit ich sehe wie viele Versuche ich gebraucht habe. |
| 5  | Muss                |Funktional      | Als User möchte ich, dass Fehleingaben abgefangen werden, damit das spiel besser läuft  |
| 6  | kann                |Funktional      | Als User möchte ich, dass es wenn die Zahl erraten wurde, man gefragt will ob man nochmals spielen will, damit man das Spiel nicht immer wieder neu starten muss um zu spielen|
| 7  | kann                |Funktional      | Als User möchte ich, dass es eine Highscoreliste gibt, damit man sehen kann was der Beste Versuch war|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Spiel gestartet | Zahl | Feedback zur generierten Zahl |
| 2.1  |  Spiel gestartet | Zahl | Feedback zur generierten Zahl |
| 3.1  |  Zahl wurde generiert | -    | Info zur eingegeben Zahl      |
| 3.2  |  Zahl wurde generiert | Zahl        |Die Geheimzahl ist kleiner als deine Eingabe |
| 3.3  |  Zahl wurde generiert | Zahl        |Die Geheimzahl ist größer als deine Eingabe  |
| 3.4  |  Zahl wurde generiert | Zahl        |Glückwunsch! Du hast die Geheimzahl (Zahl) in (Zahl) Versuchen erraten|
| 4.1  |  Zahl erraten         |         |                   |
| 5.1  |              |         |                   |
| 6.1  |              |         |                   |
| 7.1  |              |         |                   |


### 1.4 Diagramme

<img width="451" alt="Numberguesser pap" src="https://github.com/Mando-06/Arbeitsauftrag_1300/assets/110893098/682bbde0-f40b-4bc9-b317-0ab1d2bfd9d6">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 01.09.2023 |Julian Hitz | Geheimzehl generieren | 15'  |
| 2.A  | 01.09.2023 |Julian Hitz | Zahlen raten | 20'           |
| 3.A  | 01.09.2023 |Julian Hitz | Hinweis ob Zahl höher/tiefer oder eraten | 40'|
| 4.A  | 01.09.2023 |Julian Hitz | Ausgabe Anzahl Versuche|30'  |
| 5.A  | 01.09.2023 |Julian Hitz | Fehleingaben abfangen  |30'  |
| 6.A  | 01.09.2023 |Julian Hitz | nochmals spielen       |15'  |
| 7.A  | 01.09.2023 |Julian Hitz | Highscoreliste         |45'  |

Total: 195' 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 25.08.2023       | Julian Hitz           | 15'              | 20'                  |
| 2.A  | 25.08.2023       | Julian Hitz           | 20'              | 20'                  |
| 3.A  | 25.08.2023       | Julian Hitz           | 40'              | 30'                  |
| 4.A  | 25.08.2023       | Julian Hitz           | 30'              | 40'                  |
| 5.A  | 25.08.2023       | Julian Hitz           | 30'              | 30'                  |
| 6.A  | 01.09.2023       | Julian Hitz           | 15'              | 20'                  |
| 7.A  | 01.09.2023       | Julian Hitz           | 45'              | 60'                  |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
