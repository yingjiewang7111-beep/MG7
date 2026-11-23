# MG7
## Devlog
In TreeOfBirds, I used an array to store 4 Sparrow GameObjects in the scene. This makes it easier to check multiple birds without writing separate code for each one. And a for loop is used to go through the array and Vector3.Distance(), to calculate the distance between the player and the birds. If the distance is less than 5 units, SetActive(true) is used to make it pop up. And the distance is checked every frame.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
