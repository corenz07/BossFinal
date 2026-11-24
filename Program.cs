namespace Boss_final;

/*
    CONSIGNES
    Vous développez le système de combat d'un RPG. Le héros affronte un boss final.

    Le boss possède 150 PV. Le héros possède une arme qui inflige 40 dégâts par attaque.

    Vous devez créer trois méthodes :

    1. CalculateWeaponDamage()
        - Reçoit la puissance de l'arme en paramètre.
        - Retourne les dégâts infligés (ici, la puissance de l'arme).
    2. CalculateRemainingHealth()
        - Reçoit les PV actuels du boss et les dégâts infligés.
        - Calcule les nouveaux PV du boss.
        - Retourne les nouveaux PV.
    3. DisplayBossStatus()
        - Reçoit les PV du boss.
        - Affiche son état :
        - Si ses PV sont supérieurs à 0 : "Le boss est toujours vivant !".
        - Sinon : "Félicitations ! Le boss est vaincu !".
    Dans Main() :
        1. Initialisez les PV du boss à 150.
        2. Calculez les dégâts de l'arme.
        3. Infligez les dégâts au boss.
        4. Affichez son état.
        5. Recommencez une deuxième attaque.
        6. Affichez à nouveau son état.
    BONUS :
        - Inspirez-vous de votre combat du cours de Logique & Algorithmes pour aller plus loin dans cet exercice
 */
class Program
{
    private static int CalculateWeaponDamage(int weaponPower)
    {
        return weaponPower;
    }
    private static int CalculateRemainingHealth(int currentBossHealth, int damage)
    {
        return currentBossHealth - damage;
    }
    private static void DisplayBossStatus(int currentBossHealth)
    {
        if (currentBossHealth > 0)
        {
            Console.WriteLine("Le boss est toujours vivant !");
        }
        else
        {
            currentBossHealth = 0;
            Console.WriteLine("Félicitations ! Le boss est vaincu !");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Vous voilà au fond du donjon, de la fumée remplis la pièce sombre. Vous avancez doucement quand soudain du feu jaillit  de l'obscurité, c'est un dragon !");
        int bossHealth = 150;
        int damage = CalculateWeaponDamage(40);
        while(bossHealth > 0)
        {
            Console.WriteLine("Vous l'attaquer !\nDégats : "+damage);
            bossHealth = CalculateRemainingHealth(bossHealth, 40);
            if(bossHealth < 0)
            {
                bossHealth = 0;
            }
            Console.WriteLine("Santé du dragon : " + bossHealth);
            DisplayBossStatus(bossHealth);
        }
    }
}