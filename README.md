# Skys the limit
 Simulator för ett objekts rörelser över ett plan, dvs en 2-dimensionell. Detta är en konsolapplikation byggd i .net core 3.1.
  Simulatorn initieras med 4 heltal. De 2 första anger dimmension på världen, dvs bredd och höjd. De andra 2 två anger objektets startposition.
 Objektet har en position och en riktning(North,West,South,East) och initieras alltid till North.
 
 Obektet och flyttas med följande commands:
	
	* 1: Gå ett steg framåt i aktuell riktning.
	* 2: Gå ett steg bakåt från aktuell riktning.
	* 3: Byt riktning genom att svänga 90 grader åt vänster.
	* 3: Byt riktning genom att svänga 90 grader åt höger.
	* 0: Avsluta.

 En misslyckad definieras av att objektet går utanför världens kanter. 
 Simulering skriver ut sista koordinaterna för objektet. På formen [X,Y].
 En misslyckad simmulering kommer att skriva [-1,-1]
 
 ## Projektet ligger på GitHub
 [Skys the limit](https://github.com/saegen/skysthelimit)
 
 ## Använding
	Exempel:
	Kör en simulering där världen är en 4x4 matris och objektet startar på position [2,2]. 
	Kommandona flyttar objektet över världen enligt ovan och det sista kommandot, dvs 0, kommer att avsluta simuleringen.
	
	###Syntax:
	<PathToExecutable>/SKY.Simulation init=4,4,2,2 command=1,4,1,3,2,3,2,4,1,0 showPath
	
	* [Required] init: Kommaseparerad lista av 4 heltal. De två första anger världens
	* [Required] command: Kommaseparerad lista av heltal betående av de commands som anges ovan.
	* [Optional] showPath: Optional En flagga. Om den anges kommer hela simuleringen att skrivas ut annars kommer bara slutpositionen att skrivas ut.


 ## Todo:
 * Faktorisera ut interfaces så att man kan byta ut instanserna av World och PlayerObject.
 * Testa på Mac.
 * Förbättra argument parsning. Separera hantering av de olika argumenten i olika funktioner inklusive validering av värdena.
 * Lägg till UnitTests för SimulatonLibrary.
 * Var inte med i spec men fel bör skrivas till stderr och inte stdout som nu.
 
