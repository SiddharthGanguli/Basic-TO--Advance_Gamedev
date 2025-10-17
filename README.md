# Basic to Advance Game Development – Unity Journey

Welcome to my Unity GameDev learning journey!  
This repository documents my progress from basic scripting to advanced gameplay systems in **Unity (C#)**.

---

## Version 1 – Basic 2D Movement

### What I Built
A simple **2D project** with a movable square (player).  
The player can move smoothly in all directions using keyboard input.

### Features
- **Player Movement:** Controlled with arrow keys / WASD  
- **Frame-rate Independent:** Movement uses `Time.deltaTime` for smooth motion  
- **Script Component:** Custom C# script attached to the square object  
- **Transform Translation:** Object position updated every frame via `transform.Translate()`

### What I Learned
- How to create and attach **C# scripts** to GameObjects in Unity  
- Understanding the **`Update()`** method (called every frame)  
- Using **`Input.GetAxis("Horizontal")`** and **`Input.GetAxis("Vertical")`** to read keyboard input  
- The importance of **`Time.deltaTime`** to keep movement smooth on different frame rates  
- Basic Unity workflow:
  1. Creating a GameObject (the player square)
  2. Attaching a script
  3. Running and testing in Play Mode

---

##  Project Structure
Assets/ <br>
├── Scripts/ <br>
│ └── PlayerMovement.cs <br>
├── Scenes/  <br>
│ └── MainScene.unity <br>
ProjectSettings/ <br>
Packages/ <br>