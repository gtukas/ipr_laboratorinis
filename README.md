# ipr_laboratorinis
Integruotų programavimo aplinkų laboratoriniai darbai

# v0.1:
Programos pagrindo kūrimas - studentų sąrašų generavimas, talpinimas atmintyje bei rezultatų skaičiavimo aprašymas.

# v0.2:
Implementuojamas nuskaitymas iš failo.

# v0.3:
Pridedami try-catch blokai, padedantys užtikrinti sklandų programos darbą.

# v0.4
Studentų failų generavimas, pasirenkant skirtingą, vis didėjantį studentų skaičių. Galima pastebėti, jog studentų generavimui skiriamas laikas auga eksponentiškai.

# V0.5:
Šioje versijoje lyginami List ir LinkedList sąrašų formavimo, apdorojimo bei spausdinimo ypatumai.\
Užduoties atlikimo laiką matuoju naudodama System.Diagnostics.Stopwatch klasę.\
Iš failo, su 100000 eilučių, į List sąrašą įrašai įrašomi per 17532 milisekundžių.\
Iš failo, su 100000 eilučių, į Linked List sąrašą įrašai įrašomi per 1350953 milisekundžių.\

List tipo sąrašas surūšiuojamas į du sąrašus per: 27241\
LinkedList tai padaro per: 48992\

Abu sąrašai į failą išvedami gana greitai.\
Galima pastebėti, jog tiek LinkedList, tiek List sąrašai yra identiški.\

# V1.0:
Lyginu du sąrašų rūšiavimo būdus.\
Pirmasis -  Bendro studentai konteinerio ( List , LinkedList and Deque tipų) skaidymas (rūšiavimas) į du naujus to paties tipo konteinerius: "vargšiukų" ir "kietiakų". Šiuo būdu surūšiuoti studentus užtrunka:\
List tipo konteineryje - 19 milisekundžių.\
Linekd List tipo konteineryje - 24 milisekundes.\
Antrasis būdas - Bendro studentų konteinerio ( List , LinkedList and Deque ) skaidymas (rūšiavimas) panaudojant tik vieną naują konteinerį: "vargšiukai". Šio rūšiavimo rezultatus galima matyti v0.5 aprašyme.\

Antruoju būdu rūšiuoti studentus trunka gerokai ilgiau todėl, kad List<>.Remove() funkcija gana sudėtinga ir tai skaudžiai paveikia programos funkcionalumą.\

Darbas su LinkedList tipo konteineriais gerokai sulėtina programos darbą. Tai itin jaučiasi importuojant studentus iš failo - įrašų nuskaitymas į LinkedList sąrašą trunka net 22 minutes!

# Naudojimo instrukcija:
1. Įdiegti programą
2. Paleisti programą
3. Pasirinkti norimą veiksmą\
      Ivesti nauja studenta? Spauskite 1.\
      Ivesti naujus studentu is failo? Spauskite 2.\
      Isvesti rezultatus? Spauskite 3.\
      Generate random list? Spauskite 4.\
      Surusiuoti studentus i vargsiukus ir kietiakus? Spauskite 5.\
      Surasyti vargsiukus ir kietiakus i failus? Spauskite 6.\
      Baigti darba? Spauskite e.
      
4. Naudotis programa :)

# Diegimo instrukcija:
Instaliuoti nieko nereikia!\
Tiesiog parsisiųskite "LaboratorinisDarbas" git repozitoriją, nueikite į "bin/debug" aplanką ir du kartus greit spustelkite ant "ipr_laboratorinis.exe" failo. :)
