@echo off

set encase_path="C:\Program Files\OpenText\OpenText Forensic 26.2\EnCase.exe"

set case_path="C:\Demo\Demo Case\Demo Case.case"

set script_path="C:\Demo\Scripted Case Creation, Evidence Processing, Iteration and Bookmarking.EnScript"

set evidence_path="C:\Demo\Demo Evidence"

echo.
echo Starting EnCase. Maximize the application's window to view the Console output. 
echo.
echo Use the View ^> Processor Manager option to view evidence-processor status.
echo.

%encase_path% -x -r -min %script_path% %case_path% %evidence_path%

