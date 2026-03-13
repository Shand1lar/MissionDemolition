# Mission Demolition
**CS382 Project 2**

Based on the Mission Demolition tutorial

---

## Levels
The game has 4 castle layouts from easiest to hardest:

| Level | Difficulty | Notes |
|---|---|---|
| 1 | Easy | Simple open structure, wide target |
| 2 | Easy | Still simple more structure |
| 3 | Hard | More structrue + AntiGoal zone |
| 4 | Very Hard | Multi-layered fortress + 2 AntiGoal zones |

---

## Enhancements

### Rubber Band Snap Sound
A sound effect plays the moment the player releases the projectile.

### Projectile Impact Sound
A second sound effect plays when the projectile collides with any object, adding audio feedback to every hit.

### Projectile Impact Particles
A particle burst explosion effect spawns at the point of impact when the projectile hits something, giving each shot a visual que that it has collided.

### AntiGoal Zones (Levels 3 & 4)
Levels 3 and 4 feature a red AntiGoal zone placed near the regular green Goal. If the projectile enters the red zone the player immediately loses and is sent to a Game Over screen. This adds a risk/reward element to levels — the player must aim precisely to hit the green goal without touching the red zone, increasing difficulty and rewarding careful play over spam shooting.

### Game Over Screens
Two separate Game Over panels:
- **VICTORY!** — appears when all 4 levels are completed
- **GAME OVER** — appears when the projectile hits an AntiGoal zone

Both panels include a **Play Again** button that restarts the game from Level 1.

