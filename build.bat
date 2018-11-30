@echo off
set here=%~dp0
set solution=%here%AlertMessage.sln
set log=%here%output.log

rem common environments
set target=Debug
set vscommon=C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7
set vcvars=%vscommon%\Tools\vsvars32.bat
set devenv=%vscommon%\IDE\devenv.exe
rem "%vcvars%"

del "%log%"
"%devenv%" "%solution%" /rebuild "%target%" /out "%log%"
type "%log%"

endlocal
