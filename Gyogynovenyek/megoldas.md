# Megoldás

# Osztály létrehozása
- 5 tulajdonság
  - public get, private set
- 1 konstruktor
  - 1 paraméter, ami string
  - például: "Acsalapu;levél;6;8" 
  - ;-vel vannak elválasztva
  - 4 darab adat --> 5 tulajdonság?
  - átadott, fájlból beolvasott sor:
    - ; mentén tagoljuk
    - [0] --> Nev
    - [1] --> Resz
    - [2] --> Kezd
    - [3] --> Vég
    - Idotartam --> számolás
- 5-dik tulajdonság: időtartam
  - konstruktorban számoljuk
  - számolása: Vég-kezdet ha: a vég nagyobb mint a kezdet
  - Vég > kezdet --> Vég - Kezdet + 1
  - Egyébként --> 12 - vég + kezdet + 1 
## Adatok beolvasása
    - listában tároljuk
    - Olvassuk be
    - System IO
    - StreamReader
    - while ciklus amíg tart a fájl
    - Cikluson belül listához hozzáadunk egy új objektum példányt (beolvasott sor a paraméter)
## 1.Feladat
  - lista.Count
## 2. Feladat
  - Milyen gyűjthető reszei vannak?
  - Hány darab van ezekből?
  - Adatszerkezet: Dictionary<string,int>
  - 1.Milyen gyűjthető részek:
    - foreach "lsita"
    - Ha a rész nem kulcs adja hozzá 0-val
  - 2. Hány darab van?
    - foreach  lista
    - ha resz == key --> value++
      
## 3. Feladat
  - Maximum keresés --> időtartam alapján
    - maximum báltozó = 0
    - foreach lsita
    - ha max<idotarttam --> max = idotartam
  - Növények amelyeket a legtöbb ideig szedtek
    - foreach lista
    - kiírni az időtartam = max
## 4. Feladat
  - Átlag számítás
    - szum változó = 0
    - átlag változó
    - foreach lista
    - szum += Idotartam
    - atlag = szum/count
