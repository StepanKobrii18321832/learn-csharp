**ROCKET**

```C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /nologo Main.cs Rocket.cs Interfaces\RocketBody.cs Interfaces\RocketEngine.cs Interfaces\RocketHeader.cs Engines\EngineHF450.cs Headers\HeaderA100.cs Bodies\BodyKyev.cs Engines\EngineHF600.cs Headers\HeaderA150.cs Bodies\BodyKyev-2.cs Interfaces\Command.cs Command\FirstCommand.cs Command\qCommand.cs RocketConsole.cs Command\NewRocketCommand.cs Data.cs Command\RocketListCommand.cs Command\LaunchCommand.cs Command\RocketInfoCommand.cs Bodies\BodyF-1.cs Engines\EnginePRP-4.cs Engines\EngineRRP-4.cs Headers\HeaderA190.cs```

```Main.exe```

help

- q - exit
- rocket list - shows a list of rockets
- rocket new - custom rocket creation
- rocket info - information about the characteristics of the modules specified rocket
- rocket launch - launch of the selected rocket

v1.1

- **4** new modules

v1.2

- rocket message output **changed**
- console view **changed**
- The rocket now flies along the way, sending a status signal **You can launch several rockets at the same time**

v1.2.1

- bug fix