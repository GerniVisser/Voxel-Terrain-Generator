
# Procedurally Generated Voxel World

A procedural voxel world generator in Unity 3D game engine. A fun simulation to
 show how procedural world generation works in video games like Minecraft. This
  simulation uses Simplex noise to simulate what looks like randomness and is then
   projected onto the voxel landscape. This simulation allows for the overlapping
    of multiple noise functions to simulate the creation of caves, ore veins, and
     even allows for the generation of island like worlds. 

## Demo

![Alt Text](https://media.giphy.com/media/6Au4R9VBgl4zKDp3aH/giphy.gif)
![Alt Text](https://media.giphy.com/media/ykJYGPyseXr4qQZvd5/giphy.gif)

  
## Installation

- Install [Unity 3D engine](https://unity3d.com/get-unity/download) onto your pc.
- Clone repo into folder on your pc.
- Open the project in Unity.

    
## Usage

The biome editor tool can be used to configure terrain generation rules.

- In the content browser navigate to Assets/Data/Biomes then open the BiomeAttributes tool
- Layers are used to assign different blocks to different y-value ranges
- Veins are used to add 3D noise like adding Caves, Ore veins, islands.

![alt text](https://raw.githubusercontent.com/GerniVisser/Voxel-terrain-generator-Unity/main/Assets/Images/Tool.PNG)

## Lessons Learned

Firstly, I learned about Perlin and Simplex noise and overlapping these functions to generate the smooth randomness I needed to mold the terrain. The real challenge came when trying to render the thousands of voxel cubes that would populate the world. My first attempt of rendering all of them individually nearly crashed my computer!
Further research led me to create a single mesh around all the blocks that contained only the faces which are visible to the observer and to only render that one mesh. I then divided the world into smaller chunks to simplify data storge and rendering. This reduced the processing overhead when the player moved around since only the chunks that were needed had to be loaded and rendered.
This project taught me about optimization and fine tuning. I learned about new and more efficient data structures and types and about eliminating unnecessary tasks that would drain valuable resources.
