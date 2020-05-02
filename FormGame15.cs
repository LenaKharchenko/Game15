using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game15
{
    public partial class FormGame15 : Form
    {
        Game game;
        public FormGame15()
        {
            InitializeComponent();
            game = new Game(4);
        }

        private void FormGame15_Load(object sender, EventArgs e)
        {
            StartGame();
        }
        private void menu_start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.Shift(position);
            Refresh();
            if (game.CheckNumbers())
            {
                MessageBox.Show("Вы победили!");
                StartGame();
            }
        }
        private Button ButtonPosition (int position)
        {
            switch (position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }
        }

        
        private void StartGame()
        { 
            game.Start();
            for (int j = 0; j < 3; j++)
                game.ShiftRandom();
            Refresh();
        }
        private void Refresh()
        {
            for (int position = 0; position < 16; position++)
            {
                int nr = game.GetNumber(position);
                ButtonPosition(position).Text = nr.ToString();
                ButtonPosition(position).Visible = (nr > 0);
            }
        }
    }
}
