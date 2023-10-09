using System.ComponentModel.DataAnnotations;

namespace Card_Game_Database_Website.Models
{
    /// <summary>
    /// Represents a Trading Card
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Unique Identifier for each Trading Card
        /// </summary>
        [Key]
        public int CardId { get; set; }

        /// <summary>
        /// Name of the Trading Card
        /// </summary>
        [Required]
        public string CardName { get; set; }

        /// <summary>
        /// Type of card such as Monster, Spell, Trap, Trainer, Supporter, basic, stage 1
        /// </summary>
        [Required]
        public string CardType { get; set; }

        /// <summary>
        /// Text descriping the card
        /// </summary>
        public string? CardDescription { get; set; }

        /// <summary>
        /// The effect or ability of a card
        /// </summary>
        public string? CardEffect { get; set; }

        /// <summary>
        /// Mainly for pokemon cards
        /// Name of the first attack
        /// </summary>
        public string? CardAttack1 { get; set; }
        /// <summary>
        /// Mainly for pokemon cards
        /// Cost of the first attack
        /// </summary>
        public string? CardAttackCost1 { get; set; }
        /// <summary>
        /// Mainly for pokemon cards
        /// Damage of the first attack
        /// </summary>
        public string? CardAttackDamage1 { get; set; }
        /// <summary>
        /// Mainly for pokemon cards
        /// Effect of the first attack
        /// </summary>
        public string? CardAttackEffect1 { get; set; }
        /// <summary>
        /// Mainly for pokemon cards
        /// Name of the Second attack
        /// </summary>
        public string? CardAttack2 { get; set; }
        /// <summary>
        /// Mainly for pokemon cards
        /// Cost of the Second attack
        /// </summary>
        public string? CardAttackCost2 { get; set; }
        /// <summary>
        /// Mainly for pokemon cards
        /// Damage of the Second attack
        /// </summary>
        public string? CardAttackDamage2 { get; set; }
        /// <summary>
        /// Mainly for pokemon cards
        /// Effect of the Second attack
        /// </summary>
        public string? CardAttackEffect2 { get; set; }

        /// <summary>
        /// Mainly for pokemon cards
        /// amount of HP a Card has.
        /// </summary>
        public string? CardHP { get; set; }

        /// <summary>
        /// Mainly for pokemon cards
        /// figure out whether a card is a basic, stage 1 or stage 2 card
        /// </summary>
        public string? CardStage { get; set; }

        /// <summary>
        /// mainly for pokemon cards
        /// the Retreat Cost of the card
        /// </summary>
        public int? CardRetreatCost { get; set; }

        /// <summary>
        /// mainly for pokemon
        /// Determines what the rule box for the pokemon is
        /// such as ex, v, gx, tag team, Prism star and radiant
        /// </summary>
        public string? CardRuleBox { get; set; }   

        /// <summary>
        /// Attribute for the monster/pokemon card
        /// such as dark, light, fire, or steel
        /// </summary>
        public string? CardAttribute { get; set; }

        /// <summary>
        /// mainly for yugioh
        /// Monster type for the card
        /// such as Fairy, Zombie, or Dragon
        /// </summary>
        public string? CardMonsterType { get; set; }

        /// <summary>
        /// mainly for yugioh
        /// attack value of a monster card
        /// can be "?"
        /// </summary>
        public string? CardAttackValue { get; set; }

        /// <summary>
        /// mainly for yugioh
        /// defense value of a monster card
        /// can be "?"
        /// </summary>
        public string? CardDefenseValue { get; set; }

        /// <summary>
        /// mainly for yugioh
        /// the level value of a monster card.
        /// 1-12
        /// </summary>
        [Range(1,12)]
        public int? CardMonsterLevel { get; set; }
        
    }
}
