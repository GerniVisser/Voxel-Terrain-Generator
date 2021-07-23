using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BiomeAttributes", menuName = "Minecraft/Biome Attribute")]
public class Biomes : ScriptableObject
{

    public string biomeName;
    public int soilidGroundHeight;
    public byte fillerBlockID;
    public int terrainHeight;
    public float terrainScale;
    public byte topLayerBlockID;
    public Layer[] layers;
    public Vein[] veins;

}

[System.Serializable]
public class Vein
{

    public string nodeName;
    public byte blockID;
    public int minHeight;
    public int maxHeight;
    public float scale;
    public float threshold;
    public float noiseOffset;

}

[System.Serializable]

public class Layer
{
    public string name;
    public byte blockID;
    public int minHeight;
    public int maxHeight;

}