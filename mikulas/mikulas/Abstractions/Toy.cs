using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mikulas.Abstractions
{
    public abstract class Toy : Label
    {
        public Toy()
        {
            this.AutoSize = false;
            this.Height = this.Width = 50;
            Paint += Toy_Paint;
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);

        public virtual void MoveToy()
        {
            this.Left += 1;
        }
    }
}
