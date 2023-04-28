<h1>Teorie her - Axelrodův turnaj</h1>
<p style="white-space: pre-line">
V tomto úkolu si procvičíte teorii her, primárně opakované vězňovo dilema a svou vlastní představivost. Vašim úkolem je zopakovat Axelrodův turnaj z roku 1981. V tomto turnaji se proti sobě utkávají strategie řešící opakované vězňovo dilema, cílem je samozřejmě, aby daná strategie vyprodukovala co nejméně let za mřížemi pro následníka této strategie, ať už protivník zvolí jakoukoliv ze zbylých strategií.

Výplatní matice je dána následovně:

- maximální délka trestu je 5 let, maximální odměna je tedy 5 let svobody (tohle je zde proto, že originální Axelrodova matice obsahuje kladné hodnoty odměn)

- pokud hráči vzájemně spolupracují, odsedí si každý 2 roky, tedy 3 roky na svobodě.

- pokud se hráči navzájem zradí, odsedí si každý 4 roky, tedy 1 rok na svobodě.

- pokud první hráč zradí druhého, ale druhý prvního nikoliv, první hráč odejde bez trestu (5 let svobody) a druhý hráč bude zavřen na 5 let (0 let svobody)

Vašim úkolem je tedy zreprodukovat původní Axelrodův turnaj, kde se každá strategie utká s ostatními (i s kopií sebe sama) ve 200 opakováních a vyhodnotit, která strategie dosahuje nejlepšího průměrného výsledku. Základem je tedy některé známé strategie implementovat a vyzkoušet v turnaji proti sobě (TitForTat, Always Cooperate, Always Defect, Periodically DDC, Periodically CCD a další). Další částí úkolu je vymyšlení vlastní strategie, kterou otestujete.

</p>
<img src="https://user-images.githubusercontent.com/75219332/235270334-40f7097f-c0df-42e6-bae8-5057176112ee.png"></img>
<img src="https://user-images.githubusercontent.com/75219332/235270594-ce9de2f9-5214-455f-ad29-a1ee7c0e9934.png"></img>
<hr>
<h2>My solution got the current results</h2>
<pre>
The first game 'Always Cooperate' versus 'Always Cooperate'
First result 600 Second result 600
The first game 'Always Cooperate' versus 'Always Defect'
First result 0 Second result 1000
The first game 'Always Cooperate' versus 'TitForTat'
First result 600 Second result 600
The first game 'Always Cooperate' versus 'PeriodicallyCCD'
First result 402 Second result 732
The first game 'Always Cooperate' versus 'PeriodicallyDDC'
First result 198 Second result 868
The first game 'Always Cooperate' versus 'RandomStrategy'
First result 306 Second result 796
The first game 'Always Cooperate' versus 'DanilStrategy'
First result 300 Second result 800
Average number of AlwaysCooperate is 375
The first game 'Always Cooperate' versus 'Always Cooperate'
First result 200 Second result 200
The first game 'Always Defect' versus 'Always Cooperate'
First result 1000 Second result 0
The first game 'Always Defect' versus 'TitForTat'
First result 204 Second result 199
The first game 'Always Defect' versus 'PeriodicallyCCD'
First result 732 Second result 67
The first game 'Always Defect' versus 'PeriodicallyDDC'
First result 468 Second result 133
The first game 'Always Defect' versus 'RandomStrategy'
First result 608 Second result 98
The first game 'Always Defect' versus 'DanilStrategy'
First result 600 Second result 100
Average number of AlwaysDefect is 445
The first game 'TitForTat' versus 'TitForTat'
First result 1000 Second result 0
The first game 'TitForTat' versus 'Always Defect'
First result 199 Second result 204
The first game 'TitForTat' versus 'Always Defect'
First result 199 Second result 204
The first game 'TitForTat' versus 'PeriodicallyCCD'
First result 533 Second result 533
The first game 'TitForTat' versus 'PeriodicallyDDC'
First result 399 Second result 404
The first game 'TitForTat' versus 'RandomStrategy'
First result 441 Second result 446
The first game 'TitForTat' versus 'DanilStrategy'
First result 401 Second result 401
Average number of TitForTat is 398
The first game 'PeriodicallyDDC' versus 'PeriodicallyDDC'
First result 397 Second result 402
The first game 'PeriodicallyDDC' versus 'Always Cooperate'
First result 866 Second result 201
The first game 'PeriodicallyDDC' versus 'TitForTat'
First result 402 Second result 397
The first game 'PeriodicallyDDC' versus 'PeriodicallyCCD'
First result 602 Second result 267
The first game 'PeriodicallyDDC' versus 'Always Defect'
First result 133 Second result 468
The first game 'PeriodicallyDDC' versus 'RandomStrategy'
First result 515 Second result 330
The first game 'PeriodicallyDDC' versus 'DanilStrategy'
First result 499 Second result 334
Average number of PeriodicallyDDC is 444
The first game 'PeriodicallyCCD' versus 'PeriodicallyCCD'
First result 533 Second result 533
The first game 'PeriodicallyCCD' versus 'Always Defect'
First result 66 Second result 736
The first game 'PeriodicallyCCD' versus 'TitForTat'
First result 529 Second result 534
The first game 'PeriodicallyCCD' versus 'Always Cooperate'
First result 734 Second result 399
The first game 'PeriodicallyCCD' versus 'PeriodicallyDDC'
First result 267 Second result 602
The first game 'PeriodicallyCCD' versus 'RandomStrategy'
First result 388 Second result 568
The first game 'PeriodicallyCCD' versus 'DanilStrategy'
First result 400 Second result 565
Average number of PeriodicallyCCD is 420
The first game 'RandomStrategy' versus 'RandomStrategy'
First result 442 Second result 467
The first game 'RandomStrategy' versus 'Always Cooperate'
First result 794 Second result 309
The first game 'RandomStrategy' versus 'TitForTat'
First result 441 Second result 441
The first game 'RandomStrategy' versus 'PeriodicallyCCD'
First result 580 Second result 385
The first game 'RandomStrategy' versus 'PeriodicallyDDC'
First result 329 Second result 499
The first game 'RandomStrategy' versus 'Always Defect'
First result 94 Second result 624
The first game 'RandomStrategy' versus 'DanilStrategy'
First result 470 Second result 425
Average number of RandomStrategy is 453
The first game 'DanilStrategy' versus 'DanilStrategy'
First result 0 Second result 1000
The first game 'DanilStrategy' versus 'Always Cooperate'
First result 800 Second result 300
The first game 'DanilStrategy' versus 'TitForTat'
First result 503 Second result 498
The first game 'DanilStrategy' versus 'PeriodicallyCCD'
First result 566 Second result 401
The first game 'DanilStrategy' versus 'PeriodicallyDDC'
First result 334 Second result 499
The first game 'DanilStrategy' versus 'RandomStrategy'
First result 458 Second result 448
The first game 'DanilStrategy' versus 'Always Cooperate'
First result 800 Second result 300
Average number of DanilStrategy is 434
</pre>
