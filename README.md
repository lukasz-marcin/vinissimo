# 🍷 WinoNotes - Twój Cyfrowy Notatnik Degustacji Wina

> **STATUS PROJEKTU: W AKTYWNYM DEVELOPMENCIE 🚧**

WinoNotes to webowa aplikacja, która ma za zadanie służyć jako osobisty i rozbudowany notatnik do śledzenia i zapisywania wszystkich twoich degustacji wina. Projekt jest realizowany w ramach nauki przy użyciu technologii .NET i Vue.js.

---

## 🎯 Cele Aplikacji (MVP i Rozwój)

Naszym celem minimalnym (MVP) jest stworzenie pełnego systemu do zarządzania własnymi degustacjami wina.

| Etap | Opis |
| :--- | :--- |
| **MVP (Current)** | Umożliwienie zalogowanym użytkownikom pełnego CRUD (Create, Read, Update, Delete) dla ich osobistych wpisów degustacyjnych. |
| **Faza II (Statystyki i Społeczność)** | Wprowadzenie zaawansowanych statystyk użytkownika (np. najczęściej degustowane szczepy w danym okresie), rankingów i podglądu publicznych profili/degustacji innych użytkowników. |
| **Faza III (Inspiracje Vivino)** | Rozbudowa funkcjonalności o elementy znane z profesjonalnych aplikacji (np. skanowanie etykiet, zaawansowane filtry i wyszukiwanie). |

### 🛠️ Stos Technologiczny

| Element | Technologia | Uwagi |
| :--- | :--- | :--- |
| **Backend** | ASP.NET Core Web API (C#) | Obsługa logiki biznesowej, autoryzacji i API. |
| **Frontend** | Vue.js | Interfejs użytkownika. |
| **Baza Danych** | **SQLite** | Persystencja danych. |

---

## 📝 Aktualny Status

### ✅ Rzeczy Dodane (Funkcjonalności Zrealizowane)

- [ ] Konfiguracja podstawowego szkieletu repozytorium (katalogi: `Backend`, `Frontend`).
- [ ] [Wstaw kolejne ukończone zadanie]

### ➡️ Rzeczy Do Dodania (Backlog MVP)

* **Autoryzacja:** Logowanie i Rejestracja użytkowników.
* **Model Danych:** Stworzenie modelu danych dla Degustacji (Wino, Rocznik, Ocena, Notatki, Data, itp.).
* **API CRUD:** Implementacja endpointów w .NET do zarządzania degustacjami.
* **Interfejs CRUD:** Implementacja komponentów Vue.js:
    * Widok listy własnych degustacji.
    * Widok szczegółów i edycji degustacji.
    * Formularz dodawania nowej degustacji.

---

## 🖼️ Inspiracja Formularza Degustacji (MVP)

> *Różne widoki dla wina białego i czerwonego*



---


## 🧑‍💻 Jak Uruchomić Projekt Lokalnie

1.  **Klonowanie:** Sklonuj repozytorium: `git clone [Adres URL Repo]`
2.  **Backend (.NET API):**
    * Przejdź do katalogu `Backend` (lub nazwy katalogu z API).
    * Uruchom projekt: `dotnet run`
3.  **Frontend (Vue.js):**
    * Przejdź do katalogu `Frontend` (lub nazwy katalogu z aplikacją Vue).
    * Zainstaluj zależności: `npm install`
    * Uruchom serwer developerski: `npm run dev`

### 🤝 Współpraca i Kontakt

* **Właściciele Projektu:** @lukasz1231 oraz @mkosinskki
* **Zarządzanie Pracą:** Korzystamy z **GitHub Projects** oraz **Issues** do śledzenia postępów i przypisywania zadań.
