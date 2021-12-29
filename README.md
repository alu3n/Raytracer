# RayTracer
---
## Zakladni informace
* **Autor:** Vojtech Proschl
* **Predmet:** NPGR031
* **Termin:** Letni semestr 2021

**Hlavni zdroje pouzity pro reseni problemu**
* [Fundamentals of Computer Graphics](https://www.amazon.com/Fundamentals-Computer-Graphics-Steve-Marschner/dp/1482229390)
* [Linearni Algebra (nejen) pro Informatiky](https://matfyzpress.cz/cz/e-shop/vsechny-tituly/linearni-algebra-nejen-pro-informatiky-9788073783921)

### Strucny popis programu
Ucel tohoto programu je zprostredkovat moznost vykresleni 3D sceny sestavene z krychli a kouli. Uzivatel muze upravovat ruzne prametry sceny jako napriklad pozici kamery, jeji uhel, nebo treba intenzitu a bravu svetla. Program implementuje algoritmus sledovani paprsku (RayTracing).

---
## Uzivatelska dokumentace
### Nastaveni sceny
**Camera**
Position X,Y,Z - Pozice kamery v prostoru
Rotation X,Y,Z - Rotace kamery kolem odpovidajicich os
Lens Angle - Uhel zorneho pole kamery
Projection Distance - Vzdalenost projekcni roviny od stredu kamery

**Light**
Ve scene jsou 3 svetla, nastaveni kazdeho je identicke.
Position X,Y,Z - Pozice svetla v prostoru
Specular R,G,B - Barva odlesku svetla
Intensity - Intensita svetla

**Render Settings**
Resolution X,Y - Rozliseni vykresleneho obrazku
Phong Exponent - Exponent mnozstvi odrazeneho svetla, vice informaci o Blinn-Phong modelu [zde](https://cs.wikipedia.org/wiki/Phong%C5%AFv_osv%C4%9Btlovac%C3%AD_model)
Background R,G,B - Barva pozadi (mista, na kterych se nevyskytuje geometrie)
Reflection Intensity - Odraz svetla je vynasoben timto cislem, 1 = 100% odrazeneho svetla, 0 = 0% odrazeneho svetla.
Ray Cound - Pocet odrazu paprsku pro vypocet odlesku (1 je bez rekurzivniho volani), tento efekt zpomaluje rychlost vypoctu.
Sample Size - Velikost mrizky pixelu, ze ktere se prumeruje barva vysledneho pixelu, 1 = 1x1 mrizka, 2 = 2x2 mrizka... Vyssi cisla sample size pomahaji s aliasingem a sumem ve scene. Tento efekt vyrazne zpomaluje rychlost vypoctu.

**Slider**
Slouzi k zoomovani renderu.

**Export**
Otevre okno s moznosti ulozeni vysledku renderu. Vysledny render je ukladan v BMP formatu.

**Load Primitives**
Slouzi k importovani sceny, scena se uklada do JSON formatu a ma specificky format.
Existuji dva druhy podporovanee geometrie
* Cube - Krychle
* Sphere - Koule
Krychle se simuluje vyrazne pomaleji, vzhledem k tomu, ze je definovana pomoci mnoziny trojuhelniku v prostoru, tento vypocet je priblizne 16x pomalejsi nez v pripade koule.

**Format vstupnich dat:**
Format dat musi mit presne tuto strukturu, s tim, ze prvky v seznamu jsou pouze koule a krychle v libovolnem poradi, je mozno jich pridat libovolne mnozstvi. Soubor musi byt ve formatu JSON.
```
{
  "Geometry":[
    {
      "Type": "Sphere",
      "PosX": 2,
      "PosY": 2,
      "PosZ": 2,
      "Red": 255,
      "Green": 0,
      "Blue": 0,
      "Radius": 1
    },
    {
      "Type": "Cube",
      "PosX": -2,
      "PosY": -2,
      "PosZ": -2,
      "Red": 0,
      "Green": 255,
      "Blue": 255,
      "SizeX": 1,
      "SizeY": 1,
      "SizeZ": 1
    }
  ]
}

```
Koule:
* Type: Sphere - jiny typ neni mozno uvadet, pouze Sphere presne v tomto zneni
* PosX - pozice na souradnici X, cislo ve formatu double
* PosY - pozice na souradnici Y, cislo ve formatu double
* PosZ - pozice na souradnici Z, cislo ve formatu double
* Red - Hodnota RED v RGB modelu, cislo od 0 do 255
* Green - Hodnota GREEN v RGB modelu, cislo od 0 do 255
* Blue - Hodnota BLUE v RGB modelu, cislo od 0 do 255
* Radius - Polomer koule

Krychle:
* Type: Cube - jiny typ neni mozno uvadet, pouze Cube presne v tomto zneni
* PosX - pozice na souradnici X, cislo ve formatu double
* PosY - pozice na souradnici Y, cislo ve formatu double
* PosZ - pozice na souradnici Z, cislo ve formatu double
* Red - Hodnota RED v RGB modelu, cislo od 0 do 255
* Green - Hodnota GREEN v RGB modelu, cislo od 0 do 255
* Blue - Hodnota BLUE v RGB modelu, cislo od 0 do 255
* SizeX - velikost na souradnici X, cislo ve formatu double
* SizeY - velikost na souradnici Y, cislo ve formatu double
* SizeZ - velikost na souradnici Z, cislo ve formatu double

---
## Programatorska dokumentace
### Struktura programu
**RayTracer**
RayTracer je hlavni trida programu, ktera spojuje uzivatelske rozhrani se scenou a jeji simulaci pomoci RayTracing algoritmu, ktery je ve tride simulace.

**Scena**
Namespace **scene** zastituje veskere prvky, ktere hrajou roli ve vysledne simulaci, v aktualni podobe programu to jsou:
* **Camera** - Kamera popsana atributy, na zaklade nich se generuji projekcni poloprimky
* **Geometry** - Trida, ktera v sobe ma ulozene data geometrie, ktera se pri kroku 2. pouziva jako geometrie, se kterou hledame pruseciku (viz. Algoritmicka cast dokumentace)
* **Light** - Trida, ktera je popsana atributy, na zaklade ni se pri shadingu pocita barva pixelu vysledneho obrazku
* **Scene** - Tato trida slouzi jako container pro prvky simulace, je v ni kamera, ktera je pro kazdou scenu jedna, geometrie, ktera je rovnez pro scenu jedina a list svetel.



**Render**
Render je namespace, ktery v sobe ma tridy, ktere se staraji o cely proces RayTracingu. Vice o tomto procesu je v casti dokumentace o volbe algoritmu.
* RayGeneration - Trida pro generovani projekcnich poloprimek
* SphereIntersection - Trida pro vypocet pruseciku kouli
* TriangleIntersection - Trida pro vypocet pruseciku trojuhelniku
* ImprovedBlinnPhong - Trida pro vykreslovani pixelu podle BlinnPhong modelu
* Simulation - Trida, ktera spojuje vsechny prvky simulace

**Utilities**
Utilities je namespace, ktery v sobe ma ruzne typy reprezentace geometrie, coz je narozdil od objektu v namespacu scene primarne datova reprezentace a je prirazena geometrickemu objektu a ne scene.
Dale tam je trida starajici se o import .json souboru, vice o ni v dalsi casti dokumentace.
Posledni skupina trid jsou tridy z namespace interface, ktere se staraji o kontrolu predavani dat etc.

**Uzivatelske rozhrani**
Uzivatelske rozhrani je vytvoreno pomoci prvku WindowsFroms, komunikace s nim probiha pres tridu ***SceneSettings*** z namespace *Utilities/Interface*.
Pokazde, kdyz uzivatel opusti policko, do ktereho pise, tak jsou informace ve SceneSettings aktualizovany, prochazi kontrolou a nasledne jsou predany odpovidajicim objektum ve tride ***scene***.
Pri psani do policek probiha prubezna kontrola, aby uzivatel nemohl psat veci, ze kterych by vznikaly zbytecne bugy. Tuto kontrolu zprostredkovava trida ***InputHandler***.
Pro oba vyse zminene procesy jsou vytvoreny eventy ve tride Form1.cs.

Aktualni uzivatelske rozhrani podporuje pouze tri svetla, nicmene cely program je napsan tak, ze podporuje svetel libovolny pocet a staci rozsirit uzivatelske rozhrani.

**Vstup a vystup**
Jako vstup pro program slouzi .json data, ktere reprezentuji rozlozeni sceny a uzivatelske nastaveni svetel, kamery etc.
Vystup programu je .BMP soubor s vykreslenym obrazkem.
### Interpretace dat
**Interni**

Scene
Tato trida uchovava prvky, ktere hrajou roli v simulaci, samotna scena ma nejake parametry, ktere jsou pouzivany pri simulaci a jednotlive objekty, ktere jsou ulozene ve scene tzn. geometrie, svetla a kamera, maji vlastni parametry, ktere jsou pouzivany pri simulaci.

Sphere
Koule jakozto primitivni geometricky typ je reprezentovan pomoci parametru, kouli v prostoru definujeme pomoci pozice jejiho stredu, a jejiho polomeru, toto nam staci k jednoznacne definici koule.

Mesh
Tento geometricky typ je komplexnejsi, je vytvoren z pole vertexu, ktere muzou byt ve vzajemne relaci, kdy tri vertexy tvori trojuhelnik. Kazdy trojuhelnik ma prirazeny svuj normal, coz je vektor, ktery je na nej kolmy. Normaly se pouzivaji pri procesu stinovani.

Cube
Krychle je reprezentovana pomoci geometrickeho typu mesh, dokonce konstruktor tridy mesh slouzi primo pro vytvoreni krychle. Krychle se sklada ze 4 vertexu, 12 trianglu a knim prislusicich normalu.
Krychle ma 6 stran, kazdou rozdelime na 2 triangly, aby byla jednoznacne, oboum trianglum priradime normal strany, ze ktere vznikly.

**Vstupni**
Jako vstupni data slouzi jiz zminene uzivatelske rozhrani a hlavne .json soubor, ktery reprezentuje geometricke data.
V namespace *Utilities/InputOutput* je trida, ktera slouzi jako .json parser

Parser prochazi pres .json soubor pres hlavni pole, ve kterem jsou ulozeny jednotlive slovniky, v kazdem slovniku parser sleduje hodnoty, na zaklade kterych vytvari geometrii.
* Type - Rozhodne zda se jedna o krychli nebo kouli
* Red,Green,Blue - Jednotlive barvy, hodnota by mela byt v rozsahu 0-255 (byte)
* PosX,PosY,PosZ - Pozice geometrie v prostoru
* Radius - Pouze pro koule, jedna se o polomer koule
* SizeX,SizeY,SizeZ - Pouze pro krychle, jedna se o rozmery krychle v osach X,Y,Z

**Vystupni**
Vystup programu je obrazek ve formatu .BMP, pri renderu se obrazek ulozi do tridy RayTracer, odkud je pri vyvolani eventu stisknuti export tlacitka ulozen do pocitace uzivatele.


### Volby algoritmu
**RayTracing**
Sklada se ze tri zakladnich kroku
* Computing view rays (Vytvareni poloprimek)

* Ray-Geometry Intersection (Vypocet protnuti poloprimek a geometrie)

* Shading ("Stinovani" scene)

Kazdy z techto kroku se pocita zvlast pro kazdy pixel.
Generovani projekcnich poloprimek neni zavisla na ostatnich krocich, stejne tak vypocet pruseciku poloprimek a geometrie.
Proces stinovani je zavisly na vypoctu pruseciku primek a geometrie, protoze pouziva rekurzivni volani na vypocet odlesku.

Casove nejnakladnejsi proces je u RayTracingu krok 2, ten zabere pres 90% casu, je tedy nutne mu venovat zvysenou pozornost. V tomto programu jsou pro tento krok pouzity 2 metody, nejsou ovsem idealni a je mozne je v budoucnu vylepsit, viz. posledni cast dokumentace.

**Projekcni rovina**
Projekcni rovina je rovina, podle ktere budeme generovat poloprimky, scena ma parametr, ktery urcuje jeji vzdalenost od pozice kamery. Jeji velikost je vypocitana na zaklade uhlu kamery a poctu pixelu v nastaveni renderu.

**Computing view rays**
Objekt kamery ma atribut rotace, kde je hodnota pro kazdou osu zvlast. Kamera ma k sobe prirazenou ortonormalni bazi, ta se pri procesu generovani paprsku nejprve zrotuje o pozadovany uhel postupne v kazde ose, cimz zustane baze stale ortonormalni. Projekcni rovina se rozdeli na pixely, mista, kde budeme generovat paprsky jsou jednotlive pixely na projekcni rovine.  Technicke detaily v [teto](https://www.amazon.com/Fundamentals-Computer-Graphics-Steve-Marschner/dp/1482229390) knize na strane 73.

**Ray-Geometry intersection**
V programu jsou pouzity dva ruzne algoritmy na vypocet pruseciku poloprimky s geometrii. Prvni slouzi ***pouze pro vypocet pruseciku koule a poloprimky***, ten pouziva analyticke vyjadreni primky a koule v prostoru a matematickou numerickou knihovnu. Druhy algoritmus ***pro vypocet pruseciku trojuhelniku a poloprimky***, jelikoz se da v grafice vyjadrit jakakoli geometrie jako mnozina trojuhelniku, tak je program teoreticky schopny vykreslit jakoukoli geometrii, nicmene vypocet pruseciku trojuhelniku je pomaly. Pocita se pomoci pruseciku poloprimky a parametricke rovinny a overeni, zda je prusecik v trojuhelniku se provadi pomoci barycentrickych souradnic. Technicke detaily v [teto](https://www.amazon.com/Fundamentals-Computer-Graphics-Steve-Marschner/dp/1482229390) knize na strane 76.

**Shading**
Posledni cast RayTracingu, v teto casti se vykresluje scena a pocita se barva pixelu na zaklade polohy scenickych objektu a nastaveni jejich parametru, vice o tomto procesu naleznete v [teto](https://www.amazon.com/Fundamentals-Computer-Graphics-Steve-Marschner/dp/1482229390) knize na strane 81. Nektere informace o shading modelech jsou rovnez popsany v nasledujici casti dokumentace.

**Pixel Sampling**
Pixel sampling je v programu metoda, ktera je pouzita jako protivaha na [aliasing](https://cs.wikipedia.org/wiki/Aliasing), v pripade ze na obrazku je aliasing, tak pusobi "rozkostickovane". Reseni tohoto problemu je pixel sampling. Algoritmus RayTracingu se pocita pro kazdy pixel, zavedeme do nej parametr **SampleSize**, pokazde, kdyz je vypocitavan pixel, tak ho rozdelime na SampleSize*SampleSize podpixelu a misto pocitani jednoho pixelu vypocitame vsechny podpixely a jejich vyslednou hodnotu zprumerujem a vratime ji jako vysledek. Pixel sampling je pomerne nakladna technika, ale funguje velice dobre.

### Shading modely
**Obecny shading model**
Shading model je algoritmus, ktery si vezme vysledky kroku 1 a 2 a na zaklade jejich vysledku vykresli pozadovany pixel.
Ve scene je typicky vice svetel, takze je k tomu prizpusobeny model, a mame mnozinu svetel $\{L_1,...,L_n\}$, kde svetla maji (ne nutne) ruzne parametry. Nektere technicke detaily jsou take v [teto](https://www.amazon.com/Fundamentals-Computer-Graphics-Steve-Marschner/dp/1482229390)  knize, algoritmus je ale pro ucel tohoto programu mirne upraveny.

**Parametry pro shading:**
* Misto protnuti geometrie $p\in\mathbb{R}^3$
* Normal geometrie v miste protnuti $n\in\mathbb{R}^3,||n||_2=1$, je kolmy na povrch v pruseciku.
* Pozice kamery v prostoru $c\in\mathbb{R}^3$
* Vzdalenost protnuti od kamery $d\in\mathbb{R}$
* Barva protnute geometrie $C_G\in[255]^3$
* Projekcni vektor $v\in\mathbb{R}^3,||v||_2=1$
* Vektor od pruseciku ke svetlu $l\in\mathbb{R}^3,||l||_2=1$
* Phong exponenet $P\in(0,+\infty)$

**Parametry svetel**
* Pozice svetla $L_p\in\mathbb{R}^3$
* Intenzita svetla $L_I\in\mathbb{R}$
* Specular barva svetla $C_S\in[255]^3$

**Algoritmus stinovani pixelu**
Vychazi z Blinn-Phong modelu
V teto casti se pocita barva pouze jednoho pixelu, nepouziva se pixel sampling a prumerovani hodnot nekolika pixelu, to je popsano v predchozi casti dokumentace.


Tato cast algoritmu se stara o barvu pixelu bez odrazu svetla
* $C:=(0,0,0)^T$
* foreach $L\in\{L_1,...,L_n\}$:
	* $h:=||v+l||^{-1}\cdot(v+l)$
	* $C:=C+L_I\cdot max(0,n^T\cdot l)\cdot C_G+L_I\cdot max(0,n^T\cdot h)\cdot C_S$
* return $(max(C_1,255),max(C_2,255),max(C_3,255))$

V programu je schopen algoritmus vykreslovat odrazy svetla, to lze zaridit pomerne trivialnim vylepsenim. Stinovacimu algoritmus ma navic parametr rekurzivni hloubky, ktery urcuje maximalni pocet odrazu, pokud je tento parametr nenulovy, tak navic po prvni casti algoritmu nastane druha cast

Intensita odrazu $I_R\in[0,1]$

* $r:=v-2(v^T\cdot n)n$
* $parametry:=RayIntersection(r,p)$
* $C:=C+I_R*PixelShade(parametry)$

V tomto algoritmu je vlastne $r$ smer, ze ktereho lidske oko vidi odraz a my timto procesem vypocitame hodnotu pixelu jakoby kamera byla na pozici protnuti a smer byl smer odrazu a nejaky nasobek teto barvy pricteme k vysledne barve.


### Mozne budouci vylepseni
**Prostorove datove struktury**
Vzhledem ke zminovanemu problemu s rychlosti vypoctu pruseciku geometrie a poloprimek je treba nejakym zpusobem optimalizovat. 
Jedno z moznych vylepseni by mohla byt implementace nejake prostorove vyhledavaci datove struktury, napriklad [Octree](https://en.wikipedia.org/wiki/Octree), tohle by mohlo vyrazne urychlit proces a umoznit renderovani komplexnejsi polygonalni geometrie v rozumnem case.

**Vylepseni shading modelu**
V budoucnu by bylo mozne pridat do aktualniho shading modelu nejake dalsi funkce, napriklad pruhlednost, lom svetla etc.

Dalsi napad je pridani [environmentalnich  map](https://en.wikipedia.org/wiki/Reflection_mapping), rendery by pusobily vice realisticky a celkove by to ulehcilo proces osvetlovani.

Mohlo by se hodit pridat vice typu svetel, aktualne je v programu pouze fixed point light.


**Vice primitivnich teles**
Program podporuje aktualne krychle a koule, mohlo by se hodit v budoucnu pridat dalsi telesa, napriklad zbyvajici platonicka telesa, torus etc.
