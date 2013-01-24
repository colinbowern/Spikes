@echo off
if "%1" == "" goto BuildDefault
goto BuildTarget

:BuildDefault
%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe DotNetBoilerplate.msbuild /t:Compile
goto End

:BuildTarget
%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe DotNetBoilerplate.msbuild /t:%*

:End