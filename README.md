# BlackOps3MapLanguageFixer
![Screenshot of a comment on a GitHub issue showing an image, added in the Markdown, of an Octocat smiling and raising a tentacle.](https://github.com/TheGaming999/BlackOps-3-Map-Language-Fixer/blob/master/Capture1.PNG)

## How to Use

### 🔹 Automatic Method (Recommended)
1. **Run the tool as Administrator** (required for automatic Steam library detection).  
2. Open the **File** menu and click on the last button:  
   **🟢 "Auto detect Steam library folder..."**  
   - The button should be **green**, indicating that the tool is running as Administrator.  
3. Click on **"< Detect Language"**.  
4. Click on one of the following:  
   - **🛠 "FIX"** – Fixes the issue.  
   - **▶ "FIX AND RUN"** – Fixes the issue and launches the game.  
   - If *t7patch* is detected, it will be launched before the game.

---

### 🔹 Manual Method
1. Open the **File** menu and click on **"Change Steam library folder"**.  
2. Navigate to your Steam library folder (where `libraryfolder.vdf` and `steam.dll` are located) and click **"OK"**.  
3. Select your game language from the dropdown menu, or click on **"< Detect Language"**.  
   - If your Steam library folder is incorrect, you will receive an error.  
   - If correct, the tool will detect the game language automatically.  
4. Click on one of the following:  
   - **🛠 "FIX"** – Fixes any affected map.  
   - **▶ "FIX AND RUN"** – Fixes the issue and launches the game (with *t7patch* if available).  

---

## 📜 Example Output:
```plaintext
Copied 'en_zm_wonderguns.ff' as 'ea_zm_wonderguns.ff'
Copied 'en_zm_wonderguns.xpak' as 'ea_zm_wonderguns.xpak'
(SND) Copied 'zm_wonderguns.en.sabl' as 'zm_wonderguns.ea.sabl'
(SND) Copied 'zm_wonderguns.en.sabs' as 'zm_wonderguns.ea.sabs'
```

⚠ Notes:
* Running the tool as Administrator is necessary for automatic library detection.
* If language detection fails, manually set the Steam library folder and try again.
* If t7patch is found, it will be launched before the game.
* Settings are saved. If you open the tool again, you only need to click "FIX" or "FIX AND RUN"—no need to set everything up again.
