namespace RPGGAME
{
    internal class PlayerBackPack : Backpack
    {
        public PlayerBackPack() : base()
        {
            this.MaxSlots = 16;
            var test = new WeaponsItems();
            var test2 = new WeaponsItems();
            test.ItemTexture = AssetManager.GetInstance().texture["baihu"];
            test.SourceRectangle = new Microsoft.Xna.Framework.Rectangle(0, 0, 64, 64);
            test.Item_Name = "White Tiger1";

            test2.ItemTexture = AssetManager.GetInstance().texture["baihu"];
            test2.SourceRectangle = new Microsoft.Xna.Framework.Rectangle(test2.ItemTexture.Width/2, test2.ItemTexture.Height / 2, 64, 64);
            test2.Item_Name = "adasdasdasdasd";
            
            Add(test, 1);
     
        }
    }
}