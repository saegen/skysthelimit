# Skys the limit
 Simulator f�r ett objekts r�relser �ver ett plan, dvs en 2-dimensionell. Detta �r en konsolapplikation byggd i .net core 3.1.
  Simulatorn initieras med 4 heltal. De 2 f�rsta anger dimmension p� v�rlden, dvs bredd och h�jd. De andra 2 tv� anger objektets startposition.
 Objektet har en position och en riktning(North,West,South,East) och initieras alltid till North.
 
 Obektet och flyttas med f�ljande commands:
	
	* 1: G� ett steg fram�t i aktuell riktning.
	* 2: G� ett steg bak�t fr�n aktuell riktning.
	* 3: Byt riktning genom att sv�nga 90 grader �t v�nster.
	* 3: Byt riktning genom att sv�nga 90 grader �t h�ger.
	* 0: Kommer att st�nga applikationen.

 En misslyckad definieras av att objektet g�r utanf�r v�rldens kanter. 
 Simulering skriver ut sista koordinaterna f�r objektet. P� formen [X,Y].
 En misslyckad simmulering kommer att skriva [-1,-1]
 
 ## Projektet ligger p� GitHub
 [Skys the limit](https://github.com/saegen/skysthelimit)
 
 ## Anv�nding
	Exempel/Syntax:
	<PathToExecutable>/SKY.Simulation init=4,4,2,2 command=1,4,1,3,2,3,2,4,1,0 showPath
	
	* [Required] init: Kommaseparerad lista av 4 heltal. De tv� f�rsta anger v�rldens
	* [Required] command: Kommaseparerad lista av heltal bet�ende av de commands som anges ovan.
	* [Optional] showPath: Optional En flagga. Om den anges kommer hela simuleringen att skrivas ut annars kommer bara slutpositionen att skrivas ut.

 ## Todo
 Validering av commands
 L�gg till UnitTests  
