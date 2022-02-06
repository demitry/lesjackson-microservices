# Got an 'unexpected token' error while running ps1 script?
# This particular problem vanished after changing the encoding of the PS1 file from UTF-8 to UTF-8-BOM.

$netstat = netstat -aon | findstr “:5000 :6000 :5001 :6001” | Select-String -Pattern “(TCP|UDP)”
$ProcessList = Get-Process
foreach ($line in $netstat)
{
$SpltArry = $line -split ” “
$PD = $spltArry[$spltarry.length – 1]
$pn = $ProcessList | Where-Object {$_.id -eq $pd } | select processname
$SpltArry[$SpltArry.length – 1] = $PD + ” “ + $PN.processname
$SpltArry -join ” “
}