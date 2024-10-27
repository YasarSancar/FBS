@echo off

set BATCH_DIR=%~dp0
set FILE_TYPE=%~x1
set INPUT_FILE=%1
set FLATC=%BATCH_DIR%\..\external\flatbuffers\flatc.exe --raw-binary -t
set SOURCE=%BATCH_DIR%source\include

if %FILE_TYPE%==.gfbmdl call :convert_gfbmdl
if %FILE_TYPE%==.gfbmdli call :convert_gfbmdli
if %FILE_TYPE%==.gfbanm call :convert_gfbanm
if %FILE_TYPE%==.gfbanmcfg call :convert_gfbanmcfg
if %FILE_TYPE%==.gfbcol call :convert_gfbcol
if %FILE_TYPE%==.gfbprb call :convert_gfbprb
if %FILE_TYPE%==.gfblt call :convert_gfblt
if %FILE_TYPE%==.gfbenv call :convert_gfbenv
if %FILE_TYPE%==.gfbcam call :convert_gfbcam
if %FILE_TYPE%==.gfbcama call :convert_gfbcama
if %FILE_TYPE%==.gfblta call :convert_gfblta
if %FILE_TYPE%==.trmdl call :convert_trmdl
if %FILE_TYPE%==.trskl call :convert_trskl
if %FILE_TYPE%==.trmsh call :convert_trmsh
if %FILE_TYPE%==.trmtr call :convert_trmtr
if %FILE_TYPE%==.trlgt call :convert_trlgt
if %FILE_TYPE%==.trtrr call :convert_trtrr
if %FILE_TYPE%==.trvat call :convert_trvat
if %FILE_TYPE%==.ccdata call :convert_ccdata

:convert_gfbmdl
%FLATC% %SOURCE%\gfx\gfbmdl.fbs -- %INPUT_FILE%
exit /b

:convert_gfbmdli
%FLATC% %SOURCE%\gfx\gfbmdli.fbs -- %INPUT_FILE%
exit /b

:convert_gfbanm
%FLATC% %SOURCE%\anm\gfbanm.fbs -- %INPUT_FILE%
exit /b

:convert_gfbanmcfg
%FLATC% %SOURCE%\anm\gfbanmcfg.fbs -- %INPUT_FILE%
exit /b

:convert_gfbcol
%FLATC% %SOURCE%\gfx\gfbcol.fbs -- %INPUT_FILE%
exit /b

:convert_gfbcam
%FLATC% %SOURCE%\gfx\gfbcam.fbs -- %INPUT_FILE%
exit /b

:convert_gfbenv
%FLATC% %SOURCE%\gfx\gfbenv.fbs -- %INPUT_FILE%
exit /b

:convert_gfblt
%FLATC% %SOURCE%\gfx\gfblt.fbs -- %INPUT_FILE%
exit /b

:convert_gfbprb
%FLATC% %SOURCE%\gfx\gfbprb.fbs -- %INPUT_FILE%
exit /b

:convert_gfbcama
%FLATC% %SOURCE%\anm\gfbcama.fbs -- %INPUT_FILE%
exit /b

:convert_gfblta
%FLATC% %SOURCE%\anm\gfblta.fbs -- %INPUT_FILE%
exit /b

:convert_trmdl
%FLATC% %SOURCE%\gfx2\trmdl.fbs -- %INPUT_FILE%
exit /b

:convert_trskl
%FLATC% %SOURCE%\gfx2\trskl.fbs -- %INPUT_FILE%
exit /b

:convert_trmsh
%FLATC% %SOURCE%\gfx2\trmsh.fbs -- %INPUT_FILE%
exit /b

:convert_trmtr
%FLATC% %SOURCE%\gfx2\trmtr.fbs -- %INPUT_FILE%
exit /b

:convert_trtrr
%FLATC% %SOURCE%\terrain\trtrr.fbs -- %INPUT_FILE%
exit /b

:convert_trlgt
%FLATC% %SOURCE%\gfx2\object\format\current\fbs\trlgt.fbs -- %INPUT_FILE%
exit /b

:convert_trvat
%FLATC% %SOURCE%\gfx2\trvat.fbs -- %INPUT_FILE%
exit /b

:convert_ccdata
%FLATC% %SOURCE%\scene\cc_data.fbs -- %INPUT_FILE%
exit /b
