# minigame 2
## Devlog
### Question1
After placing a chest upstairs, I changed its Sorting Layer, but the spell could not damage it. I realized that the Sorting Layer only controls how objects appear on screen. The chest’s GameObject Layer also needed to match the floor it was on. After changing both settings to Layer 2, the spell could hit the chest correctly.

### Question2
I think _spriteRenderer.color = new Color(r, 0.2f, 0.2f); changes the chest’s color. The dot accesses the sprite renderer’s color property, and new creates a Color value. The three numbers control red, green, and blue. Green and blue stay at 0.2, while r changes from 1 to 0.5 to 0 as the chest loses health. This makes the chest become darker after each hit.

## Open-Source Assets
- Pixel art environment & character sprites: https://assetstore.unity.com/packages/2d/environments/pixel-art-top-down-basic-187605
