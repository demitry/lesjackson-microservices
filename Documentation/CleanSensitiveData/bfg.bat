:: Put this file and `bfg.jar` into a dedicated folder for aliases like `C:\Aliases`.
:: And ensure that you add the folder path to `PATH` environment variable.
:: Then you would be able to call `bfg` inside command prompt.
@echo off
echo.
java -jar %~dp0\bfg-1.13.2.jar %* --no-blob-protection
