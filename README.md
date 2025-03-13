# BlackOps3MapLanguageFixer
![Screenshot of a comment on a GitHub issue showing an image, added in the Markdown, of an Octocat smiling and raising a tentacle.](https://github.com/TheGaming999/BlackOps-3-Map-Language-Fixer/blob/master/Capture1.PNG)

### How to Use
#### Automatic
* Run tool as administrator
* Open file menu and click on the last button "Auto detect steam library folder..." (that button should be green, which indicates that the tool is run as administrator)
* Click on "< Detect Language" button
* Click on "FIX" or "FIX AND RUN" button  
#### Manual
* Open file menu and click on "Change steam library folder"
* Navigate to your steam library folder (where "libraryfolder.vdf" and "steam.dll" files are found) and click "Ok"
* Select your game language from the dropdown menu or click on "< Detect Language" button. It will give you an error if your steam library folder is not the correct one. Otherwise, it will pick the game language.
* Click on "FIX" or "FIX AND RUN" button  

  
*FIX*: Fixes any map that has that issue.  
*FIX AND RUN*: Same as above but runs the game after fixing. If t7patch is found, then it will start before the game.  

Example output:
```
> Copied 'en_zm_wonderguns.ff' as 'ea_zm_wonderguns.ff'
> Copied 'en_zm_wonderguns.xpak' as 'ea_zm_wonderguns.xpak'
> (SND) Copied 'zm_wonderguns.en.sabl' as 'zm_wonderguns.ea.sabl'
> (SND) Copied 'zm_wonderguns.en.sabs' as 'zm_wonderguns.ea.sabs'
```
