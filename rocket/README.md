**ROCKET**

```C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /nologo Main.cs Rocket.cs Interfaces\RocketBody.cs Interfaces\RocketEngine.cs Interfaces\RocketHeader.cs Engines\EngineHF450.cs Headers\HeaderA100.cs Bodies\BodyKyev.cs Engines\EngineHF600.cs Headers\HeaderA150.cs Bodies\BodyKyev-2.cs Interfaces\Command.cs Command\qCommand.cs RocketConsole.cs Command\NewRocketCommand.cs Data.cs Command\RocketListCommand.cs Command\LaunchCommand.cs Command\RocketInfoCommand.cs Bodies\BodyF-1.cs Engines\EnginePRP-4.cs Engines\EngineRRP-4.cs Headers\HeaderA190.cs Command\RocketListInOrbitCommand.cs Command\LandingCommand.cs Command\RefillCommand.cs Headers\HeaderG1.cs Command\GetFuelCommand.cs Interfaces\Сoordinates.cs Interfaces\Planet.cs Command\ChangeOrbitCommand.cs Bodies\BodyF-1A.cs Bodies\BodyL-1.cs Engines\EngineHF800.cs Engines\EnginePRP-5.cs Engines\EngineRRP-5.cs Headers\HeaderG2.cs```

```Main.exe```

help

- q - exit
- rocket list - shows a list of rockets
- rocket new - custom rocket creation
- rocket info - information about the characteristics of the modules specified rocket
- rocket launch - launch of the selected rocket
- rocket list in orbit - shows a list of rockets in orbit
- rocket landing - rocket landing
- rocket refill - refuel specified rocket
- rocket get fuel - refueling in orbit. From secondary to main
- rocket change orbit - flies to another orbit

v1.1

- 4 **new** modules

v1.2

- rocket message output **changed**
- console view **changed**
- The rocket now flies along the way, sending a status signal **You can launch several rockets at the same time**

v1.2.1

- bug **fix**

v1.2.2

- bug **fix**

v1.3

- landing function **added**
- **new** command "rocket list in orbit"
- **new** command "rocket landing"
- number of launch rockets **changed**
- bug **fix**

v1.4

- refill function **added**
- **new** command "rocket refill"
- bug **fix**

v1.5

- refill in orbit function **added**
- **new** command "rocket get fuel"
- 1 **new** module
- number of launch rockets **changed**
- rocket type parameter **added**

v1.5.1

- **added** info rocket "orbit radius"
- bug **fix**

v1.6

- change orbit function **added**
- **added** new command "rocket change orbit"
- bug **fix**

v1.6.1

- 1 **new** header module
- 3 **new** engine module
- 2 **new** body module

v1.6.1.1 - v1.6.1.8

- bug **fix**
- **new** architecture with support for changing locations **(in future updates)**