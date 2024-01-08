## About
This design principle says a class should have a single principle and any thing that should change its behavious should relate to its principle

## Code
The file manager handles all responsibiliites regarging file persistance 
the Journal handles all responsibiliites for journal management
Journal should not be used to save files 
Filemanager should not be used to save journals
