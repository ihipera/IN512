/* Program name: Circus
 Project file name: Circus
 Author: Isobella Johnson 
 Date: 27/07,20
 Language: C#
 Platform: Microsoft Visual Studio 2019
 Purpose: 
 Description: Clown program
 Known Bugs: 
 Additional Features:
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circus
{
    public partial class Form1 : Form
    {
      
        private Clown [] clowns;
        public Form1()
        {
            InitializeComponent();
            clowns = new Clown[3];
            clowns[0] = new Clown("Crusty", 160, 45);
            clowns[1] = new Clown("Charlie", 100, 18);
            clowns[2] = new Clown("Clary", 180, 67);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clowns.Length; i++)
            {
                pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("clown" + (i + 1).ToString());
                MessageBox.Show(clowns[i].TalkAboutYourself());
            }       
        }
    }
}
