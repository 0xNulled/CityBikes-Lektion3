# Kontrollfrågor

## Varför skriver du förväntat värde från kravet i stället för från vad koden returnerar?

För vi vill testa att koden returnerar värdet vi förväntar från den. Vi vet vad den borde ge tillbaka men vi försöker testa om den faktiskt ger det värde vi förväntar


## Varför ska ett test bara ha en Act-del, och vad händer med felsökningen om det har två?

Något kan gå fel mellan de två Act-delarna. Den ena kan störa den andra och nu testar du inte längre det isolerade funktionaliteten


## Vad hade hänt om du hade skrivit 12,50 som förväntat värde i steg 3?

Vi hade testat för något som inte ska vara enligt speccen, och om det inte märks nu kunde det ha ledit till förvirring senare när någon märker det. 


https://github.com/0xNulled/CityBikes-Lektion3