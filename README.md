# TuotekuvastoApp

HomeController käsittelee HTTP-pyynnöt, Lukee products JSON-tiedoston, deserialisoi sen sisällön ja siirtää product objectit näkymälle(product.cshtml). 

Product.cshtml käyttää Product.cs luokkaa mallina, joka määrittelee tuotteen ominaisuudet.

site.js manipuloi Product.cshtml sisältöä JavaScriptin avulla, parantaen tuotetietojen esitystä, kuten hintojen muotoilua ja nimien pääkirjaimien korostamista.

products.json sisältää tuotteiden tiedot JSON-muodossa.
