
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

//Question 1
class Player
{
    public int _HP;
    public int _playerDamage { get; set; }
    public string _playerName { get; set; }
    public int _level { get; set; }
    public int _health { get; set; }
    public int _experience { get; set; }

    public Player(string playerName, int level, int _hP, int experience)
    {
        _playerName = playerName;
        _level = level;
        _HP = _hP;
        _experience = experience;
        _health = _HP;

    }

    public void XpGain(int amount)
    {
        _experience += amount;
        if (_experience >= 100)
        {
            LevelUp();
            _experience -= 100;
        }
    }

    public void DamageGivenByPlayer(int amount)
    {
        _playerDamage = amount;
    }
    public void LevelUp()
    {
        _level++;
        _HP += 20;
        if (_health > _HP)
        {
            _health = _HP;
        }
    }
  
    public void Healing(int amount)
    {
        _health += amount;
        if (_health > _HP)
        {
            _health = _HP;
        }
    }
    public void PlayerAttributes()
    {
        Console.WriteLine($"Player: {_playerName} | level: {_level} | HP: {_health}/{_HP} | XP:{_experience}");
    }
}

//Question 2
class Enemy
{
    public int _HP;
    public string _enemyName { get; set; }
    public int _attackPower { get; set; }
    public int _health { get; set; }
    public int _defense { get; set; }

   

    public Enemy(string EnemyName, int enemyAttack, int health, int defense)
    {
        _enemyName = EnemyName;
        _attackPower = enemyAttack;
        _health = health;
        _defense = defense;
        _HP = _health;
    }

    public int GivenDamage()
    {
        int damage = _attackPower;
        return damage;
    
    }

    public void TakeDamage(int damage)
    {
        int dame = damage - _defense;
        if (dame > 0)
        {
            _health -= dame;
        }
        else
        {
            dame = 0;
            _health -= damage; 
        }
    }
    public void EnemyAttributes()
    {
        Console.WriteLine($"Enemy: {_enemyName} | Damage: {_attackPower} | HP: {_health}/{_HP} | Defense:{_defense}");
    }
}

//Question 3
class Potion
{
    public string _name { get; set; }
    public int _healingPower { get; set; }
    public int _quantity { get; set; }

    public Potion(string name, int healingPower, int quantity)
    {
        _name = name;
        _healingPower = healingPower;
        _quantity = quantity;
    }

    public int PotionUsing()
    {
        if (_quantity > 0)
        {
            _quantity -= 1;

            return _healingPower;
        }
        else
        {
            return 0;
        }
    }
    public void PotionAttributes()
    {
        Console.WriteLine($"Name:{_name} | HealGain: {_healingPower} | quantity:{_quantity}");
    }
}
//Question 4
class Quest
{
    string _questName { get; set; }
    string _questDecription { get; set; }
    string _questReward { get; set; }
    int _completionStatus { get; set; }
    bool _hasQuest { get; set; }

    public Quest(string name, string decription, string questReward, int completionStatus)
    {
        _questName = name;
        _questDecription = decription;
        _completionStatus = completionStatus;
        _questReward = questReward;
        _hasQuest = false;
    }

    public int ClaimReward(int amount)
    {
        amount *= 1;
        return amount;
    }
    public int QuestStatus()
    {
        if (!_hasQuest)
        {
            _hasQuest = true;
            _completionStatus += 1;
            return _completionStatus;
            Console.WriteLine("Quest is completed");
        }
        else
        {
            return _completionStatus;
        }
    }

   
  

    public void QuestAttributes()
    {
        Console.WriteLine($"Quest:{_questName} | Decription:{_questDecription} | Reward:{_questReward} | CompleteStatus:{_completionStatus} ");
    }


}

//Question 5
class Inventory
{
    public int _capacity { get; set; }
    List<string> Items { get; set; }

    public Inventory(int capacity)
    {
        _capacity = capacity;
        Items = new List<string>();
        
    }
    public void AddItemsToList(string item)
    {
        if(Items.Count <= _capacity)
        {
            Items.Add(item);

        }
        else
        {
            Console.WriteLine("Inventory is full");
        }
    }
    public void RemoveItemsToList(string item)
    {
        
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
            else
            {
                Console.WriteLine($"Item {item} is not found");
            }
    }
    public bool HasItem(string item)
    {
        return Items.Contains(item);
    }

    public void DisplayItems()
    {
        Console.WriteLine("Item:");
        foreach (string item in Items)
        {
            if (_capacity > 0)
            {
                Console.WriteLine($"-{item}");
            }
            else
            {
                Console.WriteLine("Inventory is empty");
            }
        }
    }

   
    public void InventoryDetail()
    {
        Console.WriteLine($"- Capacity: {_capacity}");
        Console.WriteLine($"- Current Items: {Items.Count}");
        DisplayItems();
    }
}

//Question 6
class Spell
{
    public string _spellName { get; set; }
    public string _spellDecription { get; set; }
    public int _damage { get; set; }
    public int _manaCost { get; set; }
    public Spell(string name, string decription,  int damage, int manaCost)
    {
        _spellName = name;
        _spellDecription = decription;
        _manaCost = manaCost;
        _damage = damage;
    }
    public void CastSpell(int currentMana)
    {
        if (currentMana >= _manaCost)
        {
            currentMana -= _manaCost;
            Console.WriteLine($"Casting '{_spellName}'! {_spellDecription}");
            Console.WriteLine($"It dealt {_damage} damage.");
            Console.WriteLine($"Mana remaining: {currentMana}");
        }
        else
        {
            Console.WriteLine("Mana is not enough");
        }
    }
    public void DisplaySpellDetails()
    {
        Console.WriteLine($"Spell: {_spellName}| Damage: {_damage} | Mana: {_manaCost} | Decription: {_spellDecription}");
     
    }

}

public class Program
{
    public static void Main()
    {
        string playerName = Console.ReadLine();
        Player Player = new Player(playerName, 1, 100, 0);
        Enemy Enemy = new Enemy("Enemy", 30, 100, 5);
        Potion potion = new Potion("HP Regain", 60, 5);


        Player.XpGain(150);
        Console.WriteLine("Gain 150xp");

        int damageTakenByPlayer = Enemy.GivenDamage();
        Console.WriteLine("Inflicted 30 damage by Enemy");

        Player._health = Player._health - damageTakenByPlayer;
        Console.WriteLine("Player HP -30");

        Player.Healing(10);
        Console.WriteLine("Player HP +10");

        Enemy.TakeDamage(50);
        Console.WriteLine("enemy recieve 50 damage");

        int healthRegain = potion.PotionUsing();
        Player._health = Player._health + healthRegain;
        Console.WriteLine($"Regain {healthRegain} HP");

        Quest quest = new Quest("Dragon Knight", "Kill 1 Fire Dragon", "HPRegain", 0);
        int Reward = quest.ClaimReward(2);
        quest.QuestStatus();
        potion._quantity = potion._quantity + Reward;
        quest.QuestAttributes();

        Player.PlayerAttributes();

        Enemy.EnemyAttributes();

        potion.PotionAttributes();

        Inventory inventory = new Inventory(10);
        inventory.AddItemsToList("HP Regain");
        inventory.AddItemsToList("MP Regain");
        inventory.AddItemsToList("Sword");
        inventory.AddItemsToList("HP Regain");
        inventory.AddItemsToList("HP Regain");
        inventory.RemoveItemsToList("HP Regain");
        inventory.InventoryDetail();

        Spell spell = new Spell("FireBall", "A fiery explosion is given", 50, 20);
        spell.CastSpell(100);
        spell.DisplaySpellDetails();

    }
}
    