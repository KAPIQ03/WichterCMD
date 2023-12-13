﻿using Newtonsoft.Json.Linq;

namespace Gra.Klasy;

public class Hero
{
  public string? Name;
  public int Strength;
  public int Speed;
  public int Magic;
  public int Alchemy;
  public int HP;
  public int XP;
  public int Gold;
  public int Level;
  public int Storage;

  public Hero(JObject load)
  {
    JObject Load = load;
    Init((int)Load["Strength"], (int)Load["Speed"], (int)Load["Magic"], (int)Load["Alchemy"], (int)Load["HP"], (int)Load["XP"], (int)Load["Gold"], (int)Load["Level"], (int)Load["Storage"], (string)Load["Name"]);
  }
  private void Init(int strength, int speed, int magic, int alchemy, int hp, int xp, int gold, int level, int storage, string name)
  {
    this.Name = name;
    this.Strength = strength;
    this.Speed = speed;
    this.Magic = magic;
    this.Alchemy = alchemy;
    this.HP = hp;
    this.XP = xp;
    this.Gold = gold;
    this.Level = level;
    this.Storage = storage;
  }

  // public void UpStrength() { this.Strength += 5; this.HP += 5; }
  // public void UpDexterity() { this.Dexterity += 5; }
  // public void UpIntelligence() { this.Intelligence += 5; this.MP += (3 * this.Intelligence); }
  public static void Save(JObject hero, Hero hero1)
  {
    JObject Hero = hero;
    Hero["Strength"] = hero1.Strength;
    Hero["Speed"] = hero1.Speed;
    Hero["Magic"] = hero1.Magic;
    Hero["Alchemy"] = hero1.Alchemy;
    Hero["HP"] = hero1.HP;
    Hero["XP"] = hero1.XP;
    Hero["Storage"] = hero1.Storage;
    Hero["Gold"] = hero1.Gold;
    Hero["Level"] = hero1.Level;
    Hero["Name"] = hero1.Name;

    File.WriteAllText("./hero.json", Hero.ToString());
  }
}