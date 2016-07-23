using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace RPGGAME
{
    public class PlayerManager
    {
        Player p;
        public void saveChar(string name)
        {
            using (FileStream stream = new FileStream(name + ".ch", FileMode.Create))
            {
                using (GZipStream zip = new GZipStream(stream,CompressionMode.Compress))
                {
                    using(BinaryWriter writer = new BinaryWriter(zip))
                    {
                        p = new Player();
                        writer.Write(p.SelectedIndex);
                        writer.Write(p.)
                    }
                }
            }
        }
    }
}
