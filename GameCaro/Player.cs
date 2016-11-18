using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class Player
    {
         //ctrl+r+e

        private Image anh;
        public Image Anh
        {
            get
            {
                return anh;
            }

            set
            {
                anh = value;
            }
        }

  public Player(Image anh)
        {
            this.anh = anh;
        }
    }
}
