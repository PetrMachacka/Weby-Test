# Rekapitulační cvičení na první témata z tvorby aplikací v prostředí ASP:NET Razor Pages

V tomto cvičení je cílem zopakovat probraná témata z ASP.NET a ověřit si, že jsme vše důležité probrali. Cvičení se skládá z jednotlivých úloh, mezi kterými je jen omezená vazba.

Úlohy:

1. Vytvořte novou stránku Survey, pomocí asp-helperů na ní vytvořte odkaz ze stránky Index.
2. Na stránku Survey vytvořte odkaz z horní lišty v hlavní šabloně aplikace (_Layout)
3. Na stránce Survey vytvořte formulář obsahující:
    1. Povinné textové pole pro jméno
    1. Povinně textové pole pro příjmení
    1. Povinné pole pro zadání emailu
    1. Pole, jde bude možné potvrdit pomocí checkboxu, že je respondent starší než 15 let
    1. Výběr bydliště, kde se vybírá ze 3 obcí
    1. Výběr pohlaví, kde se vybírá z několika možností
    1. Nepovinný text, kde si může uživatel určit své oslovení
    1. Dlouhý povinný text, kde se může uživatel řádně rozepsat o svém životě. Minimální délka textu bude 30 znaků.
    1. Tlačítko odesílající formulář metodou POST.
4. Pro předání dat bindováním mezi formulářem a jeho vyhodnocením prostřednictvím příslušného handleru definujte vlastní InputModel
    1. Definujte v něm validační pravidla
    1. Definujte v něm i popisky prvků (tj. labely)
5. Po odeslání validního formuláře je respondent přesměrován na stránku Welcome, kde je zobrazen název jím vybrané obce. Název je předán pomocí routovaného parametru (za ?)
    1. Upravte tuto stránku tak, aby fungovala přes "pretty" odkaz
    1. Z této stránky je možné přejít na titulní stránku nebo na stránku Survey přes odkaz vypadající jako tlačítko
