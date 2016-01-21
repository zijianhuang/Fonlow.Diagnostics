cd %~dp0
nuget.exe pack Fonlow.Diagnostics.csproj -Prop Configuration=Release -OutputDirectory c:\release\FonlowDiagnostics
pause