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
