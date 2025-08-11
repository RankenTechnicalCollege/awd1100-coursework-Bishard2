using Lab3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    public interface ICard : IComparable<ICard>
    {
        void ShowCard(PictureBox picture, Label label);
        string Name { get; }
        Image Image { get; }
        double Value { get; }
    }
}
