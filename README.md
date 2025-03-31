1. Setting Up the Unity Project
•	Create a New 2D Project
o	Open Unity Hub → Create a new project.
o	Select 2D Core template.
o	Name your project (e.g., MaskMan) and select a folder.
o	Click Create.
•	Set Up Scene and Layers
o	In the Hierarchy, right-click → Create Empty → Rename to GameManager.
o	Open Edit → Project Settings → Tags and Layers.
o	Add layers: Ground, Player, Trap, Collectible, Background.
2. Scene Setup
•	Create the Main Menu Scene
o	Create a new Scene → Name it MainMenu.
o	Add UI elements: Canvas, Panel (background), TextMeshPro (title), and buttons (Play, Options, Exit).
o	Implement MainMenu Script to handle scene transitions.
3. Options Menu
•	Create Options Scene with Level 1 and Level 2 buttons.
•	Implement OptionsMenu Script to load levels.
4. Exit Menu
•	Create ExitMenu Scene with Replay and Exit buttons.
•	Implement ExitMenu Script for functionality.
5. Add Scenes to Build Settings
•	Open File → Build Settings.
•	Add scenes: MainMenu, OptionsMenu, Level1, Level2, ExitMenu.
6. Creating the Player Character
•	Import Player Sprite and configure animations.
•	Create Player GameObject with Rigidbody2D, BoxCollider2D, and Animator.
•	Implement PlayerController Script for movement and jumping.
7. Animation
•	Create Animator Controller.
•	Set up transitions between Idle, Running, Jumping, and Falling animations.
8. Tilemap for Level Design
•	Create and paint a Tilemap.
•	Add Tilemap Collider 2D and Composite Collider 2D.
9. Camera Setup
•	Install Cinemachine and configure Virtual Camera.
10. Collectibles and Scoring
•	Create collectible prefab with CircleCollider2D.
•	Implement Collectible Script to handle scoring.
11. UI Setup
•	Create UI Canvas with TextMeshPro for score display.
•	Implement ScoreManager Script for score tracking.
12. Death and Respawn
•	Set up death detection collider.
•	Implement GameManager Script for level restart.
13. Parallax Background
•	Import background images and create Parallax Script for effect.
14. Building the Game
•	Open File → Build Settings.
•	Add all scenes and configure build settings.
15. Next Steps (Suggestions)
•	Add sound effects and background music.
•	Introduce power-ups.
•	Design more levels.
•	Implement a Pause Menu.

