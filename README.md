# GDIM 33 In-Class Activities
## W1
### Activity 1
[Pre-Production Activity Board](https://miro.com/app/board/uXjVGoFarLc=/?share_link_id=5214578093)

1. The future style UI and Lab environment. Guns. 
2. Pengcheng Qi: We both play Arknights and Death Stranding.
3. Elijah: We both like Death Stranding.


### Activity 2

![Untitled drawing](https://github.com/user-attachments/assets/ed87f1f7-1984-4f6b-94a7-742fcec0e616)


## W3
### Activity 1
<img width="960" height="720" alt="Untitled drawing (1)" src="https://github.com/user-attachments/assets/6198ff81-9640-4f39-8596-2604f39b8b1c" />

### Activity 2

1. You can simply reuse it on other NPC by change variable, with out need to change your graph. You can also prevent mistype.
2. When I try to change form Dialogue state into Explore state, I found that the button is clicked by add a Debug.log, but the translons did not happen, since the Debug.log on the translon did not trigger, and nothing happing. So, find that I use Custom event, but not Unity Event.
3. Yes. In the main screen, player need to use cursor to click on buttons. But in the game, player need to use mouse to aim, so cursor need to be locked.
4. Yes. In the game, there was a pause screen, and I can use state machine to build it. When player press ESC, trigger the Run to Pause, and when player press resume button, Trigger Pause to Run.

## W4

### Activity 1

#### playtesting goal

In the current game, player can walk around and shoot. The goal is to test if there are bugs and find point to improve.

#### playtest team

Haoyi Zhang, Pengcheng Qi, Allen Gu, Yaokun Wan, Zhengfan Yang

####  playtesting notes

Zhengfan Yang: Change the point of view to make player closer.

Pengcheng Qi: Add shake to the UI.

### Activity 2

1. Yes. You can just add more DialogueNodeW4 ScriptableObject to add a new option on dialogue.
2. Yes. For every single dialogue, you can only set up to 4 options(More than 4 options will work but the UI will look not good).
3. When you create a new function to call, you will need to make the UNITY know. But unity will not call this automatically. So you need to use this button to let unity scan your assets and find the function.

#### BONUS POINT
<img width="1237" height="905" alt="image" src="https://github.com/user-attachments/assets/2bb17e6d-765a-4beb-9327-f1612decd2c5" />



## W5

### Activity 1

Step1: Enemy can walk to player

​	Substep1: Add Navmesh

​	Substep2: Make enemy walk to player

​	Substep3: Combine with Animgraph

Step2: Enemy will walk to player when it sees player

​	Substep1: Add Raycast

​	Substep2: Cottrol enemy walk

Step3: Enemy will attack player when it get close to player

​	Substep1: Get distance

​	Substep2: Attack and make damage

​	Substep3: Combine with Animgraph

### Activity 2

I complete Step 1.

## W6

### Activity 1

[Link to the itch page](https://stormmoon.itch.io/fractured-vertical-slice-playtest-2)

#### Change since Milestone 1

I added enemy AI. The enemy will chase the player when it sees the player. I also added the death of the player. I also add some QOL update, like give player a reminder when the actual bullet hit point is different with the aim point.

#### Test goal

I want to test if there are any bug when the enemy chase and attack the player, and the player death.

#### playtesting notes

Add a restart button when player died.

Change the layer of the interact UI.

Fix a issue that cause the damage list can't show correct damage.

### Activity 2

1. Because all the value are less than 1, multiply them will make them closer to 0, which is black.
2. More. Since alpha value is less than 1, multiply it will will make it closer to 0, which is completely transparent.
3. This data comes from the mesh.
4. Yes.

## W7

1. The data comes form the mesh. The mesh contains color information.
2. They’re interpolated across the adjacent.
3. The resolution of vertex colors depends on the number of vertices, the resolution of textures is much higher than the vertex density of the mesh. This can be used to render objects in the distance that are not important, such as a mountain in the background. This can improve performance.
4. I think the direction of the normal is reversed.
5. We can use it to check the direction of tangent.
6. Since the normal vector is oriented in the opposite direction, the result must be multiplied by -1.
7. If you don't change it to “Additive,” the black in the Noise will become visible.

## W8

### Activity 1

I added a scan function into the game.

[Link to the itch page](https://stormmoon.itch.io/fractured-vertical-slice-playtest-3)

I want to test if there are any bug in the scan function.

Note: Change the key of the scan.

### Activity 2

1. The time will be turned into a looping 0 to 1 value, makes UV changes.
2. It does not affect the color of the base sprite.
3. The sprite renderer automatically replaces the sprite in the texture with the object's own sprite.
4. It may make the final value to be greater than 1, may break the scrolling effect.

## W9

### Activity 1

War Thunder

To make War Thunder'internal structure s X-ray and mouse-over outline effects in Unity, we can split the vehicle model into an opaque internal structure  and a semi-transparent surface skin, rendered later with Transparent queue so that the former naturally shows through the translucent hull. For the highlight outline, we can detect the part with raycast and draw its inflated mesh in a final pass after all transparent objects, using a queue like Overlay or injecting through a CommandBuffer at the AfterRenderingTransparents event to keep the contour sharp on top.

### Activity 2

I added a outline to the enemy. This effect will appear when the enemy being scanned.
