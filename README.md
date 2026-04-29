# 🧊 DeepCool AK400 Digital (C# Version) - Bloat-Free Controller

[Python Version](https://github.com/bishalqx980/AK400-Digital)

A lightweight, 20MB RAM, zero-installer C# script to control the LCD on DeepCool AK400 digital cooler.

> The Problem: The official DeepCool software is a ~1GB installer that runs heavy background processes just to display two digits of data.
The Solution: This ~5MB .exe file talks directly to the cooler via HID (Human Interface Device) protocol. No telemetry, no bloat, just data.

## ✨ Features

- Ultralight: Replaces 1GB of software with a tiny script.

- Customizable: Show CPU Usage & CPU Temp. (can be added more...)

- Portable: No "installation" required.

- Based on the AK400 HID protocol mapping.

```
Byte index of AK400

[0] = Report ID (always 16)
[1] = Mode
      19 = show temperature (°C)
      35 = show temperature (°F)
      76 = usage mode (bars)

[2] = Status bar (1–10) → how full the bar is

[3] = First digit   (hundreds place)
[4] = Second digit  (tens place)
[5] = Third digit   (ones place)

[6] = Alarm
      0 = off
      1 = on

[7–63] = unused (just keep 0)
```

[Source: Nortank12/deepcool-digital-linux](https://github.com/Nortank12/deepcool-digital-linux)


```
𝓐 𝓹𝓻𝓸𝓳𝓮𝓬𝓽 𝓸𝓯

 ▄▄▄▄    ██▓  ██████  ██░ ██  ▄▄▄       ██▓    
▓█████▄ ▓██▒▒██    ▒ ▓██░ ██▒▒████▄    ▓██▒    
▒██▒ ▄██▒██▒░ ▓██▄   ▒██▀▀██░▒██  ▀█▄  ▒██░    
▒██░█▀  ░██░  ▒   ██▒░▓█ ░██ ░██▄▄▄▄██ ▒██░    
░▓█  ▀█▓░██░▒██████▒▒░▓█▒░██▓ ▓█   ▓██▒░██████▒
░▒▓███▀▒░▓  ▒ ▒▓▒ ▒ ░ ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░▓  ░
▒░▒   ░  ▒ ░░ ░▒  ░ ░ ▒ ░▒░ ░  ▒   ▒▒ ░░ ░ ▒  ░
 ░    ░  ▒ ░░  ░  ░   ░  ░░ ░  ░   ▒     ░ ░   
 ░       ░        ░   ░  ░  ░      ░  ░    ░  ░
      ░                                        
```
