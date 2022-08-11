using Spire.Xls;
using Kesmai.Server.Items;
using System.Linq;

namespace StormhalterItems
{
    public class Tests
    {
        private Workbook workbook;
        private Weapon weapon;

        [SetUp]
        public void Setup()
        {
            workbook = new Workbook();
        }

        [Test]
        public void Test1()
        {
            var test = GetWorkBook();
        }

        [Test]
        public void ParseAndAddBackObject()
        {
            var test = GetWeaponType(GetAxes());
        }

        private Workbook GetWorkBook()
        {
            workbook.CreateEmptySheets(5);

            GetWorkSheet(workbook.Worksheets[0], GetWeaponType(GetAxes()));
            GetWorkSheet(workbook.Worksheets[1], GetWeaponType(GetBows()));
            GetWorkSheet(workbook.Worksheets[2], GetWeaponType(GetDaggers()));
            GetWorkSheet(workbook.Worksheets[3], GetWeaponType(GetFlails()));

            workbook.SaveToFile("NewCool.xlsx", ExcelVersion.Version2013);

            return workbook;
        }

        private Worksheet GetWorkSheet(Worksheet worksheet, List<Weapon> weapons)
        {
            int count = 2;
            foreach (var weapon in weapons)
            {
                char char1 = 'B';
                

                worksheet.Range[$"A1"].Text = "Weapon Name";
                worksheet.Range[$"A{count}"].Text = weapon.GetType().Name;

                foreach (var propertyInfo in weapon.GetType().GetProperties())
                {
                    var propertyName = propertyInfo.Name;
                    var propertyValue = propertyInfo.GetValue(weapon);
                    worksheet.Range[$"{char1}1"].Text = $"{propertyName}";
                    worksheet.Range[$"{char1}{count}"].Text = $"{propertyValue}";
                    char1++;
                }
                count++;
            }
            return worksheet;
        }

        private List<object> GetAxes()
        {
            var weaponList = new List<object>();

            weaponList.Add(new BattleAxe());
            weaponList.Add(new BayonetHammer());
            weaponList.Add(new ReturningAxe());
            weaponList.Add(new SilverGreatAxe());
            weaponList.Add(new SpikedClub());
            weaponList.Add(new SteelMace());
            weaponList.Add(new ThrowingHammer());
            weaponList.Add(new WarHammer());

            return weaponList;
        }

        private List<object> GetHalberds()
        {
            var weaponList = new List<object>();

            weaponList.Add(new CopperHalberd());

            return weaponList;
        }

        private List<object> GetBows()
        {
            var weaponList = new List<object>();

            weaponList.Add(new Bow());
            weaponList.Add(new Crossbow());
            weaponList.Add(new FineCrossbow());
            weaponList.Add(new HeavyCrossbow());
            weaponList.Add(new Longbow());
            weaponList.Add(new OakGroveBow());
            weaponList.Add(new Shortbow());

            return weaponList;
        }

        private List<object> GetDaggers()
        {
            var weaponList = new List<object>();

            weaponList.Add(new GiltDagger());
            weaponList.Add(new MainGauche());
            weaponList.Add(new MisericordeDagger());
            weaponList.Add(new SteelDagger());
            weaponList.Add(new SilverDagger());
            weaponList.Add(new YasnakiDagger());

            return weaponList;
        }

        private List<object> GetFlails()
        {
            var weaponList = new List<object>();

            weaponList.Add(new SpikedFlail());
            weaponList.Add(new WoodenFlail());

            return weaponList;
        }



        private List<Weapon> GetWeaponType(List<object> weapons)
        {
            Weapon weaponData = new Weapon();
            var weaponList = new List<Weapon>();  

            foreach (var weapon in weapons)
            {
                weaponData = new Weapon();
                weaponData.WeaponName = weapon.GetType().Name;
                
                foreach (var propertyInfo in weapon.GetType().GetProperties())
                {
                    var propertyName = propertyInfo.Name;
                    var propertyValue = propertyInfo.GetValue(weapon);

                    if(propertyName == "BasePrice")
                    {
                        weaponData.BasePrice = (uint)propertyValue;
                    }

                    if(propertyName == "MinimumDamage")
                    {
                        weaponData.MinimumDamage = (int)propertyValue;
                    }

                    if (propertyName == "MaximumDamage")
                    {
                        weaponData.MaximumDamage = (int)propertyValue;
                    }

                    if (propertyName == "BaseArmorBonus")
                    {
                        weaponData.BaseArmorBonus = (int)propertyValue;
                    }

                    if (propertyName == "BaseAttackBonus")
                    {
                        weaponData.BaseAttackBonus = (int)propertyValue;
                    }

                    if (propertyName == "Penetration")
                    {
                        weaponData.Penetration = (ShieldPenetration)propertyValue;
                    }

                    if (propertyName == "Flags")
                    {
                        weaponData.Flags = (WeaponFlags)propertyValue;
                    }

                    if(propertyName == "CanBind")
                    {
                        weaponData.CanBind = (bool)propertyValue;
                    }

                }

                weaponList.Add(weaponData);
            }

            return weaponList;
        }
    }
}