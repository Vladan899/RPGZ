namespace RPGGAME
{
    internal class PlayerBackPack : Backpack
    {
        public PlayerBackPack() : base()
        {
            var test = new WeaponsItems();
            var test2 = new WeaponsItems();
            test.ItemTexture = AssetManager.GetInstance().texture["baihu"];
            test.SourceRectangle = new Microsoft.Xna.Framework.Rectangle(0, 0, 64, 64);
            test.Item_Name = "White Tiger";
            test2.ItemTexture = AssetManager.GetInstance().texture["baihu"];
            test2.SourceRectangle = new Microsoft.Xna.Framework.Rectangle(0, 0, 64, 64);
            test2.Item_Name = "White Tiger2";

            Add(test, 1);
            Add(test2, 1);
        }
    }
}