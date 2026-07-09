@echo off

set encase_path="C:\Program Files\OpenText\OpenText Forensic 26.2\EnCase.exe"

:: Case folder must exist albeit the case file will be created by the script.

set case_path="C:\Demo\Demo Case\Demo Case.case"

set script_path="C:\Demo\Scripted Case Creation, Evidence Processing, Iteration and Bookmarking.EnScript"

:: The script will process every Lx01, L01, Ex01, and E01 file in the following folder. Sub-folders will 
:: be ignored. 

set evidence_path="C:\Demo\Demo Evidence"

:: The following case-template has a couple of user-created bookmark folders and tags. More importantly,
:: it has been configured to use a hash-library containing the following hash-sets:
::
:: - Yellow Banner Pics (Notable)
:: - Security Docs (Known)
::
:: Using hash analysis with a template is necessary to identify known/nptable files.

set case_template_path="C:\Demo\Demo Case Template.CaseTemplate"

echo.
echo Starting EnCase. Maximize the application's window to view the Console output. 
echo.
echo Use the View ^> Processor Manager option to view evidence-processor status.
echo.

%encase_path% -x -r -min %script_path% %case_path% %evidence_path% %case_template_path%