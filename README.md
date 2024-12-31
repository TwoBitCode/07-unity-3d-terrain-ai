
# **Unity Week 7: Three-Dimensional Scene-Building and Navigation**

Play on itch: https://twobitcode.itch.io/07-unity-3d-terrain-ai

A project with step-by-step scenes illustrating how to construct a 3D game, including:

- 🏗️ **Scene Modelling**: Using Terrain Tools and ProGrids for creating and aligning structures.
- 🎮 **Player Control**: Implementing CharacterController and NavMeshAgent for smooth navigation.
- 🤖 **Enemy AI**: Adding intelligent enemy behavior.
- 🎯 **Target Visualization**: Using gizmos for better debugging and visualization.

Text explanations are available in the [08 folder](https://github.com/gamedev-at-ariel/gamedev-5782).

---

## **Our Developments in This Scene**
This project expands the **3-e complete building** scene by adding a new bedroom and custom features:

### **1. Added a Bedroom**
- 🛏️ Built a **bedroom** in the **3-e complete building** scene using **ProGrids** for precise alignment.
- Included:
  - A **bed**, custom-built using Unity's **ProBuilder** tool.
  - A **desk and chair**, also designed with **ProBuilder**.
  - A **lamp prefab** from the [Roman Furniture Pack](https://assetstore.unity.com/packages/3d/props/furniture/roman-furniture-roman-villa-pack-165586) for decoration and lighting.

### **2. Integrated Prefabs**
- 🪑 Used prefabs from the **Roman Furniture Pack** to enhance the room's appearance and add functional elements.

### **3. Added a Corridor**
- 🚪 Constructed a corridor to connect the new bedroom to the main building.

### **4. Improved Lighting**
- 💡 Added **Point Lights** to illuminate the room effectively, including the lamp as a light source.
- 
### **5. New Player Interactions**
- 🏃‍♂️ **Jumping Ability**: The player can now jump using the **spacebar**.
  script reference:
  https://github.com/TwoBitCode/07-unity-3d-terrain-ai/blob/3ee98bd3164dd5f1ee73b841408d0c81ecd0c736/Assets/Scripts/1-player/CharacterKeyboardMover.cs#L73-L79
  
- 👀 **Interactive Objects**: When the player is near another **capsule GameObject**, a message will appear when the **E key** is pressed.
  script reference:
  https://github.com/TwoBitCode/07-unity-3d-terrain-ai/blob/b44bf5b6d86c935ff1ce149d2f4629a75480b4eb/Assets/Scripts/3-objects/popMessageAction.cs#L31-L37
  
  https://github.com/TwoBitCode/07-unity-3d-terrain-ai/blob/main/Assets/Scripts/3-objects/popMessageAction.cs

- 💡 **Light Control**: The player can **turn the bedroom light on and off** by pressing the **L key**. If the player is too far from the light, it will automatically turn off after a certain radius.
  script reference:
  https://github.com/TwoBitCode/07-unity-3d-terrain-ai/blob/b44bf5b6d86c935ff1ce149d2f4629a75480b4eb/Assets/Scripts/3-objects/LightAction.cs#L21-L26

  https://github.com/TwoBitCode/07-unity-3d-terrain-ai/blob/main/Assets/Scripts/3-objects/LightAction.cs

The main script for the ActionKeyPressed functinalities: https://github.com/TwoBitCode/07-unity-3d-terrain-ai/blob/main/Assets/Scripts/3-objects/ActionOnKeyPress.cs

---
### **Programming**:
- 👨‍💻 Vivian Umansky
- 👨‍💻 Miriam Nagar
---

## **Credits**

### **Programming**:
- 👨‍💻 Michael Lemberger
- 👨‍💻 Erel Segal-Halevi

### **Graphics**:
- 🔫 [Sci-Fi Gun Light](https://assetstore.unity.com/packages/3d/props/guns/sci-fi-gun-light-87916)
- 🛸 [Sci-Fi Styled Modular Pack](https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913)
- 🪖 [Toon Soldiers Demo](https://assetstore.unity.com/packages/3d/characters/toon-soldiers-demo-69684)
- 🏺 [Roman Furniture Pack](https://assetstore.unity.com/packages/3d/props/furniture/roman-furniture-roman-villa-pack-165586)

### **Online Course**:
- 📚 [Unity RPG](https://www.gamedev.tv/p/unity-rpg/?product_id=1503859&coupon_code=JOINUS)

---
